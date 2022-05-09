﻿namespace MyTelegram.Domain.EventFlow;

public abstract class MyInMemorySnapshotAggregateRoot<TAggregate, TIdentity, TSnapshot> :
    AggregateRoot<TAggregate, TIdentity>,
    ISnapshotAggregateRoot<TIdentity, TSnapshot>
    where TAggregate : MyInMemorySnapshotAggregateRoot<TAggregate, TIdentity, TSnapshot>
    where TIdentity : IIdentity
    where TSnapshot : ISnapshot
{
    protected MyInMemorySnapshotAggregateRoot(
        TIdentity id,
        ISnapshotStrategy snapshotStrategy)
        : base(id)
    {
        SnapshotStrategy = snapshotStrategy;
    }

    protected ISnapshotStrategy SnapshotStrategy { get; }

    public int? SnapshotVersion { get; private set; }

    public override async Task LoadAsync(
        IEventStore eventStore,
        ISnapshotStore snapshotStore,
        CancellationToken cancellationToken)
    {
        var snapshot = await snapshotStore.LoadSnapshotAsync<TAggregate, TIdentity, TSnapshot>(
                Id,
                cancellationToken)
            .ConfigureAwait(false);
        if (snapshot == null)
        {
            await base.LoadAsync(eventStore, snapshotStore, cancellationToken).ConfigureAwait(false);
            await SaveInMemorySnapshotContainerAsync(snapshotStore, cancellationToken).ConfigureAwait(false);
            return;
        }

        await LoadSnapshotContainerAsync(snapshot, cancellationToken).ConfigureAwait(false);

        Version = snapshot.Metadata.AggregateSequenceNumber;
        AddPreviousSourceIds(snapshot.Metadata.PreviousSourceIds);

        var domainEvents = await eventStore.LoadEventsAsync<TAggregate, TIdentity>(
                Id,
                Version + 1,
                cancellationToken)
            .ConfigureAwait(false);

        ApplyEvents(domainEvents);
    }

    public override async Task<IReadOnlyCollection<IDomainEvent>> CommitAsync(
        IEventStore eventStore,
        ISnapshotStore snapshotStore,
        ISourceId sourceId,
        CancellationToken cancellationToken)
    {
        var domainEvents = await base.CommitAsync(eventStore, snapshotStore, sourceId, cancellationToken)
            .ConfigureAwait(false);

        await SaveInMemorySnapshotContainerAsync(snapshotStore, cancellationToken).ConfigureAwait(false);

        if (!await SnapshotStrategy.ShouldCreateSnapshotAsync(this, cancellationToken).ConfigureAwait(false))
        {
            return domainEvents;
        }

        var snapshotContainer = await CreateSnapshotContainerAsync(cancellationToken).ConfigureAwait(false);
        await snapshotStore.StoreSnapshotAsync<TAggregate, TIdentity, TSnapshot>(
                Id,
                snapshotContainer,
                cancellationToken)
            .ConfigureAwait(false);

        return domainEvents;
    }

    protected abstract Task<TSnapshot> CreateSnapshotAsync(CancellationToken cancellationToken);

    private async Task<SnapshotContainer> CreateSnapshotContainerAsync(CancellationToken cancellationToken)
    {
        var snapshotTask = CreateSnapshotAsync(cancellationToken);
        var snapshotMetadataTask = CreateSnapshotMetadataAsync(cancellationToken);

        await Task.WhenAll(snapshotTask, snapshotMetadataTask).ConfigureAwait(false);

        var snapshotContainer = new SnapshotContainer(
            snapshotTask.Result,
            snapshotMetadataTask.Result);

        return snapshotContainer;
    }

    protected virtual Task<ISnapshotMetadata> CreateSnapshotMetadataAsync(CancellationToken cancellationToken)
    {
        var snapshotMetadata = new SnapshotMetadata
        {
            AggregateId = Id.Value,
            AggregateName = Name.Value,
            AggregateSequenceNumber = Version,
            PreviousSourceIds = PreviousSourceIds.ToList()
        };

        return Task.FromResult<ISnapshotMetadata>(snapshotMetadata);
    }

    protected abstract Task LoadSnapshotAsync(TSnapshot snapshot,
        ISnapshotMetadata metadata,
        CancellationToken cancellationToken);

    private Task LoadSnapshotContainerAsync(SnapshotContainer snapshotContainer,
        CancellationToken cancellationToken)
    {
        if (SnapshotVersion.HasValue)
        {
            throw new InvalidOperationException(
                $"Aggregate '{Id}' of type '{GetType().PrettyPrint()}' already has snapshot loaded");
        }

        if (Version > 0)
        {
            throw new InvalidOperationException(
                $"Aggregate '{Id}' of type '{GetType().PrettyPrint()}' already has events loaded");
        }

        if (snapshotContainer.Snapshot is not TSnapshot snapshot)
        {
            throw new ArgumentException(
                $"Snapshot '{snapshotContainer.Snapshot.GetType().PrettyPrint()}' for aggregate '{GetType().PrettyPrint()}' is not of type '{typeof(TSnapshot).PrettyPrint()}'. Did you forget to implement a snapshot upgrader?");
        }

        SnapshotVersion = snapshotContainer.Metadata.AggregateSequenceNumber;

        return LoadSnapshotAsync(
            snapshot,
            snapshotContainer.Metadata,
            cancellationToken);
    }

    private async Task SaveInMemorySnapshotContainerAsync(ISnapshotStore snapshotStore,
        CancellationToken cancellationToken)
    {
        if (snapshotStore is ISnapshotWithInMemoryCacheStore snapshotWithInMemoryCacheStore)
        {
            var snapshotContainer = await CreateSnapshotContainerAsync(cancellationToken).ConfigureAwait(false);
            await snapshotWithInMemoryCacheStore
                .StoreInMemorySnapshotAsync<TAggregate, TIdentity, TSnapshot>(Id, snapshotContainer, cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
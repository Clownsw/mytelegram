﻿namespace MyTelegram.Domain.Sagas;

public class ClearHistorySaga : MyInMemoryAggregateSaga<ClearHistorySaga, ClearHistorySagaId, ClearHistorySagaLocator>,
    ISagaIsStartedBy<DialogAggregate, DialogId, HistoryClearedEvent>,
    ISagaHandles<MessageAggregate, MessageId, MessageDeletedEvent>,
    ISagaHandles<MessageAggregate, MessageId, OtherPartyMessageDeletedEvent>,
    IApply<ClearHistorySagaCompletedEvent>
{
    private readonly IIdGenerator _idGenerator;
    private readonly ClearHistoryState _state = new();

    public ClearHistorySaga(ClearHistorySagaId id, IEventStore eventStore, IIdGenerator idGenerator) : base(id, eventStore)
    {
        _idGenerator = idGenerator;
        Register(_state);
    }

    public void Apply(ClearHistorySagaCompletedEvent aggregateEvent)
    {
        CompleteAsync();
    }

    public async Task HandleAsync(IDomainEvent<MessageAggregate, MessageId, MessageDeletedEvent> domainEvent,
        ISagaContext sagaContext,
        CancellationToken cancellationToken)
    {
        await IncrementPtsAsync(domainEvent.AggregateEvent.OwnerPeerId, domainEvent.AggregateEvent.MessageId)
            .ConfigureAwait(false);
        DeleteMessagesForOtherParty(domainEvent.AggregateEvent);
    }

    public async Task HandleAsync(
        IDomainEvent<MessageAggregate, MessageId, OtherPartyMessageDeletedEvent> domainEvent,
        ISagaContext sagaContext,
        CancellationToken cancellationToken)
    {
        await IncrementPtsAsync(domainEvent.AggregateEvent.OwnerPeerId, domainEvent.AggregateEvent.MessageId)
            .ConfigureAwait(false);
    }

    public Task HandleAsync(IDomainEvent<DialogAggregate, DialogId, HistoryClearedEvent> domainEvent,
        ISagaContext sagaContext,
        CancellationToken cancellationToken)
    {
        Emit(new ClearHistorySagaStartedEvent(domainEvent.AggregateEvent.Request,
            domainEvent.AggregateEvent.OwnerPeerId,
            domainEvent.AggregateEvent.Revoke,
            domainEvent.AggregateEvent.ToPeer,
            domainEvent.AggregateEvent.MessageActionData,
            domainEvent.AggregateEvent.RandomId,
            domainEvent.AggregateEvent.MessageIdListToBeDelete.Count,
            domainEvent.AggregateEvent.NextMaxId
        ));

        DeleteMessagesForSelf(domainEvent.AggregateEvent.OwnerPeerId,
            domainEvent.AggregateEvent.MessageIdListToBeDelete,
            domainEvent.AggregateEvent.CorrelationId);

        return Task.CompletedTask;
    }

    private void DeleteMessagesForOtherParty(MessageDeletedEvent aggregateEvent)
    {
        if (!_state.Revoke)
        {
            return;
        }

        // Only user peer support clear other member's history
        if (_state.ToPeer.PeerType != PeerType.User)
        {
            return;
        }

        if (aggregateEvent.IsOut)
        {
            if (aggregateEvent.InboxItems?.Count > 0)
            {
                foreach (var inboxItem in aggregateEvent.InboxItems)
                {
                    if (inboxItem.InboxOwnerPeerId == _state.Request.UserId)
                    {
                        continue;
                    }

                    var command = new DeleteOtherPartyMessageCommand(
                        MessageId.Create(inboxItem.InboxOwnerPeerId, inboxItem.InboxMessageId),
                        aggregateEvent.CorrelationId);
                    Publish(command);
                }
            }
        }
        else if (_state.ToPeer.PeerType == PeerType.User)
        {
            var command = new DeleteOtherPartyMessageCommand(
                MessageId.Create(aggregateEvent.SenderPeerId, aggregateEvent.SenderMessageId),
                aggregateEvent.CorrelationId);
            Publish(command);
        }
    }

    private void DeleteMessagesForSelf(long selfUserId,
        IReadOnlyList<int> messageIdList,
        Guid correlationId)
    {
        foreach (var messageId in messageIdList)
        {
            var command = new DeleteMessageCommand(MessageId.Create(selfUserId, messageId),
                correlationId);
            Publish(command);
        }
    }

    private Task HandleClearHistoryCompletedAsync(long peerId)
    {
        if (_state.IsCompletedForUid(peerId))
        {
            if (_state.OwnerToMessageIdList.TryGetValue(peerId, out var deletedMessageIdList))
            {
                if (_state.PeerToPts.TryGetValue(peerId, out var pts))
                {
                    Emit(new ClearSingleUserHistoryCompletedEvent(_state.Request.ReqMsgId,
                        _state.Request.AuthKeyId,
                        _state.NextMaxId,
                        _state.Request.UserId == peerId,
                        _state.ToPeer.PeerType,
                        new DeletedBoxItem(peerId, pts, deletedMessageIdList.Count, deletedMessageIdList)
                    ));
                }
            }

            if (_state.IsCompleted())
            {
                // after messages cleared should send history cleared service message
                var ownerPeerId = _state.Request.UserId;
                var outMessageId = 0;
                var aggregateId = MessageId.CreateWithRandomId(ownerPeerId, _state.RandomId);
                var messageItem = new MessageItem(
                    new Peer(PeerType.User, ownerPeerId),
                    _state.ToPeer,
                    new Peer(PeerType.User, _state.Request.UserId),
                    outMessageId,
                    string.Empty,
                    DateTime.UtcNow.ToTimestamp(),
                    _state.RandomId,
                    true,
                    SendMessageType.MessageService,
                    messageSubType: MessageSubType.ClearHistory,
                    messageActionData: _state.MessageActionData,
                    messageActionType: MessageActionType.HistoryClear);
                var command = new StartSendMessageCommand(aggregateId, _state.Request, messageItem, correlationId: Guid.NewGuid());
                Publish(command);

                Emit(new ClearHistorySagaCompletedEvent());
            }
        }

        return Task.CompletedTask;
    }

    private async Task IncrementPtsAsync(long peerId,
        int messageId)
    {
        var pts = await _idGenerator.NextIdAsync(IdType.Pts, peerId).ConfigureAwait(false);
        Emit(new ClearHistoryPtsIncrementedEvent(peerId, messageId, pts));
        await HandleClearHistoryCompletedAsync(peerId).ConfigureAwait(false);
    }
}

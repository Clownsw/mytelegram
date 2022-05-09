﻿using MyTelegram.Domain.Commands.User;

namespace MyTelegram.MessengerServer.Services.Impl;

public class DataSeeder : IDataSeeder
{
    private readonly ICommandBus _commandBus;

    private readonly IEventStore _eventStore;
    private readonly IRandomHelper _randomHelper;
    private readonly ISnapshotStore _snapshotStore;

    public DataSeeder(ICommandBus commandBus,
        IRandomHelper randomHelper,
        IEventStore eventStore,
        ISnapshotStore snapshotStore
    )
    {
        _commandBus = commandBus;
        _randomHelper = randomHelper;
        _eventStore = eventStore;
        _snapshotStore = snapshotStore;
    }

    public async Task SeedAsync()
    {
        await CreateOfficialUserAsync().ConfigureAwait(false);

        var initUid = MyTelegramServerDomainConsts.UserIdInitId;
        var testUserCount = 30;
        for (var i = 1; i < testUserCount; i++)
        {
            await CreateUserIfNeedAsync(initUid + i,
                $"1{i}",
                $"{i}",
                $"{i}",
                false).ConfigureAwait(false);
        }
    }

    private async Task CreateOfficialUserAsync()
    {
        var userId = MyTelegramServerDomainConsts.OfficialUserId;
        var created = await CreateUserIfNeedAsync(userId,
            "42777",
            "Telegram",
            null,
            false).ConfigureAwait(false);

        if (created)
        {
            var command = new SetSupportCommand(UserId.Create(userId), true);
            await _commandBus.PublishAsync(command, CancellationToken.None).ConfigureAwait(false);

            var setVerifiedCommand = new SetVerifiedCommand(UserId.Create(userId), true);
            await _commandBus.PublishAsync(setVerifiedCommand, CancellationToken.None).ConfigureAwait(false);
        }
    }

    private async Task<bool> CreateUserIfNeedAsync(long userId,
        string phoneNumber,
        string firstName,
        string? lastName,
        bool bot)
    {
        var aggregateId = UserId.Create(userId);
        var u = new UserAggregate(aggregateId);
        await u.LoadAsync(_eventStore, _snapshotStore, CancellationToken.None).ConfigureAwait(false);
        if (u.IsNew)
        {
            var accessHash = _randomHelper.NextLong();
            var createUserCommand =
                new CreateUserCommand(aggregateId,
                    new RequestInfo(0,
                        0,
                        0,
                        0,
                        Guid.Empty),
                    userId,
                    accessHash,
                    phoneNumber,
                    firstName,
                    lastName,
                    bot);
            await _commandBus.PublishAsync(createUserCommand, CancellationToken.None).ConfigureAwait(false);
            return true;
        }

        return false;
    }
}

﻿namespace MyTelegram.MessengerServer.DomainEventHandlers;

public class ChannelDomainEventHandler : DomainEventHandlerBase,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, ChannelCreatedEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, ExportChatInviteEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, StartInviteToChannelEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, SetDiscussionGroupEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, ChannelTitleEditedEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, ChannelAboutEditedEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, ChannelDefaultBannedRightsEditedEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, SlowModeChangedEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, PreHistoryHiddenChangedEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, ChannelAdminRightsEditedEvent>,
    ISubscribeSynchronousTo<ChannelAggregate, ChannelId, ChannelUserNameChangedEvent>,
    ISubscribeSynchronousTo<ChannelMemberAggregate, ChannelMemberId, ChannelMemberJoinedEvent>,
    ISubscribeSynchronousTo<ChannelMemberAggregate, ChannelMemberId, ChannelMemberBannedRightsChangedEvent>,
    ISubscribeSynchronousTo<ChannelMemberAggregate, ChannelMemberId, ChannelMemberLeftEvent>
{
    private readonly ITlChatConverter _chatConverter;
    private readonly IChatEventCacheHelper _chatEventCacheHelper;
    private readonly IQueryProcessor _queryProcessor;

    public ChannelDomainEventHandler(IObjectMessageSender objectMessageSender,
        ICommandBus commandBus,
        IIdGenerator idGenerator,
        IAckCacheService ackCacheService,
        IResponseCacheAppService responseCacheAppService,
        IChatEventCacheHelper chatEventCacheHelper,
        IQueryProcessor queryProcessor,
        ITlChatConverter chatConverter) : base(objectMessageSender,
        commandBus,
        idGenerator,
        ackCacheService,
        responseCacheAppService)
    {
        _chatEventCacheHelper = chatEventCacheHelper;
        _queryProcessor = queryProcessor;
        _chatConverter = chatConverter;
    }

    public Task HandleAsync(IDomainEvent<ChannelAggregate, ChannelId, ChannelAboutEditedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        return SendRpcMessageToClientAsync(domainEvent.AggregateEvent.ReqMsgId,
            new TBoolTrue(),
            domainEvent.Metadata.SourceId.Value);
    }

    public async Task HandleAsync(
        IDomainEvent<ChannelAggregate, ChannelId, ChannelAdminRightsEditedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        await NotifyUpdateChannelAsync(domainEvent.AggregateEvent.ReqMsgId,
                domainEvent.AggregateEvent.ChannelId,
                domainEvent.Metadata.SourceId.Value)
            .ConfigureAwait(false);
    }

    public Task HandleAsync(IDomainEvent<ChannelAggregate, ChannelId, ChannelCreatedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        _chatEventCacheHelper.Add(domainEvent.AggregateEvent);
        return Task.CompletedTask;
    }

    public async Task HandleAsync(
        IDomainEvent<ChannelAggregate, ChannelId, ChannelDefaultBannedRightsEditedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        await NotifyUpdateChannelAsync(domainEvent.AggregateEvent.ReqMsgId,
                domainEvent.AggregateEvent.ChannelId,
                domainEvent.Metadata.SourceId.Value)
            .ConfigureAwait(false);
        //var updates = new TUpdateShort
        //{
        //    Date = DateTime.UtcNow.ToTimestamp(),
        //    Update = new TUpdateChannel
        //    {
        //        ChannelId = domainEvent.AggregateEvent.ChannelId
        //    }
        //};
        //// todo:这里应该返回TUpdates给发送者,只包含频道信息即可
        //await SendRpcMessageToClientAsync(domainEvent.AggregateEvent.ReqMsgId, () => updates).ConfigureAwait(false);
        //await SendMessageToPeerAsync(new Peer(PeerType.Channel, domainEvent.AggregateEvent.ChannelId), updates);
    }

    public async Task HandleAsync(IDomainEvent<ChannelAggregate, ChannelId, ChannelTitleEditedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        await NotifyUpdateChannelAsync(0, domainEvent.AggregateEvent.ChannelId, domainEvent.Metadata.SourceId.Value)
            .ConfigureAwait(false);
    }

    public Task HandleAsync(IDomainEvent<ChannelAggregate, ChannelId, ChannelUserNameChangedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        return SendRpcMessageToClientAsync(domainEvent.AggregateEvent.ReqMsgId, new TBoolTrue());
    }

    public async Task HandleAsync(IDomainEvent<ChannelAggregate, ChannelId, ExportChatInviteEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        await SendRpcMessageToClientAsync(domainEvent.AggregateEvent.ReqMsgId,
            _chatConverter.ToExportedChatInvite(domainEvent.AggregateEvent)
        ).ConfigureAwait(false);
    }

    public async Task HandleAsync(
        IDomainEvent<ChannelAggregate, ChannelId, PreHistoryHiddenChangedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        await NotifyUpdateChannelAsync(domainEvent.AggregateEvent.ReqMsgId,
                domainEvent.AggregateEvent.ChannelId,
                domainEvent.Metadata.SourceId.Value)
            .ConfigureAwait(false);
    }

    public Task HandleAsync(IDomainEvent<ChannelAggregate, ChannelId, SetDiscussionGroupEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        return SendRpcMessageToClientAsync(domainEvent.AggregateEvent.ReqMsgId,
            new TBoolTrue(),
            domainEvent.Metadata.SourceId.Value);
    }

    public async Task HandleAsync(IDomainEvent<ChannelAggregate, ChannelId, SlowModeChangedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        await NotifyUpdateChannelAsync(domainEvent.AggregateEvent.ReqMsgId,
                domainEvent.AggregateEvent.ChannelId,
                domainEvent.Metadata.SourceId.Value)
            .ConfigureAwait(false);
    }

    //public Task HandleAsync(IDomainEvent<InviteToChannelSaga, InviteToChannelSagaId, InviteToChannelCompletedEvent> domainEvent,
    //    CancellationToken cancellationToken)
    //{
    //    throw new NotImplementedException();
    //}
    public Task HandleAsync(IDomainEvent<ChannelAggregate, ChannelId, StartInviteToChannelEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        _chatEventCacheHelper.Add(domainEvent.AggregateEvent);
        return Task.CompletedTask;
    }

    public Task HandleAsync(
        IDomainEvent<ChannelMemberAggregate, ChannelMemberId, ChannelMemberBannedRightsChangedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        return NotifyUpdateChannelAsync(domainEvent.AggregateEvent.ReqMsgId,
            domainEvent.AggregateEvent.ChannelId,
            null,
            domainEvent.AggregateEvent.MemberUid);
    }

    public async Task HandleAsync(
        IDomainEvent<ChannelMemberAggregate, ChannelMemberId, ChannelMemberJoinedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        // 这里直接从ReadModel获取频道信息
        var channelReadModel = await _queryProcessor
            .ProcessAsync(new GetChannelByIdQuery(domainEvent.AggregateEvent.ChannelId), default)
            .ConfigureAwait(false);
        var updates = new TUpdates
        {
            Chats = new TVector<IChat>(_chatConverter.ToChannel(channelReadModel,
                null,
                domainEvent.AggregateEvent.MemberUid,
                false)),
            Date = domainEvent.AggregateEvent.Date,
            Seq = 0,
            Users = new TVector<IUser>(),
            Updates = new TVector<IUpdate>()
        };

        await SendRpcMessageToClientAsync(domainEvent.AggregateEvent.ReqMsgId, updates).ConfigureAwait(false);
        await NotifyUpdateChannelAsync(0, domainEvent.AggregateEvent.ChannelId, null).ConfigureAwait(false);
    }

    public Task HandleAsync(
        IDomainEvent<ChannelMemberAggregate, ChannelMemberId, ChannelMemberLeftEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        return NotifyUpdateChannelAsync(domainEvent.AggregateEvent.ReqMsgId,
            domainEvent.AggregateEvent.ChannelId,
            null,
            domainEvent.AggregateEvent.MemberUid);
    }

    private async Task NotifyUpdateChannelAsync(long reqMsgId,
        long channelId,
        string? sourceId,
        long memberUid = 0)
    {
        var updates = new TUpdateShort
        {
            Date = DateTime.UtcNow.ToTimestamp(),
            Update = new TUpdateChannel { ChannelId = channelId }
        };
        // todo:这里应该返回TUpdates给发送者,只包含频道信息即可
        if (reqMsgId != 0)
        {
            await SendRpcMessageToClientAsync(reqMsgId, updates, sourceId).ConfigureAwait(false);
        }

        if (memberUid != 0)
        {
            await PushUpdatesToPeerAsync(new Peer(PeerType.User, memberUid), updates).ConfigureAwait(false);
        }
        else
        {
            await PushUpdatesToPeerAsync(new Peer(PeerType.Channel, channelId), updates).ConfigureAwait(false);
        }
    }
}

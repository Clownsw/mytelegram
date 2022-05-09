﻿namespace MyTelegram.MessengerServer.Services.Impl;

public class MessageAppService : BaseAppService, IMessageAppService
{
    private readonly ICommandBus _commandBus;
    private readonly IObjectMapper _objectMapper;
    private readonly IQueryProcessor _queryProcessor;

    public MessageAppService(
        IQueryProcessor queryProcessor,
        ICommandBus commandBus,
        IObjectMapper objectMapper)
    {
        _queryProcessor = queryProcessor;
        _commandBus = commandBus;
        _objectMapper = objectMapper;
    }

    public async Task<GetMessageOutput> GetChannelDifferenceAsync(GetDifferenceInput input)
    {
        return await GetMessagesInternalAsync(new GetMessagesQuery(input.OwnerPeerId,
            MessageType.Unknown,
            null,
            null,
            0,
            input.Limit,
            null,
            null,
            input.SelfUserId,
            input.Pts)).ConfigureAwait(false);
    }

    public Task<GetMessageOutput> GetDifferenceAsync(GetDifferenceInput input)
    {
        return GetMessagesInternalAsync(new GetMessagesQuery(input.OwnerPeerId,
            MessageType.Unknown,
            null,
            null,
            0,
            input.Limit,
            null,
            null,
            input.SelfUserId,
            input.Pts));
    }

    public async Task SendMessageAsync(SendMessageInput input)
    {
        var correlationId = Guid.NewGuid();
        var ownerPeerId = input.ToPeer.PeerType == PeerType.Channel ? input.ToPeer.PeerId : input.SenderPeerId;

        var date = CurrentDate;
        var aggregateId = MessageId.CreateWithRandomId(ownerPeerId, input.RandomId);
        var messageItem = new MessageItem(
            input.ToPeer with { PeerId = ownerPeerId },
            input.ToPeer,
            new Peer(PeerType.User, input.SenderPeerId),
            0,
            input.Message,
            date,
            input.RandomId,
            true,
            input.SendMessageType,
            (MessageType)input.SendMessageType,
            MessageSubType.Normal,
            input.ReplyToMsgId,
            input.MessageActionData,
            MessageActionType.None,
            input.Entities,
            input.Media,
            input.GroupId
        );

        var command = new StartSendMessageCommand(aggregateId,
            input.Request,
            messageItem,
            input.ClearDraft,
            input.GroupItemCount,
            correlationId);

        await _commandBus.PublishAsync(command, default).ConfigureAwait(false);
    }

    public Task<GetMessageOutput> GetMessagesAsync(GetMessagesInput input)
    {
        return GetMessagesCoreAsync(input);
    }

    public Task<GetMessageOutput> GetHistoryAsync(GetHistoryInput input)
    {
        return GetMessagesCoreAsync(input);
    }

    public Task<GetMessageOutput> SearchAsync(SearchInput input)
    {
        return GetMessagesCoreAsync(input);
    }

    public Task<GetMessageOutput> SearchGlobalAsync(SearchGlobalInput input)
    {
        return GetMessagesCoreAsync(input);
    }

    private Task<GetMessageOutput> GetMessagesCoreAsync<TRequest>(TRequest input)
        where TRequest : GetPagedListInput
    {
        var offset = GetOffset(input);
        var query = _objectMapper.Map<TRequest, GetMessagesQuery>(input);
        query.Offset = offset;

        return GetMessagesInternalAsync(query);
    }

    private async Task<GetMessageOutput> GetMessagesInternalAsync(GetMessagesQuery query)
    {
        //var channelHistoryMinId = 0;
        //if (query.Peer?.PeerType == PeerType.Channel)
        //{
        //    var dialog = await QueryProcessor
        //        .ProcessAsync(new GetDialogByIdQuery(DialogId.Create(query.SelfUserId, query.Peer)),
        //            CancellationToken.None).ConfigureAwait(false);
        //    channelHistoryMinId = dialog?.ChannelHistoryMinId ?? 0;
        //    ;
        //}
        var messageBoxList = await _queryProcessor.ProcessAsync(query, CancellationToken.None).ConfigureAwait(false);
        // Console.WriteLine($"GetMessagesInternalAsync limit={query.Limit} actual count={messageBoxList.Count},offset={query.Offset}");
        // 添加群成员里的用户列表需要单独处理
        //var addChatUserIdList = messageBoxList
        //    .Where(p => p.MessageActionType == MessageActionType.ChatAddUser).SelectMany(p =>
        //        p.MessageActionData.ToBytes().ToTObject2<TMessageActionChatAddUser>().Users.ToList()).ToList();
        var extraChatUserIdList = new List<long>();
        foreach (var box in messageBoxList)
        {
            switch (box.MessageActionType)
            {
                case MessageActionType.ChatAddUser:
                    var addedUserIdList = box.MessageActionData!.ToBytes().ToTObject<TMessageActionChatAddUser>()
                        .Users.ToList();
                    extraChatUserIdList.AddRange(addedUserIdList);
                    break;
                case MessageActionType.ChatDeleteUser:
                    var deletedUserId = box.MessageActionData!.ToBytes().ToTObject<TMessageActionChatDeleteUser>()
                        .UserId;
                    extraChatUserIdList.Add(deletedUserId);
                    break;
            }

            extraChatUserIdList.Add(box.SenderPeerId);
        }

        var userIdList = messageBoxList.Where(p => p.ToPeerType == PeerType.User).Select(p => p.ToPeerId).ToList();
        var chatIdList = messageBoxList.Where(p => p.ToPeerType == PeerType.Chat).Select(p => p.ToPeerId).ToList();
        var channelIdList = messageBoxList.Where(p => p.ToPeerType == PeerType.Channel).Select(p => p.ToPeerId)
            .ToList();
        userIdList.Add(query.SelfUserId);
        userIdList.AddRange(extraChatUserIdList);

        //if (query.Q?.Length > 5 && query.Q.StartsWith("@"))
        //{
        //    var userNameReadModels = await _queryProcessor
        //        .ProcessAsync(new SearchUserNameQuery(query.Q[1..]), default).ConfigureAwait(false);
        //    userIdList.AddRange(userNameReadModels.Where(p => p.PeerType == PeerType.User).Select(p => p.PeerId).ToList());
        //    channelIdList.AddRange(userNameReadModels.Where(p => p.PeerType == PeerType.Channel).Select(p => p.PeerId).ToList());

        //    userIdList = userIdList.Distinct().ToList();
        //    channelIdList = channelIdList.Distinct().ToList();
        //}

        var userList =
            await _queryProcessor.ProcessAsync(new GetUsersByUidListQuery(userIdList), CancellationToken.None)
                .ConfigureAwait(false);
        var chatList = chatIdList.Count == 0
            ? new List<IChatReadModel>()
            : await _queryProcessor
                .ProcessAsync(new GetChatByChatIdListQuery(chatIdList), CancellationToken.None).ConfigureAwait(false);
        var channelList = channelIdList.Count == 0
            ? new List<IChannelReadModel>()
            : await _queryProcessor
                .ProcessAsync(new GetChannelByChannelIdListQuery(channelIdList), CancellationToken.None)
                .ConfigureAwait(false);

        IReadOnlyCollection<long> joinedChannelIdList = new List<long>();
        if (channelIdList.Count > 0)
        {
            joinedChannelIdList = await _queryProcessor
                .ProcessAsync(new GetJoinedChannelIdListQuery(query.SelfUserId, channelIdList), default)
                .ConfigureAwait(false);
        }

        IReadOnlyCollection<IChannelMemberReadModel> channelMemberList = new List<IChannelMemberReadModel>();
        if (joinedChannelIdList.Count > 0)
        {
            channelMemberList = await _queryProcessor
                .ProcessAsync(new GetChannelMemberListByChannelIdListQuery(query.SelfUserId, joinedChannelIdList.ToList()),
                    default).ConfigureAwait(false);
        }

        var pts = query.Pts;
        if (pts == 0 && messageBoxList.Count > 0)
        {
            pts = messageBoxList.Max(p => p.Pts);
        }

        return new GetMessageOutput(channelList,
            channelMemberList,
            chatList,
            joinedChannelIdList,
            messageBoxList,
            userList,
            query.Limit == messageBoxList.Count,
            query.IsSearchGlobal,
            pts,
            query.SelfUserId);
    }
}
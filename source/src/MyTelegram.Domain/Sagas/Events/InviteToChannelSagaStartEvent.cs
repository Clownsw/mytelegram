﻿namespace MyTelegram.Domain.Sagas.Events;

public class InviteToChannelSagaStartEvent : RequestAggregateEvent2<InviteToChannelSaga, InviteToChannelSagaId>,
    IHasCorrelationId
{
    public InviteToChannelSagaStartEvent(
        RequestInfo request,
        long channelId,
        long inviterId,
        int date,
        int totalCount,
        IReadOnlyList<long> memberUidList,
        int maxMessageId,
        int channelHistoryMinId,
        long randomId,
        string messageActionData,
        Guid correlationId) : base(request)
    {
        ChannelId = channelId;
        InviterId = inviterId;
        Date = date;
        TotalCount = totalCount;
        MemberUidList = memberUidList;
        MaxMessageId = maxMessageId;
        ChannelHistoryMinId = channelHistoryMinId;
        RandomId = randomId;
        MessageActionData = messageActionData;
        CorrelationId = correlationId;
    }

    public int ChannelHistoryMinId { get; }
    public long ChannelId { get; }
    public int Date { get; }
    public long InviterId { get; }
    public int MaxMessageId { get; }
    public IReadOnlyList<long> MemberUidList { get; }
    public string MessageActionData { get; }
    public long RandomId { get; }
    public int TotalCount { get; }

    public Guid CorrelationId { get; }
}

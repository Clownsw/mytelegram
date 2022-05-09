﻿namespace MyTelegram.Domain.Events.User;

public class SendUserMessageStartedEvent : AggregateEvent<UserAggregate, UserId>, IHasCorrelationId
{
    public SendUserMessageStartedEvent(long reqMsgId, Guid correlationId)
    {
        ReqMsgId = reqMsgId;
        CorrelationId = correlationId;
    }

    public Guid CorrelationId { get; }
    public long ReqMsgId { get; }
}
﻿namespace MyTelegram.Domain.Events.Messaging;

public class ReadingHistoryCreatedEvent : AggregateEvent<ReadingHistoryAggregate, ReadingHistoryId>
{
    public long ReaderPeerId { get; }
    public long TargetPeerId { get; }
    public int MessageId { get; }

    public ReadingHistoryCreatedEvent(long readerPeerId, long targetPeerId, int messageId)
    {
        ReaderPeerId = readerPeerId;
        TargetPeerId = targetPeerId;
        MessageId = messageId;
    }
}
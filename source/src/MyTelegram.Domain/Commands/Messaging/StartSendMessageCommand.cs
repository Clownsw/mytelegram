﻿namespace MyTelegram.Domain.Commands.Messaging;

public class StartSendMessageCommand : RequestCommand2<MessageAggregate, MessageId, IExecutionResult>
{
    public MessageItem OutMessageItem { get; }
    public bool ClearDraft { get; }
    public int GroupItemCount { get; }
    public Guid CorrelationId { get; }

    public StartSendMessageCommand(MessageId aggregateId,
        RequestInfo request, MessageItem outMessageItem, bool clearDraft = false, int groupItemCount = 1, Guid correlationId = default) : base(aggregateId, request)
    {
        OutMessageItem = outMessageItem;
        ClearDraft = clearDraft;
        GroupItemCount = groupItemCount;
        CorrelationId = correlationId;
    }

    protected override IEnumerable<byte[]> GetSourceIdComponents()
    {
        yield return BitConverter.GetBytes(OutMessageItem.RandomId);
    }
}
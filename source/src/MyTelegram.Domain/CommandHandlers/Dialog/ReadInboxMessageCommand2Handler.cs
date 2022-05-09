﻿namespace MyTelegram.Domain.CommandHandlers.Dialog;

public class ReadInboxMessageCommand2Handler : CommandHandler<DialogAggregate, DialogId, ReadInboxMessageCommand2>
{
    public override Task ExecuteAsync(DialogAggregate aggregate,
        ReadInboxMessageCommand2 command,
        CancellationToken cancellationToken)
    {
        aggregate.ReadInboxMessage2(command.Request,
            command.ReaderUid,
            command.OwnerPeerId,
            command.MaxMessageId,
            command.ToPeer,
            command.CorrelationId);
        return Task.CompletedTask;
    }
}

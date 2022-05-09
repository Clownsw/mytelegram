﻿namespace MyTelegram.Domain.CommandHandlers.Chat;

public class CreateChatCommandHandler : CommandHandler<ChatAggregate, ChatId, CreateChatCommand>
{
    public override Task ExecuteAsync(ChatAggregate aggregate,
        CreateChatCommand command,
        CancellationToken cancellationToken)
    {
        aggregate.Create(command.Request,
            command.ChatId,
            command.CreatorUid,
            command.Title,
            command.MemberUidList,
            command.Date,
            command.RandomId,
            command.MessageActionData,
            command.CorrelationId);
        return Task.CompletedTask;
    }
}

﻿namespace MyTelegram.Domain.CommandHandlers.AppCode;

public class CheckSignInCodeCommandHandler : CommandHandler<AppCodeAggregate, AppCodeId, CheckSignInCodeCommand>
{
    public override Task ExecuteAsync(AppCodeAggregate aggregate,
        CheckSignInCodeCommand command,
        CancellationToken cancellationToken)
    {
        aggregate.CheckSignInCode(command.Request,
            command.PhoneCodeHash,
            command.UserId,
            command.CorrelationId);
        return Task.CompletedTask;
    }
}

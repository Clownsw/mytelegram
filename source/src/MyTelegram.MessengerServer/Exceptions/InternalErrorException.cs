﻿namespace MyTelegram.MessengerServer.Exceptions;

public class InternalErrorException : RpcException
{
    public InternalErrorException(
        string errorMessage) : base(ErrorCodes.InternalError, errorMessage)
    {
    }
}
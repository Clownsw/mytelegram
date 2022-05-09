﻿namespace MyTelegram.MessengerServer.Exceptions;

public class RpcException : Exception
{
    public TRpcError Error { get; }
    //public long RequestMessageId { get; }

    protected RpcException(int errorCode, string errorMessage) : base(errorMessage)
    {
        //RequestMessageId = requestMessageId;
        Error = new TRpcError
        {
            ErrorCode = errorCode,
            ErrorMessage = errorMessage
        };
    }
}
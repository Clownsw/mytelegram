﻿namespace MyTelegram.MessengerServer.Services.IdGenerator;

public interface IHiLoStateBlockSizeHelper
{
    int GetBlockSize(IdType idType);
}
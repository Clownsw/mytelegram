﻿// ReSharper disable All

namespace MyTelegram.Schema.Messages;

public interface ISearchCounter : IObject
{
    BitArray Flags { get; set; }
    bool Inexact { get; set; }
    MyTelegram.Schema.IMessagesFilter Filter { get; set; }
    int Count { get; set; }

}

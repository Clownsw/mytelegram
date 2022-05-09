﻿// ReSharper disable All

namespace MyTelegram.Schema;

public interface IMessageReplyHeader : IObject
{
    BitArray Flags { get; set; }
    int ReplyToMsgId { get; set; }
    MyTelegram.Schema.IPeer? ReplyToPeerId { get; set; }
    int? ReplyToTopId { get; set; }

}

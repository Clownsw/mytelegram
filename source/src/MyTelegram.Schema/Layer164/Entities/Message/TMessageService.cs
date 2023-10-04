﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Indicates a service message
/// See <a href="https://corefork.telegram.org/constructor/messageService" />
///</summary>
[TlObject(0x2b085862)]
public sealed class TMessageService : IMessage
{
    public uint ConstructorId => 0x2b085862;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the message is outgoing
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Out { get; set; }

    ///<summary>
    /// Whether we were mentioned in the message
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Mentioned { get; set; }

    ///<summary>
    /// Whether the message contains unread media
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool MediaUnread { get; set; }

    ///<summary>
    /// Whether the message is silent
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Silent { get; set; }

    ///<summary>
    /// Whether it's a channel post
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Post { get; set; }

    ///<summary>
    /// This is a legacy message: it has to be refetched with the new layer
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Legacy { get; set; }

    ///<summary>
    /// Message ID
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// ID of the sender of this message
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer? FromId { get; set; }

    ///<summary>
    /// Sender of service message
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer PeerId { get; set; }

    ///<summary>
    /// Reply (thread) information
    /// See <a href="https://corefork.telegram.org/type/MessageReplyHeader" />
    ///</summary>
    public MyTelegram.Schema.IMessageReplyHeader? ReplyTo { get; set; }

    ///<summary>
    /// Message date
    ///</summary>
    public int Date { get; set; }

    ///<summary>
    /// Event connected with the service message
    /// See <a href="https://corefork.telegram.org/type/MessageAction" />
    ///</summary>
    public MyTelegram.Schema.IMessageAction Action { get; set; }

    ///<summary>
    /// Time To Live of the message, once message.date+message.ttl_period === time(), the message will be deleted on the server, and must be deleted locally as well.
    ///</summary>
    public int? TtlPeriod { get; set; }

    public void ComputeFlag()
    {
        if (Out) { Flags[1] = true; }
        if (Mentioned) { Flags[4] = true; }
        if (MediaUnread) { Flags[5] = true; }
        if (Silent) { Flags[13] = true; }
        if (Post) { Flags[14] = true; }
        if (Legacy) { Flags[19] = true; }
        if (FromId != null) { Flags[8] = true; }
        if (ReplyTo != null) { Flags[3] = true; }
        if (/*TtlPeriod != 0 && */TtlPeriod.HasValue) { Flags[25] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        if (Flags[8]) { writer.Write(FromId); }
        writer.Write(PeerId);
        if (Flags[3]) { writer.Write(ReplyTo); }
        writer.Write(Date);
        writer.Write(Action);
        if (Flags[25]) { writer.Write(TtlPeriod.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { Out = true; }
        if (Flags[4]) { Mentioned = true; }
        if (Flags[5]) { MediaUnread = true; }
        if (Flags[13]) { Silent = true; }
        if (Flags[14]) { Post = true; }
        if (Flags[19]) { Legacy = true; }
        Id = reader.ReadInt32();
        if (Flags[8]) { FromId = reader.Read<MyTelegram.Schema.IPeer>(); }
        PeerId = reader.Read<MyTelegram.Schema.IPeer>();
        if (Flags[3]) { ReplyTo = reader.Read<MyTelegram.Schema.IMessageReplyHeader>(); }
        Date = reader.ReadInt32();
        Action = reader.Read<MyTelegram.Schema.IMessageAction>();
        if (Flags[25]) { TtlPeriod = reader.ReadInt32(); }
    }
}
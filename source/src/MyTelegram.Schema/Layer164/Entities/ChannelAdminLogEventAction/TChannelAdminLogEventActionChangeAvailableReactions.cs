﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The set of allowed <a href="https://corefork.telegram.org/api/reactions">message reactions »</a> for this channel has changed
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionChangeAvailableReactions" />
///</summary>
[TlObject(0xbe4e0ef8)]
public sealed class TChannelAdminLogEventActionChangeAvailableReactions : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0xbe4e0ef8;
    ///<summary>
    /// Previously allowed reaction emojis
    /// See <a href="https://corefork.telegram.org/type/ChatReactions" />
    ///</summary>
    public MyTelegram.Schema.IChatReactions PrevValue { get; set; }

    ///<summary>
    /// New allowed reaction emojis
    /// See <a href="https://corefork.telegram.org/type/ChatReactions" />
    ///</summary>
    public MyTelegram.Schema.IChatReactions NewValue { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(PrevValue);
        writer.Write(NewValue);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        PrevValue = reader.Read<MyTelegram.Schema.IChatReactions>();
        NewValue = reader.Read<MyTelegram.Schema.IChatReactions>();
    }
}
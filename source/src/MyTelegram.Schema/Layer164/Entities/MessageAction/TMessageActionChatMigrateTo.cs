﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Indicates the chat was <a href="https://corefork.telegram.org/api/channel">migrated</a> to the specified supergroup
/// See <a href="https://corefork.telegram.org/constructor/messageActionChatMigrateTo" />
///</summary>
[TlObject(0xe1037f92)]
public sealed class TMessageActionChatMigrateTo : IMessageAction
{
    public uint ConstructorId => 0xe1037f92;
    ///<summary>
    /// The supergroup it was migrated to
    ///</summary>
    public long ChannelId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ChannelId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ChannelId = reader.ReadInt64();
    }
}
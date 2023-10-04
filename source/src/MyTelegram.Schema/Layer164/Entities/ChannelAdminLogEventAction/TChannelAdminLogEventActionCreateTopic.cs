﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A <a href="https://corefork.telegram.org/api/forum#forum-topics">forum topic</a> was created
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionCreateTopic" />
///</summary>
[TlObject(0x58707d28)]
public sealed class TChannelAdminLogEventActionCreateTopic : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x58707d28;
    ///<summary>
    /// The <a href="https://corefork.telegram.org/api/forum#forum-topics">forum topic</a> that was created
    /// See <a href="https://corefork.telegram.org/type/ForumTopic" />
    ///</summary>
    public MyTelegram.Schema.IForumTopic Topic { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Topic);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Topic = reader.Read<MyTelegram.Schema.IForumTopic>();
    }
}
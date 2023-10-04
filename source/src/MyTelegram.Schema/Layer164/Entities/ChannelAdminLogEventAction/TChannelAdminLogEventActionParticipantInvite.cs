﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A user was invited to the group
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionParticipantInvite" />
///</summary>
[TlObject(0xe31c34d8)]
public sealed class TChannelAdminLogEventActionParticipantInvite : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0xe31c34d8;
    ///<summary>
    /// The user that was invited
    /// See <a href="https://corefork.telegram.org/type/ChannelParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChannelParticipant Participant { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Participant);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Participant = reader.Read<MyTelegram.Schema.IChannelParticipant>();
    }
}
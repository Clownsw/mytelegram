﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The admin <a href="https://corefork.telegram.org/api/rights">rights</a> of a user were changed
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionParticipantToggleAdmin" />
///</summary>
[TlObject(0xd5676710)]
public sealed class TChannelAdminLogEventActionParticipantToggleAdmin : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0xd5676710;
    ///<summary>
    /// Previous admin rights
    /// See <a href="https://corefork.telegram.org/type/ChannelParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChannelParticipant PrevParticipant { get; set; }

    ///<summary>
    /// New admin rights
    /// See <a href="https://corefork.telegram.org/type/ChannelParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChannelParticipant NewParticipant { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(PrevParticipant);
        writer.Write(NewParticipant);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        PrevParticipant = reader.Read<MyTelegram.Schema.IChannelParticipant>();
        NewParticipant = reader.Read<MyTelegram.Schema.IChannelParticipant>();
    }
}
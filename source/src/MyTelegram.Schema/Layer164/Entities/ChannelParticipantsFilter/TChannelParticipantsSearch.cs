﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Query participants by name
/// See <a href="https://corefork.telegram.org/constructor/channelParticipantsSearch" />
///</summary>
[TlObject(0x656ac4b)]
public sealed class TChannelParticipantsSearch : IChannelParticipantsFilter
{
    public uint ConstructorId => 0x656ac4b;
    ///<summary>
    /// Search query
    ///</summary>
    public string Q { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Q);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Q = reader.ReadString();
    }
}
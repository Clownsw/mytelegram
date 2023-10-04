﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Information about an active supergroup inviter
/// See <a href="https://corefork.telegram.org/constructor/statsGroupTopInviter" />
///</summary>
[TlObject(0x535f779d)]
public sealed class TStatsGroupTopInviter : IStatsGroupTopInviter
{
    public uint ConstructorId => 0x535f779d;
    ///<summary>
    /// User ID
    ///</summary>
    public long UserId { get; set; }

    ///<summary>
    /// Number of invitations for <a href="https://corefork.telegram.org/api/stats">statistics</a> period in consideration
    ///</summary>
    public int Invitations { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(UserId);
        writer.Write(Invitations);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        UserId = reader.ReadInt64();
        Invitations = reader.ReadInt32();
    }
}
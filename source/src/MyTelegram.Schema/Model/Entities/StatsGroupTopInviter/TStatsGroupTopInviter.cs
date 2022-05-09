﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/statsGroupTopInviter" />
///</summary>
[TlObject(0x535f779d)]
public class TStatsGroupTopInviter : IStatsGroupTopInviter
{
    public uint ConstructorId => 0x535f779d;
    public long UserId { get; set; }
    public int Invitations { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        bw.Write(Invitations);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        Invitations = br.ReadInt32();
    }
}
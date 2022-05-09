﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.affectedFoundMessages" />
///</summary>
[TlObject(0xef8d3e6c)]
public class TAffectedFoundMessages : IAffectedFoundMessages
{
    public uint ConstructorId => 0xef8d3e6c;
    public int Pts { get; set; }
    public int PtsCount { get; set; }
    public int Offset { get; set; }
    public TVector<int> Messages { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Pts);
        bw.Write(PtsCount);
        bw.Write(Offset);
        Messages.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Pts = br.ReadInt32();
        PtsCount = br.ReadInt32();
        Offset = br.ReadInt32();
        Messages = br.Deserialize<TVector<int>>();
    }
}
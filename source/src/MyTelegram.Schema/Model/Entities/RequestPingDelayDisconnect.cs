﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

[TlObject(0xf3427b8c)]
public sealed class RequestPingDelayDisconnect : IRequest<MyTelegram.Schema.IPong>
{
    public uint ConstructorId => 0xf3427b8c;
    public long PingId { get; set; }
    public int DisconnectDelay { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(PingId);
        bw.Write(DisconnectDelay);
    }

    public void Deserialize(BinaryReader br)
    {
        PingId = br.ReadInt64();
        DisconnectDelay = br.ReadInt32();
    }
}

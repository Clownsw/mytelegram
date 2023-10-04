﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0xb5890dba)]
public sealed class TServerDHInnerData : IObject
{
    public uint ConstructorId => 0xb5890dba;
    public byte[] Nonce { get; set; }
    public byte[] ServerNonce { get; set; }
    public int G { get; set; }
    public byte[] DhPrime { get; set; }
    public byte[] GA { get; set; }
    public int ServerTime { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.WriteRawBytes(Nonce);
        writer.WriteRawBytes(ServerNonce);
        writer.Write(G);
        writer.Write(DhPrime);
        writer.Write(GA);
        writer.Write(ServerTime);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Nonce = reader.ReadInt128();
        ServerNonce = reader.ReadInt128();
        G = reader.ReadInt32();
        DhPrime = reader.ReadBytes();
        GA = reader.ReadBytes();
        ServerTime = reader.ReadInt32();
    }
}
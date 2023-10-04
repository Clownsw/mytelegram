﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0xa69dae02)]
public sealed class TDhGenFail : ISetClientDHParamsAnswer
{
    public uint ConstructorId => 0xa69dae02;
    public byte[] Nonce { get; set; }
    public byte[] ServerNonce { get; set; }
    public byte[] NewNonceHash3 { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.WriteRawBytes(Nonce);
        writer.WriteRawBytes(ServerNonce);
        writer.WriteRawBytes(NewNonceHash3);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Nonce = reader.ReadInt128();
        ServerNonce = reader.ReadInt128();
        NewNonceHash3 = reader.ReadInt128();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

[TlObject(0xbe7e8ef1)]
public sealed class RequestReqPqMulti : IRequest<MyTelegram.Schema.IResPQ>
{
    public uint ConstructorId => 0xbe7e8ef1;
    public byte[] Nonce { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        SerializerFactory.CreateInt128Serializer().Serialize(Nonce, bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Nonce = SerializerFactory.CreateInt128Serializer().Deserialize(br);
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0xf660e1d4)]
public class TDestroyAuthKeyOk : IDestroyAuthKeyRes
{
    public uint ConstructorId => 0xf660e1d4;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/photoStrippedSize" />
///</summary>
[TlObject(0xe0b0bc2e)]
public class TPhotoStrippedSize : IPhotoSize
{
    public uint ConstructorId => 0xe0b0bc2e;
    public string Type { get; set; }
    public byte[] Bytes { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Type);
        bw.Serialize(Bytes);
    }

    public void Deserialize(BinaryReader br)
    {
        Type = br.Deserialize<string>();
        Bytes = br.Deserialize<byte[]>();
    }
}
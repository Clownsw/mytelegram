﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateReadFeaturedStickers" />
///</summary>
[TlObject(0x571d2742)]
public class TUpdateReadFeaturedStickers : IUpdate
{
    public uint ConstructorId => 0x571d2742;


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
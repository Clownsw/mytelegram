﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/baseThemeTinted" />
///</summary>
[TlObject(0x6d5f77ee)]
public class TBaseThemeTinted : IBaseTheme
{
    public uint ConstructorId => 0x6d5f77ee;


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
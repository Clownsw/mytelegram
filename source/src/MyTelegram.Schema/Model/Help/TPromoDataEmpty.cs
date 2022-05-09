﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;


///<summary>
///See <a href="https://core.telegram.org/constructor/help.promoDataEmpty" />
///</summary>
[TlObject(0x98f6ac75)]
public class TPromoDataEmpty : IPromoData,IEmpty
{
    public uint ConstructorId => 0x98f6ac75;
    public int Expires { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Expires);
    }

    public void Deserialize(BinaryReader br)
    {
        Expires = br.ReadInt32();
    }
}
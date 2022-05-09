﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/documentAttributeImageSize" />
///</summary>
[TlObject(0x6c37c15c)]
public class TDocumentAttributeImageSize : IDocumentAttribute
{
    public uint ConstructorId => 0x6c37c15c;
    public int W { get; set; }
    public int H { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(W);
        bw.Write(H);
    }

    public void Deserialize(BinaryReader br)
    {
        W = br.ReadInt32();
        H = br.ReadInt32();
    }
}
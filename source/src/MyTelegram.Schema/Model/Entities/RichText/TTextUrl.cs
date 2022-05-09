﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/textUrl" />
///</summary>
[TlObject(0x3c2884c1)]
public class TTextUrl : IRichText
{
    public uint ConstructorId => 0x3c2884c1;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/RichText" />
    ///</summary>
    public MyTelegram.Schema.IRichText Text { get; set; }
    public string Url { get; set; }
    public long WebpageId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Text.Serialize(bw);
        bw.Serialize(Url);
        bw.Write(WebpageId);
    }

    public void Deserialize(BinaryReader br)
    {
        Text = br.Deserialize<MyTelegram.Schema.IRichText>();
        Url = br.Deserialize<string>();
        WebpageId = br.ReadInt64();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/bankCardOpenUrl" />
///</summary>
[TlObject(0xf568028a)]
public class TBankCardOpenUrl : IBankCardOpenUrl
{
    public uint ConstructorId => 0xf568028a;
    public string Url { get; set; }
    public string Name { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Url);
        bw.Serialize(Name);
    }

    public void Deserialize(BinaryReader br)
    {
        Url = br.Deserialize<string>();
        Name = br.Deserialize<string>();
    }
}
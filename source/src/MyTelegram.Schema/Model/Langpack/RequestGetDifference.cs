﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Langpack;

///<summary>
///See <a href="https://core.telegram.org/method/langpack.getDifference" />
///</summary>
[TlObject(0xcd984aa5)]
public sealed class RequestGetDifference : IRequest<MyTelegram.Schema.ILangPackDifference>
{
    public uint ConstructorId => 0xcd984aa5;
    public string LangPack { get; set; }
    public string LangCode { get; set; }
    public int FromVersion { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(LangPack);
        bw.Serialize(LangCode);
        bw.Write(FromVersion);
    }

    public void Deserialize(BinaryReader br)
    {
        LangPack = br.Deserialize<string>();
        LangCode = br.Deserialize<string>();
        FromVersion = br.ReadInt32();
    }
}

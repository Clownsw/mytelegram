﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getFeaturedStickers" />
///</summary>
[TlObject(0x64780b14)]
public sealed class RequestGetFeaturedStickers : IRequest<MyTelegram.Schema.Messages.IFeaturedStickers>
{
    public uint ConstructorId => 0x64780b14;
    public long Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Hash = br.ReadInt64();
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getCommonChats" />
///</summary>
[TlObject(0xe40ca104)]
public sealed class RequestGetCommonChats : IRequest<MyTelegram.Schema.Messages.IChats>
{
    public uint ConstructorId => 0xe40ca104;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser UserId { get; set; }
    public long MaxId { get; set; }
    public int Limit { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        UserId.Serialize(bw);
        bw.Write(MaxId);
        bw.Write(Limit);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.Deserialize<MyTelegram.Schema.IInputUser>();
        MaxId = br.ReadInt64();
        Limit = br.ReadInt32();
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateNewMessage" />
///</summary>
[TlObject(0x1f2b0afd)]
public class TUpdateNewMessage : IUpdate
{
    public uint ConstructorId => 0x1f2b0afd;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Message" />
    ///</summary>
    public MyTelegram.Schema.IMessage Message { get; set; }
    public int Pts { get; set; }
    public int PtsCount { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Message.Serialize(bw);
        bw.Write(Pts);
        bw.Write(PtsCount);
    }

    public void Deserialize(BinaryReader br)
    {
        Message = br.Deserialize<MyTelegram.Schema.IMessage>();
        Pts = br.ReadInt32();
        PtsCount = br.ReadInt32();
    }
}
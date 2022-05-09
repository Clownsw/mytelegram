﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/sendMessageEmojiInteractionSeen" />
///</summary>
[TlObject(0xb665902e)]
public class TSendMessageEmojiInteractionSeen : ISendMessageAction
{
    public uint ConstructorId => 0xb665902e;
    public string Emoticon { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Emoticon);
    }

    public void Deserialize(BinaryReader br)
    {
        Emoticon = br.Deserialize<string>();
    }
}
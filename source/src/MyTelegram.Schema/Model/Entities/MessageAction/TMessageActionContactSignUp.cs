﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageActionContactSignUp" />
///</summary>
[TlObject(0xf3f25f76)]
public class TMessageActionContactSignUp : IMessageAction
{
    public uint ConstructorId => 0xf3f25f76;


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
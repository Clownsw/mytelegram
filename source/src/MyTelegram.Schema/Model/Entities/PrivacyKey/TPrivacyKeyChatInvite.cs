﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/privacyKeyChatInvite" />
///</summary>
[TlObject(0x500e6dfa)]
public class TPrivacyKeyChatInvite : IPrivacyKey
{
    public uint ConstructorId => 0x500e6dfa;


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
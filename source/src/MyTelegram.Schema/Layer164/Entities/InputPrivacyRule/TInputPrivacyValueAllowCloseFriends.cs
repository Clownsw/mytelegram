﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/inputPrivacyValueAllowCloseFriends" />
///</summary>
[TlObject(0x2f453e49)]
public sealed class TInputPrivacyValueAllowCloseFriends : IInputPrivacyRule
{
    public uint ConstructorId => 0x2f453e49;


    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}
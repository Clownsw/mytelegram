﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Allow all users
/// See <a href="https://corefork.telegram.org/constructor/inputPrivacyValueAllowAll" />
///</summary>
[TlObject(0x184b35ce)]
public sealed class TInputPrivacyValueAllowAll : IInputPrivacyRule
{
    public uint ConstructorId => 0x184b35ce;


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
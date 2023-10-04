﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Disallow only contacts
/// See <a href="https://corefork.telegram.org/constructor/inputPrivacyValueDisallowContacts" />
///</summary>
[TlObject(0xba52007)]
public sealed class TInputPrivacyValueDisallowContacts : IInputPrivacyRule
{
    public uint ConstructorId => 0xba52007;


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
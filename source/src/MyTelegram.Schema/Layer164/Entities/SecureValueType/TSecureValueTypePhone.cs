﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Phone
/// See <a href="https://corefork.telegram.org/constructor/secureValueTypePhone" />
///</summary>
[TlObject(0xb320aadb)]
public sealed class TSecureValueTypePhone : ISecureValueType
{
    public uint ConstructorId => 0xb320aadb;


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
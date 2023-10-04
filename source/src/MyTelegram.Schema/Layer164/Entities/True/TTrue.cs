﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/mtproto/TL-formal#predefined-identifiers">predefined identifiers</a>.
/// See <a href="https://corefork.telegram.org/constructor/true" />
///</summary>
[TlObject(0x3fedd339)]
public sealed class TTrue : ITrue
{
    public uint ConstructorId => 0x3fedd339;


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
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Users to which the users often forwards messages to
/// See <a href="https://corefork.telegram.org/constructor/topPeerCategoryForwardUsers" />
///</summary>
[TlObject(0xa8406ca9)]
public sealed class TTopPeerCategoryForwardUsers : ITopPeerCategory
{
    public uint ConstructorId => 0xa8406ca9;


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
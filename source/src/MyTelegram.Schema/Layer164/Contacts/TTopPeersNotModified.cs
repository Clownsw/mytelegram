﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
/// Top peer info hasn't changed
/// See <a href="https://corefork.telegram.org/constructor/contacts.topPeersNotModified" />
///</summary>
[TlObject(0xde266ef5)]
public sealed class TTopPeersNotModified : ITopPeers
{
    public uint ConstructorId => 0xde266ef5;


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
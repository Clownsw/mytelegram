﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// An empty constructor, no user or chat is defined.
/// See <a href="https://corefork.telegram.org/constructor/inputPeerEmpty" />
///</summary>
[TlObject(0x7f3b18ea)]
public sealed class TInputPeerEmpty : IInputPeer,IEmpty
{
    public uint ConstructorId => 0x7f3b18ea;


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
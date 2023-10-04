﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A message was pinned
/// See <a href="https://corefork.telegram.org/constructor/messageActionPinMessage" />
///</summary>
[TlObject(0x94bd38ed)]
public sealed class TMessageActionPinMessage : IMessageAction
{
    public uint ConstructorId => 0x94bd38ed;


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
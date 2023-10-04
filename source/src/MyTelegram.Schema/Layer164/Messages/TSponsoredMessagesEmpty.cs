﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// No sponsored messages are available.
/// See <a href="https://corefork.telegram.org/constructor/messages.sponsoredMessagesEmpty" />
///</summary>
[TlObject(0x1839490f)]
public sealed class TSponsoredMessagesEmpty : ISponsoredMessages,IEmpty
{
    public uint ConstructorId => 0x1839490f;


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
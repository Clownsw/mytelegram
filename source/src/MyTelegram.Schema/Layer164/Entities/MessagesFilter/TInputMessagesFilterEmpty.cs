﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Filter is absent.
/// See <a href="https://corefork.telegram.org/constructor/inputMessagesFilterEmpty" />
///</summary>
[TlObject(0x57e2f66c)]
public sealed class TInputMessagesFilterEmpty : IMessagesFilter,IEmpty
{
    public uint ConstructorId => 0x57e2f66c;


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
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// All contacts were deleted
/// See <a href="https://corefork.telegram.org/constructor/updateContactsReset" />
///</summary>
[TlObject(0x7084a7be)]
public sealed class TUpdateContactsReset : IUpdate
{
    public uint ConstructorId => 0x7084a7be;


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
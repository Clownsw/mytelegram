﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The saved gif list has changed, the client should refetch it using <a href="https://core.telegram.org/method/messages.getSavedGifs">messages.getSavedGifs</a>
/// See <a href="https://corefork.telegram.org/constructor/updateSavedGifs" />
///</summary>
[TlObject(0x9375341e)]
public sealed class TUpdateSavedGifs : IUpdate
{
    public uint ConstructorId => 0x9375341e;


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
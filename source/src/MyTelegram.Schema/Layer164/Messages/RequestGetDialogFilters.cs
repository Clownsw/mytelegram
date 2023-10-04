﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Get <a href="https://corefork.telegram.org/api/folders">folders</a>
/// See <a href="https://corefork.telegram.org/method/messages.getDialogFilters" />
///</summary>
[TlObject(0xf19ed96d)]
public sealed class RequestGetDialogFilters : IRequest<TVector<MyTelegram.Schema.IDialogFilter>>
{
    public uint ConstructorId => 0xf19ed96d;

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

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Get installed mask stickers
/// See <a href="https://corefork.telegram.org/method/messages.getMaskStickers" />
///</summary>
[TlObject(0x640f82b8)]
public sealed class RequestGetMaskStickers : IRequest<MyTelegram.Schema.Messages.IAllStickers>
{
    public uint ConstructorId => 0x640f82b8;
    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash for pagination, for more info click here</a>
    ///</summary>
    public long Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Hash = reader.ReadInt64();
    }
}

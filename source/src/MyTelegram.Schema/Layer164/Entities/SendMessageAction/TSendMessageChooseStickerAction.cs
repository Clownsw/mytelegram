﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// User is choosing a sticker
/// See <a href="https://corefork.telegram.org/constructor/sendMessageChooseStickerAction" />
///</summary>
[TlObject(0xb05ac6b1)]
public sealed class TSendMessageChooseStickerAction : ISendMessageAction
{
    public uint ConstructorId => 0xb05ac6b1;


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
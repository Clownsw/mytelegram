﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stickers;

///<summary>
/// Changes the absolute position of a sticker in the set to which it belongs; for bots only. The sticker set must have been created by the bot
/// <para>Possible errors</para>
/// Code Type Description
/// 400 STICKER_INVALID The provided sticker is invalid.
/// See <a href="https://corefork.telegram.org/method/stickers.changeStickerPosition" />
///</summary>
[TlObject(0xffb6d4ca)]
public sealed class RequestChangeStickerPosition : IRequest<MyTelegram.Schema.Messages.IStickerSet>
{
    public uint ConstructorId => 0xffb6d4ca;
    ///<summary>
    /// The sticker
    /// See <a href="https://corefork.telegram.org/type/InputDocument" />
    ///</summary>
    public MyTelegram.Schema.IInputDocument Sticker { get; set; }

    ///<summary>
    /// The new position of the sticker, zero-based
    ///</summary>
    public int Position { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Sticker);
        writer.Write(Position);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Sticker = reader.Read<MyTelegram.Schema.IInputDocument>();
        Position = reader.ReadInt32();
    }
}

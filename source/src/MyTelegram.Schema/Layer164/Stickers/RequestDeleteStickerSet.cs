﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stickers;

///<summary>
/// Deletes a stickerset we created, bots only.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 BOT_MISSING Only bots can call this method, please use <a href="https://t.me/stickers">@stickers</a> if you're a user.
/// 400 STICKERSET_INVALID The provided sticker set is invalid.
/// See <a href="https://corefork.telegram.org/method/stickers.deleteStickerSet" />
///</summary>
[TlObject(0x87704394)]
public sealed class RequestDeleteStickerSet : IRequest<IBool>
{
    public uint ConstructorId => 0x87704394;
    ///<summary>
    /// Stickerset to delete
    /// See <a href="https://corefork.telegram.org/type/InputStickerSet" />
    ///</summary>
    public MyTelegram.Schema.IInputStickerSet Stickerset { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Stickerset);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Stickerset = reader.Read<MyTelegram.Schema.IInputStickerSet>();
    }
}

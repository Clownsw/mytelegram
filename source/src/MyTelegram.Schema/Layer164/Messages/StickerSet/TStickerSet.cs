﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Stickerset and stickers inside it
/// See <a href="https://corefork.telegram.org/constructor/messages.stickerSet" />
///</summary>
[TlObject(0x6e153f16)]
public sealed class TStickerSet : IStickerSet
{
    public uint ConstructorId => 0x6e153f16;
    ///<summary>
    /// The stickerset
    /// See <a href="https://corefork.telegram.org/type/StickerSet" />
    ///</summary>
    public MyTelegram.Schema.IStickerSet Set { get; set; }

    ///<summary>
    /// Emoji info for stickers
    ///</summary>
    public TVector<MyTelegram.Schema.IStickerPack> Packs { get; set; }

    ///<summary>
    /// Keywords for some or every sticker in the stickerset.
    ///</summary>
    public TVector<MyTelegram.Schema.IStickerKeyword> Keywords { get; set; }

    ///<summary>
    /// Stickers in stickerset
    ///</summary>
    public TVector<MyTelegram.Schema.IDocument> Documents { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Set);
        writer.Write(Packs);
        writer.Write(Keywords);
        writer.Write(Documents);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Set = reader.Read<MyTelegram.Schema.IStickerSet>();
        Packs = reader.Read<TVector<MyTelegram.Schema.IStickerPack>>();
        Keywords = reader.Read<TVector<MyTelegram.Schema.IStickerKeyword>>();
        Documents = reader.Read<TVector<MyTelegram.Schema.IDocument>>();
    }
}
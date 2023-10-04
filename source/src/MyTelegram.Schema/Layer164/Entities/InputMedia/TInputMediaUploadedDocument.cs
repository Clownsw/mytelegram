﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// New document
/// See <a href="https://corefork.telegram.org/constructor/inputMediaUploadedDocument" />
///</summary>
[TlObject(0x5b38c6c1)]
public sealed class TInputMediaUploadedDocument : IInputMedia
{
    public uint ConstructorId => 0x5b38c6c1;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the specified document is a video file with no audio tracks (a GIF animation (even as MPEG4), for example)
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool NosoundVideo { get; set; }

    ///<summary>
    /// Force the media file to be uploaded as document
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ForceFile { get; set; }

    ///<summary>
    /// Whether this media should be hidden behind a spoiler warning
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Spoiler { get; set; }

    ///<summary>
    /// The <a href="https://corefork.telegram.org/api/files">uploaded file</a>
    /// See <a href="https://corefork.telegram.org/type/InputFile" />
    ///</summary>
    public MyTelegram.Schema.IInputFile File { get; set; }

    ///<summary>
    /// Thumbnail of the document, uploaded as for the file
    /// See <a href="https://corefork.telegram.org/type/InputFile" />
    ///</summary>
    public MyTelegram.Schema.IInputFile? Thumb { get; set; }

    ///<summary>
    /// MIME type of document
    ///</summary>
    public string MimeType { get; set; }

    ///<summary>
    /// Attributes that specify the type of the document (video, audio, voice, sticker, etc.)
    ///</summary>
    public TVector<MyTelegram.Schema.IDocumentAttribute> Attributes { get; set; }

    ///<summary>
    /// Attached stickers
    ///</summary>
    public TVector<MyTelegram.Schema.IInputDocument>? Stickers { get; set; }

    ///<summary>
    /// Time to live in seconds of self-destructing document
    ///</summary>
    public int? TtlSeconds { get; set; }

    public void ComputeFlag()
    {
        if (NosoundVideo) { Flags[3] = true; }
        if (ForceFile) { Flags[4] = true; }
        if (Spoiler) { Flags[5] = true; }
        if (Thumb != null) { Flags[2] = true; }
        if (Stickers?.Count > 0) { Flags[0] = true; }
        if (/*TtlSeconds != 0 && */TtlSeconds.HasValue) { Flags[1] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(File);
        if (Flags[2]) { writer.Write(Thumb); }
        writer.Write(MimeType);
        writer.Write(Attributes);
        if (Flags[0]) { writer.Write(Stickers); }
        if (Flags[1]) { writer.Write(TtlSeconds.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[3]) { NosoundVideo = true; }
        if (Flags[4]) { ForceFile = true; }
        if (Flags[5]) { Spoiler = true; }
        File = reader.Read<MyTelegram.Schema.IInputFile>();
        if (Flags[2]) { Thumb = reader.Read<MyTelegram.Schema.IInputFile>(); }
        MimeType = reader.ReadString();
        Attributes = reader.Read<TVector<MyTelegram.Schema.IDocumentAttribute>>();
        if (Flags[0]) { Stickers = reader.Read<TVector<MyTelegram.Schema.IInputDocument>>(); }
        if (Flags[1]) { TtlSeconds = reader.ReadInt32(); }
    }
}
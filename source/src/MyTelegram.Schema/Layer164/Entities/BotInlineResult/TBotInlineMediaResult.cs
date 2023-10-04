﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Media result
/// See <a href="https://corefork.telegram.org/constructor/botInlineMediaResult" />
///</summary>
[TlObject(0x17db940b)]
public sealed class TBotInlineMediaResult : IBotInlineResult
{
    public uint ConstructorId => 0x17db940b;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Result ID
    ///</summary>
    public string Id { get; set; }

    ///<summary>
    /// Result type (see <a href="https://corefork.telegram.org/bots/api#inlinequeryresult">bot API docs</a>)
    ///</summary>
    public string Type { get; set; }

    ///<summary>
    /// If type is <code>photo</code>, the photo to send
    /// See <a href="https://corefork.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto? Photo { get; set; }

    ///<summary>
    /// If type is <code>document</code>, the document to send
    /// See <a href="https://corefork.telegram.org/type/Document" />
    ///</summary>
    public MyTelegram.Schema.IDocument? Document { get; set; }

    ///<summary>
    /// Result title
    ///</summary>
    public string? Title { get; set; }

    ///<summary>
    /// Description
    ///</summary>
    public string? Description { get; set; }

    ///<summary>
    /// Depending on the <code>type</code> and on the <a href="https://corefork.telegram.org/type/BotInlineMessage">constructor</a>, contains the caption of the media or the content of the message to be sent <strong>instead</strong> of the media
    /// See <a href="https://corefork.telegram.org/type/BotInlineMessage" />
    ///</summary>
    public MyTelegram.Schema.IBotInlineMessage SendMessage { get; set; }

    public void ComputeFlag()
    {
        if (Photo != null) { Flags[0] = true; }
        if (Document != null) { Flags[1] = true; }
        if (Title != null) { Flags[2] = true; }
        if (Description != null) { Flags[3] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        writer.Write(Type);
        if (Flags[0]) { writer.Write(Photo); }
        if (Flags[1]) { writer.Write(Document); }
        if (Flags[2]) { writer.Write(Title); }
        if (Flags[3]) { writer.Write(Description); }
        writer.Write(SendMessage);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Id = reader.ReadString();
        Type = reader.ReadString();
        if (Flags[0]) { Photo = reader.Read<MyTelegram.Schema.IPhoto>(); }
        if (Flags[1]) { Document = reader.Read<MyTelegram.Schema.IDocument>(); }
        if (Flags[2]) { Title = reader.ReadString(); }
        if (Flags[3]) { Description = reader.ReadString(); }
        SendMessage = reader.Read<MyTelegram.Schema.IBotInlineMessage>();
    }
}
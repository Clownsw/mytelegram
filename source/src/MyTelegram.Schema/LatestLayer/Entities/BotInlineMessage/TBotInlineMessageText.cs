﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Send a simple text message
/// See <a href="https://corefork.telegram.org/constructor/botInlineMessageText" />
///</summary>
[TlObject(0x8c7f65e2)]
public sealed class TBotInlineMessageText : IBotInlineMessage
{
    public uint ConstructorId => 0x8c7f65e2;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Disable webpage preview
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool NoWebpage { get; set; }
    public bool InvertMedia { get; set; }

    ///<summary>
    /// The message
    ///</summary>
    public string Message { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/entities">Message entities for styled text</a>
    ///</summary>
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }

    ///<summary>
    /// Inline keyboard
    /// See <a href="https://corefork.telegram.org/type/ReplyMarkup" />
    ///</summary>
    public MyTelegram.Schema.IReplyMarkup? ReplyMarkup { get; set; }

    public void ComputeFlag()
    {
        if (NoWebpage) { Flags[0] = true; }
        if (InvertMedia) { Flags[3] = true; }
        if (Entities?.Count > 0) { Flags[1] = true; }
        if (ReplyMarkup != null) { Flags[2] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Message);
        if (Flags[1]) { writer.Write(Entities); }
        if (Flags[2]) { writer.Write(ReplyMarkup); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { NoWebpage = true; }
        if (Flags[3]) { InvertMedia = true; }
        Message = reader.ReadString();
        if (Flags[1]) { Entities = reader.Read<TVector<MyTelegram.Schema.IMessageEntity>>(); }
        if (Flags[2]) { ReplyMarkup = reader.Read<MyTelegram.Schema.IReplyMarkup>(); }
    }
}
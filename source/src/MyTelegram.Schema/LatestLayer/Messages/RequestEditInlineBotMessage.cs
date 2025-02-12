﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Edit an inline bot message
/// <para>Possible errors</para>
/// Code Type Description
/// 400 BUTTON_DATA_INVALID The data of one or more of the buttons you provided is invalid.
/// 400 ENTITY_BOUNDS_INVALID A specified <a href="https://corefork.telegram.org/api/entities#entity-length">entity offset or length</a> is invalid, see <a href="https://corefork.telegram.org/api/entities#entity-length">here »</a> for info on how to properly compute the entity offset/length.
/// 400 MESSAGE_ID_INVALID The provided message id is invalid.
/// 400 MESSAGE_NOT_MODIFIED The provided message data is identical to the previous message data, the message wasn't modified.
/// See <a href="https://corefork.telegram.org/method/messages.editInlineBotMessage" />
///</summary>
[TlObject(0x83557dba)]
public sealed class RequestEditInlineBotMessage : IRequest<IBool>
{
    public uint ConstructorId => 0x83557dba;
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
    /// Sent inline message ID
    /// See <a href="https://corefork.telegram.org/type/InputBotInlineMessageID" />
    ///</summary>
    public MyTelegram.Schema.IInputBotInlineMessageID Id { get; set; }

    ///<summary>
    /// Message
    ///</summary>
    public string? Message { get; set; }

    ///<summary>
    /// Media
    /// See <a href="https://corefork.telegram.org/type/InputMedia" />
    ///</summary>
    public MyTelegram.Schema.IInputMedia? Media { get; set; }

    ///<summary>
    /// Reply markup for inline keyboards
    /// See <a href="https://corefork.telegram.org/type/ReplyMarkup" />
    ///</summary>
    public MyTelegram.Schema.IReplyMarkup? ReplyMarkup { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/entities">Message entities for styled text</a>
    ///</summary>
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }

    public void ComputeFlag()
    {
        if (NoWebpage) { Flags[1] = true; }
        if (InvertMedia) { Flags[16] = true; }
        if (Message != null) { Flags[11] = true; }
        if (Media != null) { Flags[14] = true; }
        if (ReplyMarkup != null) { Flags[2] = true; }
        if (Entities?.Count > 0) { Flags[3] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        if (Flags[11]) { writer.Write(Message); }
        if (Flags[14]) { writer.Write(Media); }
        if (Flags[2]) { writer.Write(ReplyMarkup); }
        if (Flags[3]) { writer.Write(Entities); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { NoWebpage = true; }
        if (Flags[16]) { InvertMedia = true; }
        Id = reader.Read<MyTelegram.Schema.IInputBotInlineMessageID>();
        if (Flags[11]) { Message = reader.ReadString(); }
        if (Flags[14]) { Media = reader.Read<MyTelegram.Schema.IInputMedia>(); }
        if (Flags[2]) { ReplyMarkup = reader.Read<MyTelegram.Schema.IReplyMarkup>(); }
        if (Flags[3]) { Entities = reader.Read<TVector<MyTelegram.Schema.IMessageEntity>>(); }
    }
}

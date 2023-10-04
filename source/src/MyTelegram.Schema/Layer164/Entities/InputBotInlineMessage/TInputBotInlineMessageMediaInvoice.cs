﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// An invoice
/// See <a href="https://corefork.telegram.org/constructor/inputBotInlineMessageMediaInvoice" />
///</summary>
[TlObject(0xd7e78225)]
public sealed class TInputBotInlineMessageMediaInvoice : IInputBotInlineMessage
{
    public uint ConstructorId => 0xd7e78225;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Product name, 1-32 characters
    ///</summary>
    public string Title { get; set; }

    ///<summary>
    /// Product description, 1-255 characters
    ///</summary>
    public string Description { get; set; }

    ///<summary>
    /// Invoice photo
    /// See <a href="https://corefork.telegram.org/type/InputWebDocument" />
    ///</summary>
    public MyTelegram.Schema.IInputWebDocument? Photo { get; set; }

    ///<summary>
    /// The invoice
    /// See <a href="https://corefork.telegram.org/type/Invoice" />
    ///</summary>
    public MyTelegram.Schema.IInvoice Invoice { get; set; }

    ///<summary>
    /// Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.
    ///</summary>
    public byte[] Payload { get; set; }

    ///<summary>
    /// Payments provider token, obtained via <a href="https://t.me/botfather">Botfather</a>
    ///</summary>
    public string Provider { get; set; }

    ///<summary>
    /// A JSON-serialized object for data about the invoice, which will be shared with the payment provider. A detailed description of the required fields should be provided by the payment provider.
    /// See <a href="https://corefork.telegram.org/type/DataJSON" />
    ///</summary>
    public MyTelegram.Schema.IDataJSON ProviderData { get; set; }

    ///<summary>
    /// Inline keyboard
    /// See <a href="https://corefork.telegram.org/type/ReplyMarkup" />
    ///</summary>
    public MyTelegram.Schema.IReplyMarkup? ReplyMarkup { get; set; }

    public void ComputeFlag()
    {
        if (Photo != null) { Flags[0] = true; }
        if (ReplyMarkup != null) { Flags[2] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Title);
        writer.Write(Description);
        if (Flags[0]) { writer.Write(Photo); }
        writer.Write(Invoice);
        writer.Write(Payload);
        writer.Write(Provider);
        writer.Write(ProviderData);
        if (Flags[2]) { writer.Write(ReplyMarkup); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Title = reader.ReadString();
        Description = reader.ReadString();
        if (Flags[0]) { Photo = reader.Read<MyTelegram.Schema.IInputWebDocument>(); }
        Invoice = reader.Read<MyTelegram.Schema.IInvoice>();
        Payload = reader.ReadBytes();
        Provider = reader.ReadString();
        ProviderData = reader.Read<MyTelegram.Schema.IDataJSON>();
        if (Flags[2]) { ReplyMarkup = reader.Read<MyTelegram.Schema.IReplyMarkup>(); }
    }
}
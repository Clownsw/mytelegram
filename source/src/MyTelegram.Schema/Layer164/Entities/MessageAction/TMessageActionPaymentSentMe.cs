﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A user just sent a payment to me (a bot)
/// See <a href="https://corefork.telegram.org/constructor/messageActionPaymentSentMe" />
///</summary>
[TlObject(0x8f31b327)]
public sealed class TMessageActionPaymentSentMe : IMessageAction
{
    public uint ConstructorId => 0x8f31b327;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether this is the first payment of a recurring payment we just subscribed to
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool RecurringInit { get; set; }

    ///<summary>
    /// Whether this payment is part of a recurring payment
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool RecurringUsed { get; set; }

    ///<summary>
    /// Three-letter ISO 4217 <a href="https://corefork.telegram.org/bots/payments#supported-currencies">currency</a> code
    ///</summary>
    public string Currency { get; set; }

    ///<summary>
    /// Price of the product in the smallest units of the currency (integer, not float/double). For example, for a price of <code>US$ 1.45</code> pass <code>amount = 145</code>. See the exp parameter in <a href="https://corefork.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
    ///</summary>
    public long TotalAmount { get; set; }

    ///<summary>
    /// Bot specified invoice payload
    ///</summary>
    public byte[] Payload { get; set; }

    ///<summary>
    /// Order info provided by the user
    /// See <a href="https://corefork.telegram.org/type/PaymentRequestedInfo" />
    ///</summary>
    public MyTelegram.Schema.IPaymentRequestedInfo? Info { get; set; }

    ///<summary>
    /// Identifier of the shipping option chosen by the user
    ///</summary>
    public string? ShippingOptionId { get; set; }

    ///<summary>
    /// Provider payment identifier
    /// See <a href="https://corefork.telegram.org/type/PaymentCharge" />
    ///</summary>
    public MyTelegram.Schema.IPaymentCharge Charge { get; set; }

    public void ComputeFlag()
    {
        if (RecurringInit) { Flags[2] = true; }
        if (RecurringUsed) { Flags[3] = true; }
        if (Info != null) { Flags[0] = true; }
        if (ShippingOptionId != null) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Currency);
        writer.Write(TotalAmount);
        writer.Write(Payload);
        if (Flags[0]) { writer.Write(Info); }
        if (Flags[1]) { writer.Write(ShippingOptionId); }
        writer.Write(Charge);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[2]) { RecurringInit = true; }
        if (Flags[3]) { RecurringUsed = true; }
        Currency = reader.ReadString();
        TotalAmount = reader.ReadInt64();
        Payload = reader.ReadBytes();
        if (Flags[0]) { Info = reader.Read<MyTelegram.Schema.IPaymentRequestedInfo>(); }
        if (Flags[1]) { ShippingOptionId = reader.ReadString(); }
        Charge = reader.Read<MyTelegram.Schema.IPaymentCharge>();
    }
}
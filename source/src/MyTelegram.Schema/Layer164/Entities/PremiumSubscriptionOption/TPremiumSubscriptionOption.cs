﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Describes a Telegram Premium subscription option
/// See <a href="https://corefork.telegram.org/constructor/premiumSubscriptionOption" />
///</summary>
[TlObject(0x5f2d1df2)]
public sealed class TPremiumSubscriptionOption : IPremiumSubscriptionOption
{
    public uint ConstructorId => 0x5f2d1df2;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether this subscription option is currently in use.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Current { get; set; }

    ///<summary>
    /// Whether this subscription option can be used to upgrade the existing Telegram Premium subscription. When upgrading Telegram Premium subscriptions bought through stores, make sure that the store transaction ID is equal to <code>transaction</code>, to avoid upgrading someone else's account, if the client is currently logged into multiple accounts.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool CanPurchaseUpgrade { get; set; }

    ///<summary>
    /// Identifier of the last in-store transaction for the currently used subscription on the current account.
    ///</summary>
    public string? Transaction { get; set; }

    ///<summary>
    /// Duration of subscription in months
    ///</summary>
    public int Months { get; set; }

    ///<summary>
    /// Three-letter ISO 4217 <a href="https://corefork.telegram.org/bots/payments#supported-currencies">currency</a> code
    ///</summary>
    public string Currency { get; set; }

    ///<summary>
    /// Total price in the smallest units of the currency (integer, not float/double). For example, for a price of <code>US$ 1.45</code> pass <code>amount = 145</code>. See the exp parameter in <a href="https://corefork.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
    ///</summary>
    public long Amount { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/links">Deep link</a> used to initiate payment
    ///</summary>
    public string BotUrl { get; set; }

    ///<summary>
    /// Store product ID, only for official apps
    ///</summary>
    public string? StoreProduct { get; set; }

    public void ComputeFlag()
    {
        if (Current) { Flags[1] = true; }
        if (CanPurchaseUpgrade) { Flags[2] = true; }
        if (Transaction != null) { Flags[3] = true; }
        if (StoreProduct != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[3]) { writer.Write(Transaction); }
        writer.Write(Months);
        writer.Write(Currency);
        writer.Write(Amount);
        writer.Write(BotUrl);
        if (Flags[0]) { writer.Write(StoreProduct); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { Current = true; }
        if (Flags[2]) { CanPurchaseUpgrade = true; }
        if (Flags[3]) { Transaction = reader.ReadString(); }
        Months = reader.ReadInt32();
        Currency = reader.ReadString();
        Amount = reader.ReadInt64();
        BotUrl = reader.ReadString();
        if (Flags[0]) { StoreProduct = reader.ReadString(); }
    }
}
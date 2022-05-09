﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/invoice" />
///</summary>
[TlObject(0xcd886e0)]
public class TInvoice : IInvoice
{
    public uint ConstructorId => 0xcd886e0;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Test { get; set; }
    public bool NameRequested { get; set; }
    public bool PhoneRequested { get; set; }
    public bool EmailRequested { get; set; }
    public bool ShippingAddressRequested { get; set; }
    public bool Flexible { get; set; }
    public bool PhoneToProvider { get; set; }
    public bool EmailToProvider { get; set; }
    public string Currency { get; set; }
    public TVector<MyTelegram.Schema.ILabeledPrice> Prices { get; set; }
    public long? MaxTipAmount { get; set; }
    public TVector<long>? SuggestedTipAmounts { get; set; }

    public void ComputeFlag()
    {
        if (Test) { Flags[0] = true; }
        if (NameRequested) { Flags[1] = true; }
        if (PhoneRequested) { Flags[2] = true; }
        if (EmailRequested) { Flags[3] = true; }
        if (ShippingAddressRequested) { Flags[4] = true; }
        if (Flexible) { Flags[5] = true; }
        if (PhoneToProvider) { Flags[6] = true; }
        if (EmailToProvider) { Flags[7] = true; }
        if (MaxTipAmount != 0 && MaxTipAmount.HasValue) { Flags[8] = true; }
        if (SuggestedTipAmounts?.Count > 0) { Flags[8] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Currency);
        Prices.Serialize(bw);
        if (Flags[8]) { bw.Write(MaxTipAmount.Value); }
        if (Flags[8]) { SuggestedTipAmounts.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Test = true; }
        if (Flags[1]) { NameRequested = true; }
        if (Flags[2]) { PhoneRequested = true; }
        if (Flags[3]) { EmailRequested = true; }
        if (Flags[4]) { ShippingAddressRequested = true; }
        if (Flags[5]) { Flexible = true; }
        if (Flags[6]) { PhoneToProvider = true; }
        if (Flags[7]) { EmailToProvider = true; }
        Currency = br.Deserialize<string>();
        Prices = br.Deserialize<TVector<MyTelegram.Schema.ILabeledPrice>>();
        if (Flags[8]) { MaxTipAmount = br.ReadInt64(); }
        if (Flags[8]) { SuggestedTipAmounts = br.Deserialize<TVector<long>>(); }
    }
}
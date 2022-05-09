﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Payments;


///<summary>
///See <a href="https://core.telegram.org/constructor/payments.paymentVerificationNeeded" />
///</summary>
[TlObject(0xd8411139)]
public class TPaymentVerificationNeeded : IPaymentResult
{
    public uint ConstructorId => 0xd8411139;
    public string Url { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Url);
    }

    public void Deserialize(BinaryReader br)
    {
        Url = br.Deserialize<string>();
    }
}
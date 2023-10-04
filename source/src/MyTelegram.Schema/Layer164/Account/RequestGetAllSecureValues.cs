﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// Get all saved <a href="https://corefork.telegram.org/passport">Telegram Passport</a> documents, <a href="https://corefork.telegram.org/passport/encryption#encryption">for more info see the passport docs »</a>
/// See <a href="https://corefork.telegram.org/method/account.getAllSecureValues" />
///</summary>
[TlObject(0xb288bc7d)]
public sealed class RequestGetAllSecureValues : IRequest<TVector<MyTelegram.Schema.ISecureValue>>
{
    public uint ConstructorId => 0xb288bc7d;

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}

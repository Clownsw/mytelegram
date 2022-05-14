﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.acceptAuthorization" />
///</summary>
[TlObject(0xf3ed4c73)]
public sealed class RequestAcceptAuthorization : IRequest<IBool>
{
    public uint ConstructorId => 0xf3ed4c73;
    public long BotId { get; set; }
    public string Scope { get; set; }
    public string PublicKey { get; set; }
    public TVector<MyTelegram.Schema.ISecureValueHash> ValueHashes { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureCredentialsEncrypted" />
    ///</summary>
    public MyTelegram.Schema.ISecureCredentialsEncrypted Credentials { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(BotId);
        bw.Serialize(Scope);
        bw.Serialize(PublicKey);
        ValueHashes.Serialize(bw);
        Credentials.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        BotId = br.ReadInt64();
        Scope = br.Deserialize<string>();
        PublicKey = br.Deserialize<string>();
        ValueHashes = br.Deserialize<TVector<MyTelegram.Schema.ISecureValueHash>>();
        Credentials = br.Deserialize<MyTelegram.Schema.ISecureCredentialsEncrypted>();
    }
}

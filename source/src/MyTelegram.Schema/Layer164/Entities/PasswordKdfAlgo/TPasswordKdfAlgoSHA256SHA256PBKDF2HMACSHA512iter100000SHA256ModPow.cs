﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// This key derivation algorithm defines that <a href="https://corefork.telegram.org/api/srp">SRP 2FA login</a> must be used
/// See <a href="https://corefork.telegram.org/constructor/passwordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow" />
///</summary>
[TlObject(0x3a912d4a)]
public sealed class TPasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow : IPasswordKdfAlgo
{
    public uint ConstructorId => 0x3a912d4a;
    ///<summary>
    /// One of two salts used by the derivation function (see <a href="https://corefork.telegram.org/api/srp">SRP 2FA login</a>)
    ///</summary>
    public byte[] Salt1 { get; set; }

    ///<summary>
    /// One of two salts used by the derivation function (see <a href="https://corefork.telegram.org/api/srp">SRP 2FA login</a>)
    ///</summary>
    public byte[] Salt2 { get; set; }

    ///<summary>
    /// Base (see <a href="https://corefork.telegram.org/api/srp">SRP 2FA login</a>)
    ///</summary>
    public int G { get; set; }

    ///<summary>
    /// 2048-bit modulus (see <a href="https://corefork.telegram.org/api/srp">SRP 2FA login</a>)
    ///</summary>
    public byte[] P { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Salt1);
        writer.Write(Salt2);
        writer.Write(G);
        writer.Write(P);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Salt1 = reader.ReadBytes();
        Salt2 = reader.ReadBytes();
        G = reader.ReadInt32();
        P = reader.ReadBytes();
    }
}
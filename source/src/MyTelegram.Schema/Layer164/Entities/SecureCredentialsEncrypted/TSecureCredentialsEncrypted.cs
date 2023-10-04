﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Encrypted credentials required to decrypt <a href="https://corefork.telegram.org/passport">telegram passport</a> data.
/// See <a href="https://corefork.telegram.org/constructor/secureCredentialsEncrypted" />
///</summary>
[TlObject(0x33f0ea47)]
public sealed class TSecureCredentialsEncrypted : ISecureCredentialsEncrypted
{
    public uint ConstructorId => 0x33f0ea47;
    ///<summary>
    /// Encrypted JSON-serialized data with unique user's payload, data hashes and secrets required for EncryptedPassportElement decryption and authentication, as described in <a href="https://corefork.telegram.org/passport#decrypting-data">decrypting data »</a>
    ///</summary>
    public byte[] Data { get; set; }

    ///<summary>
    /// Data hash for data authentication as described in <a href="https://corefork.telegram.org/passport#decrypting-data">decrypting data »</a>
    ///</summary>
    public byte[] Hash { get; set; }

    ///<summary>
    /// Secret, encrypted with the bot's public RSA key, required for data decryption as described in <a href="https://corefork.telegram.org/passport#decrypting-data">decrypting data »</a>
    ///</summary>
    public byte[] Secret { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Data);
        writer.Write(Hash);
        writer.Write(Secret);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Data = reader.ReadBytes();
        Hash = reader.ReadBytes();
        Secret = reader.ReadBytes();
    }
}
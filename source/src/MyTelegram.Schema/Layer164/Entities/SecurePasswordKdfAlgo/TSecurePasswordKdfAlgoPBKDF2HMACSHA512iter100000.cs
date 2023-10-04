﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// PBKDF2 with SHA512 and 100000 iterations KDF algo
/// See <a href="https://corefork.telegram.org/constructor/securePasswordKdfAlgoPBKDF2HMACSHA512iter100000" />
///</summary>
[TlObject(0xbbf2dda0)]
public sealed class TSecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000 : ISecurePasswordKdfAlgo
{
    public uint ConstructorId => 0xbbf2dda0;
    ///<summary>
    /// Salt
    ///</summary>
    public byte[] Salt { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Salt);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Salt = reader.ReadBytes();
    }
}
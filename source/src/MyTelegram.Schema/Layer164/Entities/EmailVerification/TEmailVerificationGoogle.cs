﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Google ID email verification token
/// See <a href="https://corefork.telegram.org/constructor/emailVerificationGoogle" />
///</summary>
[TlObject(0xdb909ec2)]
public sealed class TEmailVerificationGoogle : IEmailVerification
{
    public uint ConstructorId => 0xdb909ec2;
    ///<summary>
    /// Token
    ///</summary>
    public string Token { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Token);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Token = reader.ReadString();
    }
}
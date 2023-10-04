﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Saved payment credentials
/// See <a href="https://corefork.telegram.org/constructor/inputPaymentCredentialsSaved" />
///</summary>
[TlObject(0xc10eb2cf)]
public sealed class TInputPaymentCredentialsSaved : IInputPaymentCredentials
{
    public uint ConstructorId => 0xc10eb2cf;
    ///<summary>
    /// Credential ID
    ///</summary>
    public string Id { get; set; }

    ///<summary>
    /// Temporary password
    ///</summary>
    public byte[] TmpPassword { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(TmpPassword);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadString();
        TmpPassword = reader.ReadBytes();
    }
}
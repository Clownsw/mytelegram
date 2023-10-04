﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Disallow only certain users
/// See <a href="https://corefork.telegram.org/constructor/inputPrivacyValueDisallowUsers" />
///</summary>
[TlObject(0x90110467)]
public sealed class TInputPrivacyValueDisallowUsers : IInputPrivacyRule
{
    public uint ConstructorId => 0x90110467;
    ///<summary>
    /// Users to disallow
    ///</summary>
    public TVector<MyTelegram.Schema.IInputUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Users = reader.Read<TVector<MyTelegram.Schema.IInputUser>>();
    }
}
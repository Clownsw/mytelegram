﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Allow only certain users
/// See <a href="https://corefork.telegram.org/constructor/inputPrivacyValueAllowUsers" />
///</summary>
[TlObject(0x131cc67f)]
public sealed class TInputPrivacyValueAllowUsers : IInputPrivacyRule
{
    public uint ConstructorId => 0x131cc67f;
    ///<summary>
    /// Allowed users
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
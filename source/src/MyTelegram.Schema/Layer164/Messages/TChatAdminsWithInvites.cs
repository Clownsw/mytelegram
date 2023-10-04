﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Info about chat invites generated by admins.
/// See <a href="https://corefork.telegram.org/constructor/messages.chatAdminsWithInvites" />
///</summary>
[TlObject(0xb69b72d7)]
public sealed class TChatAdminsWithInvites : IChatAdminsWithInvites
{
    public uint ConstructorId => 0xb69b72d7;
    ///<summary>
    /// Info about chat invites generated by admins.
    ///</summary>
    public TVector<MyTelegram.Schema.IChatAdminWithInvites> Admins { get; set; }

    ///<summary>
    /// Mentioned users
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Admins);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Admins = reader.Read<TVector<MyTelegram.Schema.IChatAdminWithInvites>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;


///<summary>
///See <a href="https://core.telegram.org/constructor/contacts.blocked" />
///</summary>
[TlObject(0xade1591)]
public class TBlocked : IBlocked
{
    public uint ConstructorId => 0xade1591;
    public TVector<MyTelegram.Schema.IPeerBlocked> Blocked { get; set; }
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Blocked.Serialize(bw);
        Chats.Serialize(bw);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Blocked = br.Deserialize<TVector<MyTelegram.Schema.IPeerBlocked>>();
        Chats = br.Deserialize<TVector<MyTelegram.Schema.IChat>>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}
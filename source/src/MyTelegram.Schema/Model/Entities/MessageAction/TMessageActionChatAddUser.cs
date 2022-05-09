﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageActionChatAddUser" />
///</summary>
[TlObject(0x15cefd00)]
public class TMessageActionChatAddUser : IMessageAction
{
    public uint ConstructorId => 0x15cefd00;
    public TVector<long> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Users = br.Deserialize<TVector<long>>();
    }
}
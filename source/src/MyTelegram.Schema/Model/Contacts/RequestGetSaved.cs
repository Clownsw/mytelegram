﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
///See <a href="https://core.telegram.org/method/contacts.getSaved" />
///</summary>
[TlObject(0x82f1e39f)]
public sealed class RequestGetSaved : IRequest<TVector<MyTelegram.Schema.ISavedContact>>
{
    public uint ConstructorId => 0x82f1e39f;

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}

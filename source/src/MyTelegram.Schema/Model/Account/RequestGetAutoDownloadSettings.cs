﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.getAutoDownloadSettings" />
///</summary>
[TlObject(0x56da0b3f)]
public sealed class RequestGetAutoDownloadSettings : IRequest<MyTelegram.Schema.Account.IAutoDownloadSettings>
{
    public uint ConstructorId => 0x56da0b3f;

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

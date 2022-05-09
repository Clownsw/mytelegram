﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;

///<summary>
///See <a href="https://core.telegram.org/method/auth.signIn" />
///</summary>
[TlObject(0xbcd51581)]
public sealed class RequestSignIn : IRequest<MyTelegram.Schema.Auth.IAuthorization>
{
    public uint ConstructorId => 0xbcd51581;
    public string PhoneNumber { get; set; }
    public string PhoneCodeHash { get; set; }
    public string PhoneCode { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(PhoneNumber);
        bw.Serialize(PhoneCodeHash);
        bw.Serialize(PhoneCode);
    }

    public void Deserialize(BinaryReader br)
    {
        PhoneNumber = br.Deserialize<string>();
        PhoneCodeHash = br.Deserialize<string>();
        PhoneCode = br.Deserialize<string>();
    }
}

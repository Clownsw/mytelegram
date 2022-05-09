﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;


///<summary>
///See <a href="https://core.telegram.org/constructor/auth.loginTokenMigrateTo" />
///</summary>
[TlObject(0x68e9916)]
public class TLoginTokenMigrateTo : ILoginToken
{
    public uint ConstructorId => 0x68e9916;
    public int DcId { get; set; }
    public byte[] Token { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(DcId);
        bw.Serialize(Token);
    }

    public void Deserialize(BinaryReader br)
    {
        DcId = br.ReadInt32();
        Token = br.Deserialize<byte[]>();
    }
}
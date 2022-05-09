﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputCheckPasswordSRP" />
///</summary>
[TlObject(0xd27ff082)]
public class TInputCheckPasswordSRP : IInputCheckPasswordSRP
{
    public uint ConstructorId => 0xd27ff082;
    public long SrpId { get; set; }
    public byte[] A { get; set; }
    public byte[] M1 { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(SrpId);
        bw.Serialize(A);
        bw.Serialize(M1);
    }

    public void Deserialize(BinaryReader br)
    {
        SrpId = br.ReadInt64();
        A = br.Deserialize<byte[]>();
        M1 = br.Deserialize<byte[]>();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMediaGame" />
///</summary>
[TlObject(0xd33f43f3)]
public class TInputMediaGame : IInputMedia
{
    public uint ConstructorId => 0xd33f43f3;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputGame" />
    ///</summary>
    public MyTelegram.Schema.IInputGame Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Id.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.Deserialize<MyTelegram.Schema.IInputGame>();
    }
}
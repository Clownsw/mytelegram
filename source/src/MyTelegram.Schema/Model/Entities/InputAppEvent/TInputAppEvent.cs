﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputAppEvent" />
///</summary>
[TlObject(0x1d1b1245)]
public class TInputAppEvent : IInputAppEvent
{
    public uint ConstructorId => 0x1d1b1245;
    public double Time { get; set; }
    public string Type { get; set; }
    public long Peer { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/JSONValue" />
    ///</summary>
    public MyTelegram.Schema.IJSONValue Data { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Time);
        bw.Serialize(Type);
        bw.Write(Peer);
        Data.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Time = br.ReadDouble();
        Type = br.Deserialize<string>();
        Peer = br.ReadInt64();
        Data = br.Deserialize<MyTelegram.Schema.IJSONValue>();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
///See <a href="https://core.telegram.org/method/channels.editLocation" />
///</summary>
[TlObject(0x58e63f6d)]
public sealed class RequestEditLocation : IRequest<IBool>
{
    public uint ConstructorId => 0x58e63f6d;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputGeoPoint" />
    ///</summary>
    public MyTelegram.Schema.IInputGeoPoint GeoPoint { get; set; }
    public string Address { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Channel.Serialize(bw);
        GeoPoint.Serialize(bw);
        bw.Serialize(Address);
    }

    public void Deserialize(BinaryReader br)
    {
        Channel = br.Deserialize<MyTelegram.Schema.IInputChannel>();
        GeoPoint = br.Deserialize<MyTelegram.Schema.IInputGeoPoint>();
        Address = br.Deserialize<string>();
    }
}

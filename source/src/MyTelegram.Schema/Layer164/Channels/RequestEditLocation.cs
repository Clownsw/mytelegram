﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Edit location of geogroup
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 CHAT_NOT_MODIFIED No changes were made to chat information because the new information you passed is identical to the current information.
/// 400 MEGAGROUP_REQUIRED You can only use this method on a supergroup.
/// See <a href="https://corefork.telegram.org/method/channels.editLocation" />
///</summary>
[TlObject(0x58e63f6d)]
public sealed class RequestEditLocation : IRequest<IBool>
{
    public uint ConstructorId => 0x58e63f6d;
    ///<summary>
    /// <a href="https://corefork.telegram.org/api/channel">Geogroup</a>
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    /// New geolocation
    /// See <a href="https://corefork.telegram.org/type/InputGeoPoint" />
    ///</summary>
    public MyTelegram.Schema.IInputGeoPoint GeoPoint { get; set; }

    ///<summary>
    /// Address string
    ///</summary>
    public string Address { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Channel);
        writer.Write(GeoPoint);
        writer.Write(Address);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
        GeoPoint = reader.Read<MyTelegram.Schema.IInputGeoPoint>();
        Address = reader.ReadString();
    }
}

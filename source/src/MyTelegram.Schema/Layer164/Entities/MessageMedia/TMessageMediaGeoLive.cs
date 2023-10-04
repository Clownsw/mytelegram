﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Indicates a <a href="https://corefork.telegram.org/api/live-location">live geolocation</a>
/// See <a href="https://corefork.telegram.org/constructor/messageMediaGeoLive" />
///</summary>
[TlObject(0xb940c666)]
public sealed class TMessageMediaGeoLive : IMessageMedia
{
    public uint ConstructorId => 0xb940c666;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Geolocation
    /// See <a href="https://corefork.telegram.org/type/GeoPoint" />
    ///</summary>
    public MyTelegram.Schema.IGeoPoint Geo { get; set; }

    ///<summary>
    /// For <a href="https://corefork.telegram.org/api/live-location">live locations</a>, a direction in which the location moves, in degrees; 1-360
    ///</summary>
    public int? Heading { get; set; }

    ///<summary>
    /// Validity period of provided geolocation
    ///</summary>
    public int Period { get; set; }

    ///<summary>
    /// For <a href="https://corefork.telegram.org/api/live-location">live locations</a>, a maximum distance to another chat member for proximity alerts, in meters (0-100000).
    ///</summary>
    public int? ProximityNotificationRadius { get; set; }

    public void ComputeFlag()
    {
        if (/*Heading != 0 && */Heading.HasValue) { Flags[0] = true; }
        if (/*ProximityNotificationRadius != 0 && */ProximityNotificationRadius.HasValue) { Flags[1] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Geo);
        if (Flags[0]) { writer.Write(Heading.Value); }
        writer.Write(Period);
        if (Flags[1]) { writer.Write(ProximityNotificationRadius.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Geo = reader.Read<MyTelegram.Schema.IGeoPoint>();
        if (Flags[0]) { Heading = reader.ReadInt32(); }
        Period = reader.ReadInt32();
        if (Flags[1]) { ProximityNotificationRadius = reader.ReadInt32(); }
    }
}
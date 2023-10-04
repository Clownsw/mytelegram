﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A user of the chat is now in proximity of another user
/// See <a href="https://corefork.telegram.org/constructor/messageActionGeoProximityReached" />
///</summary>
[TlObject(0x98e0d697)]
public sealed class TMessageActionGeoProximityReached : IMessageAction
{
    public uint ConstructorId => 0x98e0d697;
    ///<summary>
    /// The user or chat that is now in proximity of <code>to_id</code>
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer FromId { get; set; }

    ///<summary>
    /// The user or chat that subscribed to <a href="https://corefork.telegram.org/api/live-location#proximity-alert">live geolocation proximity alerts</a>
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer ToId { get; set; }

    ///<summary>
    /// Distance, in meters (0-100000)
    ///</summary>
    public int Distance { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(FromId);
        writer.Write(ToId);
        writer.Write(Distance);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        FromId = reader.Read<MyTelegram.Schema.IPeer>();
        ToId = reader.Read<MyTelegram.Schema.IPeer>();
        Distance = reader.ReadInt32();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Create a <a href="https://corefork.telegram.org/api/channel">supergroup/channel</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNELS_ADMIN_LOCATED_TOO_MUCH The user has reached the limit of public geogroups.
/// 400 CHANNELS_TOO_MUCH You have joined too many channels/supergroups.
/// 500 CHANNEL_ID_GENERATE_FAILED &nbsp;
/// 400 CHAT_ABOUT_TOO_LONG Chat about too long.
/// 400 CHAT_TITLE_EMPTY No chat title provided.
/// 400 TTL_PERIOD_INVALID The specified TTL period is invalid.
/// 406 USER_RESTRICTED You're spamreported, you can't create channels or chats.
/// See <a href="https://corefork.telegram.org/method/channels.createChannel" />
///</summary>
[TlObject(0x91006707)]
public sealed class RequestCreateChannel : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x91006707;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to create a <a href="https://corefork.telegram.org/api/channel">channel</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Broadcast { get; set; }

    ///<summary>
    /// Whether to create a <a href="https://corefork.telegram.org/api/channel">supergroup</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Megagroup { get; set; }

    ///<summary>
    /// Whether the supergroup is being created to import messages from a foreign chat service using <a href="https://corefork.telegram.org/method/messages.initHistoryImport">messages.initHistoryImport</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ForImport { get; set; }

    ///<summary>
    /// Whether to create a <a href="https://corefork.telegram.org/api/forum">forum</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Forum { get; set; }

    ///<summary>
    /// Channel title
    ///</summary>
    public string Title { get; set; }

    ///<summary>
    /// Channel description
    ///</summary>
    public string About { get; set; }

    ///<summary>
    /// Geogroup location
    /// See <a href="https://corefork.telegram.org/type/InputGeoPoint" />
    ///</summary>
    public MyTelegram.Schema.IInputGeoPoint? GeoPoint { get; set; }

    ///<summary>
    /// Geogroup address
    ///</summary>
    public string? Address { get; set; }

    ///<summary>
    /// Time-to-live of all messages that will be sent in the supergroup: once message.date+message.ttl_period === time(), the message will be deleted on the server, and must be deleted locally as well. You can use <a href="https://corefork.telegram.org/method/messages.setDefaultHistoryTTL">messages.setDefaultHistoryTTL</a> to edit this value later.
    ///</summary>
    public int? TtlPeriod { get; set; }

    public void ComputeFlag()
    {
        if (Broadcast) { Flags[0] = true; }
        if (Megagroup) { Flags[1] = true; }
        if (ForImport) { Flags[3] = true; }
        if (Forum) { Flags[5] = true; }
        if (GeoPoint != null) { Flags[2] = true; }
        if (Address != null) { Flags[2] = true; }
        if (/*TtlPeriod != 0 && */TtlPeriod.HasValue) { Flags[4] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Title);
        writer.Write(About);
        if (Flags[2]) { writer.Write(GeoPoint); }
        if (Flags[2]) { writer.Write(Address); }
        if (Flags[4]) { writer.Write(TtlPeriod.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Broadcast = true; }
        if (Flags[1]) { Megagroup = true; }
        if (Flags[3]) { ForImport = true; }
        if (Flags[5]) { Forum = true; }
        Title = reader.ReadString();
        About = reader.ReadString();
        if (Flags[2]) { GeoPoint = reader.Read<MyTelegram.Schema.IInputGeoPoint>(); }
        if (Flags[2]) { Address = reader.ReadString(); }
        if (Flags[4]) { TtlPeriod = reader.ReadInt32(); }
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
/// Get most used peers
/// <para>Possible errors</para>
/// Code Type Description
/// 400 TYPES_EMPTY No top peer type was provided.
/// See <a href="https://corefork.telegram.org/method/contacts.getTopPeers" />
///</summary>
[TlObject(0x973478b6)]
public sealed class RequestGetTopPeers : IRequest<MyTelegram.Schema.Contacts.ITopPeers>
{
    public uint ConstructorId => 0x973478b6;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Users we've chatted most frequently with
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Correspondents { get; set; }

    ///<summary>
    /// Most used bots
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool BotsPm { get; set; }

    ///<summary>
    /// Most used inline bots
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool BotsInline { get; set; }

    ///<summary>
    /// Most frequently called users
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool PhoneCalls { get; set; }

    ///<summary>
    /// Users to which the users often forwards messages to
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ForwardUsers { get; set; }

    ///<summary>
    /// Chats to which the users often forwards messages to
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ForwardChats { get; set; }

    ///<summary>
    /// Often-opened groups and supergroups
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Groups { get; set; }

    ///<summary>
    /// Most frequently visited channels
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Channels { get; set; }

    ///<summary>
    /// Offset for <a href="https://corefork.telegram.org/api/offsets">pagination</a>
    ///</summary>
    public int Offset { get; set; }

    ///<summary>
    /// Maximum number of results to return, <a href="https://corefork.telegram.org/api/offsets">see pagination</a>
    ///</summary>
    public int Limit { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash for pagination, for more info click here</a>
    ///</summary>
    public long Hash { get; set; }

    public void ComputeFlag()
    {
        if (Correspondents) { Flags[0] = true; }
        if (BotsPm) { Flags[1] = true; }
        if (BotsInline) { Flags[2] = true; }
        if (PhoneCalls) { Flags[3] = true; }
        if (ForwardUsers) { Flags[4] = true; }
        if (ForwardChats) { Flags[5] = true; }
        if (Groups) { Flags[10] = true; }
        if (Channels) { Flags[15] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Offset);
        writer.Write(Limit);
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Correspondents = true; }
        if (Flags[1]) { BotsPm = true; }
        if (Flags[2]) { BotsInline = true; }
        if (Flags[3]) { PhoneCalls = true; }
        if (Flags[4]) { ForwardUsers = true; }
        if (Flags[5]) { ForwardChats = true; }
        if (Flags[10]) { Groups = true; }
        if (Flags[15]) { Channels = true; }
        Offset = reader.ReadInt32();
        Limit = reader.ReadInt32();
        Hash = reader.ReadInt64();
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Returns found messages
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 400 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 403 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 CHAT_ID_INVALID The provided chat id is invalid.
/// 400 FROM_PEER_INVALID The specified from_id is invalid.
/// 400 INPUT_FILTER_INVALID The specified filter is invalid.
/// 400 INPUT_USER_DEACTIVATED The specified user was deleted.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// 400 PEER_ID_NOT_SUPPORTED The provided peer ID is not supported.
/// 400 SEARCH_QUERY_EMPTY The search query is empty.
/// 400 USER_ID_INVALID The provided user ID is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.search" />
///</summary>
[TlObject(0xa0fda762)]
public sealed class RequestSearch : IRequest<MyTelegram.Schema.Messages.IMessages>
{
    public uint ConstructorId => 0xa0fda762;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// User or chat, histories with which are searched, or <a href="https://corefork.telegram.org/constructor/inputPeerEmpty">(inputPeerEmpty)</a> constructor for global search
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Text search request
    ///</summary>
    public string Q { get; set; }

    ///<summary>
    /// Only return messages sent by the specified user ID
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? FromId { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/threads">Thread ID</a>
    ///</summary>
    public int? TopMsgId { get; set; }

    ///<summary>
    /// Filter to return only specified message types
    /// See <a href="https://corefork.telegram.org/type/MessagesFilter" />
    ///</summary>
    public MyTelegram.Schema.IMessagesFilter Filter { get; set; }

    ///<summary>
    /// If a positive value was transferred, only messages with a sending date bigger than the transferred one will be returned
    ///</summary>
    public int MinDate { get; set; }

    ///<summary>
    /// If a positive value was transferred, only messages with a sending date smaller than the transferred one will be returned
    ///</summary>
    public int MaxDate { get; set; }

    ///<summary>
    /// Only return messages starting from the specified message ID
    ///</summary>
    public int OffsetId { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets">Additional offset</a>
    ///</summary>
    public int AddOffset { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets">Number of results to return</a>
    ///</summary>
    public int Limit { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets">Maximum message ID to return</a>
    ///</summary>
    public int MaxId { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets">Minimum message ID to return</a>
    ///</summary>
    public int MinId { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets">Hash</a>
    ///</summary>
    public long Hash { get; set; }

    public void ComputeFlag()
    {
        if (FromId != null) { Flags[0] = true; }
        if (/*TopMsgId != 0 && */TopMsgId.HasValue) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(Q);
        if (Flags[0]) { writer.Write(FromId); }
        if (Flags[1]) { writer.Write(TopMsgId.Value); }
        writer.Write(Filter);
        writer.Write(MinDate);
        writer.Write(MaxDate);
        writer.Write(OffsetId);
        writer.Write(AddOffset);
        writer.Write(Limit);
        writer.Write(MaxId);
        writer.Write(MinId);
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Q = reader.ReadString();
        if (Flags[0]) { FromId = reader.Read<MyTelegram.Schema.IInputPeer>(); }
        if (Flags[1]) { TopMsgId = reader.ReadInt32(); }
        Filter = reader.Read<MyTelegram.Schema.IMessagesFilter>();
        MinDate = reader.ReadInt32();
        MaxDate = reader.ReadInt32();
        OffsetId = reader.ReadInt32();
        AddOffset = reader.ReadInt32();
        Limit = reader.ReadInt32();
        MaxId = reader.ReadInt32();
        MinId = reader.ReadInt32();
        Hash = reader.ReadInt64();
    }
}

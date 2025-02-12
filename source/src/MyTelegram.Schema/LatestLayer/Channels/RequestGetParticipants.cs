﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Get the participants of a <a href="https://corefork.telegram.org/api/channel">supergroup/channel</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 406 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 403 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// See <a href="https://corefork.telegram.org/method/channels.getParticipants" />
///</summary>
[TlObject(0x77ced9d0)]
public sealed class RequestGetParticipants : IRequest<MyTelegram.Schema.Channels.IChannelParticipants>
{
    public uint ConstructorId => 0x77ced9d0;
    ///<summary>
    /// Channel
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    /// Which participant types to fetch
    /// See <a href="https://corefork.telegram.org/type/ChannelParticipantsFilter" />
    ///</summary>
    public MyTelegram.Schema.IChannelParticipantsFilter Filter { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets">Offset</a>
    ///</summary>
    public int Offset { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets">Limit</a>
    ///</summary>
    public int Limit { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets">Hash</a>
    ///</summary>
    public long Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Channel);
        writer.Write(Filter);
        writer.Write(Offset);
        writer.Write(Limit);
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
        Filter = reader.Read<MyTelegram.Schema.IChannelParticipantsFilter>();
        Offset = reader.ReadInt32();
        Limit = reader.ReadInt32();
        Hash = reader.ReadInt64();
    }
}

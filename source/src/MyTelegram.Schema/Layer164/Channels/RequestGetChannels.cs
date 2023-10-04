﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Get info about <a href="https://corefork.telegram.org/api/channel">channels/supergroups</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 406 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// 400 USER_BANNED_IN_CHANNEL You're banned from sending messages in supergroups/channels.
/// See <a href="https://corefork.telegram.org/method/channels.getChannels" />
///</summary>
[TlObject(0xa7f6bbb)]
public sealed class RequestGetChannels : IRequest<MyTelegram.Schema.Messages.IChats>
{
    public uint ConstructorId => 0xa7f6bbb;
    ///<summary>
    /// IDs of channels/supergroups to get info about
    ///</summary>
    public TVector<MyTelegram.Schema.IInputChannel> Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.Read<TVector<MyTelegram.Schema.IInputChannel>>();
    }
}

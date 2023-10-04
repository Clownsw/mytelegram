﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Get and increase the view counter of a message sent or forwarded from a <a href="https://corefork.telegram.org/api/channel">channel</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 406 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 400 CHAT_ID_INVALID The provided chat id is invalid.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.getMessagesViews" />
///</summary>
[TlObject(0x5784d3e1)]
public sealed class RequestGetMessagesViews : IRequest<MyTelegram.Schema.Messages.IMessageViews>
{
    public uint ConstructorId => 0x5784d3e1;
    ///<summary>
    /// Peer where the message was found
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// ID of message
    ///</summary>
    public TVector<int> Id { get; set; }

    ///<summary>
    /// Whether to mark the message as viewed and increment the view counter
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool Increment { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Id);
        writer.Write(Increment);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Id = reader.Read<TVector<int>>();
        Increment = reader.Read();
    }
}

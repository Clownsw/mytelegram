﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Mark a specific sponsored message as read
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 400 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// See <a href="https://corefork.telegram.org/method/channels.viewSponsoredMessage" />
///</summary>
[TlObject(0xbeaedb94)]
public sealed class RequestViewSponsoredMessage : IRequest<IBool>
{
    public uint ConstructorId => 0xbeaedb94;
    ///<summary>
    /// Peer
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    /// Message ID
    ///</summary>
    public byte[] RandomId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Channel);
        writer.Write(RandomId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
        RandomId = reader.ReadBytes();
    }
}

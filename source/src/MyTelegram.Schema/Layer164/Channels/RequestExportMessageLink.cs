﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Get link and embed info of a message in a <a href="https://corefork.telegram.org/api/channel">channel/supergroup</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 400 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 400 MESSAGE_ID_INVALID The provided message id is invalid.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// See <a href="https://corefork.telegram.org/method/channels.exportMessageLink" />
///</summary>
[TlObject(0xe63fadeb)]
public sealed class RequestExportMessageLink : IRequest<MyTelegram.Schema.IExportedMessageLink>
{
    public uint ConstructorId => 0xe63fadeb;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to include other grouped media (for albums)
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Grouped { get; set; }

    ///<summary>
    /// Whether to also include a thread ID, if available, inside of the link
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Thread { get; set; }

    ///<summary>
    /// Channel
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    /// Message ID
    ///</summary>
    public int Id { get; set; }

    public void ComputeFlag()
    {
        if (Grouped) { Flags[0] = true; }
        if (Thread) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Channel);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Grouped = true; }
        if (Flags[1]) { Thread = true; }
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
        Id = reader.ReadInt32();
    }
}

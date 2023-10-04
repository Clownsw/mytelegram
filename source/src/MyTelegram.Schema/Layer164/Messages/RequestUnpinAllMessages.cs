﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// <a href="https://corefork.telegram.org/api/pin">Unpin</a> all pinned messages
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 CHAT_NOT_MODIFIED No changes were made to chat information because the new information you passed is identical to the current information.
/// See <a href="https://corefork.telegram.org/method/messages.unpinAllMessages" />
///</summary>
[TlObject(0xee22b9a8)]
public sealed class RequestUnpinAllMessages : IRequest<MyTelegram.Schema.Messages.IAffectedHistory>
{
    public uint ConstructorId => 0xee22b9a8;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Chat where to unpin
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/forum#forum-topics">Forum topic</a> where to unpin
    ///</summary>
    public int? TopMsgId { get; set; }

    public void ComputeFlag()
    {
        if (/*TopMsgId != 0 && */TopMsgId.HasValue) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        if (Flags[0]) { writer.Write(TopMsgId.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        if (Flags[0]) { TopMsgId = reader.ReadInt32(); }
    }
}

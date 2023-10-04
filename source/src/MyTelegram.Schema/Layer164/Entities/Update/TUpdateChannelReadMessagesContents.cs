﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The specified <a href="https://corefork.telegram.org/api/channel">channel/supergroup</a> messages were read
/// See <a href="https://corefork.telegram.org/constructor/updateChannelReadMessagesContents" />
///</summary>
[TlObject(0xea29055d)]
public sealed class TUpdateChannelReadMessagesContents : IUpdate
{
    public uint ConstructorId => 0xea29055d;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/channel">Channel/supergroup</a> ID
    ///</summary>
    public long ChannelId { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/forum#forum-topics">Forum topic ID</a>.
    ///</summary>
    public int? TopMsgId { get; set; }

    ///<summary>
    /// IDs of messages that were read
    ///</summary>
    public TVector<int> Messages { get; set; }

    public void ComputeFlag()
    {
        if (/*TopMsgId != 0 && */TopMsgId.HasValue) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(ChannelId);
        if (Flags[0]) { writer.Write(TopMsgId.Value); }
        writer.Write(Messages);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        ChannelId = reader.ReadInt64();
        if (Flags[0]) { TopMsgId = reader.ReadInt32(); }
        Messages = reader.Read<TVector<int>>();
    }
}
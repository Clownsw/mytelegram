﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Reorder pinned forum topics
/// See <a href="https://corefork.telegram.org/method/channels.reorderPinnedForumTopics" />
///</summary>
[TlObject(0x2950a18f)]
public sealed class RequestReorderPinnedForumTopics : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x2950a18f;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// If set, topics pinned server-side but not present in the order field will be unpinned.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Force { get; set; }

    ///<summary>
    /// Supergroup ID
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/forum">Topic IDs »</a>
    ///</summary>
    public TVector<int> Order { get; set; }

    public void ComputeFlag()
    {
        if (Force) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Channel);
        writer.Write(Order);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Force = true; }
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
        Order = reader.Read<TVector<int>>();
    }
}

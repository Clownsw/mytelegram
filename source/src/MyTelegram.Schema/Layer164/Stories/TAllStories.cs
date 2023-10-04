﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stories;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/stories.allStories" />
///</summary>
[TlObject(0x6efc5e81)]
public sealed class TAllStories : IAllStories
{
    public uint ConstructorId => 0x6efc5e81;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool HasMore { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Count { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public string State { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IPeerStories> PeerStories { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/StoriesStealthMode" />
    ///</summary>
    public MyTelegram.Schema.IStoriesStealthMode StealthMode { get; set; }

    public void ComputeFlag()
    {
        if (HasMore) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Count);
        writer.Write(State);
        writer.Write(PeerStories);
        writer.Write(Chats);
        writer.Write(Users);
        writer.Write(StealthMode);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { HasMore = true; }
        Count = reader.ReadInt32();
        State = reader.ReadString();
        PeerStories = reader.Read<TVector<MyTelegram.Schema.IPeerStories>>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
        StealthMode = reader.Read<MyTelegram.Schema.IStoriesStealthMode>();
    }
}
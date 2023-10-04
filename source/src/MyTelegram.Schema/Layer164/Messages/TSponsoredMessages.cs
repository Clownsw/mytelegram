﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// A set of sponsored messages associated to a channel
/// See <a href="https://corefork.telegram.org/constructor/messages.sponsoredMessages" />
///</summary>
[TlObject(0xc9ee1d87)]
public sealed class TSponsoredMessages : ISponsoredMessages
{
    public uint ConstructorId => 0xc9ee1d87;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// If set, specifies the minimum number of messages between shown sponsored messages; otherwise, only one sponsored message must be shown after all ordinary messages.
    ///</summary>
    public int? PostsBetween { get; set; }

    ///<summary>
    /// Sponsored messages
    ///</summary>
    public TVector<MyTelegram.Schema.ISponsoredMessage> Messages { get; set; }

    ///<summary>
    /// Chats mentioned in the sponsored messages
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// Users mentioned in the sponsored messages
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {
        if (/*PostsBetween != 0 && */PostsBetween.HasValue) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[0]) { writer.Write(PostsBetween.Value); }
        writer.Write(Messages);
        writer.Write(Chats);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { PostsBetween = reader.ReadInt32(); }
        Messages = reader.Read<TVector<MyTelegram.Schema.ISponsoredMessage>>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}
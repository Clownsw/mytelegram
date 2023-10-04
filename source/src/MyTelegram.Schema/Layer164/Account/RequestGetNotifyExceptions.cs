﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// Returns list of chats with non-default notification settings
/// See <a href="https://corefork.telegram.org/method/account.getNotifyExceptions" />
///</summary>
[TlObject(0x53577479)]
public sealed class RequestGetNotifyExceptions : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x53577479;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// If true, chats with non-default sound will also be returned
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool CompareSound { get; set; }
    public bool CompareStories { get; set; }

    ///<summary>
    /// If specified, only chats of the specified category will be returned
    /// See <a href="https://corefork.telegram.org/type/InputNotifyPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputNotifyPeer? Peer { get; set; }

    public void ComputeFlag()
    {
        if (CompareSound) { Flags[1] = true; }
        if (CompareStories) { Flags[2] = true; }
        if (Peer != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[0]) { writer.Write(Peer); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { CompareSound = true; }
        if (Flags[2]) { CompareStories = true; }
        if (Flags[0]) { Peer = reader.Read<MyTelegram.Schema.IInputNotifyPeer>(); }
    }
}

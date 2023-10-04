﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
/// MTProxy/Public Service Announcement information
/// See <a href="https://corefork.telegram.org/constructor/help.promoData" />
///</summary>
[TlObject(0x8c39793f)]
public sealed class TPromoData : IPromoData
{
    public uint ConstructorId => 0x8c39793f;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// MTProxy-related channel
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Proxy { get; set; }

    ///<summary>
    /// Expiry of PSA/MTProxy info
    ///</summary>
    public int Expires { get; set; }

    ///<summary>
    /// MTProxy/PSA peer
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    /// Chat info
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// User info
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    ///<summary>
    /// PSA type
    ///</summary>
    public string? PsaType { get; set; }

    ///<summary>
    /// PSA message
    ///</summary>
    public string? PsaMessage { get; set; }

    public void ComputeFlag()
    {
        if (Proxy) { Flags[0] = true; }
        if (PsaType != null) { Flags[1] = true; }
        if (PsaMessage != null) { Flags[2] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Expires);
        writer.Write(Peer);
        writer.Write(Chats);
        writer.Write(Users);
        if (Flags[1]) { writer.Write(PsaType); }
        if (Flags[2]) { writer.Write(PsaMessage); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Proxy = true; }
        Expires = reader.ReadInt32();
        Peer = reader.Read<MyTelegram.Schema.IPeer>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
        if (Flags[1]) { PsaType = reader.ReadString(); }
        if (Flags[2]) { PsaMessage = reader.ReadString(); }
    }
}
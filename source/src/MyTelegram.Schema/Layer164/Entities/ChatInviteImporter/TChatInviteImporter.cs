﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// When and which user joined the chat using a chat invite
/// See <a href="https://corefork.telegram.org/constructor/chatInviteImporter" />
///</summary>
[TlObject(0x8c5adfd9)]
public sealed class TChatInviteImporter : IChatInviteImporter
{
    public uint ConstructorId => 0x8c5adfd9;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether this user currently has a pending <a href="https://corefork.telegram.org/api/invites#join-requests">join request »</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Requested { get; set; }

    ///<summary>
    /// The participant joined by importing a <a href="https://corefork.telegram.org/api/links#chat-folder-links">chat folder deep link »</a>.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ViaChatlist { get; set; }

    ///<summary>
    /// The user
    ///</summary>
    public long UserId { get; set; }

    ///<summary>
    /// When did the user join
    ///</summary>
    public int Date { get; set; }

    ///<summary>
    /// For users with pending requests, contains bio of the user that requested to join
    ///</summary>
    public string? About { get; set; }

    ///<summary>
    /// The administrator that approved the <a href="https://corefork.telegram.org/api/invites#join-requests">join request »</a> of the user
    ///</summary>
    public long? ApprovedBy { get; set; }

    public void ComputeFlag()
    {
        if (Requested) { Flags[0] = true; }
        if (ViaChatlist) { Flags[3] = true; }
        if (About != null) { Flags[2] = true; }
        if (/*ApprovedBy != 0 &&*/ ApprovedBy.HasValue) { Flags[1] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(UserId);
        writer.Write(Date);
        if (Flags[2]) { writer.Write(About); }
        if (Flags[1]) { writer.Write(ApprovedBy.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Requested = true; }
        if (Flags[3]) { ViaChatlist = true; }
        UserId = reader.ReadInt64();
        Date = reader.ReadInt32();
        if (Flags[2]) { About = reader.ReadString(); }
        if (Flags[1]) { ApprovedBy = reader.ReadInt64(); }
    }
}
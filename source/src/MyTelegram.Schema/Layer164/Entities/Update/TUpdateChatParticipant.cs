﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A user has joined or left a specific chat
/// See <a href="https://corefork.telegram.org/constructor/updateChatParticipant" />
///</summary>
[TlObject(0xd087663a)]
public sealed class TUpdateChatParticipant : IUpdate
{
    public uint ConstructorId => 0xd087663a;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/channel">Chat</a> ID
    ///</summary>
    public long ChatId { get; set; }

    ///<summary>
    /// When did this event occur
    ///</summary>
    public int Date { get; set; }

    ///<summary>
    /// User that triggered the change (inviter, admin that kicked the user, or the even the <strong>user_id</strong> itself)
    ///</summary>
    public long ActorId { get; set; }

    ///<summary>
    /// User that was affected by the change
    ///</summary>
    public long UserId { get; set; }

    ///<summary>
    /// Previous participant info (empty if this participant just joined)
    /// See <a href="https://corefork.telegram.org/type/ChatParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChatParticipant? PrevParticipant { get; set; }

    ///<summary>
    /// New participant info (empty if this participant just left)
    /// See <a href="https://corefork.telegram.org/type/ChatParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChatParticipant? NewParticipant { get; set; }

    ///<summary>
    /// The invite that was used to join the group
    /// See <a href="https://corefork.telegram.org/type/ExportedChatInvite" />
    ///</summary>
    public MyTelegram.Schema.IExportedChatInvite? Invite { get; set; }

    ///<summary>
    /// New <strong>qts</strong> value, see <a href="https://corefork.telegram.org/api/updates">updates »</a> for more info.
    ///</summary>
    public int Qts { get; set; }

    public void ComputeFlag()
    {
        if (PrevParticipant != null) { Flags[0] = true; }
        if (NewParticipant != null) { Flags[1] = true; }
        if (Invite != null) { Flags[2] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(ChatId);
        writer.Write(Date);
        writer.Write(ActorId);
        writer.Write(UserId);
        if (Flags[0]) { writer.Write(PrevParticipant); }
        if (Flags[1]) { writer.Write(NewParticipant); }
        if (Flags[2]) { writer.Write(Invite); }
        writer.Write(Qts);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        ChatId = reader.ReadInt64();
        Date = reader.ReadInt32();
        ActorId = reader.ReadInt64();
        UserId = reader.ReadInt64();
        if (Flags[0]) { PrevParticipant = reader.Read<MyTelegram.Schema.IChatParticipant>(); }
        if (Flags[1]) { NewParticipant = reader.Read<MyTelegram.Schema.IChatParticipant>(); }
        if (Flags[2]) { Invite = reader.Read<MyTelegram.Schema.IExportedChatInvite>(); }
        Qts = reader.ReadInt32();
    }
}
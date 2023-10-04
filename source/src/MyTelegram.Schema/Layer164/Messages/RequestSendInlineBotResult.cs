﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Send a result obtained using <a href="https://corefork.telegram.org/method/messages.getInlineBotResults">messages.getInlineBotResults</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 400 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 403 CHAT_GUEST_SEND_FORBIDDEN You join the discussion group before commenting, see <a href="https://corefork.telegram.org/api/discussion#requiring-users-to-join-the-group">here »</a> for more info.
/// 400 CHAT_RESTRICTED You can't send messages in this chat, you were restricted.
/// 403 CHAT_SEND_AUDIOS_FORBIDDEN You can't send audio messages in this chat.
/// 403 CHAT_SEND_GAME_FORBIDDEN You can't send a game to this chat.
/// 403 CHAT_SEND_GIFS_FORBIDDEN You can't send gifs in this chat.
/// 403 CHAT_SEND_INLINE_FORBIDDEN You can't send inline messages in this group.
/// 403 CHAT_SEND_MEDIA_FORBIDDEN You can't send media in this chat.
/// 403 CHAT_SEND_PHOTOS_FORBIDDEN You can't send photos in this chat.
/// 403 CHAT_SEND_STICKERS_FORBIDDEN You can't send stickers in this chat.
/// 403 CHAT_SEND_VOICES_FORBIDDEN You can't send voice recordings in this chat.
/// 403 CHAT_WRITE_FORBIDDEN You can't write in this chat.
/// 400 ENTITY_BOUNDS_INVALID A specified <a href="https://corefork.telegram.org/api/entities#entity-length">entity offset or length</a> is invalid, see <a href="https://corefork.telegram.org/api/entities#entity-length">here »</a> for info on how to properly compute the entity offset/length.
/// 400 INLINE_RESULT_EXPIRED The inline query expired.
/// 400 INPUT_USER_DEACTIVATED The specified user was deleted.
/// 400 MEDIA_EMPTY The provided media object is invalid.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// 400 QUERY_ID_EMPTY The query ID is empty.
/// 500 RANDOM_ID_DUPLICATE You provided a random ID that was already used.
/// 400 RESULT_ID_EMPTY Result ID empty.
/// 400 SCHEDULE_DATE_TOO_LATE You can't schedule a message this far in the future.
/// 400 SCHEDULE_TOO_MUCH There are too many scheduled messages.
/// 420 SLOWMODE_WAIT_%d Slowmode is enabled in this chat: wait %d seconds before sending another message to this chat.
/// 400 TOPIC_DELETED The specified topic was deleted.
/// 400 USER_BANNED_IN_CHANNEL You're banned from sending messages in supergroups/channels.
/// 400 VOICE_MESSAGES_FORBIDDEN This user's privacy settings forbid you from sending voice messages.
/// 400 WEBPAGE_CURL_FAILED Failure while fetching the webpage with cURL.
/// 400 WEBPAGE_MEDIA_EMPTY Webpage media empty.
/// 400 YOU_BLOCKED_USER You blocked this user.
/// See <a href="https://corefork.telegram.org/method/messages.sendInlineBotResult" />
///</summary>
[TlObject(0xf7bc68ba)]
public sealed class RequestSendInlineBotResult : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xf7bc68ba;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to send the message silently (no notification will be triggered on the other client)
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Silent { get; set; }

    ///<summary>
    /// Whether to send the message in background
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Background { get; set; }

    ///<summary>
    /// Whether to clear the <a href="https://corefork.telegram.org/api/drafts">draft</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ClearDraft { get; set; }

    ///<summary>
    /// Whether to hide the <code>via @botname</code> in the resulting message (only for bot usernames encountered in the <a href="https://corefork.telegram.org/constructor/config">config</a>)
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool HideVia { get; set; }

    ///<summary>
    /// Destination
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public MyTelegram.Schema.IInputReplyTo? ReplyTo { get; set; }

    ///<summary>
    /// Random ID to avoid resending the same query
    ///</summary>
    public long RandomId { get; set; }

    ///<summary>
    /// Query ID from <a href="https://corefork.telegram.org/method/messages.getInlineBotResults">messages.getInlineBotResults</a>
    ///</summary>
    public long QueryId { get; set; }

    ///<summary>
    /// Result ID from <a href="https://corefork.telegram.org/method/messages.getInlineBotResults">messages.getInlineBotResults</a>
    ///</summary>
    public string Id { get; set; }

    ///<summary>
    /// Scheduled message date for scheduled messages
    ///</summary>
    public int? ScheduleDate { get; set; }

    ///<summary>
    /// Send this message as the specified peer
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? SendAs { get; set; }

    public void ComputeFlag()
    {
        if (Silent) { Flags[5] = true; }
        if (Background) { Flags[6] = true; }
        if (ClearDraft) { Flags[7] = true; }
        if (HideVia) { Flags[11] = true; }
        if (ReplyTo != null) { Flags[0] = true; }
        if (/*ScheduleDate != 0 && */ScheduleDate.HasValue) { Flags[10] = true; }
        if (SendAs != null) { Flags[13] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        if (Flags[0]) { writer.Write(ReplyTo); }
        writer.Write(RandomId);
        writer.Write(QueryId);
        writer.Write(Id);
        if (Flags[10]) { writer.Write(ScheduleDate.Value); }
        if (Flags[13]) { writer.Write(SendAs); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[5]) { Silent = true; }
        if (Flags[6]) { Background = true; }
        if (Flags[7]) { ClearDraft = true; }
        if (Flags[11]) { HideVia = true; }
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        if (Flags[0]) { ReplyTo = reader.Read<MyTelegram.Schema.IInputReplyTo>(); }
        RandomId = reader.ReadInt64();
        QueryId = reader.ReadInt64();
        Id = reader.ReadString();
        if (Flags[10]) { ScheduleDate = reader.ReadInt32(); }
        if (Flags[13]) { SendAs = reader.Read<MyTelegram.Schema.IInputPeer>(); }
    }
}

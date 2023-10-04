﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Send an <a href="https://corefork.telegram.org/api/files#albums-grouped-media">album or grouped media</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 CHAT_FORWARDS_RESTRICTED You can't forward messages from a protected chat.
/// 403 CHAT_SEND_MEDIA_FORBIDDEN You can't send media in this chat.
/// 403 CHAT_SEND_PHOTOS_FORBIDDEN You can't send photos in this chat.
/// 403 CHAT_SEND_VIDEOS_FORBIDDEN You can't send videos in this chat.
/// 403 CHAT_WRITE_FORBIDDEN You can't write in this chat.
/// 400 ENTITY_BOUNDS_INVALID A specified <a href="https://corefork.telegram.org/api/entities#entity-length">entity offset or length</a> is invalid, see <a href="https://corefork.telegram.org/api/entities#entity-length">here »</a> for info on how to properly compute the entity offset/length.
/// 400 MEDIA_CAPTION_TOO_LONG The caption is too long.
/// 400 MEDIA_EMPTY The provided media object is invalid.
/// 400 MEDIA_INVALID Media invalid.
/// 400 MULTI_MEDIA_TOO_LONG Too many media files for album.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// 500 RANDOM_ID_DUPLICATE You provided a random ID that was already used.
/// 400 RANDOM_ID_EMPTY Random ID empty.
/// 400 SCHEDULE_DATE_TOO_LATE You can't schedule a message this far in the future.
/// 400 SCHEDULE_TOO_MUCH There are too many scheduled messages.
/// 400 SEND_AS_PEER_INVALID You can't send messages as the specified peer.
/// 420 SLOWMODE_WAIT_%d Slowmode is enabled in this chat: wait %d seconds before sending another message to this chat.
/// 400 TOPIC_DELETED The specified topic was deleted.
/// 400 USER_BANNED_IN_CHANNEL You're banned from sending messages in supergroups/channels.
/// See <a href="https://corefork.telegram.org/method/messages.sendMultiMedia" />
///</summary>
[TlObject(0x456e8987)]
public sealed class RequestSendMultiMedia : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x456e8987;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to send the album silently (no notification triggered)
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Silent { get; set; }

    ///<summary>
    /// Send in background?
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Background { get; set; }

    ///<summary>
    /// Whether to clear <a href="https://corefork.telegram.org/api/drafts">drafts</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ClearDraft { get; set; }

    ///<summary>
    /// Only for bots, disallows forwarding and saving of the messages, even if the destination chat doesn't have <a href="https://telegram.org/blog/protected-content-delete-by-date-and-more">content protection</a> enabled
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Noforwards { get; set; }

    ///<summary>
    /// Whether to move used stickersets to top, <a href="https://corefork.telegram.org/api/stickers#recent-stickersets">see here for more info on this flag »</a>
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool UpdateStickersetsOrder { get; set; }

    ///<summary>
    /// The destination chat
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public MyTelegram.Schema.IInputReplyTo? ReplyTo { get; set; }

    ///<summary>
    /// The medias to send: note that they must be separately uploaded using <a href="https://corefork.telegram.org/method/messages.uploadMedia">messages.uploadMedia</a> first, using raw <code>inputMediaUploaded*</code> constructors is not supported.
    ///</summary>
    public TVector<MyTelegram.Schema.IInputSingleMedia> MultiMedia { get; set; }

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
        if (Noforwards) { Flags[14] = true; }
        if (UpdateStickersetsOrder) { Flags[15] = true; }
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
        writer.Write(MultiMedia);
        if (Flags[10]) { writer.Write(ScheduleDate.Value); }
        if (Flags[13]) { writer.Write(SendAs); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[5]) { Silent = true; }
        if (Flags[6]) { Background = true; }
        if (Flags[7]) { ClearDraft = true; }
        if (Flags[14]) { Noforwards = true; }
        if (Flags[15]) { UpdateStickersetsOrder = true; }
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        if (Flags[0]) { ReplyTo = reader.Read<MyTelegram.Schema.IInputReplyTo>(); }
        MultiMedia = reader.Read<TVector<MyTelegram.Schema.IInputSingleMedia>>();
        if (Flags[10]) { ScheduleDate = reader.ReadInt32(); }
        if (Flags[13]) { SendAs = reader.Read<MyTelegram.Schema.IInputPeer>(); }
    }
}

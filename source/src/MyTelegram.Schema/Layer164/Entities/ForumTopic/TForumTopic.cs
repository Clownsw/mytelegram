﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Represents a <a href="https://corefork.telegram.org/api/forum#forum-topics">forum topic</a>.
/// See <a href="https://corefork.telegram.org/constructor/forumTopic" />
///</summary>
[TlObject(0x71701da9)]
public sealed class TForumTopic : IForumTopic
{
    public uint ConstructorId => 0x71701da9;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the topic was created by the current user
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool My { get; set; }

    ///<summary>
    /// Whether the topic is closed (no messages can be sent to it)
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Closed { get; set; }

    ///<summary>
    /// Whether the topic is pinned
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Pinned { get; set; }

    ///<summary>
    /// Whether this constructor is a reduced version of the full topic information. <br>If set, only the <code>my</code>, <code>closed</code>, <code>id</code>, <code>date</code>, <code>title</code>, <code>icon_color</code>, <code>icon_emoji_id</code> and <code>from_id</code> parameters will contain valid information. <br>Reduced info is usually only returned in topic-related <a href="https://corefork.telegram.org/api/recent-actions">admin log events »</a> and in the <a href="https://corefork.telegram.org/constructor/messages.channelMessages">messages.channelMessages</a> constructor: if needed, full information can be fetched using <a href="https://corefork.telegram.org/method/channels.getForumTopicsByID">channels.getForumTopicsByID</a>.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Short { get; set; }

    ///<summary>
    /// Whether the topic is hidden (only valid for the "General" topic, <code>id=1</code>)
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Hidden { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/forum#forum-topics">Topic ID</a>
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// Topic creation date
    ///</summary>
    public int Date { get; set; }

    ///<summary>
    /// Topic title
    ///</summary>
    public string Title { get; set; }

    ///<summary>
    /// If no custom emoji icon is specified, specifies the color of the fallback topic icon (RGB), one of <code>0x6FB9F0</code>, <code>0xFFD67E</code>, <code>0xCB86DB</code>, <code>0x8EEE98</code>, <code>0xFF93B2</code>, or <code>0xFB6F5F</code>.
    ///</summary>
    public int IconColor { get; set; }

    ///<summary>
    /// ID of the <a href="https://corefork.telegram.org/api/custom-emoji">custom emoji</a> used as topic icon.
    ///</summary>
    public long? IconEmojiId { get; set; }

    ///<summary>
    /// ID of the last message that was sent to this topic
    ///</summary>
    public int TopMessage { get; set; }

    ///<summary>
    /// Position up to which all incoming messages are read.
    ///</summary>
    public int ReadInboxMaxId { get; set; }

    ///<summary>
    /// Position up to which all outgoing messages are read.
    ///</summary>
    public int ReadOutboxMaxId { get; set; }

    ///<summary>
    /// Number of unread messages
    ///</summary>
    public int UnreadCount { get; set; }

    ///<summary>
    /// Number of <a href="https://corefork.telegram.org/api/mentions">unread mentions</a>
    ///</summary>
    public int UnreadMentionsCount { get; set; }

    ///<summary>
    /// Number of unread reactions to messages you sent
    ///</summary>
    public int UnreadReactionsCount { get; set; }

    ///<summary>
    /// ID of the peer that created the topic
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer FromId { get; set; }

    ///<summary>
    /// Notification settings
    /// See <a href="https://corefork.telegram.org/type/PeerNotifySettings" />
    ///</summary>
    public MyTelegram.Schema.IPeerNotifySettings NotifySettings { get; set; }

    ///<summary>
    /// Message <a href="https://corefork.telegram.org/api/drafts">draft</a>
    /// See <a href="https://corefork.telegram.org/type/DraftMessage" />
    ///</summary>
    public MyTelegram.Schema.IDraftMessage? Draft { get; set; }

    public void ComputeFlag()
    {
        if (My) { Flags[1] = true; }
        if (Closed) { Flags[2] = true; }
        if (Pinned) { Flags[3] = true; }
        if (Short) { Flags[5] = true; }
        if (Hidden) { Flags[6] = true; }
        if (/*IconEmojiId != 0 &&*/ IconEmojiId.HasValue) { Flags[0] = true; }
        if (Draft != null) { Flags[4] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        writer.Write(Date);
        writer.Write(Title);
        writer.Write(IconColor);
        if (Flags[0]) { writer.Write(IconEmojiId.Value); }
        writer.Write(TopMessage);
        writer.Write(ReadInboxMaxId);
        writer.Write(ReadOutboxMaxId);
        writer.Write(UnreadCount);
        writer.Write(UnreadMentionsCount);
        writer.Write(UnreadReactionsCount);
        writer.Write(FromId);
        writer.Write(NotifySettings);
        if (Flags[4]) { writer.Write(Draft); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { My = true; }
        if (Flags[2]) { Closed = true; }
        if (Flags[3]) { Pinned = true; }
        if (Flags[5]) { Short = true; }
        if (Flags[6]) { Hidden = true; }
        Id = reader.ReadInt32();
        Date = reader.ReadInt32();
        Title = reader.ReadString();
        IconColor = reader.ReadInt32();
        if (Flags[0]) { IconEmojiId = reader.ReadInt64(); }
        TopMessage = reader.ReadInt32();
        ReadInboxMaxId = reader.ReadInt32();
        ReadOutboxMaxId = reader.ReadInt32();
        UnreadCount = reader.ReadInt32();
        UnreadMentionsCount = reader.ReadInt32();
        UnreadReactionsCount = reader.ReadInt32();
        FromId = reader.Read<MyTelegram.Schema.IPeer>();
        NotifySettings = reader.Read<MyTelegram.Schema.IPeerNotifySettings>();
        if (Flags[4]) { Draft = reader.Read<MyTelegram.Schema.IDraftMessage>(); }
    }
}
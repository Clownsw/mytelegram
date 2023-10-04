﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A <a href="https://core.telegram.org/api/sponsored-messages">sponsored message</a>.
/// See <a href="https://corefork.telegram.org/constructor/sponsoredMessage" />
///</summary>
[TlObject(0xdaafff6b)]
public sealed class TSponsoredMessage : ISponsoredMessage
{
    public uint ConstructorId => 0xdaafff6b;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the message needs to be labeled as "recommended" instead of "sponsored"
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Recommended { get; set; }

    ///<summary>
    /// Whether a profile photo bubble should be displayed for this message, like for messages sent in groups. The photo shown in the bubble is obtained either from the peer contained in <code>from_id</code>, or from <code>chat_invite</code>.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ShowPeerPhoto { get; set; }

    ///<summary>
    /// Message ID
    ///</summary>
    public byte[] RandomId { get; set; }

    ///<summary>
    /// ID of the sender of the message
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer? FromId { get; set; }

    ///<summary>
    /// Information about the chat invite hash specified in <code>chat_invite_hash</code>
    /// See <a href="https://corefork.telegram.org/type/ChatInvite" />
    ///</summary>
    public MyTelegram.Schema.IChatInvite? ChatInvite { get; set; }

    ///<summary>
    /// Chat invite
    ///</summary>
    public string? ChatInviteHash { get; set; }

    ///<summary>
    /// Optional link to a channel post if <code>from_id</code> points to a channel
    ///</summary>
    public int? ChannelPost { get; set; }

    ///<summary>
    /// Parameter for the bot start message if the sponsored chat is a chat with a bot.
    ///</summary>
    public string? StartParam { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/SponsoredWebPage" />
    ///</summary>
    public MyTelegram.Schema.ISponsoredWebPage? Webpage { get; set; }

    ///<summary>
    /// Sponsored message
    ///</summary>
    public string Message { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/entities">Message entities for styled text</a>
    ///</summary>
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }

    ///<summary>
    /// If set, contains additional information about the sponsor to be shown along with the message.
    ///</summary>
    public string? SponsorInfo { get; set; }

    ///<summary>
    /// If set, contains additional information about the sponsored message to be shown along with the message.
    ///</summary>
    public string? AdditionalInfo { get; set; }

    public void ComputeFlag()
    {
        if (Recommended) { Flags[5] = true; }
        if (ShowPeerPhoto) { Flags[6] = true; }
        if (FromId != null) { Flags[3] = true; }
        if (ChatInvite != null) { Flags[4] = true; }
        if (ChatInviteHash != null) { Flags[4] = true; }
        if (/*ChannelPost != 0 && */ChannelPost.HasValue) { Flags[2] = true; }
        if (StartParam != null) { Flags[0] = true; }
        if (Webpage != null) { Flags[9] = true; }
        if (Entities?.Count > 0) { Flags[1] = true; }
        if (SponsorInfo != null) { Flags[7] = true; }
        if (AdditionalInfo != null) { Flags[8] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(RandomId);
        if (Flags[3]) { writer.Write(FromId); }
        if (Flags[4]) { writer.Write(ChatInvite); }
        if (Flags[4]) { writer.Write(ChatInviteHash); }
        if (Flags[2]) { writer.Write(ChannelPost.Value); }
        if (Flags[0]) { writer.Write(StartParam); }
        if (Flags[9]) { writer.Write(Webpage); }
        writer.Write(Message);
        if (Flags[1]) { writer.Write(Entities); }
        if (Flags[7]) { writer.Write(SponsorInfo); }
        if (Flags[8]) { writer.Write(AdditionalInfo); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[5]) { Recommended = true; }
        if (Flags[6]) { ShowPeerPhoto = true; }
        RandomId = reader.ReadBytes();
        if (Flags[3]) { FromId = reader.Read<MyTelegram.Schema.IPeer>(); }
        if (Flags[4]) { ChatInvite = reader.Read<MyTelegram.Schema.IChatInvite>(); }
        if (Flags[4]) { ChatInviteHash = reader.ReadString(); }
        if (Flags[2]) { ChannelPost = reader.ReadInt32(); }
        if (Flags[0]) { StartParam = reader.ReadString(); }
        if (Flags[9]) { Webpage = reader.Read<MyTelegram.Schema.ISponsoredWebPage>(); }
        Message = reader.ReadString();
        if (Flags[1]) { Entities = reader.Read<TVector<MyTelegram.Schema.IMessageEntity>>(); }
        if (Flags[7]) { SponsorInfo = reader.ReadString(); }
        if (Flags[8]) { AdditionalInfo = reader.ReadString(); }
    }
}
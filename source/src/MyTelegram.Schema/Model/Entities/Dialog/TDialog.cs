﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/dialog" />
///</summary>
[TlObject(0xa8edd0f5)]
public class TDialog : IDialog
{
    public uint ConstructorId => 0xa8edd0f5;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Pinned { get; set; }
    public bool UnreadMark { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }
    public int TopMessage { get; set; }
    public int ReadInboxMaxId { get; set; }
    public int ReadOutboxMaxId { get; set; }
    public int UnreadCount { get; set; }
    public int UnreadMentionsCount { get; set; }
    public int UnreadReactionsCount { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PeerNotifySettings" />
    ///</summary>
    public MyTelegram.Schema.IPeerNotifySettings NotifySettings { get; set; }
    public int? Pts { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/DraftMessage" />
    ///</summary>
    public MyTelegram.Schema.IDraftMessage? Draft { get; set; }
    public int? FolderId { get; set; }

    public void ComputeFlag()
    {
        if (Pinned) { Flags[2] = true; }
        if (UnreadMark) { Flags[3] = true; }
        if (Pts != 0 && Pts.HasValue) { Flags[0] = true; }
        if (Draft != null) { Flags[1] = true; }
        if (FolderId != 0 && FolderId.HasValue) { Flags[4] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(TopMessage);
        bw.Write(ReadInboxMaxId);
        bw.Write(ReadOutboxMaxId);
        bw.Write(UnreadCount);
        bw.Write(UnreadMentionsCount);
        bw.Write(UnreadReactionsCount);
        NotifySettings.Serialize(bw);
        if (Flags[0]) { bw.Write(Pts.Value); }
        if (Flags[1]) { Draft.Serialize(bw); }
        if (Flags[4]) { bw.Write(FolderId.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[2]) { Pinned = true; }
        if (Flags[3]) { UnreadMark = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IPeer>();
        TopMessage = br.ReadInt32();
        ReadInboxMaxId = br.ReadInt32();
        ReadOutboxMaxId = br.ReadInt32();
        UnreadCount = br.ReadInt32();
        UnreadMentionsCount = br.ReadInt32();
        UnreadReactionsCount = br.ReadInt32();
        NotifySettings = br.Deserialize<MyTelegram.Schema.IPeerNotifySettings>();
        if (Flags[0]) { Pts = br.ReadInt32(); }
        if (Flags[1]) { Draft = br.Deserialize<MyTelegram.Schema.IDraftMessage>(); }
        if (Flags[4]) { FolderId = br.ReadInt32(); }
    }
}
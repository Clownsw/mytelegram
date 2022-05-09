﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.sendInlineBotResult" />
///</summary>
[TlObject(0x220815b0)]
public sealed class RequestSendInlineBotResult : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x220815b0;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Silent { get; set; }
    public bool Background { get; set; }
    public bool ClearDraft { get; set; }
    public bool HideVia { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public int? ReplyToMsgId { get; set; }
    public long RandomId { get; set; }
    public long QueryId { get; set; }
    public string Id { get; set; }
    public int? ScheduleDate { get; set; }

    public void ComputeFlag()
    {
        if (Silent) { Flags[5] = true; }
        if (Background) { Flags[6] = true; }
        if (ClearDraft) { Flags[7] = true; }
        if (HideVia) { Flags[11] = true; }
        if (ReplyToMsgId != 0 && ReplyToMsgId.HasValue) { Flags[0] = true; }
        if (ScheduleDate != 0 && ScheduleDate.HasValue) { Flags[10] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        if (Flags[0]) { bw.Write(ReplyToMsgId.Value); }
        bw.Write(RandomId);
        bw.Write(QueryId);
        bw.Serialize(Id);
        if (Flags[10]) { bw.Write(ScheduleDate.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[5]) { Silent = true; }
        if (Flags[6]) { Background = true; }
        if (Flags[7]) { ClearDraft = true; }
        if (Flags[11]) { HideVia = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        if (Flags[0]) { ReplyToMsgId = br.ReadInt32(); }
        RandomId = br.ReadInt64();
        QueryId = br.ReadInt64();
        Id = br.Deserialize<string>();
        if (Flags[10]) { ScheduleDate = br.ReadInt32(); }
    }
}

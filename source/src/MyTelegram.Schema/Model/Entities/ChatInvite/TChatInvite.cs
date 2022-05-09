﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/chatInvite" />
///</summary>
[TlObject(0xdfc2f58e)]
public class TChatInvite : IChatInvite
{
    public uint ConstructorId => 0xdfc2f58e;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Channel { get; set; }
    public bool Broadcast { get; set; }
    public bool Public { get; set; }
    public bool Megagroup { get; set; }
    public string Title { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto Photo { get; set; }
    public int ParticipantsCount { get; set; }
    public TVector<MyTelegram.Schema.IUser>? Participants { get; set; }

    public void ComputeFlag()
    {
        if (Channel) { Flags[0] = true; }
        if (Broadcast) { Flags[1] = true; }
        if (Public) { Flags[2] = true; }
        if (Megagroup) { Flags[3] = true; }
        if (Participants?.Count > 0) { Flags[4] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Title);
        Photo.Serialize(bw);
        bw.Write(ParticipantsCount);
        if (Flags[4]) { Participants.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Channel = true; }
        if (Flags[1]) { Broadcast = true; }
        if (Flags[2]) { Public = true; }
        if (Flags[3]) { Megagroup = true; }
        Title = br.Deserialize<string>();
        Photo = br.Deserialize<MyTelegram.Schema.IPhoto>();
        ParticipantsCount = br.ReadInt32();
        if (Flags[4]) { Participants = br.Deserialize<TVector<MyTelegram.Schema.IUser>>(); }
    }
}
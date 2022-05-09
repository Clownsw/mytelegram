﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/chatParticipantAdmin" />
///</summary>
[TlObject(0xa0933f5b)]
public class TChatParticipantAdmin : IChatParticipant
{
    public uint ConstructorId => 0xa0933f5b;
    public long UserId { get; set; }
    public long InviterId { get; set; }
    public int Date { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        bw.Write(InviterId);
        bw.Write(Date);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        InviterId = br.ReadInt64();
        Date = br.ReadInt32();
    }
}
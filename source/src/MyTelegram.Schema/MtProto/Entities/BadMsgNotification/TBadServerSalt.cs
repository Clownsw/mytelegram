﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0xedab447b)]
public sealed class TBadServerSalt : IBadMsgNotification
{
    public uint ConstructorId => 0xedab447b;
    public long BadMsgId { get; set; }
    public int BadMsgSeqno { get; set; }
    public int ErrorCode { get; set; }
    public long NewServerSalt { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(BadMsgId);
        writer.Write(BadMsgSeqno);
        writer.Write(ErrorCode);
        writer.Write(NewServerSalt);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        BadMsgId = reader.ReadInt64();
        BadMsgSeqno = reader.ReadInt32();
        ErrorCode = reader.ReadInt32();
        NewServerSalt = reader.ReadInt64();
    }
}
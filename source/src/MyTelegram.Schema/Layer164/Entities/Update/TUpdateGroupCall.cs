﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A new groupcall was started
/// See <a href="https://corefork.telegram.org/constructor/updateGroupCall" />
///</summary>
[TlObject(0x14b24500)]
public sealed class TUpdateGroupCall : IUpdate
{
    public uint ConstructorId => 0x14b24500;
    ///<summary>
    /// The <a href="https://corefork.telegram.org/api/channel">channel/supergroup</a> where this group call or livestream takes place
    ///</summary>
    public long ChatId { get; set; }

    ///<summary>
    /// Info about the group call or livestream
    /// See <a href="https://corefork.telegram.org/type/GroupCall" />
    ///</summary>
    public MyTelegram.Schema.IGroupCall Call { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ChatId);
        writer.Write(Call);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ChatId = reader.ReadInt64();
        Call = reader.Read<MyTelegram.Schema.IGroupCall>();
    }
}
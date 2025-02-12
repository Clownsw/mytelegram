﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/postInteractionCountersMessage" />
///</summary>
[TlObject(0xe7058e7f)]
public sealed class TPostInteractionCountersMessage : IPostInteractionCounters
{
    public uint ConstructorId => 0xe7058e7f;
    ///<summary>
    /// &nbsp;
    ///</summary>
    public int MsgId { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Views { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Forwards { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Reactions { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(MsgId);
        writer.Write(Views);
        writer.Write(Forwards);
        writer.Write(Reactions);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        MsgId = reader.ReadInt32();
        Views = reader.ReadInt32();
        Forwards = reader.ReadInt32();
        Reactions = reader.ReadInt32();
    }
}
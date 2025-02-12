﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/updateStoryID" />
///</summary>
[TlObject(0x1bf335b9)]
public sealed class TUpdateStoryID : IUpdate
{
    public uint ConstructorId => 0x1bf335b9;
    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public long RandomId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(RandomId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt32();
        RandomId = reader.ReadInt64();
    }
}
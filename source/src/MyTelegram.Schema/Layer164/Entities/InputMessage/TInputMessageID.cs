﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Message by ID
/// See <a href="https://corefork.telegram.org/constructor/inputMessageID" />
///</summary>
[TlObject(0xa676a322)]
public sealed class TInputMessageID : IInputMessage
{
    public uint ConstructorId => 0xa676a322;
    ///<summary>
    /// Message ID
    ///</summary>
    public int Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt32();
    }
}
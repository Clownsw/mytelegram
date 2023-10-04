﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Message entity representing <strong>bold text</strong>.
/// See <a href="https://corefork.telegram.org/constructor/messageEntityBold" />
///</summary>
[TlObject(0xbd610bc9)]
public sealed class TMessageEntityBold : IMessageEntity
{
    public uint ConstructorId => 0xbd610bc9;
    ///<summary>
    /// Offset of message entity within message (in <a href="https://corefork.telegram.org/api/entities#entity-length">UTF-16 code units</a>)
    ///</summary>
    public int Offset { get; set; }

    ///<summary>
    /// Length of message entity within message (in <a href="https://corefork.telegram.org/api/entities#entity-length">UTF-16 code units</a>)
    ///</summary>
    public int Length { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Offset);
        writer.Write(Length);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Offset = reader.ReadInt32();
        Length = reader.ReadInt32();
    }
}
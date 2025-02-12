﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/prepaidGiveaway" />
///</summary>
[TlObject(0xb2539d54)]
public sealed class TPrepaidGiveaway : IPrepaidGiveaway
{
    public uint ConstructorId => 0xb2539d54;
    public long Id { get; set; }
    public int Months { get; set; }
    public int Quantity { get; set; }
    public int Date { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(Months);
        writer.Write(Quantity);
        writer.Write(Date);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt64();
        Months = reader.ReadInt32();
        Quantity = reader.ReadInt32();
        Date = reader.ReadInt32();
    }
}
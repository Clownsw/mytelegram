﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/storyItemSkipped" />
///</summary>
[TlObject(0xffadc913)]
public sealed class TStoryItemSkipped : IStoryItem
{
    public uint ConstructorId => 0xffadc913;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool CloseFriends { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int Date { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int ExpireDate { get; set; }

    public void ComputeFlag()
    {
        if (CloseFriends) { Flags[8] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        writer.Write(Date);
        writer.Write(ExpireDate);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[8]) { CloseFriends = true; }
        Id = reader.ReadInt32();
        Date = reader.ReadInt32();
        ExpireDate = reader.ReadInt32();
    }
}
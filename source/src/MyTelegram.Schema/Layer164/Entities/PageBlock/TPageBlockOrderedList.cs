﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Ordered list of IV blocks
/// See <a href="https://corefork.telegram.org/constructor/pageBlockOrderedList" />
///</summary>
[TlObject(0x9a8ae1e1)]
public sealed class TPageBlockOrderedList : IPageBlock
{
    public uint ConstructorId => 0x9a8ae1e1;
    ///<summary>
    /// List items
    ///</summary>
    public TVector<MyTelegram.Schema.IPageListOrderedItem> Items { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Items);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Items = reader.Read<TVector<MyTelegram.Schema.IPageListOrderedItem>>();
    }
}
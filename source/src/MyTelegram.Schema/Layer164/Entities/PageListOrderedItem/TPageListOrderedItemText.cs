﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Ordered list of text items
/// See <a href="https://corefork.telegram.org/constructor/pageListOrderedItemText" />
///</summary>
[TlObject(0x5e068047)]
public sealed class TPageListOrderedItemText : IPageListOrderedItem
{
    public uint ConstructorId => 0x5e068047;
    ///<summary>
    /// Number of element within ordered list
    ///</summary>
    public string Num { get; set; }

    ///<summary>
    /// Text
    /// See <a href="https://corefork.telegram.org/type/RichText" />
    ///</summary>
    public MyTelegram.Schema.IRichText Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Num);
        writer.Write(Text);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Num = reader.ReadString();
        Text = reader.Read<MyTelegram.Schema.IRichText>();
    }
}
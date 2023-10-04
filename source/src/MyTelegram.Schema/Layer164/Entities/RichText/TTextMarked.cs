﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Highlighted text
/// See <a href="https://corefork.telegram.org/constructor/textMarked" />
///</summary>
[TlObject(0x34b8621)]
public sealed class TTextMarked : IRichText
{
    public uint ConstructorId => 0x34b8621;
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
        writer.Write(Text);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Text = reader.Read<MyTelegram.Schema.IRichText>();
    }
}
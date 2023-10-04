﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Subtitle
/// See <a href="https://corefork.telegram.org/constructor/pageBlockSubtitle" />
///</summary>
[TlObject(0x8ffa9a1f)]
public sealed class TPageBlockSubtitle : IPageBlock
{
    public uint ConstructorId => 0x8ffa9a1f;
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
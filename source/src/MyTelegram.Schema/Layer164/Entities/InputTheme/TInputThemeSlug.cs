﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Theme by theme ID
/// See <a href="https://corefork.telegram.org/constructor/inputThemeSlug" />
///</summary>
[TlObject(0xf5890df1)]
public sealed class TInputThemeSlug : IInputTheme
{
    public uint ConstructorId => 0xf5890df1;
    ///<summary>
    /// Unique theme ID obtained from a <a href="https://corefork.telegram.org/api/links#theme-links">theme deep link »</a>
    ///</summary>
    public string Slug { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Slug);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Slug = reader.ReadString();
    }
}
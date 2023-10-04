﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Defines the width and height of an image uploaded as document
/// See <a href="https://corefork.telegram.org/constructor/documentAttributeImageSize" />
///</summary>
[TlObject(0x6c37c15c)]
public sealed class TDocumentAttributeImageSize : IDocumentAttribute
{
    public uint ConstructorId => 0x6c37c15c;
    ///<summary>
    /// Width of image
    ///</summary>
    public int W { get; set; }

    ///<summary>
    /// Height of image
    ///</summary>
    public int H { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(W);
        writer.Write(H);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        W = reader.ReadInt32();
        H = reader.ReadInt32();
    }
}
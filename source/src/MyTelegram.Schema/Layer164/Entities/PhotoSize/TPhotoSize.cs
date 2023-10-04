﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Image description.
/// See <a href="https://corefork.telegram.org/constructor/photoSize" />
///</summary>
[TlObject(0x75c78e60)]
public sealed class TPhotoSize : IPhotoSize
{
    public uint ConstructorId => 0x75c78e60;
    ///<summary>
    /// <a href="https://corefork.telegram.org/api/files#image-thumbnail-types">Thumbnail type »</a>
    ///</summary>
    public string Type { get; set; }

    ///<summary>
    /// Image width
    ///</summary>
    public int W { get; set; }

    ///<summary>
    /// Image height
    ///</summary>
    public int H { get; set; }

    ///<summary>
    /// File size
    ///</summary>
    public int Size { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Type);
        writer.Write(W);
        writer.Write(H);
        writer.Write(Size);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Type = reader.ReadString();
        W = reader.ReadInt32();
        H = reader.ReadInt32();
        Size = reader.ReadInt32();
    }
}
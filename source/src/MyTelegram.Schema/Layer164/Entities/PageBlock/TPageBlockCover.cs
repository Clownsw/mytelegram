﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A page cover
/// See <a href="https://corefork.telegram.org/constructor/pageBlockCover" />
///</summary>
[TlObject(0x39f23300)]
public sealed class TPageBlockCover : IPageBlock
{
    public uint ConstructorId => 0x39f23300;
    ///<summary>
    /// Cover
    /// See <a href="https://corefork.telegram.org/type/PageBlock" />
    ///</summary>
    public MyTelegram.Schema.IPageBlock Cover { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Cover);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Cover = reader.Read<MyTelegram.Schema.IPageBlock>();
    }
}
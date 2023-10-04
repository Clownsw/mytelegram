﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A preview of the webpage is currently being generated
/// See <a href="https://corefork.telegram.org/constructor/webPagePending" />
///</summary>
[TlObject(0xc586da1c)]
public sealed class TWebPagePending : IWebPage
{
    public uint ConstructorId => 0xc586da1c;
    ///<summary>
    /// ID of preview
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// When was the processing started
    ///</summary>
    public int Date { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(Date);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt64();
        Date = reader.ReadInt32();
    }
}
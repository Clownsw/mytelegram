﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/sponsoredWebPage" />
///</summary>
[TlObject(0x3db8ec63)]
public sealed class TSponsoredWebPage : ISponsoredWebPage
{
    public uint ConstructorId => 0x3db8ec63;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// &nbsp;
    ///</summary>
    public string Url { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public string SiteName { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto? Photo { get; set; }

    public void ComputeFlag()
    {
        if (Photo != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Url);
        writer.Write(SiteName);
        if (Flags[0]) { writer.Write(Photo); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Url = reader.ReadString();
        SiteName = reader.ReadString();
        if (Flags[0]) { Photo = reader.Read<MyTelegram.Schema.IPhoto>(); }
    }
}
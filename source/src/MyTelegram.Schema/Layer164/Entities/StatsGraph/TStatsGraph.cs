﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// <a href="https://corefork.telegram.org/api/stats">Channel statistics graph</a>
/// See <a href="https://corefork.telegram.org/constructor/statsGraph" />
///</summary>
[TlObject(0x8ea464b6)]
public sealed class TStatsGraph : IStatsGraph
{
    public uint ConstructorId => 0x8ea464b6;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Statistics data
    /// See <a href="https://corefork.telegram.org/type/DataJSON" />
    ///</summary>
    public MyTelegram.Schema.IDataJSON Json { get; set; }

    ///<summary>
    /// Zoom token
    ///</summary>
    public string? ZoomToken { get; set; }

    public void ComputeFlag()
    {
        if (ZoomToken != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Json);
        if (Flags[0]) { writer.Write(ZoomToken); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Json = reader.Read<MyTelegram.Schema.IDataJSON>();
        if (Flags[0]) { ZoomToken = reader.ReadString(); }
    }
}
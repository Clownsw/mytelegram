﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Authorized to the current user's account through an unknown device.
/// See <a href="https://corefork.telegram.org/constructor/updateNewAuthorization" />
///</summary>
[TlObject(0x8951abef)]
public sealed class TUpdateNewAuthorization : IUpdate
{
    public uint ConstructorId => 0x8951abef;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Unconfirmed { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash for pagination, for more info click here</a>
    ///</summary>
    public long Hash { get; set; }

    ///<summary>
    /// Authorization date
    ///</summary>
    public int? Date { get; set; }

    ///<summary>
    /// Name of device, for example <em>Android</em>
    ///</summary>
    public string? Device { get; set; }

    ///<summary>
    /// Location, for example <em>USA, NY (IP=1.2.3.4)</em>
    ///</summary>
    public string? Location { get; set; }

    public void ComputeFlag()
    {
        if (Unconfirmed) { Flags[0] = true; }
        if (/*Date != 0 && */Date.HasValue) { Flags[0] = true; }
        if (Device != null) { Flags[0] = true; }
        if (Location != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Hash);
        if (Flags[0]) { writer.Write(Date.Value); }
        if (Flags[0]) { writer.Write(Device); }
        if (Flags[0]) { writer.Write(Location); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Unconfirmed = true; }
        Hash = reader.ReadInt64();
        if (Flags[0]) { Date = reader.ReadInt32(); }
        if (Flags[0]) { Device = reader.ReadString(); }
        if (Flags[0]) { Location = reader.ReadString(); }
    }
}
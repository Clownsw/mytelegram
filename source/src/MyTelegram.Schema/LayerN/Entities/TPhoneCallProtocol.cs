﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.LayerN;

///<summary>
/// Protocol info for libtgvoip
/// See <a href="https://corefork.telegram.org/constructor/phoneCallProtocol" />
///</summary>
[TlObject(0xa2bb35cb)]
public sealed class TPhoneCallProtocol : IObject
{
    public uint ConstructorId => 0xa2bb35cb;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to allow P2P connection to the other participant
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool UdpP2p { get; set; }

    ///<summary>
    /// Whether to allow connection to the other participants through the reflector servers
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool UdpReflector { get; set; }

    ///<summary>
    /// Minimum layer for remote libtgvoip
    ///</summary>
    public int MinLayer { get; set; }

    ///<summary>
    /// Maximum layer for remote libtgvoip
    ///</summary>
    public int MaxLayer { get; set; }

    public void ComputeFlag()
    {
        if (UdpP2p) { Flags[0] = true; }
        if (UdpReflector) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(MinLayer);
        writer.Write(MaxLayer);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { UdpP2p = true; }
        if (Flags[1]) { UdpReflector = true; }
        MinLayer = reader.ReadInt32();
        MaxLayer = reader.ReadInt32();
    }
}
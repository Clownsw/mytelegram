﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Premium;

///<summary>
/// See <a href="https://corefork.telegram.org/method/premium.applyBoost" />
///</summary>
[TlObject(0x6b7da746)]
public sealed class RequestApplyBoost : IRequest<MyTelegram.Schema.Premium.IMyBoosts>
{
    public uint ConstructorId => 0x6b7da746;
    public BitArray Flags { get; set; } = new BitArray(32);
    public TVector<int>? Slots { get; set; }
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    public void ComputeFlag()
    {
        if (Slots?.Count > 0) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[0]) { writer.Write(Slots); }
        writer.Write(Peer);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Slots = reader.Read<TVector<int>>(); }
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
    }
}

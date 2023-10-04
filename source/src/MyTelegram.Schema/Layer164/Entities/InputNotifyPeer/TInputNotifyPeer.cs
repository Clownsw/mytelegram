﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Notifications generated by a certain user or group.
/// See <a href="https://corefork.telegram.org/constructor/inputNotifyPeer" />
///</summary>
[TlObject(0xb8bc5b0c)]
public sealed class TInputNotifyPeer : IInputNotifyPeer
{
    public uint ConstructorId => 0xb8bc5b0c;
    ///<summary>
    /// User or group
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
    }
}
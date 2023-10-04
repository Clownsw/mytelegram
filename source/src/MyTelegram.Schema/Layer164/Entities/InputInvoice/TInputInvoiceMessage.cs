﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// An invoice contained in a <a href="https://corefork.telegram.org/constructor/messageMediaInvoice">messageMediaInvoice</a> message.
/// See <a href="https://corefork.telegram.org/constructor/inputInvoiceMessage" />
///</summary>
[TlObject(0xc5b56859)]
public sealed class TInputInvoiceMessage : IInputInvoice
{
    public uint ConstructorId => 0xc5b56859;
    ///<summary>
    /// Chat where the invoice was sent
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Message ID
    ///</summary>
    public int MsgId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(MsgId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        MsgId = reader.ReadInt32();
    }
}
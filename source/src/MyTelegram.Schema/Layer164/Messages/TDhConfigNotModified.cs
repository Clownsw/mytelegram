﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Configuring parameters did not change.
/// See <a href="https://corefork.telegram.org/constructor/messages.dhConfigNotModified" />
///</summary>
[TlObject(0xc0e24635)]
public sealed class TDhConfigNotModified : IDhConfig
{
    public uint ConstructorId => 0xc0e24635;
    ///<summary>
    /// Random sequence of bytes of assigned length
    ///</summary>
    public byte[] Random { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Random);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Random = reader.ReadBytes();
    }
}
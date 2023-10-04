﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Popular contact
/// See <a href="https://corefork.telegram.org/constructor/popularContact" />
///</summary>
[TlObject(0x5ce14175)]
public sealed class TPopularContact : IPopularContact
{
    public uint ConstructorId => 0x5ce14175;
    ///<summary>
    /// Contact identifier
    ///</summary>
    public long ClientId { get; set; }

    ///<summary>
    /// How many people imported this contact
    ///</summary>
    public int Importers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ClientId);
        writer.Write(Importers);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ClientId = reader.ReadInt64();
        Importers = reader.ReadInt32();
    }
}
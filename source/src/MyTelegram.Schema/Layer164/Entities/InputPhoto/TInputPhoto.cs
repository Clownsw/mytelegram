﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Defines a photo for further interaction.
/// See <a href="https://corefork.telegram.org/constructor/inputPhoto" />
///</summary>
[TlObject(0x3bb3b94a)]
public sealed class TInputPhoto : IInputPhoto
{
    public uint ConstructorId => 0x3bb3b94a;
    ///<summary>
    /// Photo identifier
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// <strong>access_hash</strong> value from the <a href="https://corefork.telegram.org/constructor/photo">photo</a> constructor
    ///</summary>
    public long AccessHash { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/file_reference">File reference</a>
    ///</summary>
    public byte[] FileReference { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(AccessHash);
        writer.Write(FileReference);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt64();
        AccessHash = reader.ReadInt64();
        FileReference = reader.ReadBytes();
    }
}
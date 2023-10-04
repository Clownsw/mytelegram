﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Location of encrypted secret chat file.
/// See <a href="https://corefork.telegram.org/constructor/inputEncryptedFileLocation" />
///</summary>
[TlObject(0xf5235d55)]
public sealed class TInputEncryptedFileLocation : IInputFileLocation
{
    public uint ConstructorId => 0xf5235d55;
    ///<summary>
    /// File ID, <strong>id</strong> parameter value from <a href="https://corefork.telegram.org/constructor/encryptedFile">encryptedFile</a>
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// Checksum, <strong>access_hash</strong> parameter value from <a href="https://corefork.telegram.org/constructor/encryptedFile">encryptedFile</a>
    ///</summary>
    public long AccessHash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(AccessHash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt64();
        AccessHash = reader.ReadInt64();
    }
}
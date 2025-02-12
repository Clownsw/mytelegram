﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Upload;

///<summary>
/// Request a reupload of a certain file to a <a href="https://corefork.telegram.org/cdn">CDN DC</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 500 CDN_UPLOAD_TIMEOUT A server-side timeout occurred while reuploading the file to the CDN DC.
/// 400 FILE_TOKEN_INVALID The specified file token is invalid.
/// 400 RSA_DECRYPT_FAILED Internal RSA decryption failed.
/// See <a href="https://corefork.telegram.org/method/upload.reuploadCdnFile" />
///</summary>
[TlObject(0x9b2754a8)]
public sealed class RequestReuploadCdnFile : IRequest<TVector<MyTelegram.Schema.IFileHash>>
{
    public uint ConstructorId => 0x9b2754a8;
    ///<summary>
    /// File token
    ///</summary>
    public byte[] FileToken { get; set; }

    ///<summary>
    /// Request token
    ///</summary>
    public byte[] RequestToken { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(FileToken);
        writer.Write(RequestToken);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        FileToken = reader.ReadBytes();
        RequestToken = reader.ReadBytes();
    }
}

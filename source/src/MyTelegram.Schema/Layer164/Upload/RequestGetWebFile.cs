﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Upload;

///<summary>
/// Returns content of a web file, by proxying the request through telegram, see the <a href="https://corefork.telegram.org/api/files#downloading-webfiles">webfile docs for more info</a>.<strong>Note</strong>: the query must be sent to the DC specified in the <code>webfile_dc_id</code> <a href="https://corefork.telegram.org/api/config#mtproto-configuration">MTProto configuration field</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 DOCUMENT_INVALID The specified document is invalid.
/// 400 LOCATION_INVALID The provided location is invalid.
/// See <a href="https://corefork.telegram.org/method/upload.getWebFile" />
///</summary>
[TlObject(0x24e6818d)]
public sealed class RequestGetWebFile : IRequest<MyTelegram.Schema.Upload.IWebFile>
{
    public uint ConstructorId => 0x24e6818d;
    ///<summary>
    /// The file to download
    /// See <a href="https://corefork.telegram.org/type/InputWebFileLocation" />
    ///</summary>
    public MyTelegram.Schema.IInputWebFileLocation Location { get; set; }

    ///<summary>
    /// Number of bytes to be skipped
    ///</summary>
    public int Offset { get; set; }

    ///<summary>
    /// Number of bytes to be returned
    ///</summary>
    public int Limit { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Location);
        writer.Write(Offset);
        writer.Write(Limit);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Location = reader.Read<MyTelegram.Schema.IInputWebFileLocation>();
        Offset = reader.ReadInt32();
        Limit = reader.ReadInt32();
    }
}

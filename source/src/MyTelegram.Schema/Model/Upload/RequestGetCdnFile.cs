﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Upload;

///<summary>
///See <a href="https://core.telegram.org/method/upload.getCdnFile" />
///</summary>
[TlObject(0x2000bcc3)]
public sealed class RequestGetCdnFile : IRequest<MyTelegram.Schema.Upload.ICdnFile>
{
    public uint ConstructorId => 0x2000bcc3;
    public byte[] FileToken { get; set; }
    public int Offset { get; set; }
    public int Limit { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(FileToken);
        bw.Write(Offset);
        bw.Write(Limit);
    }

    public void Deserialize(BinaryReader br)
    {
        FileToken = br.Deserialize<byte[]>();
        Offset = br.ReadInt32();
        Limit = br.ReadInt32();
    }
}

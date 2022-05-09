﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Upload;

///<summary>
///See <a href="https://core.telegram.org/method/upload.getCdnFileHashes" />
///</summary>
[TlObject(0x4da54231)]
public sealed class RequestGetCdnFileHashes : IRequest<TVector<MyTelegram.Schema.IFileHash>>
{
    public uint ConstructorId => 0x4da54231;
    public byte[] FileToken { get; set; }
    public int Offset { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(FileToken);
        bw.Write(Offset);
    }

    public void Deserialize(BinaryReader br)
    {
        FileToken = br.Deserialize<byte[]>();
        Offset = br.ReadInt32();
    }
}

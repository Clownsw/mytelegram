﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.acceptEncryption" />
///</summary>
[TlObject(0x3dbc0415)]
public sealed class RequestAcceptEncryption : IRequest<MyTelegram.Schema.IEncryptedChat>
{
    public uint ConstructorId => 0x3dbc0415;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputEncryptedChat" />
    ///</summary>
    public MyTelegram.Schema.IInputEncryptedChat Peer { get; set; }
    public byte[] GB { get; set; }
    public long KeyFingerprint { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
        bw.Serialize(GB);
        bw.Write(KeyFingerprint);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IInputEncryptedChat>();
        GB = br.Deserialize<byte[]>();
        KeyFingerprint = br.ReadInt64();
    }
}

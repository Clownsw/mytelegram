﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getExportedChatInvite" />
///</summary>
[TlObject(0x73746f5c)]
public sealed class RequestGetExportedChatInvite : IRequest<MyTelegram.Schema.Messages.IExportedChatInvite>
{
    public uint ConstructorId => 0x73746f5c;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public string Link { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
        bw.Serialize(Link);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        Link = br.Deserialize<string>();
    }
}

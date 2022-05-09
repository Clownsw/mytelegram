﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Folders;

///<summary>
///See <a href="https://core.telegram.org/method/folders.editPeerFolders" />
///</summary>
[TlObject(0x6847d0ab)]
public sealed class RequestEditPeerFolders : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x6847d0ab;
    public TVector<MyTelegram.Schema.IInputFolderPeer> FolderPeers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        FolderPeers.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        FolderPeers = br.Deserialize<TVector<MyTelegram.Schema.IInputFolderPeer>>();
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Chatlists;

///<summary>
/// Import a <a href="https://corefork.telegram.org/api/links#chat-folder-links">chat folder deep link »</a>, joining some or all the chats in the folder.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 INVITE_SLUG_EMPTY The specified invite slug is empty.
/// See <a href="https://corefork.telegram.org/method/chatlists.joinChatlistInvite" />
///</summary>
[TlObject(0xa6b1e39a)]
public sealed class RequestJoinChatlistInvite : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xa6b1e39a;
    ///<summary>
    /// <code>slug</code> obtained from a <a href="https://corefork.telegram.org/api/links#chat-folder-links">chat folder deep link »</a>.
    ///</summary>
    public string Slug { get; set; }

    ///<summary>
    /// List of new chats to join, fetched using <a href="https://corefork.telegram.org/method/chatlists.checkChatlistInvite">chatlists.checkChatlistInvite</a> and filtered as specified in the <a href="https://corefork.telegram.org/api/folders#shared-folders">documentation »</a>.
    ///</summary>
    public TVector<MyTelegram.Schema.IInputPeer> Peers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Slug);
        writer.Write(Peers);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Slug = reader.ReadString();
        Peers = reader.Read<TVector<MyTelegram.Schema.IInputPeer>>();
    }
}

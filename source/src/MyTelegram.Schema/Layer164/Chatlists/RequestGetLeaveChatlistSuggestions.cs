﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Chatlists;

///<summary>
/// Returns identifiers of pinned or always included chats from a chat folder imported using a <a href="https://corefork.telegram.org/api/links#chat-folder-links">chat folder deep link »</a>, which are suggested to be left when the chat folder is deleted.
/// See <a href="https://corefork.telegram.org/method/chatlists.getLeaveChatlistSuggestions" />
///</summary>
[TlObject(0xfdbcd714)]
public sealed class RequestGetLeaveChatlistSuggestions : IRequest<TVector<MyTelegram.Schema.IPeer>>
{
    public uint ConstructorId => 0xfdbcd714;
    ///<summary>
    /// Folder ID
    /// See <a href="https://corefork.telegram.org/type/InputChatlist" />
    ///</summary>
    public MyTelegram.Schema.IInputChatlist Chatlist { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Chatlist);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Chatlist = reader.Read<MyTelegram.Schema.IInputChatlist>();
    }
}

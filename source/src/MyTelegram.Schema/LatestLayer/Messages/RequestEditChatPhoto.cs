﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Changes chat photo and sends a service message on it
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHAT_ID_INVALID The provided chat id is invalid.
/// 400 CHAT_NOT_MODIFIED No changes were made to chat information because the new information you passed is identical to the current information.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// 400 PHOTO_CROP_SIZE_SMALL Photo is too small.
/// 400 PHOTO_EXT_INVALID The extension of the photo is invalid.
/// 400 PHOTO_INVALID Photo invalid.
/// See <a href="https://corefork.telegram.org/method/messages.editChatPhoto" />
///</summary>
[TlObject(0x35ddd674)]
public sealed class RequestEditChatPhoto : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x35ddd674;
    ///<summary>
    /// Chat ID
    ///</summary>
    public long ChatId { get; set; }

    ///<summary>
    /// Photo to be set
    /// See <a href="https://corefork.telegram.org/type/InputChatPhoto" />
    ///</summary>
    public MyTelegram.Schema.IInputChatPhoto Photo { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ChatId);
        writer.Write(Photo);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ChatId = reader.ReadInt64();
        Photo = reader.Read<MyTelegram.Schema.IInputChatPhoto>();
    }
}

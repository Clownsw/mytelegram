﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Returns attachment menu entry for a <a href="https://corefork.telegram.org/api/bots/attach">bot web app that can be launched from the attachment menu »</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 BOT_INVALID This is not a valid bot.
/// See <a href="https://corefork.telegram.org/method/messages.getAttachMenuBot" />
///</summary>
[TlObject(0x77216192)]
public sealed class RequestGetAttachMenuBot : IRequest<MyTelegram.Schema.IAttachMenuBotsBot>
{
    public uint ConstructorId => 0x77216192;
    ///<summary>
    /// Bot ID
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser Bot { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Bot);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Bot = reader.Read<MyTelegram.Schema.IInputUser>();
    }
}

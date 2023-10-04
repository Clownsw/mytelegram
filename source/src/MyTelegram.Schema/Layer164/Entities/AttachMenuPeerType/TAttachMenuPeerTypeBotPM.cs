﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The bot attachment menu entry is available in private chats with other bots (excluding the bot that offers the current attachment menu)
/// See <a href="https://corefork.telegram.org/constructor/attachMenuPeerTypeBotPM" />
///</summary>
[TlObject(0xc32bfa1a)]
public sealed class TAttachMenuPeerTypeBotPM : IAttachMenuPeerType
{
    public uint ConstructorId => 0xc32bfa1a;


    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// User is playing a game
/// See <a href="https://corefork.telegram.org/constructor/sendMessageGamePlayAction" />
///</summary>
[TlObject(0xdd6a8f48)]
public sealed class TSendMessageGamePlayAction : ISendMessageAction
{
    public uint ConstructorId => 0xdd6a8f48;


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
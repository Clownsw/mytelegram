﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Bots;

///<summary>
/// See <a href="https://corefork.telegram.org/method/bots.allowSendMessage" />
///</summary>
[TlObject(0xf132e3ef)]
public sealed class RequestAllowSendMessage : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xf132e3ef;
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

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
/// Returns current configuration, including data center configuration.
/// See <a href="https://corefork.telegram.org/method/help.getConfig" />
///</summary>
[TlObject(0xc4f9186b)]
public sealed class RequestGetConfig : IRequest<MyTelegram.Schema.IConfig>
{
    public uint ConstructorId => 0xc4f9186b;

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

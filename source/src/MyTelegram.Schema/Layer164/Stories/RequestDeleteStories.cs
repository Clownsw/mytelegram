﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stories;

///<summary>
/// See <a href="https://corefork.telegram.org/method/stories.deleteStories" />
///</summary>
[TlObject(0xae59db5f)]
public sealed class RequestDeleteStories : IRequest<TVector<int>>
{
    public uint ConstructorId => 0xae59db5f;
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public TVector<int> Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Id = reader.Read<TVector<int>>();
    }
}

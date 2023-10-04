﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Notifies the sender about the recipient having listened a voice message or watched a video.
/// See <a href="https://corefork.telegram.org/method/messages.readMessageContents" />
///</summary>
[TlObject(0x36a73f77)]
public sealed class RequestReadMessageContents : IRequest<MyTelegram.Schema.Messages.IAffectedMessages>
{
    public uint ConstructorId => 0x36a73f77;
    ///<summary>
    /// Message ID list
    ///</summary>
    public TVector<int> Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.Read<TVector<int>>();
    }
}

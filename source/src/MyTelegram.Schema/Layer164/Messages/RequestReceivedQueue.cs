﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Confirms receipt of messages in a secret chat by client, cancels push notifications.<br>
/// The method returns a list of <strong>random_id</strong>s of messages for which push notifications were cancelled.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 MAX_QTS_INVALID The specified max_qts is invalid.
/// 500 MSG_WAIT_FAILED A waiting call returned an error.
/// See <a href="https://corefork.telegram.org/method/messages.receivedQueue" />
///</summary>
[TlObject(0x55a5bb66)]
public sealed class RequestReceivedQueue : IRequest<TVector<long>>
{
    public uint ConstructorId => 0x55a5bb66;
    ///<summary>
    /// Maximum qts value available at the client
    ///</summary>
    public int MaxQts { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(MaxQts);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        MaxQts = reader.ReadInt32();
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The results of a poll have changed
/// See <a href="https://corefork.telegram.org/constructor/updateMessagePoll" />
///</summary>
[TlObject(0xaca1657b)]
public sealed class TUpdateMessagePoll : IUpdate
{
    public uint ConstructorId => 0xaca1657b;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Poll ID
    ///</summary>
    public long PollId { get; set; }

    ///<summary>
    /// If the server knows the client hasn't cached this poll yet, the poll itself
    /// See <a href="https://corefork.telegram.org/type/Poll" />
    ///</summary>
    public MyTelegram.Schema.IPoll? Poll { get; set; }

    ///<summary>
    /// New poll results
    /// See <a href="https://corefork.telegram.org/type/PollResults" />
    ///</summary>
    public MyTelegram.Schema.IPollResults Results { get; set; }

    public void ComputeFlag()
    {
        if (Poll != null) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(PollId);
        if (Flags[0]) { writer.Write(Poll); }
        writer.Write(Results);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        PollId = reader.ReadInt64();
        if (Flags[0]) { Poll = reader.Read<MyTelegram.Schema.IPoll>(); }
        Results = reader.Read<MyTelegram.Schema.IPollResults>();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// A bot was stopped or re-started.
/// See <a href="https://corefork.telegram.org/constructor/updateBotStopped" />
///</summary>
[TlObject(0xc4870a49)]
public sealed class TUpdateBotStopped : IUpdate
{
    public uint ConstructorId => 0xc4870a49;
    ///<summary>
    /// The user ID
    ///</summary>
    public long UserId { get; set; }

    ///<summary>
    /// When did this action occur
    ///</summary>
    public int Date { get; set; }

    ///<summary>
    /// Whether the bot was stopped or started
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool Stopped { get; set; }

    ///<summary>
    /// New <strong>qts</strong> value, see <a href="https://corefork.telegram.org/api/updates">updates »</a> for more info.
    ///</summary>
    public int Qts { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(UserId);
        writer.Write(Date);
        writer.Write(Stopped);
        writer.Write(Qts);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        UserId = reader.ReadInt64();
        Date = reader.ReadInt32();
        Stopped = reader.Read();
        Qts = reader.ReadInt32();
    }
}
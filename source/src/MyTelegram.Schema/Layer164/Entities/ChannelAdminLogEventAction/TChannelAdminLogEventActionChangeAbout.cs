﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The description was changed
/// See <a href="https://corefork.telegram.org/constructor/channelAdminLogEventActionChangeAbout" />
///</summary>
[TlObject(0x55188a2e)]
public sealed class TChannelAdminLogEventActionChangeAbout : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x55188a2e;
    ///<summary>
    /// Previous description
    ///</summary>
    public string PrevValue { get; set; }

    ///<summary>
    /// New description
    ///</summary>
    public string NewValue { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(PrevValue);
        writer.Write(NewValue);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        PrevValue = reader.ReadString();
        NewValue = reader.ReadString();
    }
}
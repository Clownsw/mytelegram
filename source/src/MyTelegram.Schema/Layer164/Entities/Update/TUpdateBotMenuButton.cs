﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The menu button behavior for the specified bot has changed
/// See <a href="https://corefork.telegram.org/constructor/updateBotMenuButton" />
///</summary>
[TlObject(0x14b85813)]
public sealed class TUpdateBotMenuButton : IUpdate
{
    public uint ConstructorId => 0x14b85813;
    ///<summary>
    /// Bot ID
    ///</summary>
    public long BotId { get; set; }

    ///<summary>
    /// New menu button
    /// See <a href="https://corefork.telegram.org/type/BotMenuButton" />
    ///</summary>
    public MyTelegram.Schema.IBotMenuButton Button { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(BotId);
        writer.Write(Button);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        BotId = reader.ReadInt64();
        Button = reader.Read<MyTelegram.Schema.IBotMenuButton>();
    }
}
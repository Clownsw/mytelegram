﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Represents a <a href="https://corefork.telegram.org/api/bots/attach">bot web app that can be launched from the attachment menu »</a>
/// See <a href="https://corefork.telegram.org/constructor/attachMenuBotsBot" />
///</summary>
[TlObject(0x93bf667f)]
public sealed class TAttachMenuBotsBot : IAttachMenuBotsBot
{
    public uint ConstructorId => 0x93bf667f;
    ///<summary>
    /// Represents a <a href="https://corefork.telegram.org/api/bots/attach">bot web app that can be launched from the attachment menu »</a><br>
    /// See <a href="https://corefork.telegram.org/type/AttachMenuBot" />
    ///</summary>
    public MyTelegram.Schema.IAttachMenuBot Bot { get; set; }

    ///<summary>
    /// Info about related users and bots
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Bot);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Bot = reader.Read<MyTelegram.Schema.IAttachMenuBot>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}
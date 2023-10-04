﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// The notification sound was not in MP3 format and was successfully converted and saved, use the returned <a href="https://corefork.telegram.org/type/Document">Document</a> to refer to the notification sound from now on
/// See <a href="https://corefork.telegram.org/constructor/account.savedRingtoneConverted" />
///</summary>
[TlObject(0x1f307eb7)]
public sealed class TSavedRingtoneConverted : ISavedRingtone
{
    public uint ConstructorId => 0x1f307eb7;
    ///<summary>
    /// The converted notification sound
    /// See <a href="https://corefork.telegram.org/type/Document" />
    ///</summary>
    public MyTelegram.Schema.IDocument Document { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Document);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Document = reader.Read<MyTelegram.Schema.IDocument>();
    }
}
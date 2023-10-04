﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Sends a message with a file attachment to a secret chat
/// <para>Possible errors</para>
/// Code Type Description
/// 400 DATA_TOO_LONG Data too long.
/// 400 ENCRYPTION_DECLINED The secret chat was declined.
/// 400 FILE_EMTPY An empty file was provided.
/// 400 MD5_CHECKSUM_INVALID The MD5 checksums do not match.
/// 400 MSG_WAIT_FAILED A waiting call returned an error.
/// See <a href="https://corefork.telegram.org/method/messages.sendEncryptedFile" />
///</summary>
[TlObject(0x5559481d)]
public sealed class RequestSendEncryptedFile : IRequest<MyTelegram.Schema.Messages.ISentEncryptedMessage>
{
    public uint ConstructorId => 0x5559481d;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to send the file without triggering a notification
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Silent { get; set; }

    ///<summary>
    /// Secret chat ID
    /// See <a href="https://corefork.telegram.org/type/InputEncryptedChat" />
    ///</summary>
    public MyTelegram.Schema.IInputEncryptedChat Peer { get; set; }

    ///<summary>
    /// Unique client message ID necessary to prevent message resending
    ///</summary>
    public long RandomId { get; set; }

    ///<summary>
    /// TL-serialization of <a href="https://corefork.telegram.org/type/DecryptedMessage">DecryptedMessage</a> type, encrypted with a key generated during chat initialization
    ///</summary>
    public byte[] Data { get; set; }

    ///<summary>
    /// File attachment for the secret chat
    /// See <a href="https://corefork.telegram.org/type/InputEncryptedFile" />
    ///</summary>
    public MyTelegram.Schema.IInputEncryptedFile File { get; set; }

    public void ComputeFlag()
    {
        if (Silent) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(RandomId);
        writer.Write(Data);
        writer.Write(File);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Silent = true; }
        Peer = reader.Read<MyTelegram.Schema.IInputEncryptedChat>();
        RandomId = reader.ReadInt64();
        Data = reader.ReadBytes();
        File = reader.Read<MyTelegram.Schema.IInputEncryptedFile>();
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
/// Rate a call, returns info about the rating message sent to the official VoIP bot.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CALL_PEER_INVALID The provided call peer object is invalid.
/// See <a href="https://corefork.telegram.org/method/phone.setCallRating" />
///</summary>
[TlObject(0x59ead627)]
public sealed class RequestSetCallRating : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x59ead627;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the user decided on their own initiative to rate the call
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool UserInitiative { get; set; }

    ///<summary>
    /// The call to rate
    /// See <a href="https://corefork.telegram.org/type/InputPhoneCall" />
    ///</summary>
    public MyTelegram.Schema.IInputPhoneCall Peer { get; set; }

    ///<summary>
    /// Rating in <code>1-5</code> stars
    ///</summary>
    public int Rating { get; set; }

    ///<summary>
    /// An additional comment
    ///</summary>
    public string Comment { get; set; }

    public void ComputeFlag()
    {
        if (UserInitiative) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(Rating);
        writer.Write(Comment);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { UserInitiative = true; }
        Peer = reader.Read<MyTelegram.Schema.IInputPhoneCall>();
        Rating = reader.ReadInt32();
        Comment = reader.ReadString();
    }
}

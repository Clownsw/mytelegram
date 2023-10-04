﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Get more info about a Seamless Telegram Login authorization request, for more info <a href="https://corefork.telegram.org/api/url-authorization">click here »</a>
/// See <a href="https://corefork.telegram.org/method/messages.requestUrlAuth" />
///</summary>
[TlObject(0x198fb446)]
public sealed class RequestRequestUrlAuth : IRequest<MyTelegram.Schema.IUrlAuthResult>
{
    public uint ConstructorId => 0x198fb446;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Peer where the message is located
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? Peer { get; set; }

    ///<summary>
    /// The message
    ///</summary>
    public int? MsgId { get; set; }

    ///<summary>
    /// The ID of the button with the authorization request
    ///</summary>
    public int? ButtonId { get; set; }

    ///<summary>
    /// URL used for <a href="https://corefork.telegram.org/api/url-authorization#link-url-authorization">link URL authorization, click here for more info »</a>
    ///</summary>
    public string? Url { get; set; }

    public void ComputeFlag()
    {
        if (Peer != null) { Flags[1] = true; }
        if (/*MsgId != 0 && */MsgId.HasValue) { Flags[1] = true; }
        if (/*ButtonId != 0 && */ButtonId.HasValue) { Flags[1] = true; }
        if (Url != null) { Flags[2] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[1]) { writer.Write(Peer); }
        if (Flags[1]) { writer.Write(MsgId.Value); }
        if (Flags[1]) { writer.Write(ButtonId.Value); }
        if (Flags[2]) { writer.Write(Url); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { Peer = reader.Read<MyTelegram.Schema.IInputPeer>(); }
        if (Flags[1]) { MsgId = reader.ReadInt32(); }
        if (Flags[1]) { ButtonId = reader.ReadInt32(); }
        if (Flags[2]) { Url = reader.ReadString(); }
    }
}

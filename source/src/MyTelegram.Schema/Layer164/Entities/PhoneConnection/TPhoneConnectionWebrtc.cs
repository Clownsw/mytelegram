﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// WebRTC connection parameters
/// See <a href="https://corefork.telegram.org/constructor/phoneConnectionWebrtc" />
///</summary>
[TlObject(0x635fe375)]
public sealed class TPhoneConnectionWebrtc : IPhoneConnection
{
    public uint ConstructorId => 0x635fe375;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether this is a TURN endpoint
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Turn { get; set; }

    ///<summary>
    /// Whether this is a STUN endpoint
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Stun { get; set; }

    ///<summary>
    /// Endpoint ID
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// IP address
    ///</summary>
    public string Ip { get; set; }

    ///<summary>
    /// IPv6 address
    ///</summary>
    public string Ipv6 { get; set; }

    ///<summary>
    /// Port
    ///</summary>
    public int Port { get; set; }

    ///<summary>
    /// Username
    ///</summary>
    public string Username { get; set; }

    ///<summary>
    /// Password
    ///</summary>
    public string Password { get; set; }

    public void ComputeFlag()
    {
        if (Turn) { Flags[0] = true; }
        if (Stun) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        writer.Write(Ip);
        writer.Write(Ipv6);
        writer.Write(Port);
        writer.Write(Username);
        writer.Write(Password);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Turn = true; }
        if (Flags[1]) { Stun = true; }
        Id = reader.ReadInt64();
        Ip = reader.ReadString();
        Ipv6 = reader.ReadString();
        Port = reader.ReadInt32();
        Username = reader.ReadString();
        Password = reader.ReadString();
    }
}
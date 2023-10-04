﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contains information about a username.
/// See <a href="https://corefork.telegram.org/constructor/username" />
///</summary>
[TlObject(0xb4073647)]
public sealed class TUsername : IUsername
{
    public uint ConstructorId => 0xb4073647;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the username is editable, meaning it wasn't bought on <a href="https://fragment.com/">fragment</a>.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Editable { get; set; }

    ///<summary>
    /// Whether the username is active.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Active { get; set; }

    ///<summary>
    /// The username.
    ///</summary>
    public string Username { get; set; }

    public void ComputeFlag()
    {
        if (Editable) { Flags[0] = true; }
        if (Active) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Username);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Editable = true; }
        if (Flags[1]) { Active = true; }
        Username = reader.ReadString();
    }
}
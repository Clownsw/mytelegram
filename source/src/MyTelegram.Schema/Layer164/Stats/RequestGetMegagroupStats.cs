﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stats;

///<summary>
/// Get <a href="https://corefork.telegram.org/api/stats">supergroup statistics</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 403 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 MEGAGROUP_REQUIRED You can only use this method on a supergroup.
/// See <a href="https://corefork.telegram.org/method/stats.getMegagroupStats" />
///</summary>
[TlObject(0xdcdf8607)]
public sealed class RequestGetMegagroupStats : IRequest<MyTelegram.Schema.Stats.IMegagroupStats>
{
    public uint ConstructorId => 0xdcdf8607;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to enable dark theme for graph colors
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Dark { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/channel">Supergroup ID</a>
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    public void ComputeFlag()
    {
        if (Dark) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Channel);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Dark = true; }
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
    }
}

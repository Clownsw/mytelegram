﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// Finish account takeout session
/// <para>Possible errors</para>
/// Code Type Description
/// 403 TAKEOUT_REQUIRED A takeout session has to be initialized, first.
/// See <a href="https://corefork.telegram.org/method/account.finishTakeoutSession" />
///</summary>
[TlObject(0x1d2652ee)]
public sealed class RequestFinishTakeoutSession : IRequest<IBool>
{
    public uint ConstructorId => 0x1d2652ee;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Data exported successfully
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Success { get; set; }

    public void ComputeFlag()
    {
        if (Success) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Success = true; }
    }
}

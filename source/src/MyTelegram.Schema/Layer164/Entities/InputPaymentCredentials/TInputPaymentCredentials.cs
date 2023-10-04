﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Payment credentials
/// See <a href="https://corefork.telegram.org/constructor/inputPaymentCredentials" />
///</summary>
[TlObject(0x3417d728)]
public sealed class TInputPaymentCredentials : IInputPaymentCredentials
{
    public uint ConstructorId => 0x3417d728;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Save payment credential for future use
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Save { get; set; }

    ///<summary>
    /// Payment credentials
    /// See <a href="https://corefork.telegram.org/type/DataJSON" />
    ///</summary>
    public MyTelegram.Schema.IDataJSON Data { get; set; }

    public void ComputeFlag()
    {
        if (Save) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Data);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Save = true; }
        Data = reader.Read<MyTelegram.Schema.IDataJSON>();
    }
}
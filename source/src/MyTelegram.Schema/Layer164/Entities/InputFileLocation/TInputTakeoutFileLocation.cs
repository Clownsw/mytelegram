﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Empty constructor for takeout
/// See <a href="https://corefork.telegram.org/constructor/inputTakeoutFileLocation" />
///</summary>
[TlObject(0x29be5899)]
public sealed class TInputTakeoutFileLocation : IInputFileLocation
{
    public uint ConstructorId => 0x29be5899;


    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// No new <a href="https://corefork.telegram.org/api/wallpapers">wallpapers</a> were found
/// See <a href="https://corefork.telegram.org/constructor/account.wallPapersNotModified" />
///</summary>
[TlObject(0x1c199183)]
public sealed class TWallPapersNotModified : IWallPapers
{
    public uint ConstructorId => 0x1c199183;


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
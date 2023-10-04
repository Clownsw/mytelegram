﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// Installed <a href="https://corefork.telegram.org/api/wallpapers">wallpapers</a>
/// See <a href="https://corefork.telegram.org/constructor/account.wallPapers" />
///</summary>
[TlObject(0xcdc3858c)]
public sealed class TWallPapers : IWallPapers
{
    public uint ConstructorId => 0xcdc3858c;
    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash for pagination, for more info click here</a>
    ///</summary>
    public long Hash { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/wallpapers">Wallpapers</a>
    ///</summary>
    public TVector<MyTelegram.Schema.IWallPaper> Wallpapers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Hash);
        writer.Write(Wallpapers);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Hash = reader.ReadInt64();
        Wallpapers = reader.Read<TVector<MyTelegram.Schema.IWallPaper>>();
    }
}
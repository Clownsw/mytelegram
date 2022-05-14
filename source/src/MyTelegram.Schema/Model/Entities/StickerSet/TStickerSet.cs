﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/stickerSet" />
///</summary>
[TlObject(0xd7df217a)]
public class TStickerSet : IStickerSet
{
    public uint ConstructorId => 0xd7df217a;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Archived { get; set; }
    public bool Official { get; set; }
    public bool Masks { get; set; }
    public bool Animated { get; set; }
    public bool Videos { get; set; }
    public int? InstalledDate { get; set; }
    public long Id { get; set; }
    public long AccessHash { get; set; }
    public string Title { get; set; }
    public string ShortName { get; set; }
    public TVector<MyTelegram.Schema.IPhotoSize>? Thumbs { get; set; }
    public int? ThumbDcId { get; set; }
    public int? ThumbVersion { get; set; }
    public int Count { get; set; }
    public int Hash { get; set; }

    public void ComputeFlag()
    {
        if (Archived) { Flags[1] = true; }
        if (Official) { Flags[2] = true; }
        if (Masks) { Flags[3] = true; }
        if (Animated) { Flags[5] = true; }
        if (Videos) { Flags[6] = true; }
        if (InstalledDate != 0 && InstalledDate.HasValue) { Flags[0] = true; }
        if (Thumbs?.Count > 0) { Flags[4] = true; }
        if (ThumbDcId != 0 && ThumbDcId.HasValue) { Flags[4] = true; }
        if (ThumbVersion != 0 && ThumbVersion.HasValue) { Flags[4] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { bw.Write(InstalledDate.Value); }
        bw.Write(Id);
        bw.Write(AccessHash);
        bw.Serialize(Title);
        bw.Serialize(ShortName);
        if (Flags[4]) { Thumbs.Serialize(bw); }
        if (Flags[4]) { bw.Write(ThumbDcId.Value); }
        if (Flags[4]) { bw.Write(ThumbVersion.Value); }
        bw.Write(Count);
        bw.Write(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { Archived = true; }
        if (Flags[2]) { Official = true; }
        if (Flags[3]) { Masks = true; }
        if (Flags[5]) { Animated = true; }
        if (Flags[6]) { Videos = true; }
        if (Flags[0]) { InstalledDate = br.ReadInt32(); }
        Id = br.ReadInt64();
        AccessHash = br.ReadInt64();
        Title = br.Deserialize<string>();
        ShortName = br.Deserialize<string>();
        if (Flags[4]) { Thumbs = br.Deserialize<TVector<MyTelegram.Schema.IPhotoSize>>(); }
        if (Flags[4]) { ThumbDcId = br.ReadInt32(); }
        if (Flags[4]) { ThumbVersion = br.ReadInt32(); }
        Count = br.ReadInt32();
        Hash = br.ReadInt32();
    }
}
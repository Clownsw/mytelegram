﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/peerNotifySettings" />
///</summary>
[TlObject(0xaf509d20)]
public class TPeerNotifySettings : IPeerNotifySettings
{
    public uint ConstructorId => 0xaf509d20;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool? ShowPreviews { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool? Silent { get; set; }
    public int? MuteUntil { get; set; }
    public string? Sound { get; set; }

    public void ComputeFlag()
    {
        if (ShowPreviews !=null) { Flags[0] = true; }
        if (Silent !=null) { Flags[1] = true; }
        //if (MuteUntil != 0 && MuteUntil.HasValue) { Flags[2] = true; }
        if (MuteUntil.HasValue) { Flags[2] = true; }
        if (Sound != null) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { bw.Serialize(ShowPreviews.Value); }
        if (Flags[1]) { bw.Serialize(Silent.Value); }
        if (Flags[2]) { bw.Write(MuteUntil.Value); }
        if (Flags[3]) { bw.Serialize(Sound); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { ShowPreviews = br.Deserialize<bool>(); }
        if (Flags[1]) { Silent = br.Deserialize<bool>(); }
        if (Flags[2]) { MuteUntil = br.ReadInt32(); }
        if (Flags[3]) { Sound = br.Deserialize<string>(); }
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/replyKeyboardMarkup" />
///</summary>
[TlObject(0x85dd99d1)]
public class TReplyKeyboardMarkup : IReplyMarkup
{
    public uint ConstructorId => 0x85dd99d1;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Resize { get; set; }
    public bool SingleUse { get; set; }
    public bool Selective { get; set; }
    public TVector<MyTelegram.Schema.IKeyboardButtonRow> Rows { get; set; }
    public string? Placeholder { get; set; }

    public void ComputeFlag()
    {
        if (Resize) { Flags[0] = true; }
        if (SingleUse) { Flags[1] = true; }
        if (Selective) { Flags[2] = true; }
        if (Placeholder != null) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Rows.Serialize(bw);
        if (Flags[3]) { bw.Serialize(Placeholder); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Resize = true; }
        if (Flags[1]) { SingleUse = true; }
        if (Flags[2]) { Selective = true; }
        Rows = br.Deserialize<TVector<MyTelegram.Schema.IKeyboardButtonRow>>();
        if (Flags[3]) { Placeholder = br.Deserialize<string>(); }
    }
}
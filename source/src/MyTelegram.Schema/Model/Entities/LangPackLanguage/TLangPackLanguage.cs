﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/langPackLanguage" />
///</summary>
[TlObject(0xeeca5ce3)]
public class TLangPackLanguage : ILangPackLanguage
{
    public uint ConstructorId => 0xeeca5ce3;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Official { get; set; }
    public bool Rtl { get; set; }
    public bool Beta { get; set; }
    public string Name { get; set; }
    public string NativeName { get; set; }
    public string LangCode { get; set; }
    public string? BaseLangCode { get; set; }
    public string PluralCode { get; set; }
    public int StringsCount { get; set; }
    public int TranslatedCount { get; set; }
    public string TranslationsUrl { get; set; }

    public void ComputeFlag()
    {
        if (Official) { Flags[0] = true; }
        if (Rtl) { Flags[2] = true; }
        if (Beta) { Flags[3] = true; }
        if (BaseLangCode != null) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Name);
        bw.Serialize(NativeName);
        bw.Serialize(LangCode);
        if (Flags[1]) { bw.Serialize(BaseLangCode); }
        bw.Serialize(PluralCode);
        bw.Write(StringsCount);
        bw.Write(TranslatedCount);
        bw.Serialize(TranslationsUrl);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Official = true; }
        if (Flags[2]) { Rtl = true; }
        if (Flags[3]) { Beta = true; }
        Name = br.Deserialize<string>();
        NativeName = br.Deserialize<string>();
        LangCode = br.Deserialize<string>();
        if (Flags[1]) { BaseLangCode = br.Deserialize<string>(); }
        PluralCode = br.Deserialize<string>();
        StringsCount = br.ReadInt32();
        TranslatedCount = br.ReadInt32();
        TranslationsUrl = br.Deserialize<string>();
    }
}
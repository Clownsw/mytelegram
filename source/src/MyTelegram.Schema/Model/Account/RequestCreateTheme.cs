﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.createTheme" />
///</summary>
[TlObject(0x652e4400)]
public sealed class RequestCreateTheme : IRequest<MyTelegram.Schema.ITheme>
{
    public uint ConstructorId => 0x652e4400;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string Slug { get; set; }
    public string Title { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputDocument" />
    ///</summary>
    public MyTelegram.Schema.IInputDocument? Document { get; set; }
    public TVector<MyTelegram.Schema.IInputThemeSettings>? Settings { get; set; }

    public void ComputeFlag()
    {
        if (Document != null) { Flags[2] = true; }
        if (Settings?.Count > 0) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Slug);
        bw.Serialize(Title);
        if (Flags[2]) { Document.Serialize(bw); }
        if (Flags[3]) { Settings.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Slug = br.Deserialize<string>();
        Title = br.Deserialize<string>();
        if (Flags[2]) { Document = br.Deserialize<MyTelegram.Schema.IInputDocument>(); }
        if (Flags[3]) { Settings = br.Deserialize<TVector<MyTelegram.Schema.IInputThemeSettings>>(); }
    }
}

﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Page theme
/// See <a href="https://corefork.telegram.org/constructor/webPageAttributeTheme" />
///</summary>
[TlObject(0x54b56617)]
public sealed class TWebPageAttributeTheme : IWebPageAttribute
{
    public uint ConstructorId => 0x54b56617;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Theme files
    ///</summary>
    public TVector<MyTelegram.Schema.IDocument>? Documents { get; set; }

    ///<summary>
    /// Theme settings
    /// See <a href="https://corefork.telegram.org/type/ThemeSettings" />
    ///</summary>
    public MyTelegram.Schema.IThemeSettings? Settings { get; set; }

    public void ComputeFlag()
    {
        if (Documents?.Count > 0) { Flags[0] = true; }
        if (Settings != null) { Flags[1] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[0]) { writer.Write(Documents); }
        if (Flags[1]) { writer.Write(Settings); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Documents = reader.Read<TVector<MyTelegram.Schema.IDocument>>(); }
        if (Flags[1]) { Settings = reader.Read<MyTelegram.Schema.IThemeSettings>(); }
    }
}
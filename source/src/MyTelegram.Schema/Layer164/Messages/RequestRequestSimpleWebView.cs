﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Open a <a href="https://corefork.telegram.org/api/bots/webapps">bot web app</a>.
/// See <a href="https://corefork.telegram.org/method/messages.requestSimpleWebView" />
///</summary>
[TlObject(0x1a46500a)]
public sealed class RequestRequestSimpleWebView : IRequest<MyTelegram.Schema.ISimpleWebViewResult>
{
    public uint ConstructorId => 0x1a46500a;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the webapp was opened by clicking on the <code>switch_webview</code> button shown on top of the inline results list returned by <a href="https://corefork.telegram.org/method/messages.getInlineBotResults">messages.getInlineBotResults</a>.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool FromSwitchWebview { get; set; }
    public bool FromSideMenu { get; set; }

    ///<summary>
    /// Bot that owns the webapp
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser Bot { get; set; }

    ///<summary>
    /// Web app URL
    ///</summary>
    public string? Url { get; set; }
    public string? StartParam { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/bots/webapps#theme-parameters">Theme parameters »</a>
    /// See <a href="https://corefork.telegram.org/type/DataJSON" />
    ///</summary>
    public MyTelegram.Schema.IDataJSON? ThemeParams { get; set; }

    ///<summary>
    /// Short name of the application; 0-64 English letters, digits, and underscores
    ///</summary>
    public string Platform { get; set; }

    public void ComputeFlag()
    {
        if (FromSwitchWebview) { Flags[1] = true; }
        if (FromSideMenu) { Flags[2] = true; }
        if (Url != null) { Flags[3] = true; }
        if (StartParam != null) { Flags[4] = true; }
        if (ThemeParams != null) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Bot);
        if (Flags[3]) { writer.Write(Url); }
        if (Flags[4]) { writer.Write(StartParam); }
        if (Flags[0]) { writer.Write(ThemeParams); }
        writer.Write(Platform);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { FromSwitchWebview = true; }
        if (Flags[2]) { FromSideMenu = true; }
        Bot = reader.Read<MyTelegram.Schema.IInputUser>();
        if (Flags[3]) { Url = reader.ReadString(); }
        if (Flags[4]) { StartParam = reader.ReadString(); }
        if (Flags[0]) { ThemeParams = reader.Read<MyTelegram.Schema.IDataJSON>(); }
        Platform = reader.ReadString();
    }
}

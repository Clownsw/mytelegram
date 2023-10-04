﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contains information about a <a href="https://corefork.telegram.org/api/bots/webapps#named-bot-web-apps">named bot web app</a>.
/// See <a href="https://corefork.telegram.org/constructor/botApp" />
///</summary>
[TlObject(0x95fcd1d6)]
public sealed class TBotApp : IBotApp
{
    public uint ConstructorId => 0x95fcd1d6;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Bot web app ID
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// Bot web app access hash
    ///</summary>
    public long AccessHash { get; set; }

    ///<summary>
    /// Bot web app short name, used to generate <a href="https://corefork.telegram.org/api/links#named-bot-web-app-links">named bot web app deep links</a>.
    ///</summary>
    public string ShortName { get; set; }

    ///<summary>
    /// Bot web app title.
    ///</summary>
    public string Title { get; set; }

    ///<summary>
    /// Bot web app description.
    ///</summary>
    public string Description { get; set; }

    ///<summary>
    /// Bot web app photo.
    /// See <a href="https://corefork.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto Photo { get; set; }

    ///<summary>
    /// Bot web app animation.
    /// See <a href="https://corefork.telegram.org/type/Document" />
    ///</summary>
    public MyTelegram.Schema.IDocument? Document { get; set; }

    ///<summary>
    /// Hash to pass to <a href="https://corefork.telegram.org/method/messages.getBotApp">messages.getBotApp</a>, to avoid refetching bot app info if it hasn't changed.
    ///</summary>
    public long Hash { get; set; }

    public void ComputeFlag()
    {
        if (Document != null) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        writer.Write(AccessHash);
        writer.Write(ShortName);
        writer.Write(Title);
        writer.Write(Description);
        writer.Write(Photo);
        if (Flags[0]) { writer.Write(Document); }
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Id = reader.ReadInt64();
        AccessHash = reader.ReadInt64();
        ShortName = reader.ReadString();
        Title = reader.ReadString();
        Description = reader.ReadString();
        Photo = reader.Read<MyTelegram.Schema.IPhoto>();
        if (Flags[0]) { Document = reader.Read<MyTelegram.Schema.IDocument>(); }
        Hash = reader.ReadInt64();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Deleted emoji keyword
/// See <a href="https://corefork.telegram.org/constructor/emojiKeywordDeleted" />
///</summary>
[TlObject(0x236df622)]
public sealed class TEmojiKeywordDeleted : IEmojiKeyword
{
    public uint ConstructorId => 0x236df622;
    ///<summary>
    /// Keyword
    ///</summary>
    public string Keyword { get; set; }

    ///<summary>
    /// Emojis that were associated to keyword
    ///</summary>
    public TVector<string> Emoticons { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Keyword);
        writer.Write(Emoticons);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Keyword = reader.ReadString();
        Emoticons = reader.Read<TVector<string>>();
    }
}
﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Force the user to send a reply
/// See <a href="https://corefork.telegram.org/constructor/replyKeyboardForceReply" />
///</summary>
[TlObject(0x86b40b08)]
public sealed class TReplyKeyboardForceReply : IReplyMarkup
{
    public uint ConstructorId => 0x86b40b08;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Requests clients to hide the keyboard as soon as it's been used. The keyboard will still be available, but clients will automatically display the usual letter-keyboard in the chat – the user can press a special button in the input field to see the custom keyboard again.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool SingleUse { get; set; }

    ///<summary>
    /// Use this parameter if you want to show the keyboard to specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message. <br>Example: A user requests to change the bot's language, bot replies to the request with a keyboard to select the new language. Other users in the group don't see the keyboard.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Selective { get; set; }

    ///<summary>
    /// The placeholder to be shown in the input field when the keyboard is active; 1-64 characters.
    ///</summary>
    public string? Placeholder { get; set; }

    public void ComputeFlag()
    {
        if (SingleUse) { Flags[1] = true; }
        if (Selective) { Flags[2] = true; }
        if (Placeholder != null) { Flags[3] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[3]) { writer.Write(Placeholder); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { SingleUse = true; }
        if (Flags[2]) { Selective = true; }
        if (Flags[3]) { Placeholder = reader.ReadString(); }
    }
}
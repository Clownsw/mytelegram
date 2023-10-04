﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Button to request a user's geolocation
/// See <a href="https://corefork.telegram.org/constructor/keyboardButtonRequestGeoLocation" />
///</summary>
[TlObject(0xfc796b3f)]
public sealed class TKeyboardButtonRequestGeoLocation : IKeyboardButton
{
    public uint ConstructorId => 0xfc796b3f;
    ///<summary>
    /// Button text
    ///</summary>
    public string Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Text);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Text = reader.ReadString();
    }
}
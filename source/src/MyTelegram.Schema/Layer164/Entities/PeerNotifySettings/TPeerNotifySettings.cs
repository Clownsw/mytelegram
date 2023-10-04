﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Notification settings.
/// See <a href="https://corefork.telegram.org/constructor/peerNotifySettings" />
///</summary>
[TlObject(0x99622c0c)]
public sealed class TPeerNotifySettings : IPeerNotifySettings
{
    public uint ConstructorId => 0x99622c0c;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// (Ternary value) If set, indicates whether or not to display previews of messages in notifications; otherwise the default behavior should be used.
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool? ShowPreviews { get; set; }

    ///<summary>
    /// (Ternary value) If set, indicates whether to mute or unmute the peer; otherwise the default behavior should be used.
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool? Silent { get; set; }

    ///<summary>
    /// Mute all notifications until this date
    ///</summary>
    public int? MuteUntil { get; set; }

    ///<summary>
    /// Notification sound for the official iOS application
    /// See <a href="https://corefork.telegram.org/type/NotificationSound" />
    ///</summary>
    public MyTelegram.Schema.INotificationSound? IosSound { get; set; }

    ///<summary>
    /// Notification sound for the official android application
    /// See <a href="https://corefork.telegram.org/type/NotificationSound" />
    ///</summary>
    public MyTelegram.Schema.INotificationSound? AndroidSound { get; set; }

    ///<summary>
    /// Notification sound for other applications
    /// See <a href="https://corefork.telegram.org/type/NotificationSound" />
    ///</summary>
    public MyTelegram.Schema.INotificationSound? OtherSound { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool? StoriesMuted { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool? StoriesHideSender { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/NotificationSound" />
    ///</summary>
    public MyTelegram.Schema.INotificationSound? StoriesIosSound { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/NotificationSound" />
    ///</summary>
    public MyTelegram.Schema.INotificationSound? StoriesAndroidSound { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/NotificationSound" />
    ///</summary>
    public MyTelegram.Schema.INotificationSound? StoriesOtherSound { get; set; }

    public void ComputeFlag()
    {
        if (ShowPreviews !=null) { Flags[0] = true; }
        if (Silent !=null) { Flags[1] = true; }
        if (/*MuteUntil != 0 && */MuteUntil.HasValue) { Flags[2] = true; }
        if (IosSound != null) { Flags[3] = true; }
        if (AndroidSound != null) { Flags[4] = true; }
        if (OtherSound != null) { Flags[5] = true; }
        if (StoriesMuted !=null) { Flags[6] = true; }
        if (StoriesHideSender !=null) { Flags[7] = true; }
        if (StoriesIosSound != null) { Flags[8] = true; }
        if (StoriesAndroidSound != null) { Flags[9] = true; }
        if (StoriesOtherSound != null) { Flags[10] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[0]) { writer.Write(ShowPreviews.Value); }
        if (Flags[1]) { writer.Write(Silent.Value); }
        if (Flags[2]) { writer.Write(MuteUntil.Value); }
        if (Flags[3]) { writer.Write(IosSound); }
        if (Flags[4]) { writer.Write(AndroidSound); }
        if (Flags[5]) { writer.Write(OtherSound); }
        if (Flags[6]) { writer.Write(StoriesMuted.Value); }
        if (Flags[7]) { writer.Write(StoriesHideSender.Value); }
        if (Flags[8]) { writer.Write(StoriesIosSound); }
        if (Flags[9]) { writer.Write(StoriesAndroidSound); }
        if (Flags[10]) { writer.Write(StoriesOtherSound); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { ShowPreviews = reader.Read(); }
        if (Flags[1]) { Silent = reader.Read(); }
        if (Flags[2]) { MuteUntil = reader.ReadInt32(); }
        if (Flags[3]) { IosSound = reader.Read<MyTelegram.Schema.INotificationSound>(); }
        if (Flags[4]) { AndroidSound = reader.Read<MyTelegram.Schema.INotificationSound>(); }
        if (Flags[5]) { OtherSound = reader.Read<MyTelegram.Schema.INotificationSound>(); }
        if (Flags[6]) { StoriesMuted = reader.Read(); }
        if (Flags[7]) { StoriesHideSender = reader.Read(); }
        if (Flags[8]) { StoriesIosSound = reader.Read<MyTelegram.Schema.INotificationSound>(); }
        if (Flags[9]) { StoriesAndroidSound = reader.Read<MyTelegram.Schema.INotificationSound>(); }
        if (Flags[10]) { StoriesOtherSound = reader.Read<MyTelegram.Schema.INotificationSound>(); }
    }
}
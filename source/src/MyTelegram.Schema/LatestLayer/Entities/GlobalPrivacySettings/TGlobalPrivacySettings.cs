﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Global privacy settings
/// See <a href="https://corefork.telegram.org/constructor/globalPrivacySettings" />
///</summary>
[TlObject(0x734c4ccb)]
public sealed class TGlobalPrivacySettings : IGlobalPrivacySettings
{
    public uint ConstructorId => 0x734c4ccb;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether to archive and mute new chats from non-contacts
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool ArchiveAndMuteNewNoncontactPeers { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool KeepArchivedUnmuted { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool KeepArchivedFolders { get; set; }

    public void ComputeFlag()
    {
        if (ArchiveAndMuteNewNoncontactPeers) { Flags[0] = true; }
        if (KeepArchivedUnmuted) { Flags[1] = true; }
        if (KeepArchivedFolders) { Flags[2] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { ArchiveAndMuteNewNoncontactPeers = true; }
        if (Flags[1]) { KeepArchivedUnmuted = true; }
        if (Flags[2]) { KeepArchivedFolders = true; }
    }
}
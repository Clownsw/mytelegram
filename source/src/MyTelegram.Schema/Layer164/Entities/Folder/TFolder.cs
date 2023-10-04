﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Folder
/// See <a href="https://corefork.telegram.org/constructor/folder" />
///</summary>
[TlObject(0xff544e65)]
public sealed class TFolder : IFolder
{
    public uint ConstructorId => 0xff544e65;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Automatically add new channels to this folder
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool AutofillNewBroadcasts { get; set; }

    ///<summary>
    /// Automatically add joined new public supergroups to this folder
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool AutofillPublicGroups { get; set; }

    ///<summary>
    /// Automatically add new private chats to this folder
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool AutofillNewCorrespondents { get; set; }

    ///<summary>
    /// Folder ID
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// Folder title
    ///</summary>
    public string Title { get; set; }

    ///<summary>
    /// Folder picture
    /// See <a href="https://corefork.telegram.org/type/ChatPhoto" />
    ///</summary>
    public MyTelegram.Schema.IChatPhoto? Photo { get; set; }

    public void ComputeFlag()
    {
        if (AutofillNewBroadcasts) { Flags[0] = true; }
        if (AutofillPublicGroups) { Flags[1] = true; }
        if (AutofillNewCorrespondents) { Flags[2] = true; }
        if (Photo != null) { Flags[3] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        writer.Write(Title);
        if (Flags[3]) { writer.Write(Photo); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { AutofillNewBroadcasts = true; }
        if (Flags[1]) { AutofillPublicGroups = true; }
        if (Flags[2]) { AutofillNewCorrespondents = true; }
        Id = reader.ReadInt32();
        Title = reader.ReadString();
        if (Flags[3]) { Photo = reader.Read<MyTelegram.Schema.IChatPhoto>(); }
    }
}
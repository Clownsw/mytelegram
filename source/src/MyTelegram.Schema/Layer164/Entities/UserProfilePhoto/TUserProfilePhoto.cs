﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// User profile photo.
/// See <a href="https://corefork.telegram.org/constructor/userProfilePhoto" />
///</summary>
[TlObject(0x82d1f706)]
public sealed class TUserProfilePhoto : IUserProfilePhoto
{
    public uint ConstructorId => 0x82d1f706;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether an <a href="https://corefork.telegram.org/api/files#animated-profile-pictures">animated profile picture</a> is available for this user
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool HasVideo { get; set; }

    ///<summary>
    /// Whether this profile photo is only visible to us (i.e. it was set using <a href="https://corefork.telegram.org/method/photos.uploadContactProfilePhoto">photos.uploadContactProfilePhoto</a>).
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Personal { get; set; }

    ///<summary>
    /// Identifier of the respective photo
    ///</summary>
    public long PhotoId { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/files#stripped-thumbnails">Stripped thumbnail</a>
    ///</summary>
    public byte[]? StrippedThumb { get; set; }

    ///<summary>
    /// DC ID where the photo is stored
    ///</summary>
    public int DcId { get; set; }

    public void ComputeFlag()
    {
        if (HasVideo) { Flags[0] = true; }
        if (Personal) { Flags[2] = true; }
        if (StrippedThumb != null) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(PhotoId);
        if (Flags[1]) { writer.Write(StrippedThumb); }
        writer.Write(DcId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { HasVideo = true; }
        if (Flags[2]) { Personal = true; }
        PhotoId = reader.ReadInt64();
        if (Flags[1]) { StrippedThumb = reader.ReadBytes(); }
        DcId = reader.ReadInt32();
    }
}
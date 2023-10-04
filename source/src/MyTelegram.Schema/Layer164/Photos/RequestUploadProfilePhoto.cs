﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Photos;

///<summary>
/// Updates current user profile photo.The <code>file</code>, <code>video</code> and <code>video_emoji_markup</code> flags are mutually exclusive.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 ALBUM_PHOTOS_TOO_MANY You have uploaded too many profile photos, delete some before retrying.
/// 400 EMOJI_MARKUP_INVALID The specified <code>video_emoji_markup</code> was invalid.
/// 400 FILE_PARTS_INVALID The number of file parts is invalid.
/// 400 IMAGE_PROCESS_FAILED Failure while processing image.
/// 400 PHOTO_CROP_FILE_MISSING Photo crop file missing.
/// 400 PHOTO_CROP_SIZE_SMALL Photo is too small.
/// 400 PHOTO_EXT_INVALID The extension of the photo is invalid.
/// 400 PHOTO_FILE_MISSING Profile photo file missing.
/// 400 PHOTO_INVALID Photo invalid.
/// 400 STICKER_MIME_INVALID The specified sticker MIME type is invalid.
/// 400 VIDEO_FILE_INVALID The specified video file is invalid.
/// See <a href="https://corefork.telegram.org/method/photos.uploadProfilePhoto" />
///</summary>
[TlObject(0x388a3b5)]
public sealed class RequestUploadProfilePhoto : IRequest<MyTelegram.Schema.Photos.IPhoto>
{
    public uint ConstructorId => 0x388a3b5;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// If set, the chosen profile photo will be shown to users that can't display your main profile photo due to your privacy settings.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Fallback { get; set; }

    ///<summary>
    /// Can contain info of a bot we own, to change the profile photo of that bot, instead of the current user.
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser? Bot { get; set; }

    ///<summary>
    /// Profile photo
    /// See <a href="https://corefork.telegram.org/type/InputFile" />
    ///</summary>
    public MyTelegram.Schema.IInputFile? File { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/files#animated-profile-pictures">Animated profile picture</a> video
    /// See <a href="https://corefork.telegram.org/type/InputFile" />
    ///</summary>
    public MyTelegram.Schema.IInputFile? Video { get; set; }

    ///<summary>
    /// Floating point UNIX timestamp in seconds, indicating the frame of the video/sticker that should be used as static preview; can only be used if <code>video</code> or <code>video_emoji_markup</code> is set.
    ///</summary>
    public double? VideoStartTs { get; set; }

    ///<summary>
    /// Animated sticker profile picture, must contain either a <a href="https://corefork.telegram.org/constructor/videoSizeEmojiMarkup">videoSizeEmojiMarkup</a> or a <a href="https://corefork.telegram.org/constructor/videoSizeStickerMarkup">videoSizeStickerMarkup</a> constructor.
    /// See <a href="https://corefork.telegram.org/type/VideoSize" />
    ///</summary>
    public MyTelegram.Schema.IVideoSize? VideoEmojiMarkup { get; set; }

    public void ComputeFlag()
    {
        if (Fallback) { Flags[3] = true; }
        if (Bot != null) { Flags[5] = true; }
        if (File != null) { Flags[0] = true; }
        if (Video != null) { Flags[1] = true; }
        if (VideoStartTs>0) { Flags[2] = true; }
        if (VideoEmojiMarkup != null) { Flags[4] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[5]) { writer.Write(Bot); }
        if (Flags[0]) { writer.Write(File); }
        if (Flags[1]) { writer.Write(Video); }
        if (Flags[2]) { writer.Write(VideoStartTs.Value); }
        if (Flags[4]) { writer.Write(VideoEmojiMarkup); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[3]) { Fallback = true; }
        if (Flags[5]) { Bot = reader.Read<MyTelegram.Schema.IInputUser>(); }
        if (Flags[0]) { File = reader.Read<MyTelegram.Schema.IInputFile>(); }
        if (Flags[1]) { Video = reader.Read<MyTelegram.Schema.IInputFile>(); }
        if (Flags[2]) { VideoStartTs = reader.ReadDouble(); }
        if (Flags[4]) { VideoEmojiMarkup = reader.Read<MyTelegram.Schema.IVideoSize>(); }
    }
}

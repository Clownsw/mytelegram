﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Langpack.LayerN;

///<summary>
/// Get information about all languages in a localization pack
/// <para>Possible errors</para>
/// Code Type Description
/// 400 LANG_PACK_INVALID The provided language pack is invalid.
/// See <a href="https://corefork.telegram.org/method/langpack.getLanguages" />
///</summary>
[TlObject(0x800fd57d)]
public sealed class RequestGetLanguages : IRequest<TVector<ILangPackLanguage>>
{
    public uint ConstructorId => 0x800fd57d;

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}

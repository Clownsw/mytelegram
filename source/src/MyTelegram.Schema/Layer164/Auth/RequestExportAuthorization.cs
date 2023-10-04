﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;

///<summary>
/// Returns data for copying authorization to another data-center.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 DC_ID_INVALID The provided DC ID is invalid.
/// See <a href="https://corefork.telegram.org/method/auth.exportAuthorization" />
///</summary>
[TlObject(0xe5bfffcd)]
public sealed class RequestExportAuthorization : IRequest<MyTelegram.Schema.Auth.IExportedAuthorization>
{
    public uint ConstructorId => 0xe5bfffcd;
    ///<summary>
    /// Number of a target data-center
    ///</summary>
    public int DcId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(DcId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        DcId = reader.ReadInt32();
    }
}

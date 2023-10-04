﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
/// Check whether the group call Server Forwarding Unit is currently receiving the streams with the specified WebRTC source IDs.<br>
/// Returns an intersection of the source IDs specified in <code>sources</code>, and the source IDs currently being forwarded by the SFU.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 GROUPCALL_JOIN_MISSING You haven't joined this group call.
/// See <a href="https://corefork.telegram.org/method/phone.checkGroupCall" />
///</summary>
[TlObject(0xb59cf977)]
public sealed class RequestCheckGroupCall : IRequest<TVector<int>>
{
    public uint ConstructorId => 0xb59cf977;
    ///<summary>
    /// Group call
    /// See <a href="https://corefork.telegram.org/type/InputGroupCall" />
    ///</summary>
    public MyTelegram.Schema.IInputGroupCall Call { get; set; }

    ///<summary>
    /// Source IDs
    ///</summary>
    public TVector<int> Sources { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Call);
        writer.Write(Sources);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Call = reader.Read<MyTelegram.Schema.IInputGroupCall>();
        Sources = reader.Read<TVector<int>>();
    }
}

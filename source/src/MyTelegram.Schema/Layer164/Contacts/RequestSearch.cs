﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
/// Returns users found by username substring.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 QUERY_TOO_SHORT The query string is too short.
/// 400 SEARCH_QUERY_EMPTY The search query is empty.
/// See <a href="https://corefork.telegram.org/method/contacts.search" />
///</summary>
[TlObject(0x11f812d8)]
public sealed class RequestSearch : IRequest<MyTelegram.Schema.Contacts.IFound>
{
    public uint ConstructorId => 0x11f812d8;
    ///<summary>
    /// Target substring
    ///</summary>
    public string Q { get; set; }

    ///<summary>
    /// Maximum number of users to be returned
    ///</summary>
    public int Limit { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Q);
        writer.Write(Limit);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Q = reader.ReadString();
        Limit = reader.ReadInt32();
    }
}

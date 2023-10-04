﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
/// Info about an update of telegram's terms of service. If the terms of service are declined, then the <a href="https://corefork.telegram.org/method/account.deleteAccount">account.deleteAccount</a> method should be called with the reason "Decline ToS update"
/// See <a href="https://corefork.telegram.org/constructor/help.termsOfServiceUpdate" />
///</summary>
[TlObject(0x28ecf961)]
public sealed class TTermsOfServiceUpdate : ITermsOfServiceUpdate
{
    public uint ConstructorId => 0x28ecf961;
    ///<summary>
    /// New TOS updates will have to be queried using <a href="https://corefork.telegram.org/method/help.getTermsOfServiceUpdate">help.getTermsOfServiceUpdate</a> in <code>expires</code> seconds
    ///</summary>
    public int Expires { get; set; }

    ///<summary>
    /// New terms of service
    /// See <a href="https://corefork.telegram.org/type/help.TermsOfService" />
    ///</summary>
    public MyTelegram.Schema.Help.ITermsOfService TermsOfService { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Expires);
        writer.Write(TermsOfService);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Expires = reader.ReadInt32();
        TermsOfService = reader.Read<MyTelegram.Schema.Help.ITermsOfService>();
    }
}
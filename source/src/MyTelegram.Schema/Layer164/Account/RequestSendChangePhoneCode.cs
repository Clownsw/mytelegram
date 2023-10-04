﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// Verify a new phone number to associate to the current account
/// <para>Possible errors</para>
/// Code Type Description
/// 406 FRESH_CHANGE_PHONE_FORBIDDEN You can't change phone number right after logging in, please wait at least 24 hours.
/// 400 PHONE_NUMBER_BANNED The provided phone number is banned from telegram.
/// 406 PHONE_NUMBER_INVALID The phone number is invalid.
/// 400 PHONE_NUMBER_OCCUPIED The phone number is already in use.
/// See <a href="https://corefork.telegram.org/method/account.sendChangePhoneCode" />
///</summary>
[TlObject(0x82574ae5)]
public sealed class RequestSendChangePhoneCode : IRequest<MyTelegram.Schema.Auth.ISentCode>
{
    public uint ConstructorId => 0x82574ae5;
    ///<summary>
    /// New phone number
    ///</summary>
    public string PhoneNumber { get; set; }

    ///<summary>
    /// Phone code settings
    /// See <a href="https://corefork.telegram.org/type/CodeSettings" />
    ///</summary>
    public MyTelegram.Schema.ICodeSettings Settings { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(PhoneNumber);
        writer.Write(Settings);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        PhoneNumber = reader.ReadString();
        Settings = reader.Read<MyTelegram.Schema.ICodeSettings>();
    }
}

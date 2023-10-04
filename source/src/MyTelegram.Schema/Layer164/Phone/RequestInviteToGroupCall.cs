﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
/// Invite a set of users to a group call.
/// <para>Possible errors</para>
/// Code Type Description
/// 403 GROUPCALL_FORBIDDEN The group call has already ended.
/// 400 GROUPCALL_INVALID The specified group call is invalid.
/// 400 INVITE_FORBIDDEN_WITH_JOINAS If the user has anonymously joined a group call as a channel, they can't invite other users to the group call because that would cause deanonymization, because the invite would be sent using the original user ID, not the anonymized channel ID.
/// 400 USER_ALREADY_INVITED You have already invited this user.
/// See <a href="https://corefork.telegram.org/method/phone.inviteToGroupCall" />
///</summary>
[TlObject(0x7b393160)]
public sealed class RequestInviteToGroupCall : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x7b393160;
    ///<summary>
    /// The group call
    /// See <a href="https://corefork.telegram.org/type/InputGroupCall" />
    ///</summary>
    public MyTelegram.Schema.IInputGroupCall Call { get; set; }

    ///<summary>
    /// The users to invite.
    ///</summary>
    public TVector<MyTelegram.Schema.IInputUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Call);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Call = reader.Read<MyTelegram.Schema.IInputGroupCall>();
        Users = reader.Read<TVector<MyTelegram.Schema.IInputUser>>();
    }
}

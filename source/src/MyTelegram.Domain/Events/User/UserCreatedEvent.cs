﻿namespace MyTelegram.Domain.Events.User;

public class UserCreatedEvent : AggregateEvent<UserAggregate, UserId>
{
    public UserCreatedEvent(
        RequestInfo request,
        long userId,
        long accessHash,
        string phoneNumber,
        string firstName,
        string? lastName,
        bool bot,
        int? botInfoVersion,
        int accountTtl,
        DateTime creationTime
    ) //: base(request)
    {
        Request = request;
        UserId = userId;
        AccessHash = accessHash;
        PhoneNumber = phoneNumber;
        FirstName = firstName;
        LastName = lastName;
        Bot = bot;
        BotInfoVersion = botInfoVersion;
        AccountTtl = accountTtl;
        CreationTime = creationTime;
    }

    public long AccessHash { get; }
    public int AccountTtl { get; }
    public bool Bot { get; }
    public int? BotInfoVersion { get; }
    public DateTime CreationTime { get; }
    public string FirstName { get; }
    public string? LastName { get; }

    public string PhoneNumber { get; }
    public RequestInfo Request { get; }
    public long UserId { get; }
}

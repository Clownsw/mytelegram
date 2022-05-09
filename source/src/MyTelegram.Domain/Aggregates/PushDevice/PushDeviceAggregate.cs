﻿namespace MyTelegram.Domain.Aggregates.PushDevice;

public class PushDeviceAggregate : AggregateRoot<PushDeviceAggregate, PushDeviceId>,
    IApply<PushDeviceRegisteredEvent>,
    IApply<PushDeviceUnRegisteredEvent>
{
    public PushDeviceAggregate(PushDeviceId id) : base(id)
    {
    }

    public void Apply(PushDeviceRegisteredEvent aggregateEvent)
    {
    }

    public void Apply(PushDeviceUnRegisteredEvent aggregateEvent)
    {
    }

    public void RegisterDevice(long reqMsgId,
        long userId,
        long authKeyId,
        int tokenType,
        string token,
        bool noMuted,
        bool appSandbox,
        byte[]? secret,
        IReadOnlyList<long>? otherUids)
    {
        Emit(new PushDeviceRegisteredEvent(reqMsgId,
            userId,
            authKeyId,
            tokenType,
            token,
            noMuted,
            appSandbox,
            secret,
            otherUids));
    }

    public void UnRegisterDevice(long reqMsgId,
        int tokenType,
        string token,
        IReadOnlyList<long> otherUids)
    {
        Specs.AggregateIsCreated.ThrowFirstDomainErrorIfNotSatisfied(this);
        Emit(new PushDeviceUnRegisteredEvent(reqMsgId, tokenType, token, otherUids));
    }
}

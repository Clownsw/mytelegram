﻿namespace MyTelegram.MessengerServer.Services.Impl;

public class ScheduleAppService : IScheduleAppService
{
    private readonly IRandomHelper _randomHelper;

    private readonly HashedWheelTimer _timer = new(TimeSpan.FromMilliseconds(100),
        100000,
        0);

    public ScheduleAppService(IRandomHelper randomHelper)
    {
        _randomHelper = randomHelper;
    }

    public long Execute(Action action,
        TimeSpan timeSpan)
    {
        _timer.NewTimeout(new ActionTimeTask(action), timeSpan);
        return _randomHelper.NextLong();
    }

    public Task ExecuteAsync(Action action,
        TimeSpan timeSpan)
    {
        _timer.NewTimeout(new ActionTimeTask(action), timeSpan);
        return Task.CompletedTask;
    }
}
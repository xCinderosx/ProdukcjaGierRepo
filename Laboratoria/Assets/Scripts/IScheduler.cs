using System;

public interface IScheduler
{
    void ScheduleParameter(float delay, Action action);
}
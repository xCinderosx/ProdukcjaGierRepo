using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoroutineScheduler : MonoBehaviour, IScheduler
{
    public static CoroutineScheduler _instance { get; private set; }

    private void Awake()
    {
        _instance = this;
    }

    public void ScheduleParameter (float delay, Action action)
    {
        Debug.Log("Delay is: " + delay);
        StartCoroutine(RunDelayed(delay, action));
        
    }

    private IEnumerator RunDelayed(float delay, Action action)
    {
        yield return new WaitForSeconds(delay);
        action();
    }
}


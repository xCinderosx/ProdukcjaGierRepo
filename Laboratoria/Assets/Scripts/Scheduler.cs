using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scheduler : MonoBehaviour
{
    public static Scheduler _instance { get; private set; }

    private void Awake()
    {
        _instance = this;
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ScheduleParameter (float delay, string message)
    {
        Debug.Log("Delay is: " + delay);
    }

    private IEnumerator RunDelayed(float delay, string message)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("DelayedAttribute message: " + message);
    }
}


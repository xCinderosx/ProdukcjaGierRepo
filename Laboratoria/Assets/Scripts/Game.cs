using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Game : MonoBehaviour {

    public float delay;
    public List<GameObject> prefabTargets;

	// Use this for initialization
	void Start () {
        Action a = () =>
        {
            
            foreach (var item in prefabTargets)
            { 
                item.active = false;
            }

        };
        Scheduler._instance.ScheduleParameter(delay, a);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

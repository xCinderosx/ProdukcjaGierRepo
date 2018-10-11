using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Scheduler._instance.ScheduleParameter(5);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

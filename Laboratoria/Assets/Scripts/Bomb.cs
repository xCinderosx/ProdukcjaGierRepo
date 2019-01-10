using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class Bomb : MonoBehaviour {

    public Text Text;
    public int Ticks;
    public bool isDetonated = false;
    private IScheduler _scheduler;

    [Inject]
    void Construct(IScheduler scheduler)
    {
        _scheduler = scheduler;
    }
    
    // Use this for initialization
    void Start () {
        Text.text = Ticks.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDetonation()
    {
        if (!isDetonated)
        {
            isDetonated = true;
            _scheduler.ScheduleParameter(1, () =>  DetonationTick());
        }
    }

    void DetonationTick()
    {
        Ticks--;
        Text.text = Ticks.ToString();
        if (Ticks > 0)
        {
            _scheduler.ScheduleParameter(1, () => DetonationTick());
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

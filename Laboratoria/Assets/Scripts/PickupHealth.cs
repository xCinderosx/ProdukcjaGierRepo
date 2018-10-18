using System.Collections;
using System.Collections.Generic;
using PlayerCharacter;
using UnityEngine;
public class PickupHealth : MonoBehaviour, IPickable
{
    public int initialValue = 40;
    [SerializeField] public int pickupValue { get; private set; }

    private void Start()
    {
        pickupValue = initialValue;
    }
    public void Pickup(Character c)
    {
        c.OnPickupEnter(this);
    }
}

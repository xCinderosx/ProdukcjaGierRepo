using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerCharacter;

public class PickupSuperbuff : MonoBehaviour, IPickable
{
    public int initial1Value = 40;
    public int initial2Value = 5;

    [SerializeField] public int pickupHealthValue { get; private set; }
    [SerializeField] public int pickupAmmoValue { get; private set; }

    private void Start()
    {
        pickupHealthValue = initial1Value;
        pickupAmmoValue = initial2Value;
    }
    public void Pickup(Character c)
    {
        c.OnPickupEnter(this);
    }
}

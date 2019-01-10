using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



namespace PlayerCharacter
{

    public class Character : MonoBehaviour
    {

        public int health, ammo, basicHealthRegenValue, basicAmmoPickupValue;
        public bool Invicible = false;

        private void Awake()
        {
            health = 100;
            ammo = 40;
            basicHealthRegenValue = 40;
            basicAmmoPickupValue = 5;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnPickupEnter(PickupHealth pickup)
        {
            health += pickup.pickupValue;
            Destroy(pickup.gameObject);
        }

        public void OnPickupEnter(PickupAmmo pickup)
        {
            ammo += pickup.pickupValue;
            Destroy(pickup.gameObject);
        }

        public void OnPickupEnter(PickupSuperbuff pickup)
        {
            ammo += pickup.pickupAmmoValue;
            health += pickup.pickupHealthValue;
            Invicible = true;
            Action a = () =>
            {
                Invicible = false;
            };
            CoroutineScheduler._instance.ScheduleParameter(5, a);
            Destroy(pickup.gameObject);
        }

        private void OnTriggerEnter(Collider C)
        {

            var pickup = C.GetComponent<IPickable>();
            if (pickup != null)
            {
                pickup.Pickup(this);
            }
        }
    }
}

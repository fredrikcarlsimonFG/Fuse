using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayerTwo : MonoBehaviour
{
        public int healthPlayerTwo = 100;
        public int healthIncrease = 10;
        public int healthDecrease = -10;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "LightHealth" )
            {
                healthPlayerTwo += healthIncrease;
                Debug.Log("Health P1: " + healthPlayerTwo);
            }

            if (collision.gameObject.tag == "Enemy")
            {
                healthPlayerTwo -= healthDecrease;
                Debug.Log("Health P2: " + healthPlayerTwo);
            }

            if (healthPlayerTwo <= 0)
            {
                Destroy(gameObject);
            }
        }
}
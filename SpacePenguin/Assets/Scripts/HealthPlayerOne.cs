using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayerOne : MonoBehaviour
{
        public int healthPlayerOne = 100;
        public int healthIncrease = 10;
        public int healthDecrease = -10;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "LightHealth" )
            {
                healthPlayerOne += healthIncrease;
                Debug.Log(healthPlayerOne);
            }

            if (collision.gameObject.tag == "Enemy")
            {
                healthPlayerOne -= healthDecrease;
                Debug.Log("Health P1: " + healthPlayerOne);
            }

            if (healthPlayerOne <= 0)
            {
                Destroy(gameObject);
            }
        }
}
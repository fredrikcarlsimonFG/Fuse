using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
        public int health = 100;
        public int healthIncrease = 10;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "LightHealth" )
            {
                health += healthIncrease;
                Debug.Log(health);
            }

            if (health <= 0)
            {
                Destroy(gameObject);
            }   
        }

}
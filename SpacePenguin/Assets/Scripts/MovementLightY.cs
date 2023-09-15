using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovementY : MonoBehaviour
{
    public float speed = 2f ;

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime; 
    }
}

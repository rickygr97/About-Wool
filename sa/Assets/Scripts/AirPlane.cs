using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlane : MonoBehaviour
{

    public float flightspeed = 75;
    public GameObject plane;

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * flightspeed;

        transform.Rotate(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0);

        flightspeed -= transform.forward.y * Time.deltaTime;

        if (flightspeed < 30.0f)
        {
            flightspeed = 30.0f;
        }
    }  
}

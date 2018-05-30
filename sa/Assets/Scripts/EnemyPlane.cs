using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : MonoBehaviour
{
    public GameObject player;
    public float flightspeed = 75;

	void Update ()
    {
        transform.position += transform.forward * Time.deltaTime * flightspeed;

        flightspeed -= transform.forward.y * Time.deltaTime;

        if (flightspeed < 30.0f)
        {
            flightspeed = 30.0f;
        }

        transform.Rotate(-transform.right);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinGun : MonoBehaviour
{

    public GameObject pin;
    private bool fire;
    public GameObject planedaddy;

    private void Start()
    {
        fire = true;
    }

    void Update ()
    {
        pin.GetComponent<PinProjectile>().bulletspeedmod = planedaddy.GetComponent<AirPlane>().flightspeed;
        if (Input.GetKey(KeyCode.Mouse0) && fire)
        {
            StartCoroutine(firerate());
        }
	}
    IEnumerator firerate ()
    {
        fire = false;
        Instantiate(pin, this.transform.position + (transform.forward * 3), this.transform.rotation);
        yield return new WaitForSeconds(0.1f);
        fire = true;
    }
}

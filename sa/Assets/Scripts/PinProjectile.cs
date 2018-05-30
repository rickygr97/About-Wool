using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinProjectile : MonoBehaviour
{

    public float bulletspeedmod;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 5 * bulletspeedmod;
        Destroy(this.gameObject, 3);
    }

    private void OnCollisionEnter(Collision col)
    {
        Destroy(this.gameObject);
        if (col.transform.tag == "destructible")
        {
            Destroy(col.gameObject);
        }
    }
}

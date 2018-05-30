using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHitboxes : MonoBehaviour
{

    public GameObject planedad;
    public ParticleSystem ringgot;
    public bool fatality;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ring")
        {
            Destroy(other.gameObject, 0.5f);
            ringgot.Play();
        }

        if (fatality && other.transform.name != "Ring")
        {
            Destroy(planedad.gameObject);
        }
    }
}

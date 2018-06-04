using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minmapscript : MonoBehaviour {

    public Transform pl;


    private void LateUpdate()
    {
        // Vector3 mewposition = pl.position;
        //mewposition.y = transform.position.y;
        //  transform.position = mewposition;

       Vector3 mewposition = new Vector3(pl.position.x, pl.position.y, pl.position.z);
        mewposition.y += 60;
        transform.position = mewposition;

    }
}

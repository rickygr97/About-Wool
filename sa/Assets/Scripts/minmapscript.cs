using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minmapscript : MonoBehaviour {

    public Transform pl;


    private void LateUpdate()
    {
        Vector3 mewposition = pl.position;
        mewposition.y = transform.position.y;
        transform.position = mewposition;
    }
}

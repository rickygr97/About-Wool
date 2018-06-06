using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class en : MonoBehaviour {

    public GameObject target2;
    float distance;
    int lookradius = 200;
    float stopradius = 100;
    bool stop;

    bool shoot = false;
    public GameObject bul;
    public GameObject bulpos;


    private int heath;
    public int Health
    {
        get
        {
            return heath;

        }
        set
        {
            heath = value;
        }

    }

    // Use this for initialization
    void Start()
    {
        Health = 200;

        stop = false;
        shoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(new Vector3(target2.transform.position.x, this.transform.position.y, target2.transform.position.z), this.transform.position);

        Vector3 movement = new Vector3(target2.transform.position.x, this.transform.position.y, target2.transform.position.z);
        Debug.Log(distance);
        if (distance < lookradius && stop == false)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, movement, Time.deltaTime * 2);

            if (shoot)
            {
                StartCoroutine(hallo());
                shoot = false;
            }
        }
        if (distance <= stopradius)
        {
            stop = true;
            facecarater();
        }
        if (distance >= stopradius)
        {
            stop = false;
            facecarater();
        }
    }

    void facecarater() // zorgter voor dat de enemy naar je toe kijkt
    {
        Vector3 diraction = (target2.transform.position - this.transform.position).normalized;
        Quaternion lookrotation = Quaternion.LookRotation(new Vector3(diraction.x, diraction.y, diraction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position, lookradius);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, stopradius);
    }

    IEnumerator hallo()
    {
        var hallo = (GameObject)Instantiate(bul, bulpos.transform.position, bulpos.transform.rotation);
        hallo.GetComponent<Rigidbody>().velocity = target2.transform.position * 6;

        yield return new WaitForSeconds(2);
        shoot = true;
    }
}

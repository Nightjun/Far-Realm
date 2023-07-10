using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addbaginside : MonoBehaviour
{
    public Transform things;
    public GameObject baginside;

    void Update()
    {
       
        if ( things.childCount / 3+1 > gameObject.transform.childCount)
        {
           GameObject newbagside= Instantiate(baginside, gameObject.transform.position, Quaternion.identity);
            newbagside.transform.SetParent(gameObject.transform);
            newbagside.transform.localScale = new Vector3(1, 1, 1);
        }
        if(things.childCount / 3 + 1 < gameObject.transform.childCount)
        {
            Destroy(gameObject.transform.GetChild(0).gameObject);
        }
    }
}

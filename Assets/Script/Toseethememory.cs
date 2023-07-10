using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toseethememory : MonoBehaviour
{
    public GameObject theani;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            theani.SetActive(true);
            PlayerControll.instance.isbattle = true;
        }
    }
}

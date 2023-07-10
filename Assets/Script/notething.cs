using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notething : MonoBehaviour
{
    notslot firstone;
    void Start()
    {
        Openit();
    }

    public void Openit()
    {
        if (gameObject.transform.childCount <= 0)
        {

        }
        else
        {
            firstone = gameObject.transform.GetChild(0).gameObject.GetComponent<notslot>();
            firstone.Buttendown();
        }
    }
}

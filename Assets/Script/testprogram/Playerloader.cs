using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerloader : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        if (PlayerControll.instance == null)
        {
            Instantiate(player);
        }
    }
}

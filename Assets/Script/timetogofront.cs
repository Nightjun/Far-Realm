using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timetogofront : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerControll.instance.Timetogo();
        timetoani.instance.Aninow();
    }

    
}

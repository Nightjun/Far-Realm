using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossthebrigee : MonoBehaviour
{
    public Dialogue1 dia;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerControll.instance.isbattle = true;
            dia.Sendthetalk();
        }
    }
}

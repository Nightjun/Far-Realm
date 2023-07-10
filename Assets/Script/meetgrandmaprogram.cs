using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meetgrandmaprogram : MonoBehaviour
{
    public Dialogue1 dia;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerControll.instance.isbattle = true;
            PlayerControll.instance.anim.SetFloat("Horizonztal", 1);
            PlayerControll.instance.anim.SetFloat("Vertical",0);
            dia.Sendthetalk();
        }
    }
}

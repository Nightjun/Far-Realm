using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustWplayer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerControll.instance.isjustw = true;
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
    }
}

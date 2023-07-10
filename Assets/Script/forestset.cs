using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestset : MonoBehaviour
{
    public Animator man;
   
    void Start()
    {
        PlayerControll.instance.gameObject.transform.position = new Vector3(0, 0, 0);
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
        man.SetFloat("ver", -1);
        man.SetFloat("hor", 0);
    }

  
}

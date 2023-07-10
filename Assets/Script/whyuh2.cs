using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whyuh2 : MonoBehaviour
{
    public Dialogue1 dia;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            dia.Sendthetalk();
            gameObject.SetActive(false);
            PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
            PlayerControll.instance.anim.SetFloat("Vertical", 1);
            grandmaniall.instance.Grandmazoom();
        }
    }
}

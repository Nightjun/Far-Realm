using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treeuprogram : MonoBehaviour
{
     Animator ani;
    float time;
    private void Start()
    {
        ani = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag=="Player"&&PlayerControll.instance.iswalking&& Input.GetAxisRaw("Vertical")==1)
        {
            time += Time.deltaTime;
            ani.SetFloat("Blend", time);
        }
    }
}

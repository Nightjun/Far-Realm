using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostlight : MonoBehaviour
{
    private Animator ani;
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ani.SetTrigger("playerclose");
        Audiomanager.instance.Play("ghostfire");
    }
}

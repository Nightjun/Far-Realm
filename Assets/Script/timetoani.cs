using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timetoani : MonoBehaviour
{
    static public timetoani instance;

    Animator ani;
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
        if (instance != this)
        {
            instance = this;
        }
    }

    public void Aninow()
    {
        ani.SetBool("aningnow", true);
    }

    public void NotAninow()
    {
        ani.SetBool("aningnow", false);
    }
}

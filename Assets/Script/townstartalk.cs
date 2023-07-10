using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class townstartalk : MonoBehaviour
{
    bool sendyas;
    public string thename;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Alldialogue.instance.Sendialogue(thename);
        }
    }
}

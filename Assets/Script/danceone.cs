using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danceone : MonoBehaviour
{
    bool isin;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!isin)
            {
                isin = true;
                Audiomanager.instance.StopPlay("townbackground");
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isin)
            {
                isin = false;
                Audiomanager.instance.Play("townbackground");
            }
        }

    }
}

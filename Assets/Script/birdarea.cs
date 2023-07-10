using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdarea : MonoBehaviour
{
    public bool idplayerin; 
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            idplayerin = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            idplayerin = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class getoa0 : MonoBehaviour
{
    public Transform player;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (player.position.y >= gameObject.transform.position.y)
        {
            //color.a = 0.3f;
            spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
            PlayerControll.instance.isbehind = true;
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //color.a = 1f;
        spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        PlayerControll.instance.isbehind = false;
    }
}

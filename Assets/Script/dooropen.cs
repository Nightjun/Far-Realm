using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour
{
    Animator ani;
    private void Start()
    {
        ani = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ani.SetBool("isopen", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ani.SetBool("isopen", false);
        }
    }
}

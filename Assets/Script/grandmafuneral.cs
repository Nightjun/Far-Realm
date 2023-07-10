using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grandmafuneral : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 0.4f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insidebuilding : MonoBehaviour
{
    public GameObject outbuilding, insidelight;
    public SpriteRenderer spriteRenderer;
    public float fadespeed=3f;
    float time;
    bool outhere,intodoor,outdoor;
    private void Start()
    {
        spriteRenderer = outbuilding.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (outhere)
        {
            time += Time.deltaTime;
            if (time >= 1f)
            {
                outdoor = true;
                time = 0;
                outhere = false;
            }
        }
        if (intodoor)
        {
            time = 0;
            insidelight.SetActive(true);
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, Mathf.MoveTowards(spriteRenderer.color.a, 0f, fadespeed * Time.deltaTime));
            if (spriteRenderer.color.a == 0f)
            {
                outbuilding.SetActive(false);
                intodoor = false;
            }
        }
        if (outdoor)
        {
            outbuilding.SetActive(true);
            insidelight.SetActive(false);
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, Mathf.MoveTowards(spriteRenderer.color.a, 1f, fadespeed * Time.deltaTime));
            if (spriteRenderer.color.a == 1f)
            {

                outdoor = false;
            }
        }
        if (intodoor && outdoor)
        {
            time = 0;
            outdoor = false;
            outhere = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (spriteRenderer.color.a != 0f)
        {
            if (collision.gameObject.tag == "Player" && PlayerControll.instance.gameObject.transform.position.y > outbuilding.transform.position.y)
            {
                intodoor = true;
                outhere = false;
            }
        }
        else
        {
            if (collision.gameObject.tag == "Player" && PlayerControll.instance.gameObject.transform.position.y > outbuilding.transform.position.y)
            {
                time = 0;
                outdoor = false;
                outhere = false;
            }
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            outhere = true;
            intodoor = false;
        }
    }
}

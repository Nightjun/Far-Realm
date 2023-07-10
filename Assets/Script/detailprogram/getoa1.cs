using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class getoa1 : MonoBehaviour
{
    public Transform player;
    public SpriteRenderer spriteRenderer;
    public GameObject wallmain,bathroomlight;

    float time;
    bool isout;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        if (isout)
        {
            time += Time.deltaTime;
            if (time >= 0.4f)
            {
               
                spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                wallmain.SetActive(true);
                bathroomlight.SetActive(false);
            }
        }
        else
        {
            time = 0;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Audiomanager.instance.Play("bathroomlight");
        Audiomanager.instance.StopPlay("officebaclgroundmusic");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (player.position.y >= gameObject.transform.position.y)
        {
            spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 0.3f);
            wallmain.SetActive(false);
            bathroomlight.SetActive(true);
            isout = false;
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isout = true;
        Audiomanager.instance.StopPlay("bathroomlight");
        Audiomanager.instance.Play("officebaclgroundmusic");
    }
}

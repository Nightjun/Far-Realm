using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightmove : MonoBehaviour
{
    public float speed = 0.5f;
    private Vector3 dir;
    private float time;
    private Animator ani;

    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
        dir = new Vector3(Random.Range(-10, 10), Random.Range(10, -10), 0);
    }
   
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 10)
        {
            dir = new Vector3(Random.Range(-10, 10), Random.Range(10, -10), 0);
            time = 0;
        }

        transform.localPosition += dir.normalized * speed * Time.deltaTime;

       }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag== "redlight")
        {
            dir = -dir;
        }
    }
    
     //ani.SetTrigger("stamp");   
}

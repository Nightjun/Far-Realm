using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertattack : MonoBehaviour
{
   
    public Vector3 targetPosition;
    public float speed = 3f;

    private void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, -1);
        targetPosition = hit.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "enemy")
        {
            //collision.gameObject.GetComponent<fallowenemy>().Enemygethurt(PlayerControll.instance.playerpower);
            Destroy(gameObject);
        }
    }
   
}

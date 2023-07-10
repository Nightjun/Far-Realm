using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogfallow : MonoBehaviour
{

    public float speed;
    public float minimunDistance;
    public Transform dog;
    private Transform target;
    private Animator dogani;
    private void Start()
    {
        target = PlayerControll.instance.gameObject.transform;
        dogani = dog.GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Vector2.Distance(dog.position, target.position) > minimunDistance)
        {
            dog.transform.position = Vector2.MoveTowards(dog.transform.position, target.position, speed * Time.deltaTime);
            dogani.SetBool("iswalking", true);
            if (dog.position.x - target.position.x > 0f)
            {
                dog.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (dog.position.x - target.position.x <= 0f)
            {
                dog.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        else
        {
            dog.transform.position = dog.transform.position;
            dogani.SetBool("iswalking", false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dog.transform.position = dog.transform.position;
        dogani.SetBool("iswalking", false);
    }

}

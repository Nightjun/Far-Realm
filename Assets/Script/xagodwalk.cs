using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xagodwalk : MonoBehaviour
{
    private Animator ani;
    private Transform target;
    public float minimunDistance,speed;
    public bool isfallowing;
    private void Start()
    {
        target = PlayerControll.instance.gameObject.transform;
        ani = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (isfallowing)
        {

            if (Vector2.Distance(gameObject.transform.position, target.position) > minimunDistance)
            {
                gameObject.transform.transform.position = Vector2.MoveTowards(gameObject.transform.transform.position, target.position, speed*PlayerControll.instance.runspeed * Time.deltaTime);
                ani.SetBool("iswalking", true);
                if (PlayerControll.instance.runspeed == 2)
                {
                    ani.speed = 2;
                }
                else
                {
                    ani.speed = 1;
                }
                if (gameObject.transform.position.x - target.position.x >= 0.5f)
                {
                    ani.SetFloat("hor", -1);
                }
                if (gameObject.transform.position.x - target.position.x < 0.5f && gameObject.transform.position.x - target.position.x > -0.5f)
                {
                    ani.SetFloat("hor", 0);
                }
                if (gameObject.transform.position.x - target.position.x <= -0.5f)
                {
                    ani.SetFloat("hor", 1);
                }
                if (gameObject.transform.position.y - target.position.y >= 0.5f)
                {
                    ani.SetFloat("ver", -1);
                }
                if (gameObject.transform.position.y - target.position.y < 0.5f && gameObject.transform.position.y - target.position.y > -0.5f)
                {
                    ani.SetFloat("ver", 0);
                }
                if (gameObject.transform.position.y - target.position.y <= -0.5f)
                {
                    ani.SetFloat("ver", 1);
                }
            }
            else
            {
                gameObject.transform.transform.position = gameObject.transform.transform.position;
                ani.SetBool("iswalking", false);
            }
        }
        else
        {
            gameObject.transform.transform.position = gameObject.transform.transform.position;
            ani.SetBool("iswalking", false);
        }
        
    }
}

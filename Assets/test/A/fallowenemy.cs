using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallowenemy : MonoBehaviour
{
    public static fallowenemy instance;
    public float speed;
    public float minimumdistance;
    public float maxdistance;

    public float enemyheath;
    public float enemypower;
    public bool ishurt;

    private float distance;
    Transform target;
    float time;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        target = PlayerControll.instance.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, target.transform.position);
        if (enemyheath <= 0)
        {
            time += Time.deltaTime;
            //死掉動畫
            //掉東西
            Destroy(GetComponent<Collider>());
            if (time >= 3)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            if (ishurt)
            {
                //受傷了就打死你
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else
            {
                //只要不招惹我就不會怎樣
                if (distance > maxdistance)
                {
                    //到時候放動畫
                }
                else
                {
                    if (distance > minimumdistance)
                    {
                        //chasing
                        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                    }
                    else
                    {
                        //attack
                        //PlayerControll.instance.playergethurt(enemypower);
                    }
                }
            }
        }
    }

    public void Enemygethurt(float playerpower)
    {
        ishurt = true;
        enemyheath -= playerpower;
    }
}

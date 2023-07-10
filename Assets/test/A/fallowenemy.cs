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
            //�����ʵe
            //���F��
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
                //���ˤF�N�����A
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else
            {
                //�u�n���۷S�ڴN���|���
                if (distance > maxdistance)
                {
                    //��ɭԩ�ʵe
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

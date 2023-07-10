using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OtherNpcMovement : MonoBehaviour
{
    public Vector3 thunderup;
    public bool playerstartalk;
    public float switchtime=2f;
    public GameObject Fbutten;
    public GameObject[] targets;
    public Dialogue1 dia;

    private GameObject target;
    private NavMeshAgent agent;
    private Vector3 oldtransition;
    private float time,time2,randommovement;
    private bool playerwannatalk;
    private void Start()
    {
        target = targets[Random.Range(0, targets.Length)];
        time2 = 2;
        oldtransition = gameObject.transform.position;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    private void Update()
    {
      

        time2 += Time.deltaTime;
        if (time2 >= 1f)
        {
            checkflipx();
            time2 = 0;
        }
        //角色左右

       

        if (playerwannatalk)
        {
            Fbutten.transform.position = gameObject.transform.position + thunderup;
            if (Input.GetKeyUp(KeyCode.F)&&!playerstartalk)
            {
                target = gameObject;
                time = 0;
                playerstartalk = true;
                Fbutten.SetActive(false);
                dia.Sendthetalk();
            }
        }

        agent.SetDestination(new Vector3(target.transform.position.x, target.transform.position.y, 0));
        
        if (!agent.hasPath&&!playerstartalk)
        {
            time += Time.deltaTime;
            if (time >= switchtime)
            {
                randommovement = Random.Range(1, 100) % 2;
                if (randommovement > 0)
                {
                    target = gameObject;
                    //停下
                }
                else
                {
                    target = targets[Random.Range(0, targets.Length)];
                    checkflipx();
                    //走去其他地方
                }

                time = 0;
            }
        }

       


    }
    public void checkflipx()
    {
        if (gameObject.transform.position.x >= oldtransition.x  )
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        oldtransition = gameObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            PlayerControll.instance.istalktosomeone = gameObject.name;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!PlayerControll.instance.isbattle && PlayerControll.instance.istalktosomeone == gameObject.name&&!playerwannatalk)
            {
                Fbutten.SetActive(true);
                playerwannatalk = true;
            }
        }
        if (PlayerControll.instance.istalktosomeone != gameObject.name)
        {
            playerwannatalk = false;
            Fbutten.SetActive(false);
            target = gameObject;
            time = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerwannatalk = false;
            Fbutten.SetActive(false);
        }
    }
   

}

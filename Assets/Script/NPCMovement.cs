using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    public GameObject[] targetposition;
    private GameObject target;
    public NavMeshAgent agent;
    private Vector3 oldtransition;
    private float time;
    private Animator ani;
    public bool arrive;
    private void Start()
    {
        ani = gameObject.GetComponent<Animator>();
        target = targetposition[0];
        oldtransition = gameObject.transform.position;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    private void Update()
    {
        agent.SetDestination(new Vector3(target.transform.position.x, target.transform.position.y, 0));
        time += Time.deltaTime;
        if (time >= 1f)
        {
            if (gameObject.transform.position.x - oldtransition.x >= 0.1f)
            {
                ani.SetFloat("hor", 1);
            }
            if (gameObject.transform.position.x - oldtransition.x < 0.1f && gameObject.transform.position.x - oldtransition.x > -0.1f)
            {
                ani.SetFloat("hor", 0);
            }
            if (gameObject.transform.position.x - oldtransition.x <= -0.1f)
            {
                ani.SetFloat("hor", -1);
            }
            if (gameObject.transform.position.y - oldtransition.y >= 0.1f)
            {
                ani.SetFloat("ver", 1);
            }
            if (gameObject.transform.position.y - oldtransition.y < 0.1f && gameObject.transform.position.y - oldtransition.y > -0.1f)
            {
                ani.SetFloat("ver", 0);
            }
            if (gameObject.transform.position.y - oldtransition.y <= -0.1f)
            {
                ani.SetFloat("ver", -1);
            }
            oldtransition = gameObject.transform.position;
            time = 0;
        }
        if (Mathf.Abs(target.transform.position.x-gameObject.transform.position.x)<=0.1f&& Mathf.Abs(target.transform.position.y - gameObject.transform.position.y) <= 0.1f)
        {
            arrive = true;
            ani.SetBool("iswalking", false);
        }
        else
        {
            arrive = false;
            ani.SetBool("iswalking", true);
        }
    }
    public void Chanagetarget(int number)
    {
        target = targetposition[number];
    }
}



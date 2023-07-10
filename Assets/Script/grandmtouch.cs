using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grandmtouch : MonoBehaviour
{
    public Animator ani, yallowone;
    public bool isoktogo;
    public Dialogue1 dia,dia2;
    public GameObject partical, grandmawave;
    private void Start()
    {
        ani = gameObject.GetComponent<Animator>();
    }
    private void Update()
    {
        if (isoktogo)
        {
            partical.SetActive(true);
        }
        else
        {
            partical.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isoktogo && collision.tag== "Player")
        {
            ani.SetTrigger("gogograndma");
        }
        
    }
    
    public void Addtransfer()
    {
        if (isoktogo)
        {
            gameObject.transform.position = new Vector3(Random.Range(-28.2f, -26.6f), gameObject.transform.position.y, 0);
            gameObject.transform.position += new Vector3(0, 3.5f, 0);
        }
       
    }

    public void Afterturntoghost()
    {
        ani.SetTrigger("ghostalk");
        dia.Sendthetalk();
    }
    public void Startyallowone()
    {
        yallowone.SetTrigger("showstart");
        grandmawave.GetComponent<Animator>().enabled = true;
    }

    public void Aferleave()
    {
        dia2.Sendthetalk();
        PlayerControll.instance.anim.SetFloat("Horizonztal", -1);
        PlayerControll.instance.anim.SetFloat("Vertical", -1);
    }

}

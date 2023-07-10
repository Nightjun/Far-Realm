using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grandmaniall : MonoBehaviour
{
    public static grandmaniall instance;
    public GameObject grandma,thecollider,thlight,thetalk;
    public Animator dragenman,meetgrandma,grandmaa,sunblack,grandmani,whyuhere,yallow01,yallow02;
   
    private void Awake()
    {
        instance = this;
        meetgrandma = GameObject.FindGameObjectWithTag("playercamera").GetComponent<Animator>();
    }
    private void Start()
    {
        grandmani = grandma.GetComponent<Animator>();
        meetgrandma = GameObject.FindGameObjectWithTag("playercamera").GetComponent<Animator>();
    }

    public void Dragenmannormal()
    {
        dragenman.SetTrigger("backtonormal");
    }
    public void Dragenmanshock()
    {
        dragenman.SetTrigger("talktodragen");
    }
    public void Meetgrandmaa()
    {
        meetgrandma.SetTrigger("grandmameetplayer");
    }
    public void Grandmazoom()
    {
        meetgrandma.SetBool("grandmazoom",true);
    }
    public void Grandmazoomout()
    {
        meetgrandma.SetBool("grandmazoom", false);
    }
    public void Grandmapopup()
    {
        grandma.SetActive(true);
        sunblack.SetTrigger("tonight");
        thlight.SetActive(false);
        thetalk.SetActive(false);
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
    }
   
    public void grandmamaaaa()
    {
        grandmaa.gameObject.SetActive(true);
        grandmaa.SetBool("grandmaaaa", true);
    }

    public void why()
    {
        camerafindplayer.instance.ShakeCamera(2f, 0.5f);
        whyuhere.SetTrigger("whyhere");
    }
    
    public void grandmamaaaa2()
    {
        grandmaa.SetBool("grandmaaaa", false);
        thecollider.SetActive(false);
    }

    public void grandmatoghost()
    {
        grandmani.SetTrigger("toghost");
    }
    public void grandmadiappear()
    {
        grandmani.SetTrigger("godisappear");
    }
    
   
    public void ghostleave()
    {
        grandmani.SetTrigger("ghostleave");
        yallow01.SetTrigger("yallowgo");
        yallow02.SetTrigger("yallowgo");
    }
    
    public void talkyellow01()
    {
        yallow01.SetBool("yallowtalk", true);
        grandmani.SetBool("yallowtalk", false);
        yallow02.SetBool("yallowtalk", false);
    }
    public void talkyellow02()
    {
        yallow02.SetBool("yallowtalk", true);
        yallow01.SetBool("yallowtalk", false);
        grandmani.SetBool("yallowtalk", false);
    }
    public void ghosttalk()
    {
        grandmani.SetBool("yallowtalk", true);
        yallow02.SetBool("yallowtalk", false);
        yallow01.SetBool("yallowtalk", false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startanimation : MonoBehaviour
{

    private Animator ani;
    public GameObject skipbutten;
    
    void Start()
    {
        skipbutten.SetActive(true);
        UIcall.instance.somethingopen = true;
        PlayerControll.instance.isbattle = true;
        hintone.instence.Openthrhint("startani");
        ani = gameObject.GetComponent<Animator>();
        Audiomanager.instance.Play("startmusic");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            hintone.instence.Closethehint();
            ani.SetTrigger("pressE");
        }
    }
    public void afterani()
    {
        UIcall.instance.somethingopen = false;
        UIcall.openwater = true; 
        Audiomanager.instance.StopPlay("schoolclock");
        Audiomanager.instance.StopPlay("startmusic");
        Audiomanager.instance.Play("bathroomlight");
        Audiomanager.instance.Play("bathwater");
        PlayerControll.instance.anim.SetFloat("Horizonztal", 1);
        PlayerControll.instance.anim.SetFloat("Vertical", 0);
        PlayerControll.instance.isbattle = false;
        gameObject.SetActive(false);
        skipbutten.SetActive(false);
    }

    public void schoolring()
    {
        Audiomanager.instance.Play("schoolclock");
    }
    
    public void laughone()
    {
        Audiomanager.instance.Play("kidlaugh");
    }
    public void theendofani()
    {
        Audiomanager.instance.Play("theendofstartani");
    }
}

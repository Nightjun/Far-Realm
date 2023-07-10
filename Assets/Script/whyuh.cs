using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whyuh : MonoBehaviour
{
    public GameObject man,pop2;
    public Animator cloud;
    private Animator mani; 
    private void Start()
    {
        mani = man.GetComponent<Animator>();
    }

    public void Manpop()
    {
        pop2.SetActive(true);
        PlayerControll.instance.anim.SetFloat("Horizonztal", -1);
        PlayerControll.instance.anim.SetFloat("Vertical", -1);
        gameObject.SetActive(false);
    }
    public void cloudout()
    {
        Audiomanager.instance.StopPlay("wiredwind");
        Audiomanager.instance.Play("battleattack");
        man.SetActive(true);
        mani.SetFloat("ver", 1);
        mani.SetFloat("hor", 1);
        cloud.SetTrigger("ccclll");
    }
}

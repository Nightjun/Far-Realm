using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yallowshow : MonoBehaviour
{
    public Animator yallow01, yallow02, grandma;
    public Dialogue1 dia0102;

    public void startani()
    {
        Audiomanager.instance.Play("drumroll");
    }
    public void Yallow01show()
    {
        yallow01.SetTrigger("show");
        Audiomanager.instance.Play("tala");
        Audiomanager.instance.Play("drumroll");
    }

    public void Yallow02show()
    {
        yallow02.SetTrigger("show");
        Audiomanager.instance.Play("tala");
        Audiomanager.instance.Play("drumroll");
    }
    public void Grandmaoneshow()
    {
        grandma.SetTrigger("showushelf");
        Audiomanager.instance.Play("tala");
        Audiomanager.instance.StopPlay("drumroll");
    }
    public void send0102()
    {
        dia0102.Sendthetalk();
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alltalkani : MonoBehaviour
{
    public static Alltalkani instance;
    public bool isani,isnpcmove;
    public NPCMovement Nowmove, ashu, thunderbird;
    private smalltalkmainsystem nowst;


    private void Awake()
    {
        if (instance != this)
            instance = this;
    }
    private void Update()
    {
        if (isani)
        {

        }
        if (isnpcmove)
        {
            if (Nowmove.arrive)
            {
                nowst.Afterani();
                timetoani.instance.NotAninow();
                isnpcmove = false;
            }
        }
    }
    public void Whichani(string number,smalltalkmainsystem st)
    {
        nowst = st;

        switch (number)
        {
            case "startashu":
                Nowmove = ashu;
                ashu.Chanagetarget(3);
                isnpcmove = true;
                break;
            case "startashu01":
                Nowmove = ashu;
                ashu.Chanagetarget(1);
                isnpcmove = true;
                break;
            case "startashu02":
                Nowmove = ashu;
                ashu.Chanagetarget(2);
                isnpcmove = true;
                break;
            case "startashu03":
                Nowmove = ashu;
                ashu.Chanagetarget(1);
                isnpcmove = true;
                break;
            case "startashu04":
                Nowmove = ashu;
                ashu.Chanagetarget(0);
                isnpcmove = true;
                break;
            case "startthunderbird01":
                Nowmove = thunderbird;
                thunderbird.Chanagetarget(1);
                isnpcmove = true;
                break;
            case "startthunderbird02":
                Nowmove = thunderbird;
                thunderbird.Chanagetarget(0);
                isnpcmove = true;
                break;
            case "startthunderbird03":
                Nowmove = thunderbird;
                thunderbird.Chanagetarget(2);
                isnpcmove = true;
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alldialogue : MonoBehaviour
{
    public static Alldialogue instance;

    public Dialogue1[] dias;
    public Dialogue[] Fdias;

    private void Awake()
    {
        if (instance != this)
            instance = this;
    }
    private void Start()
    {
        if (Storyinformation.aftertalkkk)
        {
            Debug.Log("yes");
            Storyinformation.instance.thetalkset();
        }
        else
        {
            Debug.Log("no");
            Alldialogue.instance.Sendialogue("townstartalk");
        }
    }

    public void Sendialogue(string number)
    {
        for (int i = 0; i < dias.Length; i++)
        {
            if (dias[i].linenumber == number)
            {
                Debug.Log(number);
                dias[i].Sendthetalk();
                break;
            }
        }
    }
    public void falseialogue(string number)
    {
        for (int i = 0; i < dias.Length; i++)
        {
            if (dias[i].linenumber == number)
            {
                dias[i].gameObject.SetActive(false);
                break;
            }
        }
    }
    public void Trueialogue(string number)
    {
        for (int i = 0; i < dias.Length; i++)
        {
            if (dias[i].linenumber == number)
            {
                dias[i].gameObject.SetActive(true);
                break;
            }
        }
    }
    public void SettrueFdia(string number)
    {
        Debug.Log(number);
        for (int i = 0; i < Fdias.Length; i++)
        {
            if (Fdias[i].linenumber == number)
            {
                Fdias[i].gameObject.SetActive(true);
                break;
            }
        }
    }
    public void SetFalseFdia(string number)
    {
        for (int i = 0; i < Fdias.Length; i++)
        {
            if (Fdias[i].linenumber == number)
            {
                Fdias[i].gameObject.SetActive(false);
                break;
            }
        }
    }
}

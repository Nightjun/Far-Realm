using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttensystem : MonoBehaviour
{
    public static buttensystem instence;
    public int howmuch=0;
    bool isstartin;
    public GameObject thebutten,panel;

    private void Start()
    {
        if (instence != this)
            instence = this;
    }
    private void Update()
    {
        if (isstartin)
        {
            for(int i = 0; i < howmuch; i++)
            {
                Instantiate(thebutten, panel.transform);
            }
            isstartin = false;
        }
        
    }
    public void Therightbuttenpush(int howmuchitis)
    {
        howmuch = howmuchitis;
        setfalseall();
        isstartin = true;
    }
    public void Thewrongbuttenpush()
    {
        setfalseall();
    }
    public void setfalseall()
    {
        for(int i = 0; i < panel.transform.childCount; i++)
        {
            GameObject butten = panel.transform.GetChild(i).gameObject;
            butten.SetActive(false);
            butten.transform.position = new Vector3(0, 0, 0);
        }
    }
}

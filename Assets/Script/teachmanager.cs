using System.Collections;
using System;
using UnityEngine;

public class teachmanager : MonoBehaviour
{
    public static teachmanager instance;
    public Theteachani tcani;
    public GameObject all;


    public teachdia[] teachs;
    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
    public void sandtheteach(string name)
    {
        teachdia t = Array.Find(teachs, teach => teach.teachname == name);
        if (t == null)
        {
            Debug.Log("not found teach");
            return;
        }
        all.SetActive(true);
        tcani.StartDialgue(t.aniname, t.aniteach, t.teachname);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class relationshipinformation : MonoBehaviour
{
    public static relationshipinformation instance;
    public GameObject theword;
    public Text thename;
    public notbutten nob;

    private void Awake()
    {
        if (instance != this)
            instance = this;
    }
    public void Textin(string name)
    {
        theword.SetActive(true);
        nob.setheTrueorfalse(name);
        thename.text = name;
       
    }
}

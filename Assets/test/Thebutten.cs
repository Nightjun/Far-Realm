using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thebutten : MonoBehaviour
{
    public bool isright;
    public int howmuchitwillbe;
    public string thename;
    public Text thenametext;
     
    public void Pushthebutten()
    {
        if (isright)
        {
            buttensystem.instence.Therightbuttenpush(howmuchitwillbe);
            gameObject.SetActive(false);
        }
        else
        {
            buttensystem.instence.Thewrongbuttenpush();
        }
    }
}

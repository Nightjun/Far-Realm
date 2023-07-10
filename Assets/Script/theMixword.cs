using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class theMixword : MonoBehaviour
{
    static public theMixword instance;
    public Text text;

    bool ismixing;
    private string word01, word02;
    int x=1;
    private void Awake()
    {
        if (instance != this)
            instance = this;
    }

    private void Update()
    {
        if (ismixing)
        {
           
            x = 1;
            ismixing = false;

        }
        
    }
    public void AddTheword(string mainword)
    {
        if (!ismixing)
        {
            switch (x)
            {
                case 1:
                    text.text = "";
                    text.text += mainword + "...©M";
                    word01 = mainword;
                    break;
                case 2:
                    text.text += mainword;
                    ismixing = true;
                    break;
                default:
                    Debug.Log("somethingwring,aboutMixtheword");
                    break;
            }
            x++;
        }
    }

    private void Totheword()
    {
        
    }
}

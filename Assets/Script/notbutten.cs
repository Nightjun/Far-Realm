using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class notbutten : MonoBehaviour
{
    public GameObject missiondetail,relation,settinfo,theplace;
    public textbutten[] all;

    bool startochange;
    string number;
    private void OnEnable()
    {
        all = new textbutten[gameObject.transform.childCount];

        for(int i = 0; i < gameObject.transform.childCount; i++)
        {
            all[i] = gameObject.transform.GetChild(i).GetComponent<textbutten>();
        }


        for (int i = 0; i < theplace.transform.childCount; i++)
        {
            theplace.transform.GetChild(i).parent = gameObject.transform;
        }
    }
    public void setheTrueorfalse(string thenumber)
    {
        if (!startochange)
        {
            startochange = true;
            number = thenumber;
        }
    }
    private void Update()
    {
        if (startochange)
        {
            replace();

            for (int i = 0; i < all.Length; i++)
            {
                if (all[i].forwho == number)
                {
                    all[i].gameObject.transform.parent = theplace.transform;
                    all[i].gameObject.transform.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    all[i].gameObject.transform.parent = gameObject.transform;
                }

            }
            startochange = false;
        }
        
    }
    public void replace()
    {
        if (theplace.transform.childCount != 0)
        {
            for (int i = 0; i < theplace.transform.childCount; i++)
            {
                theplace.transform.GetChild(i).parent = gameObject.transform;
            }
        }
    }
}


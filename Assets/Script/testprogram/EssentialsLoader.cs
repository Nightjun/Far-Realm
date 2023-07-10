using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject UIScreen;
    public GameObject player;

    void Start()
    {
        if (FadeUI.instance == null)
        {
           FadeUI.instance=Instantiate(UIScreen).GetComponent<FadeUI>();
        }
        if (PlayerControll.instance == null)
        {
            PlayerControll.instance = Instantiate(player).GetComponent<PlayerControll>();
        }
    }

}

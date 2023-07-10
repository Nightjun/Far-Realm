using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{

    public string TransitionName;
    void Start()
    {
        if (TransitionName == PlayerControll.instance.areatransitionName)
        {
            FadeUI.instance.FadeFromBlack();
            PlayerControll.instance.transform.position = transform.position;
        }
    }

}

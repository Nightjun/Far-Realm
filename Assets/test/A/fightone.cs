using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightone : MonoBehaviour
{
    float time;
    void Update()
    {
        
        time += Time.deltaTime;
        if (time >= 0.7f)
        {
            gameObject.SetActive(false);
            time = 0;
        }
    }
}

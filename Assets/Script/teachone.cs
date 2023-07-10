using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teachone : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    }

}

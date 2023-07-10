using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birderfly : MonoBehaviour
{
    public Animator ani01, ani02;
    public birdarea birda;

    float time;

    private void Update()
    {
       if(birda.idplayerin)
        {
            ani01.SetBool("away", true);
        }
        else
        {
            if (ani01.GetBool("away"))
            {
                time += Time.deltaTime;
                if (time >= 5)
                {
                    ani01.SetTrigger("flyin");
                    ani01.SetBool("away", false);
                    time = 0;
                }
            }
        }
    }

    public void birdfly()
    {
        ani02.SetBool("fly", true);
    }
    public void birdnofly()
    {
        ani02.SetBool("fly", false);
    }
}

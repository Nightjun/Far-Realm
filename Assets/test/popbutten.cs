using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popbutten : MonoBehaviour
{
   
    void Start()
    {
        int indexX = Random.Range(-280,180);
        int indexY = Random.Range(-180,100);
        gameObject.transform.position+=new Vector3(indexX, indexY, 0);
    }
    public void popout()
    {
        Destroy(gameObject);
        buttensystem.instence.howmuch--;
    }

   
}

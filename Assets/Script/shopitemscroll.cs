using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopitemscroll : MonoBehaviour
{
    public void Rightway()
    {
        if (gameObject.transform.position.x >= -290)
        {
            gameObject.transform.position -= new Vector3(320, 0, 0);
        }
    }
    public void Leftway()
    {
        if (gameObject.transform.position.x <= 0)
        {
            gameObject.transform.position += new Vector3(320, 0, 0);
        }
    }
}

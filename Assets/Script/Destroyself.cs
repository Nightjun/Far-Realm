using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyself : MonoBehaviour
{
    public float destroytime;
    void Start()
    {
        Destroy(gameObject, destroytime);
    }

    public void destroyitself()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomstartani : MonoBehaviour
{
    private Animator ani;
    public string thename;
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
        ani.speed = Random.Range(0.3f, 1.5f);
        ani.Play(thename, 0, Random.Range(0f,1f));
    }

}

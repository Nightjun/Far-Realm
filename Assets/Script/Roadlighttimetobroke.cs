using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roadlighttimetobroke : MonoBehaviour
{
    Animator animator;
    float animater;
    public bool isbroken;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        if (isbroken)
        {
            animator.SetBool("yesitbroken", true);
            animator.SetBool("somethimebroken", false);
        }
        else
        {
            animator.SetBool("somethimebroken", true);
            animator.SetBool("yesitbroken", false);
        }
    }

    
    void Update()
    {
        if (animater > 11)
        {
            animater = Random.Range(0f,10f);
            animator.SetFloat("timetobroken", animater);
        }
        else
        {
            animater += Time.deltaTime;
            animator.SetFloat("timetobroken", animater);
        }
    }
}

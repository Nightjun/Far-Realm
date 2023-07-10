using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xaquastiontalk : MonoBehaviour
{
    public GameObject allquastoin, waitquastion;
    public smalltalkmainsystem smt;

    public void parentall(GameObject child)
    {
        child.transform.parent = allquastoin.transform;
    }
    public void parentwait(GameObject child2)
    {
        child2.transform.parent = waitquastion.transform;
        allquastoin.SetActive(false);
        smt.isomethinghappened = false;
    }
    public void Finishthetalk()
    {
        allquastoin.SetActive(false);
        smt.isomethinghappened = false;
    }
}

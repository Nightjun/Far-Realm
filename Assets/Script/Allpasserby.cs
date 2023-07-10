using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allpasserby : MonoBehaviour
{
    public static Allpasserby instence;
    public OtherNpcMovement[] npcs;

    public void Awake()
    {
        if (instence != this)
            instence = this;
    }

}

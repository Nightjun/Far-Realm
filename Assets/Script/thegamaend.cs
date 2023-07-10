using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thegamaend : MonoBehaviour
{
    public GameObject thetrigger,theman,themanposition;
    public string afteranitalk;

    public void Afterani()
    {
        thetrigger.SetActive(false);
        gameObject.SetActive(false);
        Alldialogue.instance.Sendialogue(afteranitalk);
        theman.transform.position = themanposition.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class textbutten : MonoBehaviour
{
   
    public Text wordtext;
    public bool isstopmove;
    public wordss w;

    public string forwho, fromwho;
    private void Start()
    {
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        forwho = w.whichfight;
        fromwho = w.aboutwho;
    }

    public void Tosendtheword()
    {
        theMixword.instance.AddTheword(w.mainword);
    }

   
}

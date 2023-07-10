using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class relationinfo : MonoBehaviour
{
    [SerializeField]
    private string thename;

    public Text nametext;

    private void Start()
    {
        nametext.text = thename;
    }

    public void prassit()
    {
        Audiomanager.instance.Play("lobbybuttom");
        relationshipinformation.instance.gameObject.SetActive(true);
        relationshipinformation.instance.Textin(thename);
    }

    public void themusic()
    {
        Audiomanager.instance.Play("lobbybuttom");
    }
}

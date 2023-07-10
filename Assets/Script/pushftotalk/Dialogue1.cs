
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


[System.Serializable]
public class Dialogue1 : MonoBehaviour
{
    public smalltalkmainsystem smalltalkmainsystem;
    public GameObject panel;
    public string linenumber;

    [TextArea(3,10)]
    public string[] sentences;

    public void Sendthetalk()
    {
        PlayerControll.instance.isbattle = true;
        UIcall.instance.somethingopen = true;
        panel.SetActive(true);
        smalltalkmainsystem.gameObject.SetActive(true);
        smalltalkmainsystem.NoFandStartDialgue(this, linenumber);

    }
    
}



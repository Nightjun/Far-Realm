
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


[System.Serializable]
public class Dialogue : MonoBehaviour
{
    public smalltalkmainsystem smalltalkmainsystem;
    public GameObject panel,fbu,talkcanves;
    public Text npcname;
    public string npcnamestring;
    public string linenumber;
    public Vector3 thingup;


    [TextArea(3,10)]
    public string[] sentences;

    


    
    void Update()
    {
       
        if (fbu.activeSelf )
        {
            if (Input.GetKeyUp(KeyCode.F) && !PlayerControll.instance.isbattle && PlayerControll.instance.istalktosomeone == gameObject.name)
            {
                PlayerControll.instance.isbattle = true;
                PlayerControll.instance.istalktosomeone = null;
                UIcall.instance.somethingopen = true;
                panel.SetActive(true);
                smalltalkmainsystem.gameObject.SetActive(true);
                smalltalkmainsystem.StartDialgue(this,linenumber);
                fbu.SetActive(false);
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
            PlayerControll.instance.istalktosomeone = gameObject.name;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && PlayerControll.instance.istalktosomeone==gameObject.name)
        {
            npcname.text = npcnamestring;
            talkcanves.transform.position = gameObject.transform.position+thingup;
            fbu.SetActive(true);
        }
        if(PlayerControll.instance.istalktosomeone != gameObject.name)
        {
            fbu.SetActive(false);
            if (panel.activeSelf == true &&!PlayerControll.instance.isbattle)
            {
                panel.SetActive(false);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            fbu.SetActive(false);
            if (panel.activeSelf == true)
            {
                panel.SetActive(false);
            }
        }
    }
}



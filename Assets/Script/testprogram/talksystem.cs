using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talksystem : MonoBehaviour
{
    public smalltalkmainsystem smalltalkmainsystem;
    public GameObject fbu,panel;
    public Text npcname;
    public string npcnamestring;


    private void Start()
    {
        npcname.text = npcnamestring;
    }
    void Update()
    {
        if (fbu.activeSelf==true)
        {
            if (Input.GetKeyUp(KeyCode.F))
            {
                PlayerControll.instance.istalktosomeone = null;
                fbu.SetActive(false);
                panel.SetActive(true);
               // smalltalkmainsystem.StartDialgue();
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerControll.instance.istalktosomeone = gameObject.name;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player"&& PlayerControll.instance.istalktosomeone==gameObject.name)
        {
            fbu.SetActive(true);
        }
        if(PlayerControll.instance.istalktosomeone != gameObject.name)
        {
            fbu.SetActive(false);
            if (panel.activeSelf == true)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopone : MonoBehaviour
{
    private bool istyping,iscountmoney;
    private string talklines;
    private int itenprice;
    private Item itemm;

    public string itemname;
    public Additem aditem;
    public GameObject yesnone, numberone, sureone,talkone;
    public float textspeed;
    public Text text,sureonetext,moneytext;
    public Slider howmuch;
    public Animator gamani,cashin,openani;

    
    private void OnEnable()
    {
        gamani.SetTrigger("pup");
        PlayerControll.instance.isbattle = true;
        UIcall.instance.somethingopen = true;
    }
    public void afterstart()
    {
        StopAllCoroutines();
        talkone.SetActive(true);
        text.text = "";
        talklines = "小夥子!買啥膩?";
        StartCoroutine(TypeLine());
        openani.SetBool("open", true);
    }
    public void leavebutten()
    {
        numberone.SetActive(false);
        sureone.SetActive(false);
        yesnone.SetActive(false);
        talkone.SetActive(false);
        text.text = "";
        gamani.SetTrigger("back");
        openani.SetBool("open", false);
    }
    public void afterleave()
    {
        PlayerControll.instance.isbattle = false;
        UIcall.instance.somethingopen = false;
        gameObject.SetActive(false);
    }
    public void whichwannabuy(string itemsname,int itemprice,Item item)
    {
        StopAllCoroutines();
        itemm = item;
        itemname = itemsname;
        itenprice = itemprice;
        talkone.SetActive(true);
        text.text = "";
        talklines = "要買" + itemname + "嗎?";
        StartCoroutine(TypeLine()); 
        numberone.SetActive(false);
        sureone.SetActive(false);
        yesnone.SetActive(true);
    }

    IEnumerator TypeLine()
    {
        foreach (char c in talklines)
        {
            istyping = true;
            text.text += c;
            yield return new WaitForSeconds(textspeed);
        }
        if (text.text != talklines)
            text.text = talklines;
        istyping = false;
    }

    

    public void yesbutten()
    {
        StopAllCoroutines();
        text.text = "";
        talklines = itemname+"一個要"+itenprice.ToString()+",要幾個?";
        StartCoroutine(TypeLine());
        numberone.SetActive(true);
        sureone.SetActive(true);
        yesnone.SetActive(false);
        iscountmoney = true;
    }
    public void nobutten()
    {
        StopAllCoroutines();
        text.text = "";
        talklines = "慢慢逛";
        StartCoroutine(TypeLine());
        yesnone.SetActive(false);
    }
    public void surebutten()
    {
        numberone.SetActive(false);
        sureone.SetActive(false);
        sureonetext.text = "總額";
        cashin.SetTrigger("buy");
        aditem.Buythings(itemm, (int)howmuch.value);
        InventoryManager.money -= (int)howmuch.value * itenprice;
        talkone.SetActive(false);
        iscountmoney = false;
    }

    void Update()
    {
        moneytext.text = InventoryManager.money.ToString();

        if(istyping)
         {
            gamani.SetBool("istalk", true);
            if (text.text == talklines)
            {
                gamani.SetBool("istalk", false);
                StopAllCoroutines();
                istyping = false;
            }
        }
        else
        {
            if (text.text == talklines)
            {
                gamani.SetBool("istalk", false);
            }
           
        }

        if (iscountmoney)
        {
            sureonetext.text = "$"+(howmuch.value*itenprice).ToString();
            if ((howmuch.value * itenprice )<= InventoryManager.money)
            {
                sureone.GetComponent<Image>().color = new Color(255, 125, 125, 125);
                sureone.GetComponent<Button>().interactable = true;
            }
            else
            {
                sureone.GetComponent<Image>().color = new Color(255, 255, 255, 255);
                sureone.GetComponent<Button>().interactable = false;
            }
        }

        
    }
}

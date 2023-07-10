using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleplayerchoose : MonoBehaviour
{
    public string bossnumber;
    public GameObject friend;
    public Text talktext;
    public eyestime eye;
    public battleinformation bin;
    public bossbattlesample bbs;
    private bool firstimetotalk;

   
    public void Persuade()
    {
        //傳keyword給battleinformation
        Audiomanager.instance.Play("battlebuttem");
        bin.TheQA(bossnumber);
        bbs.isplayerchossing = false;
        if (bossnumber == "AmyQA"&& !firstimetotalk)
        {
            firstimetotalk = true;
            teachmanager.instance.sandtheteach("teachboss04");
        }
    }


  

    public void Friend()
    {
        Audiomanager.instance.Play("battlebuttem");
        talktext.text = "選擇請求幫助的夥伴";
        eye.Startocountime(8);
        friend.SetActive(true);
        bbs.isplayerchossing = false;
    }

  
    
}

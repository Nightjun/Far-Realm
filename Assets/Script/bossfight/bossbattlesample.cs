using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossbattlesample : MonoBehaviour
{
    

    [TextArea(3,10)]
    private string[] battlesentence;


    public float textspeed;
    public bool isplayerchossing, pt,isplayerseenote;
    public Text text,textboss,textplayer;
    public GameObject bigpanel,bosstext,nextline01,nextline02;
    public battleplayerchoose bpc;
    public eyestime eye;
    public tostringbattle battale;
    public battleinformation bin;
    public Animator tobattleani;

    GameObject nextline;
    private bool isfirsttalk;
    public bool thend,badend;


    bool istyping;
    private int index;
    //顯示對話
    public void Gobattle(string[] dia)
    {
        isplayerchossing =false ;
        index = 0;
        battlesentence = dia;

        if (pt)
        {
            bosstext.SetActive(false);
            text = textplayer;
        }
        else
        {
            bosstext.SetActive(true);
            text = textboss;
        }
        NextLine();
    }

    void Update()
    {
        if (pt)
        {
            bosstext.SetActive(false);
            text = textplayer;
        }
        else
        {
            bosstext.SetActive(true);
            text = textboss;
        }

        if (battale.startching)
        {
            isplayerchossing = true;
        }
        if (isplayerchossing)
        {
            nextline.SetActive(false);
            nextline01.SetActive(false);
            nextline02.SetActive(false);
        }
        if (!isplayerchossing)
        {
            
            //按F下一句話
            if (Input.GetKeyUp(KeyCode.F) || Input.GetMouseButtonUp(0))
            {
                if (text.text == battlesentence[index])
                {
                    nextline.SetActive(false);
                    index++;
                    NextLine();
                }
                else
                {
                    if (istyping)
                    {
                        StopAllCoroutines();
                        text.text = battlesentence[index];
                        nextline.SetActive(true);
                    }
                    else
                    {
                        StopAllCoroutines();
                    }
                }
            }
            //一般時候按鈕不能用
        }

    }
   

    IEnumerator TypeLine()
    {
        foreach (char c in battlesentence[index])
        {
            istyping = true;
            text.text += c;
            yield return new WaitForSeconds(textspeed);
        }
        text.text = battlesentence[index];
        nextline.SetActive(true);
        istyping = false;
    }

    void NextLine()
    {
        if (index >= battlesentence.Length)
        {
            Checkwhoend();
        }
        else
        {
            text.text = string.Empty;
            Checkifname();
            StartCoroutine(TypeLine());
        }
    }

    public void Checkwhoend()
    {
        isplayerchossing = true;
        if (badend)
        {
            bin.distroyallheart();
            bin.playerheath = 100;
            text.text = string.Empty;
            Storyinformation.instance.FinishBigBattlefalse(bin.thisbossname);
            battale.startani.SetTrigger("nofight");
            bigpanel.SetActive(false);
            badend = false;
        }else if (thend)
        {
            bin.distroyallheart();
            bin.playerheath = 100;
            text.text = string.Empty;
            Storyinformation.instance.FinishBigBattle(bin.thisbossname);
            battale.startani.SetTrigger("nofight");
            bigpanel.SetActive(false);
            thend = false;
        }
    }

    public void Checkifname()
    {
        //確認位置與要做的事情
        if (battlesentence[index].StartsWith("n-"))
        {
            nextline = nextline02;
            index++;
            pt = false;
            bosstext.SetActive(true);
            text = textboss;
        }

        if (battlesentence[index].StartsWith("p-"))
        {
            nextline = nextline01;
            index++;
            pt = true;
            bosstext.SetActive(false);
            text = textplayer;
        }

        if (battlesentence[index].StartsWith("na-"))
        {
            bin.ani.SetTrigger(battlesentence[index + 1]);
            index += 2;
        }

        if (battlesentence[index].StartsWith("pc-"))
        {
            bpc.bossnumber = battlesentence[index+1];
            if (battlesentence[index + 1] == "AmyQA"&& !isfirsttalk)
            {
                isfirsttalk = true;
                teachmanager.instance.sandtheteach("teachboss03");
            }
            index +=2;
            battale.Buttonyes();
            //這邊先暫時選的時候只能在8秒鐘之內選
            eye.Startocountime(8);
            isplayerchossing = true;
        }
        else
        {
            isplayerchossing = false;
        }

        if (battlesentence[index].StartsWith("t-"))
        {
            isplayerchossing = true;
            teachmanager.instance.sandtheteach(battlesentence[index + 1]);
            index += 2;
        }
    }
}

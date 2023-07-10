using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleinformation : MonoBehaviour
{
    public string keyword, thisbossname;
    public int enemyheath=1;
    public int playerheath = 100;
    private int currentph;
    public bool isplayerGG;

    public Animator playerhurtani, playerhertani2000, ani,playergood;
    public Slider phslider;
    public Text quastiontext,tothename;
    public bossbattlesample battle;
    public battleplayerchoose bbc;
    public stringbattle stringbattle;
    public eyestime eye;
    public talks startalk,GGtalk;
    public talks[] dia;
    public TheQnA[] qa;
    public thehelpone[] help;
    public GameObject heart, enemyheathpo;
    public bool isrightanser;

    public GameObject heartall;
    
    public void Starthebattle()
    {
        currentph = playerheath;
        this.gameObject.SetActive(true);
        Inventoryfriendmeneger.instance.bin = this;
        bbc.bin = this;
        battle.bin = this;
        eye.bin = this;
        stringbattle.bin = this;
        tothename.text = thisbossname;
        distroyallheart();
        Duplcateheart();
        battle.Gobattle(startalk.dialogue);
    }
    public void distroyallheart()
    {
        if (heartall.transform.childCount != 0)
        {
            for (int i = 0; i <= heartall.transform.childCount; i++)
            {
                Destroy(heartall.transform.GetChild(0).gameObject);
            }
        }
    }
    public void Duplcateheart()
    {
        for (var i = 0; i < enemyheath; i++)
        {
            Instantiate(heart, new Vector3(0, 0, 0), Quaternion.identity,enemyheathpo.transform);
        }
    }

    public void TheQA(string qanumber)
    {
        keyword = qanumber;
        for (int i = 0; i < qa.Length; i++)
        {
            if (qa[i].keyword.Contains(qanumber))
            {
                quastiontext.text = qa[i].Quastion;
                eye.Startocountime(qa[i].maxtime);
                stringbattle.Invokechosse(qanumber, qa[i].Anserlong, qa[i].A, qa[i].B, qa[i].C, qa[i].D, qa[i].Quastion);
                break;
            }
        }

    }
   
    public void keyndia(string anser)
    {
        if (playerheath <= 0)
        {
            anser = "badend";
        }

        for (int i = 0; i < dia.Length; i++)
        {
            if (dia[i].Keyword==anser)
            {
                battle.Gobattle(dia[i].dialogue);
                if (isrightanser)
                {
                    Audiomanager.instance.Play("battleattack");
                    Enemyheartdestroy();
                    if (dia[i].isendsentence)
                    {
                        battle.thend = true;
                    }
                    
                }
                else
                {
                    if (dia[i].isbadend)
                    {
                        battle.badend = true;
                    }
                    Playerheathcount(dia[i].hurtplayer);
                }
                return;
            }
        }
        for (int i = 0; i < dia.Length; i++)
        {
            if (dia[i].Keyword==bbc.bossnumber)
            {
                Playerheathcount(dia[i].hurtplayer);
                battle.Gobattle(dia[i].dialogue);
                return;
            }
        }
    }

    public void helpbuttem(string who)
    {
        for (int i = 0; i < help.Length; i++)
        {
            if (help[i].keyword==who)
            {
                if (isrightanser)
                {
                    Audiomanager.instance.Play("battleattack");
                    playergood.SetTrigger("UIgood");
                    Enemyheartdestroy();
                    isrightanser = false;
                }
                else
                {
                    Playerheathcount(dia[i].hurtplayer);
                }
                battle.Gobattle(help[i].dialogue);
                return;
            }
        }
        for (int i = 0; i < dia.Length; i++)
        {
            if (dia[i].Keyword == bbc.bossnumber)
            {
                Playerheathcount(dia[i].hurtplayer);
                battle.Gobattle(dia[i].dialogue);
                return;
            }
        }
    }

   
    private void Update()
    {
        if(playerheath > currentph)
        {
            playerheath--;
            phslider.value = playerheath;
        }
       
    }
    public void Gethurheart()
    {
        int all = heartall.transform.childCount;
        while (all > 0)
        {
            Animator ani = heartall.transform.GetChild(all-1).gameObject.GetComponent<Animator>();
            AnimatorClipInfo[] clip = ani.GetCurrentAnimatorClipInfo(0);
            if (clip[0].clip.name == "blurhearteanialive")
            {
                ani.SetTrigger("todie");
                break;
            }
            else
            {
                all -= 1;
            }
        }
        
    }
    public void Enemyheartdestroy()
    {
        if (heartall.transform.childCount > 0)
        {
            Gethurheart();
        }
        else
        {
            Debug.Log("noheartodestroy");
        }
        isrightanser = false;
    }
    public void Playerheathcount(int x)
    {
        currentph -= x; 
        playerhurtani.SetTrigger("heathappend");
        playerhertani2000.SetTrigger("plhurt");
        Audiomanager.instance.Play("battleattack");
        Debug.Log("playerhurt");
    }

   public void UIgood()
    {
        playergood.SetTrigger("UIgood");
    }
    public void UIbad()
    {
        playergood.SetTrigger("nogood");
    }
}

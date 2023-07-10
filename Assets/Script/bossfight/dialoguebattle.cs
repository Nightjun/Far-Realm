using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoguebattle : MonoBehaviour
{
    public bossbattlesample amyb,emmab,computerb;
    public int playerhealth, enemyhealth = 200;
    public eyestime eye;
    public Animator playerhurtani,enemybarani,playerhertani2000,amyhurtani,emmaani,computerani;
    public Slider playerheathbar,enemyheathbar;

    [TextArea(3, 10)]
    public string[] diasand,dia0,dia1,dia2,diae1, diae2, diae3, diae4, diae5,playerdia01,playerdia02,playerdia03, playerdia04, playerdia05, playerdia06, playerdia07, playerdia08, playerdia09,diedia;
    
    //對應劇情
    public string bossone;
    
    public void Theanserafterbattle(string bossnumbeer,int numberafter)
    {
        bossone = bossnumbeer;
        switch (bossnumbeer)
        {
            case "Amy01":
                switch (numberafter)
                {//目前先這樣之後可能會加一些特定的對應
                    case 0:
                        diasand = dia0;
                        break;
                    case 1://正確的
                        diasand = dia1;
                        Enemyhurt(100);
                        amyhurtani.SetBool("Amyangry", false);
                        amyhurtani.SetTrigger("gethurt");
                        break;
                    case 2://錯誤的
                        diasand = dia2;
                        playerhurt(10);
                        amyhurtani.SetBool("Amyangry", true);
                        break;
                }
                if (playerhealth <= 0)
                {
                    diasand = diedia;
                    numberafter = 3;
                }
                //bossbattlesample裡的gobattle
                //amyb.Gobattle(diasand, bossnumbeer,numberafter);
                break;
            case "Emma01":
                switch (numberafter)
                {
                    case 0:
                        diasand = diae1;
                        break;
                    case 1:
                        diasand = diae2;
                        Enemyhurt(50);
                        emmaani.SetTrigger("ishurt");
                        emmaani.SetBool("isangry", false);
                        break;
                    case 2:
                        diasand = diae3;
                        playerhurt(10);
                        emmaani.SetBool("isangry", true);
                        break;
                }
                if (playerhealth <= 0)
                {
                    diasand = diedia;
                    numberafter = 3;
                }
               // emmab.Gobattle(diasand, bossnumbeer, numberafter);
                break;
            case "Emma02":
                switch (numberafter)
                {
                    case 0:
                        diasand = diae2;
                        break;
                    case 1:
                        diasand = diae4;
                        Enemyhurt(50);
                        emmaani.SetTrigger("ishurt");
                        emmaani.SetBool("isangry", false);
                        break;
                    case 2:
                        diasand = diae5;
                        playerhurt(10);
                        emmaani.SetBool("isangry", true);
                        break;
                }
                if (playerhealth <= 0)
                {
                    diasand = diedia;
                    numberafter = 3;
                }
               // emmab.Gobattle(diasand, bossnumbeer, numberafter);
                break;
            case "playersit":
                switch (numberafter)
                {
                    case 0:
                        diasand = playerdia01;
                        break;
                    case 1:
                        diasand = playerdia02;
                        computerani.SetTrigger("isright");
                        Enemyhurt(25);
                        break;
                    case 2:
                        diasand = playerdia03;
                        computerani.SetTrigger("iswrong");
                        playerhurt(10);
                        break;
                }
                if (playerhealth <= 0)
                {
                    diasand = diedia;
                    numberafter = 3;
                }
                //computerb.Gobattle(diasand, bossnumbeer, numberafter);
                break;
            case "playersit02":
                switch (numberafter)
                {
                    case 1:
                        diasand = playerdia04;
                        computerani.SetTrigger("isbroken");
                        Enemyhurt(25);
                        break;
                    case 2:
                        diasand = playerdia05;
                        computerani.SetTrigger("iswrong");
                        playerhurt(10);
                        break;
                }
                if (playerhealth <= 0)
                {
                    diasand = diedia;
                    numberafter = 3;
                }
                //computerb.Gobattle(diasand, bossnumbeer, numberafter);
                break;
            case "playersit03":
                switch (numberafter)
                {
                    case 0:
                        diasand = playerdia07;
                        computerani.SetTrigger("isright");
                        Enemyhurt(25);
                        break;
                    case 1:
                        diasand = playerdia06;
                        playerhurt(10);
                        break;
                    case 2:
                        diasand = playerdia06;
                        playerhurt(10);
                        break;
                }
                if (playerhealth <= 0)
                {
                    diasand = diedia;
                    numberafter = 3;
                }
                //computerb.Gobattle(diasand, bossnumbeer, numberafter);
                break;
            case "playersit04":
                switch (numberafter)
                {
                    case 1:
                        diasand = playerdia08;
                        computerani.SetTrigger("isright");
                        Enemyhurt(25);
                        break;
                    case 2:
                        diasand = playerdia09;
                        computerani.SetTrigger("iswrong");
                        playerhurt(10);
                        break;
                }
                if (playerhealth <= 0)
                {
                    diasand = diedia;
                    numberafter = 3;
                }
                //computerb.Gobattle(diasand, bossnumbeer, numberafter);
                break;
        }
       
    }

    public void playerhurt(int howhurt)
    {
        playerhealth -= howhurt;
        playerheathbar.value = playerhealth ;
        playerhurtani.SetTrigger("heathappend");
        playerhertani2000.SetTrigger("plhurt");
    }

    public void Enemyhurt(int howhurt)
    {
        enemyhealth -= howhurt;
        enemyheathbar.value = enemyhealth;
        enemybarani.SetTrigger("enemybar");
    }

    public void friendyes()
    {
        switch (Inventoryfriendmeneger.instance.friendname)
        {
            case "硬體工程師":
                if (bossone == "playersit03")
                {
                    Theanserafterbattle(bossone, 0);
                }
                else
                {
                    Theanserafterbattle(bossone, 2);
                }
                break;
        }
        eye.choosedone();
    }
}

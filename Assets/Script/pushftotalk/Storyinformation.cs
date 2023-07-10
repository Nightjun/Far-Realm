using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Storyinformation : MonoBehaviour
{
    public static Storyinformation instance;

    
    public static bool istalktoamy,istalktoEmma,iscomputer,isgama01,isgama02,isice01,isice02,isice03,ishead01,ishead02,isnoodles01,isnoodles02,isdonegama,isdoneice,isdonehead,isdonesupork,isdonenoodles, aftertalkkk;
    public GameObject noteteach, amy, emma, computer, waterb1, waterb2, amy01, amy02, emma01, emma02, playersit01, playersit02, bigpanel, gosis, grandma, corss, intothe, redpartical, moveto, chu, tiger, head, ashu, thunderone, thetalksystem, thepot, aftergamani, afterbambooani,afterheadani, thedog, theend, ashufirstone,xa;
    public bool firstimeopentab, firstalktoamy,firstusebutten;
    public Animator tobattleani,phoneani,tigertonormal;
    public teachdia tdia;
    public Addmission addmission;
    public bossbattlesample bbs;
    public xagodwalk xw;
    public mapsetting mapp;
    public turnoffnote noteoff;
    public bool mantalkdone;
    bool isbacktonormel;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
    private void Update()
    {
        if (firstimeopentab)
        {
            noteteach.SetActive(true);
            hintone.instence.Closethehint();
            teachmanager.instance.sandtheteach("teachnote");
            waterb2.SetActive(true);
            firstimeopentab = false;
        }
        if (isbacktonormel)
        {
            tobattleani.SetBool("tobattle", false);
            AnimatorStateInfo stateinfo = tobattleani.GetCurrentAnimatorStateInfo(0);
            if (stateinfo.IsName("tobattlemiddleAnimation"))
            {
                bigpanel.SetActive(false);
                tobattleani.gameObject.SetActive(false);
                isbacktonormel = false;
            }
        }
    }
    //計算主角跟誰說過話
    public void Talktowho(string number)
    {
        switch (number)
        {
            case "waterbath":
                animatectrol.instance.Closewaterbath();
                camerafindplayer.instance.ShakeCamera(4f, 0.1f);
                Audiomanager.instance.StopPlay("kidlaugh");
                Audiomanager.instance.Play("playerwakeup");
                Audiomanager.instance.Play("playerdeeplybreathe"); 
                break;
            case "waterbath02":
                PlayerControll.instance.anim.SetFloat("Horizonztal", 1);
                PlayerControll.instance.anim.SetFloat("Vertical", 0);
                animatectrol.instance.Openwaterbath();
                break;
            case "waterdispenser":
                PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
                PlayerControll.instance.anim.SetFloat("Vertical", 1);
                break;
            case "rif":
                PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
                PlayerControll.instance.anim.SetFloat("Vertical", 1);
                break;
            case "Rober01":

                break;
            case "0":

                break;
            case "Amy":
                firstalktoamy = true;
                hintone.instence.Closethehint();
                break;
            case "Emma01":

                break;
            case "Emma02":
                
                break;
            case "電腦":
                break;
            case "drageman":
                grandmaniall.instance.Dragenmanshock();
                break;
            case "meetgrandma":
                PlayerControll.instance.TimetoNotgo();
                camerafindplayer.instance.ShakeCamera(3f, 0.1f);
                addmission.Removemission("funeral");
                break;
            case "noteteach":
                hintone.instence.Openthrhint("aftertab");
                break;
            case "forest01":
                break;
            case "teachnote":
                noteoff.canclose = true;
                break;
            case "teachbag":
                InventoryManager.okclose = true;
                break;
            case "teacmap":
                mapp.canclose = true;
                break;
            case "grandmastart":
                Audiomanager.instance.Play("firldbmusic");
                addmission.Removeword("B45");
                addmission.Removeword("A12");
                addmission.Removeword("資料");
                addmission.Removeword("Rick");
                break;
            case "grandmatoghost1":
                grandmaniall.instance.grandmatoghost();
                Audiomanager.instance.Play("yellowlaugh");
                break;
            case "intounknow":
                PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
                PlayerControll.instance.anim.SetFloat("Vertical", -1);
                xw.isfallowing = false;
                addmission.MissionIn("chein");
                break;
            case "crossbrige":
                PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
                PlayerControll.instance.anim.SetFloat("Vertical", -1);
                PlayerControll.instance.letparticleon();
                Audiomanager.instance.Play("xagodmagic");
                Instantiate(redpartical, PlayerControll.instance.transform.position-new Vector3(0,0.35f,0),redpartical.transform.rotation );
                break;
            case "townstart09":
                Alldialogue.instance.Trueialogue("townstart12");
                break;
            case "townstart03":
                Alldialogue.instance.SetFalseFdia("townstart031");
                break;
        }
        
    }

    public void Talktowho2(string number)
    {
        switch (number)
        {
            case "waterbath":
                waterb1.SetActive(false);
                addmission.MissionIn("amy");
                gosis.SetActive(false);
                UIcall.instance.informyes = true;
                hintone.instence.Openthrhint(number);
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "waterbath02":
                animatectrol.instance.Closewaterbath();
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "grandmastart":
                PlayerControll.instance.istalktosomeoneb = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "drageman":
                grandmaniall.instance.Dragenmannormal();
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "meetgrandma":
                timetoani.instance.Aninow();
                PlayerControll.instance.anim.SetFloat("Horizonztal", 1);
                PlayerControll.instance.anim.SetFloat("Vertical", 0);
                grandmaniall.instance.Meetgrandmaa();
                break; 
             case "grandmago":
                grandma.GetComponent<grandmtouch>().isoktogo=true;
                grandma.GetComponent<grandmtouch>().ani.SetTrigger("gogograndma");
                Audiomanager.instance.Play("wiredmusic");
                Destroy(grandma.GetComponent<Dialogue>());
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break; 
             case "grandmatoghost1":
                grandmaniall.instance.grandmadiappear();
                Audiomanager.instance.StopPlay("yellowlaugh");
                Audiomanager.instance.Play("ghostfire");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "grandmatoghost200":
               
                break;
            case "grandmatoghost202":
                grandmaniall.instance.ghostleave();
                grandmaniall.instance.Grandmazoomout();
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "grandmatoghost3":
                Audiomanager.instance.StopPlay("yellowbackground");
                Audiomanager.instance.Play("forestbackground");
                FadeUI.instance.Totherscence("Forest");
                PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
                PlayerControll.instance.anim.SetFloat("Vertical", 1);
                PlayerControll.instance.isbattle = true;
                PlayerControll.instance.isjustw = false;
                UIcall.instance.somethingopen = false;
                break;
            case "forest01":
                PlayerControll.instance.isbattle = true;
                break;
            case "mantalkp02":
                PlayerControll.instance.isbattle = true;
                break;
            case "mantalk03":
                PlayerControll.instance.isbattle = true;
                break;
            case "mantalk7":
                PlayerControll.instance.isbattle = true;
                break;
            case "mantalk10":
                PlayerControll.instance.isbattle = true;
                break;
            case "mantalk04":
                PlayerControll.instance.isbattle = true;
                break;
            case "mantalk9":
                PlayerControll.instance.isbattle = true;
                break;
            case "mantalk6":
                hintone.instence.Openthrhint("bag");
                PlayerControll.instance.isbattle = true;
                UIcall.instance.somethingopen = false;
                break;
            case "mantalk5":
                hintone.instence.Openthrhint("map");
                PlayerControll.instance.isbattle = true;
                UIcall.instance.somethingopen = false;
                break;
            case "mantalk8":
                addmission.MissionIn("goup");
                xw.isfallowing = true;
                thetalksystem.SetActive(true);
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                mantalkdone = true;
                break;
            case "mantalkafterok":
                thetalksystem.SetActive(true);
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "mantalkafter":
                PlayerControll.instance.isbattle = true;
                break;
            case "intounknow":
                PlayerControll.instance.isgofront = true;
                Audiomanager.instance.StopPlay("forestbackground");
                Audiomanager.instance.Play("townbackground");
                addmission.MissionIn("chan");
                addmission.Removemission("goup");
                FadeUI.instance.Totherscence("town");
                PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
                PlayerControll.instance.anim.SetFloat("Vertical", 1);
                intothe.SetActive(false);
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "crossbrige":
                corss.SetActive(false);
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "townstart":
                Alldialogue.instance.falseialogue("townstart");
                addmission.MissionIn("startown");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "townstart025":
                Alldialogue.instance.falseialogue("townstart025");
                Alldialogue.instance.SettrueFdia("townstart03");
                Alldialogue.instance.SettrueFdia("townstart031");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "townstart04":
                Alldialogue.instance.Sendialogue("townstart06");
                break;
            case "townstart05":
                Alldialogue.instance.Sendialogue("townstart06"); 
                break;
            case "townstart06":
                Alldialogue.instance.Sendialogue("townstart07");
                addmission.Removemission("startown");
                break;
            case "townstart08":
                Alldialogue.instance.Sendialogue("townstart09");
                break;
            case "townstart09":
                Alldialogue.instance.Sendialogue("townstart10");
                break;
            case "townstart11":
                Alldialogue.instance.SettrueFdia("thefood");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "townstart12":
                ashu.SetActive(false);
                PlayerControll.instance.gameObject.transform.position =new Vector3(0,0,0);
                addmission.MissionIn("noodelle01");
                Alldialogue.instance.SettrueFdia("ns01");
                Alldialogue.instance.SettrueFdia("head01");
                Alldialogue.instance.SettrueFdia("gamastart01");
                Alldialogue.instance.SettrueFdia("icee01");
                Alldialogue.instance.falseialogue("townstart12");
                Alldialogue.instance.falseialogue("townstart02");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "gama02":
                addmission.MissionIn("gama02");
                addmission.MissionIn("gama0202");
                Alldialogue.instance.SettrueFdia("gama03");
                Alldialogue.instance.SettrueFdia("gama0401");
                Alldialogue.instance.SettrueFdia("gama0402");
                Alldialogue.instance.SettrueFdia("gama0403");
                Alldialogue.instance.SettrueFdia("gama0404");
                Alldialogue.instance.SettrueFdia("gama0405");
                Alldialogue.instance.SettrueFdia("gama0406");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "gama03":
                Alldialogue.instance.SetFalseFdia("gama03");
                addmission.Addword("阿梅花");
                addmission.Removemission("gama02");
                isgama01 = true;
                if (isgama02)
                {
                    addmission.MissionIn("gama03");
                    addmission.Removemission("gama0202");
                    addmission.Removemission("gama02");
                    Alldialogue.instance.SettrueFdia("赤虯");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "gama0401":
                Alldialogue.instance.SetFalseFdia("gama0401");
                Alldialogue.instance.SetFalseFdia("gama0402");
                Alldialogue.instance.SetFalseFdia("gama0403");
                Alldialogue.instance.SetFalseFdia("gama0404");
                Alldialogue.instance.SetFalseFdia("gama0405");
                Alldialogue.instance.SetFalseFdia("gama0406");
                addmission.Removemission("gama0202");
                addmission.Addword("小美");
                isgama02 = true;
                if (isgama01)
                {
                    addmission.MissionIn("gama03");
                    addmission.Removemission("gama0202");
                    addmission.Removemission("gama02");
                    Alldialogue.instance.SettrueFdia("赤虯");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "icee01":
                addmission.MissionIn("ice02");
                break;
            case "ice02":
                Alldialogue.instance.SettrueFdia("ice04");
                Alldialogue.instance.SettrueFdia("ice05");
                Alldialogue.instance.SettrueFdia("ice06");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ice04":
                Alldialogue.instance.SetFalseFdia("ice04");
                addmission.Addword("虎姑婆01");
                isice01 = true;
                if (isice01 && isice02 && isice03)
                {
                    Alldialogue.instance.SettrueFdia("虎姑婆");
                    addmission.MissionIn("ice03");
                    addmission.Removemission("ice02");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ice05":
                Alldialogue.instance.SetFalseFdia("ice05");
                addmission.Addword("虎姑婆02");
                isice02 = true;
                if (isice01 && isice02 && isice03)
                {
                    Alldialogue.instance.SettrueFdia("虎姑婆");
                    addmission.MissionIn("ice03");
                    addmission.Removemission("ice02");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ice06":
                Alldialogue.instance.SetFalseFdia("ice06");
                addmission.Addword("虎姑婆03");
                isice03 = true;
                if (isice01 && isice02 && isice03)
                {
                    Alldialogue.instance.SettrueFdia("虎姑婆");
                    addmission.MissionIn("ice03");
                    addmission.Removemission("ice02");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "bamboo03":
                Alldialogue.instance.SettrueFdia("bamboo04");
                addmission.MissionIn("bamboo02");
                InventoryManager.money += 100;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "bamboo06":
                isdonesupork = true;
                addmission.Addword("陳姑娘03");
                InventoryManager.money += 300;
                addmission.Removemission("bamboo02"); 
                Alldialogue.instance.SettrueFdia("陳姑娘");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                afterbambooani.SetActive(true);
                Chackeverythingisready();
                break;
            case "head01":
                addmission.MissionIn("head02");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "head02":
                ishead01 = true;
                Alldialogue.instance.SetFalseFdia("head02");
                addmission.Addword("無頭人頭01");
                if (ishead01 && ishead02)
                {
                    addmission.Removemission("head02");
                    addmission.MissionIn("head03");
                    Alldialogue.instance.SettrueFdia("人頭與無頭");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "head03":
                ishead02 = true;
                Alldialogue.instance.SetFalseFdia("head03");
                addmission.Addword("無頭人頭02");
                if (ishead01 && ishead02)
                {
                    addmission.Removemission("head02");
                    addmission.MissionIn("head03");
                    Alldialogue.instance.SettrueFdia("人頭與無頭");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ns03":
                isdonenoodles = true;
                addmission.Removemission("noodelle01");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ns051":
                addmission.Removemission("noodelle01");
                addmission.MissionIn("noodle02");
                Alldialogue.instance.SettrueFdia("ns06");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ns052":
                addmission.Removemission("noodelle01");
                addmission.MissionIn("noodle02");
                Alldialogue.instance.SettrueFdia("ns06");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ns06":
                Alldialogue.instance.SetFalseFdia("ns06");
                Alldialogue.instance.SettrueFdia("ns07"); 
                addmission.Removemission("noodle02");
                addmission.MissionIn("noodle03"); 
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ns07":
                Alldialogue.instance.SetFalseFdia("ns07");
                Alldialogue.instance.SettrueFdia("ns08");
                Alldialogue.instance.SettrueFdia("ns09");
                addmission.Removemission("noodle03");
                addmission.MissionIn("noodle04");
                addmission.MissionIn("noodle05");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ns08":
                Alldialogue.instance.SetFalseFdia("ns08");
                addmission.Removemission("noodle04");
                isnoodles01 = true;
                if (isnoodles01 && isnoodles02)
                {
                    addmission.MissionIn("noodle06");
                    Alldialogue.instance.SettrueFdia("雷鳥");
                    addmission.Addword("雷鳥");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "ns10":
                addmission.Removemission("noodle05"); 
                isnoodles02 = true;
                if (isnoodles01 && isnoodles02)
                {
                    
                    addmission.MissionIn("noodle06");
                    Alldialogue.instance.SettrueFdia("雷鳥");
                    addmission.Addword("雷鳥");
                }
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "gama06":
                addmission.Addword("陳姑娘07");
                Alldialogue.instance.SettrueFdia("buyone");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                Chackeverythingisready();
                break;
            case "ice09":
                addmission.Addword("陳姑娘05");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                Chackeverythingisready();
                break;
            case "head05":
                addmission.Addword("陳姑娘06");
                afterheadani.SetActive(true);
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                Chackeverythingisready();
                break;
            case "ns12":
                addmission.Addword("陳姑娘04");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                Chackeverythingisready();
                break;
            case "thegirl02":
                Alldialogue.instance.SettrueFdia("thegirl03");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "thegirl03":
                Alldialogue.instance.SetFalseFdia("thegirl03");
                Alldialogue.instance.SettrueFdia("thegirl04");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "thegirl04":
                Alldialogue.instance.SetFalseFdia("thegirl04");
                Alldialogue.instance.SettrueFdia("thegirl");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "potato":
                Alldialogue.instance.SetFalseFdia("potato");
                Alldialogue.instance.SettrueFdia("potato01");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "potato01":
                Alldialogue.instance.SetFalseFdia("potato01");
                Alldialogue.instance.SettrueFdia("potato"); 
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "wiredfish01":
                Alldialogue.instance.SettrueFdia("wiredfish");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "buyone":
                Alldialogue.instance.SettrueFdia("buyone");
                break;
            case "gama07":
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                Alldialogue.instance.SettrueFdia("buyone");
                break;
            case "noheadgirlyes":
                Allpasserby.instence.npcs[0].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "noheadgirlno":
                Allpasserby.instence.npcs[0].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passby02Yes":
                Allpasserby.instence.npcs[1].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passby02NO":
                Allpasserby.instence.npcs[1].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passflyYes":
                Allpasserby.instence.npcs[2].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passflyNo":
                Allpasserby.instence.npcs[2].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passby04Yes":
                Allpasserby.instence.npcs[3].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passby04No":
                Allpasserby.instence.npcs[3].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passby05Yes":
                Allpasserby.instence.npcs[4].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passby05No":
                Allpasserby.instence.npcs[4].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passby06Yes":
                Allpasserby.instence.npcs[5].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "passby06No":
                Allpasserby.instence.npcs[5].playerstartalk = false;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break; 
            case "thefood":
                Alldialogue.instance.SetFalseFdia("thefood");
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            case "gamafterani":
                xa.SetActive(true);
                Alldialogue.instance.Sendialogue("gamafterani1");
                break;
            case "gamafterani1":
                xa.SetActive(false);
                UIcall.instance.somethingopen = false;
                PlayerControll.instance.isbattle = false;
                break;
            case "afterbambooani":
                xa.SetActive(true);
                Alldialogue.instance.Sendialogue("afterbambooani1");
                break;
            case "afterbambooani1":
                xa.SetActive(false);
                Alldialogue.instance.Sendialogue("afterbambooani2");
                break;
            case "afterbambooani2":
                UIcall.instance.somethingopen = false;
                PlayerControll.instance.isbattle = false;
                break;
            case "afterheadani":
                UIcall.instance.somethingopen = false;
                PlayerControll.instance.isbattle = false;
                break;
            case "kareafish":
                InventoryManager.money += 100;
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
            default:
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                break;
        }
    }

    //完成文字打鬥
    public void FinishBigBattle(string linenumber)
    {
        switch (linenumber)
        {
            
            case "Amy":
                UIcall.instance.somethingopen = false;
                istalktoamy = true;
                isbacktonormel = true;
                PlayerControll.instance.isbattle = false;
                amy.SetActive(false);
                amy01.SetActive(false);
                amy02.SetActive(true);
                emma01.SetActive(false);
                emma02.SetActive(true);
                Audiomanager.instance.Play("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                addmission.Removemission("amy");
                addmission.Addword("amy");
                addmission.MissionIn("emma");
                break;
            case "Emma":
                UIcall.instance.somethingopen = false;
                istalktoEmma = true;
                isbacktonormel = true;
                PlayerControll.instance.isbattle = false;
                emma.SetActive(false);
                emma01.SetActive(true);
                emma02.SetActive(false);
                playersit01.SetActive(false);
                playersit02.SetActive(true);
                Audiomanager.instance.Play("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                addmission.Removemission("emma");
                addmission.Addword("emma");
                addmission.MissionIn("computer");
                break;
            case "電腦":
                UIcall.instance.somethingopen = false;
                iscomputer = true;
                Audiomanager.instance.StopPlay("battlemusic");
                phoneani.gameObject.SetActive(true);
                computer.SetActive(false);
                phoneani.SetTrigger("phonecall");
                tobattleani.SetBool("tobattle", false);
                tobattleani.gameObject.SetActive(false);
                addmission.Removemission("computer");
                addmission.MissionIn("funeral");
                hintone.instence.Openthrhint("phone");
                Audiomanager.instance.Play("phonezoo");
                //動畫轉場景
                break;
            case "Uloser":
                isbacktonormel = true;
                break;
            case "赤虯":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                isdonegama = true;
                chu.SetActive(false);
                aftergamani.SetActive(true);
                Audiomanager.instance.Play("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                Alldialogue.instance.SetFalseFdia("赤虯");
                Alldialogue.instance.Sendialogue("gama06");
                addmission.Removemission("gama03");
                break;
            case "虎姑婆":
                UIcall.instance.somethingopen = false;
                isdoneice = true;
                isbacktonormel = true;
                thepot.SetActive(false);
                addmission.Removemission("ice03");
                tiger.SetActive(false);
                tigertonormal.SetTrigger("after");
                Audiomanager.instance.Play("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                Alldialogue.instance.SetFalseFdia("虎姑婆");
                Alldialogue.instance.Sendialogue("ice08");
                break;
            case "人頭與無頭":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                isdonehead=true;
                head.SetActive(false);
                Audiomanager.instance.Play("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                Alldialogue.instance.SetFalseFdia("人頭與無頭");
                Alldialogue.instance.Sendialogue("head051");
                addmission.Removemission("head03");
                break;
            case "雷鳥":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                isdonenoodles = true;
                thunderone.SetActive(false);
                Audiomanager.instance.Play("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                Alldialogue.instance.SetFalseFdia("雷鳥");
                addmission.Removemission("noodle06");
                Alldialogue.instance.Sendialogue("ns12");
                break;
            case "陳姑娘":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                theend.SetActive(true);
                Audiomanager.instance.Play("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                break;
           
        }

        UIcall.instance.somethingopen = false;
    }

    public void FinishBigBattlefalse(string linenumber)
    {
        switch (linenumber)
        {

            case "Amy":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                Audiomanager.instance.Play("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                break;
            case "Emma":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                Audiomanager.instance.Play("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                break;
            case "電腦":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                Audiomanager.instance.Play("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                //動畫轉場景
                break;
            case "赤虯":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                chu.SetActive(false);
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                break;
            case "虎姑婆":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                tiger.SetActive(false);
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                break;
            case "人頭與無頭":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                head.SetActive(false);
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                break;
            case "陳姑娘":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                break;
            case "雷鳥":
                UIcall.instance.somethingopen = false;
                isbacktonormel = true;
                thunderone.SetActive(false);
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.StopPlay("battlemusic");
                break;
        }
        UIcall.instance.somethingopen = false;
        PlayerControll.instance.isbattle = false;
    }

    public void Chackeverythingisready()
    {
        if (isdonegama&isdoneice&isdonehead&isdonesupork&isdonenoodles)
        {
            Alldialogue.instance.SettrueFdia("陳姑娘");
            thedog.SetActive(false);
        }
       
    }

    public void afterfistone()
    {
        istalktoamy = true;
        addmission.Removemission("amy");
        istalktoEmma = true;
        addmission.Removemission("emma");
        iscomputer = true;
        addmission.Removemission("computer"); 
        Audiomanager.instance.Play("togradmamusic");
        PlayerControll.instance.gameObject.transform.position = new Vector3(0, 0, 0);
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
    }
    public void aftergrandma()
    {
        istalktoamy = true;
        addmission.Removemission("amy");
        istalktoEmma = true;
        addmission.Removemission("emma");
        iscomputer = true;
        addmission.Removemission("computer");
        Audiomanager.instance.Play("forestbackground");
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
    }

    public void afterforest()
    {
        aftertalkkk = false;
        istalktoamy = true;
        addmission.Removemission("amy");
        istalktoEmma = true;
        addmission.Removemission("emma");
        iscomputer = true;
        addmission.Removemission("computer");
        addmission.MissionIn("chan");
        addmission.Removemission("goup");
        Audiomanager.instance.Play("townbackground");
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
        PlayerControll.instance.isbattle = false;
        UIcall.instance.somethingopen = false;
    }

    public void aftertalk()
    {
        aftertalkkk = true;
        istalktoamy = true;
        addmission.Removemission("amy");
        istalktoEmma = true;
        addmission.Removemission("emma");
        iscomputer = true;
        addmission.Removemission("computer");
        addmission.MissionIn("chan");
        addmission.Removemission("goup");
        UIcall.instance.somethingopen = false;
        FadeUI.instance.Totherscence("town");
        Audiomanager.instance.Play("townbackground");
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
        PlayerControll.instance.isbattle = false;
        PlayerControll.instance.gameObject.transform.position = new Vector3(0, 0, 0);
      
    }

    public void thetalkset()
    {
        ashufirstone.SetActive(false);
        ashu.SetActive(false);
        addmission.MissionIn("noodelle01");
        Alldialogue.instance.SettrueFdia("ns01");
        Alldialogue.instance.SettrueFdia("head01");
        Alldialogue.instance.SettrueFdia("gamastart01");
        Alldialogue.instance.SettrueFdia("icee01");
    }
}

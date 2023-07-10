using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quastionbutton : MonoBehaviour
{
    public Text yesb, nob;
    public string linenumber;
    public smalltalkmainsystem st;
    public tostringbattle battle,battle02,battlee03;
    public GameObject coffee01, coffe02,sink01,sink02,theshop,thewiredshop,thefood,theshopbutten;
    public Animator tobattleani,yellowpo;
    public Addmission addmission;
    public Dialogue1 dia0201, dia0202;

    bool isgotobattle,firstone;
    
    private void Update()
    {

        if (isgotobattle)
        {
            tobattleani.gameObject.SetActive(true);
            tobattleani.SetBool("tobattle", true);
           
            AnimatorStateInfo stateinfo = tobattleani.GetCurrentAnimatorStateInfo(0);
            if (stateinfo.IsName("tobattlemiddleAnimation"))
            {
                switch (linenumber)
                {
                    case "Amy":
                        battle.Tobigtalk(linenumber);
                        break;
                    case "Emma":
                        battle.Tobigtalk(linenumber);
                        break;
                    case "電腦":
                        battle.Tobigtalk(linenumber);
                        break;
                    case "赤虯":
                        battle02.Tobigtalk(linenumber);
                        break;
                    case "虎姑婆":
                        battle02.Tobigtalk(linenumber);
                        break;
                    case "人頭與無頭":
                        battle02.Tobigtalk(linenumber);
                        break;
                    case "陳姑娘":
                        battlee03.Tobigtalk(linenumber);
                        break;
                    case "雷鳥":
                        battle02.Tobigtalk(linenumber);
                        break;
                }
                isgotobattle = false;

            }

        }
        
    }

    public void Thebuttontext(string bnumber)
    {
        linenumber = bnumber;
        switch (bnumber)
        {
            case "waterdispenser":
                yesb.text = "不要";
                nob.text = "不要但戳一下";
                break;
            case "Amy":
                yesb.text = "資料(文字戰鬥)";
                nob.text = "沒事";
                break;
            case "rif":
                yesb.text = "上層";
                nob.text = "下層";
                break;
            case "coffee01":
                yesb.text = "好";
                nob.text = "不要";
                break;
            case "coffee02":
                yesb.text = "喝";
                nob.text = "不喝";
                break;
            case "sink01":
                yesb.text = "好";
                nob.text = "不好";
                break;
            case "sink02":
                yesb.text = "好";
                nob.text = "不好";
                break;
            case "Emma":
                yesb.text = "老闆(文字戰鬥)";
                nob.text = "沒事";
                break;
            case "電腦":
                yesb.text = "工作(文字戰鬥)";
                nob.text = "再休息一下下";
                break; 
            case "relative01":
                yesb.text = "還行";
                nob.text = "一點都不好";
                break;
            case "grandmatoghost101":
                yesb.text = "不...";
                nob.text = "喜...";
                break;
            case "grandmatoghost200":
                yesb.text = "....";
                nob.text = "????";
                break;
            case "townstart03":
                yesb.text = "陽春麵";
                nob.text = "滷肉飯";
                break;
            case "townstart07":
                yesb.text = "(人真好..)";
                nob.text = "恩";
                break;
            case "townstart10":
                yesb.text = "什麼?";
                nob.text = "?!!";
                break;
            case "townstart12":
                yesb.text = "謝謝...";
                nob.text = "恩..";
                break;
            case "gamastart01":
                theshopbutten.SetActive(true);
                yesb.text = "幫忙";
                nob.text = "離開";
                break;
            case "赤虯":
                theshopbutten.SetActive(true);
                yesb.text = "問到了(文字戰鬥)";
                nob.text = "等等";
                break;
            case "icee01":
                yesb.text = "調查";
                nob.text = "不要";
                break;
            case "虎姑婆":
                yesb.text = "安撫(文字戰鬥)";
                nob.text = "再等等";
                break;
            case "ice08":
                yesb.text = "陳姑娘";
                nob.text = "沒事";
                break;
            case "bamboo01":
                yesb.text = "幫忙";
                nob.text = "不要";
                break;
            case "bamboo02":
                yesb.text = "幫忙";
                nob.text = "不要";
                break;
            case "head01":
                yesb.text = "想辦法";
                nob.text = "離開";
                break;
            case "人頭與無頭":
                yesb.text = "解釋(文字戰鬥)";
                nob.text = "不要";
                break;
            case "head051":
                yesb.text = "陳...";
                nob.text = "陳姑娘";
                break;
            case "陳姑娘":
                yesb.text = "有件事..(文字戰鬥)";
                nob.text = "珍珠奶茶";
                break;
            case "chan01":
                yesb.text = "微微";
                nob.text = "正常冰全糖";
                break;
            case "ns01":
                yesb.text = "我有";
                nob.text = "沒有";
                break;
            case "ns02":
                yesb.text = "恩...";
                nob.text = "嘿...";
                break;
            case "ns031":
                yesb.text = "好";
                nob.text = "不要...";
                break;
            case "ns04":
                yesb.text = "其他...";
                nob.text = "那個...";
                break;
            case "ns05":
                yesb.text = "好";
                nob.text = "不要...";
                break;
            case "ns09":
                yesb.text = "點餐";
                nob.text = "要吃..";
                break;
            case "buyone":
                theshopbutten.SetActive(true);
                yesb.text = "老闆的故事";
                nob.text = "沒事";
                break;
            case "雷鳥":
                yesb.text = "老闆..(文字戰鬥)";
                nob.text = "等等";
                break;
            case "wiredfish":
                yesb.text = "買東西";
                nob.text = "其他";
                break;
            case "thecat":
                yesb.text = "好啊";
                nob.text = "不要";
                break;
            case "thegirl":
                yesb.text = "好..";
                nob.text = "不.."; 
                break;
            case "noheadgirl":
                yesb.text = "陳姑娘";
                nob.text = "沒事";
                break;
            case "passby02":
                yesb.text = "陳姑娘";
                nob.text = "沒事";
                break;
            case "passfly":
                yesb.text = "陳姑娘";
                nob.text = "沒事";
                break;
            case "passby04":
                yesb.text = "陳姑娘";
                nob.text = "沒事";
                break; 
            case "passby05":
                yesb.text = "陳姑娘";
                nob.text = "沒事";
                break;
            case "passby06":
                yesb.text = "陳姑娘";
                nob.text = "沒事";
                break; 
            case "bamboo05":
                yesb.text = "陳姑娘";
                nob.text = "那個...";
                break; 
        }
        
    }

    public void TheYesSituatuion()
    {
        switch (linenumber)
        {
            case "waterdispenser":
                st.isquation = false;
                st.Afterquastion();
                break;
            case "rif":
                animatectrol.instance.Openrifriup();
                st.Afterquastion();
                break;
            case "coffee01":
                animatectrol.instance.Coffeusing();
                coffee01.SetActive(false);
                coffe02.SetActive(true);
                st.Afterquastion();
                break;
            case "coffee02":
                animatectrol.instance.Coffetake();
                coffee01.SetActive(true);
                coffe02.SetActive(false);
                st.Afterquastion();
                break;
            case "sink01":
                animatectrol.instance.Openwatersink();
                sink01.SetActive(false);
                sink02.SetActive(true);
                st.Afterquastion();
                break;
            case "sink02":
                animatectrol.instance.Closewatersink();
                sink01.SetActive(true);
                sink02.SetActive(false);
                st.Afterquastion();
                break;
            case "Amy":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                hintone.instence.Closethehint();
                st.Afterquastion();
                Audiomanager.instance.StopPlay("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                //與主管的文字battle
                break;
            case "Emma":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                //與主管的文字battle
                break;
            case "電腦":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                //與主管的文字battle
                break;
            case "赤虯":
                theshopbutten.SetActive(false);
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "虎姑婆":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "雷鳥":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "人頭與無頭":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "陳姑娘":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "grandmatoghost101":
                yellowpo.SetTrigger("showend");
                dia0201.Sendthetalk();
                grandmaniall.instance.ghosttalk();
                st.Afterquastion();
                break;
            case "grandmatoghost200":
                dia0202.Sendthetalk();
                grandmaniall.instance.ghosttalk();
                st.Afterquastion();
                break;
            case "townstart03":
                Alldialogue.instance.SetFalseFdia("townstart03");
                Alldialogue.instance.Sendialogue("townstart04");
                st.Afterquastion2();
                break;
            case "townstart07":
                Alldialogue.instance.Sendialogue("townstart08");
                st.Afterquastion2();
                break;
            case "townstart10":
                thefood.SetActive(true);
                Alldialogue.instance.Sendialogue("townstart11");
                st.Afterquastion2();
                break;
            case "townstart12":
                st.Afterquastion();
                break;
            case "gamastart01":
                theshopbutten.SetActive(false);
                Alldialogue.instance.SetFalseFdia("gamastart01");
                Alldialogue.instance.Sendialogue("gama02");
                st.Afterquastion();
                break;
            
            case "icee01":
                Alldialogue.instance.SetFalseFdia("icee01");
                Alldialogue.instance.Sendialogue("ice02");
                addmission.MissionIn("ice02");
                addmission.Removemission("ice01");
                st.Afterquastion();
                break;
           
            case "ice08":
                Alldialogue.instance.Sendialogue("ice09");
                st.Afterquastion();
                break;
            case "bamboo01":
                Alldialogue.instance.falseialogue("bamboo01");
                Alldialogue.instance.Sendialogue("bamboo03");
                st.Afterquastion();
                break;
            case "bamboo02":
                Alldialogue.instance.Sendialogue("bamboo03");
                st.Afterquastion();
                break;
            case "head01":
                Alldialogue.instance.SetFalseFdia("head01");
                Alldialogue.instance.SettrueFdia("head02");
                Alldialogue.instance.SettrueFdia("head03");
                st.Afterquastion();
                break;
           
            case "head051":
                Alldialogue.instance.Sendialogue("head05");
                st.Afterquastion();
                break;
            
            case "chan01":
                Alldialogue.instance.Sendialogue("chan02");
                st.Afterquastion();
                break;
            case "ns01":
                Alldialogue.instance.SetFalseFdia("ns01");
                if (InventoryManager.money >= 840)
                {
                    Alldialogue.instance.Sendialogue("ns03");
                    Debug.Log("yesmoney");
                }
                else
                {
                    Alldialogue.instance.Sendialogue("ns031");
                    Debug.Log("nomoney");
                }
                st.Afterquastion2();
                break;
            case "ns02":
                Alldialogue.instance.Sendialogue("ns03");
                st.Afterquastion2();
                break;
            case "ns04":
                Alldialogue.instance.Sendialogue("ns05");
                st.Afterquastion2();
                break;
            case "ns05":
                Alldialogue.instance.Sendialogue("ns051");
                st.Afterquastion();
                break;
            case "ns031":
                Alldialogue.instance.Sendialogue("ns051");
                st.Afterquastion();
                break;
            
            case "ns09":
                Alldialogue.instance.SetFalseFdia("ns09");
                Alldialogue.instance.Sendialogue("ns10");
                st.Afterquastion2();
                break;
            case "buyone":
                theshopbutten.SetActive(false);
                Alldialogue.instance.SetFalseFdia("buyone");
                Alldialogue.instance.Sendialogue("gama07");
                st.Afterquastion();
                break;
            case "wiredfish":
                thewiredshop.SetActive(true);
                st.Afterquastion();
                break;
            case "thecat":
                Alldialogue.instance.SetFalseFdia("thecat");
                Alldialogue.instance.Sendialogue("thecat01");
                st.Afterquastion2();
                break;
            case "thegirl":
                Alldialogue.instance.SetFalseFdia("thegirl");
                Alldialogue.instance.Sendialogue("thegirl02");
                st.Afterquastion2();
                break;
            case "noheadgirl":
                Alldialogue.instance.Sendialogue("noheadgirlyes");
                st.Afterquastion2();
                break;
            case "passby02":
                Alldialogue.instance.Sendialogue("passby02Yes");
                st.Afterquastion2();
                break;
            case "passfly":
                Alldialogue.instance.Sendialogue("passflyYes");
                st.Afterquastion2();
                break;
            case "passby04":
                Alldialogue.instance.Sendialogue("passby04Yes");
                st.Afterquastion2();
                break;
            case "passby05":
                Alldialogue.instance.Sendialogue("passby05Yes");
                st.Afterquastion2();
                break;
            case "passby06":
                Alldialogue.instance.Sendialogue("passby06Yes");
                st.Afterquastion2();
                break;
            case "bamboo05":
                Alldialogue.instance.SetFalseFdia("bamboo05");
                Alldialogue.instance.Sendialogue("bamboo06");
                st.Afterquastion2();
                break;
            default:
                st.Afterquastion();
                break;
        }

    }
    public void TheNoSituatuion()
    {
        switch (linenumber)
        {
            case "waterdispenser":
                animatectrol.instance.Openwaterdis();
                st.Afterquastion();
                break;
            case "rif":
                animatectrol.instance.Openrifridown();
                st.Afterquastion();
                break;
            case "grandmatoghost101":
                yellowpo.SetTrigger("showend");
                dia0201.Sendthetalk();
                grandmaniall.instance.ghosttalk();
                st.Afterquastion();
                break;
            case "grandmatoghost200":
                dia0202.Sendthetalk();
                grandmaniall.instance.ghosttalk();
                st.Afterquastion();
                break;
            case "townstart03":
                Alldialogue.instance.SetFalseFdia("townstart03");
                Alldialogue.instance.Sendialogue("townstart05");
                st.Afterquastion2();
                break;
            case "townstart07":
                Alldialogue.instance.Sendialogue("townstart08");
                st.Afterquastion2();
                break;
            case "townstart10":
                thefood.SetActive(true);
                Alldialogue.instance.Sendialogue("townstart11");
                st.Afterquastion2();
                break;
            case "townstart12":
                st.Afterquastion();
                break;
            case "gamastart01":
                theshopbutten.SetActive(false);
                Alldialogue.instance.Sendialogue("gama0202");
                st.Afterquastion();
                break;
            case "icee01":
                Alldialogue.instance.Sendialogue("ice03");
                st.Afterquastion();
                break;
            case "虎姑婆":
                st.Afterquastion();
                break;
            case "ice08":
                st.Afterquastion();
                break;
            case "bamboo01":
                Alldialogue.instance.falseialogue("bamboo01");
                Alldialogue.instance.Sendialogue("bamboo02");
                break;
            case "bamboo02":
                Alldialogue.instance.Sendialogue("bamboo02");
                break;
            case "head01":
                st.Afterquastion();
                break;
            case "人頭與無頭":
                st.Afterquastion();
                break;
            case "head051":
                Alldialogue.instance.Sendialogue("head05");
                st.Afterquastion();
                break;
            case "陳姑娘":
                Alldialogue.instance.Sendialogue("chan01");
                st.Afterquastion();
                break;
            case "chan01":
                Alldialogue.instance.Sendialogue("chan03");
                st.Afterquastion();
                break;
            case "ns01":
                Debug.Log("noone");
                Alldialogue.instance.SetFalseFdia("ns01");
                Alldialogue.instance.Sendialogue("ns04");
                st.Afterquastion2();
                break;
            case "ns02":
                Alldialogue.instance.Sendialogue("ns03");
                st.Afterquastion2();
                break;
            case "ns04":
                Alldialogue.instance.Sendialogue("ns05");
                st.Afterquastion2();
                break;
            case "ns05":
                Alldialogue.instance.Sendialogue("ns052");
                st.Afterquastion();
                break;
            case "ns031":
                Alldialogue.instance.Sendialogue("ns052");
                st.Afterquastion();
                break;
            case "ns09":
                Alldialogue.instance.SetFalseFdia("ns09");
                Alldialogue.instance.Sendialogue("ns10");
                st.Afterquastion2();
                break;
            case "buyone":
                theshopbutten.SetActive(false);
                PlayerControll.instance.isbattle = false;
                UIcall.instance.somethingopen = false;
                st.Afterquastion();
                break;
            case "赤虯":
                theshopbutten.SetActive(false);
                st.Afterquastion();
                break;
            case "wiredfish":
                Alldialogue.instance.SetFalseFdia("wiredfish");
                Alldialogue.instance.Sendialogue("wiredfish01");
                st.Afterquastion2();
                break;
            case "thecat":
                Alldialogue.instance.SetFalseFdia("thecat");
                Alldialogue.instance.Sendialogue("thecat02");
                st.Afterquastion2();
                break;
            case "thegirl":
                Alldialogue.instance.SetFalseFdia("thegirl");
                Alldialogue.instance.Sendialogue("thegirl01");
                st.Afterquastion2();
                break;
            case "noheadgirl":
                Alldialogue.instance.Sendialogue("noheadgirlno");
                st.Afterquastion2();
                break;
            case "passby02":
                Alldialogue.instance.Sendialogue("passby02NO");
                st.Afterquastion2();
                break;
            case "passfly":
                Alldialogue.instance.Sendialogue("passflyNo");
                st.Afterquastion2();
                break; 
            case "passby04":
                Alldialogue.instance.Sendialogue("passby04No");
                st.Afterquastion2();
                break;
            case "passby05":
                Alldialogue.instance.Sendialogue("passby05No");
                st.Afterquastion2();
                break;
            case "passby06":
                Alldialogue.instance.Sendialogue("passby06No");
                st.Afterquastion2();
                break;
            case "bamboo05":
                Alldialogue.instance.SetFalseFdia("bamboo05");
                Alldialogue.instance.Sendialogue("bamboo06");
                st.Afterquastion2();
                break;
            default:
                st.Afterquastion();
                break;
        }
    }

    public void Theshop()
    {
        theshop.SetActive(true);
        st.Afterquastion();
    }
}

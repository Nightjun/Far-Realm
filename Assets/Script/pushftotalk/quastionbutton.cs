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
                    case "�q��":
                        battle.Tobigtalk(linenumber);
                        break;
                    case "����":
                        battle02.Tobigtalk(linenumber);
                        break;
                    case "��h�C":
                        battle02.Tobigtalk(linenumber);
                        break;
                    case "�H�Y�P�L�Y":
                        battle02.Tobigtalk(linenumber);
                        break;
                    case "���h�Q":
                        battlee03.Tobigtalk(linenumber);
                        break;
                    case "�p��":
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
                yesb.text = "���n";
                nob.text = "���n���W�@�U";
                break;
            case "Amy":
                yesb.text = "���(��r�԰�)";
                nob.text = "�S��";
                break;
            case "rif":
                yesb.text = "�W�h";
                nob.text = "�U�h";
                break;
            case "coffee01":
                yesb.text = "�n";
                nob.text = "���n";
                break;
            case "coffee02":
                yesb.text = "��";
                nob.text = "����";
                break;
            case "sink01":
                yesb.text = "�n";
                nob.text = "���n";
                break;
            case "sink02":
                yesb.text = "�n";
                nob.text = "���n";
                break;
            case "Emma":
                yesb.text = "����(��r�԰�)";
                nob.text = "�S��";
                break;
            case "�q��":
                yesb.text = "�u�@(��r�԰�)";
                nob.text = "�A�𮧤@�U�U";
                break; 
            case "relative01":
                yesb.text = "�٦�";
                nob.text = "�@�I�����n";
                break;
            case "grandmatoghost101":
                yesb.text = "��...";
                nob.text = "��...";
                break;
            case "grandmatoghost200":
                yesb.text = "....";
                nob.text = "????";
                break;
            case "townstart03":
                yesb.text = "���K��";
                nob.text = "���׶�";
                break;
            case "townstart07":
                yesb.text = "(�H�u�n..)";
                nob.text = "��";
                break;
            case "townstart10":
                yesb.text = "����?";
                nob.text = "?!!";
                break;
            case "townstart12":
                yesb.text = "����...";
                nob.text = "��..";
                break;
            case "gamastart01":
                theshopbutten.SetActive(true);
                yesb.text = "����";
                nob.text = "���}";
                break;
            case "����":
                theshopbutten.SetActive(true);
                yesb.text = "�ݨ�F(��r�԰�)";
                nob.text = "����";
                break;
            case "icee01":
                yesb.text = "�լd";
                nob.text = "���n";
                break;
            case "��h�C":
                yesb.text = "�w��(��r�԰�)";
                nob.text = "�A����";
                break;
            case "ice08":
                yesb.text = "���h�Q";
                nob.text = "�S��";
                break;
            case "bamboo01":
                yesb.text = "����";
                nob.text = "���n";
                break;
            case "bamboo02":
                yesb.text = "����";
                nob.text = "���n";
                break;
            case "head01":
                yesb.text = "�Q��k";
                nob.text = "���}";
                break;
            case "�H�Y�P�L�Y":
                yesb.text = "����(��r�԰�)";
                nob.text = "���n";
                break;
            case "head051":
                yesb.text = "��...";
                nob.text = "���h�Q";
                break;
            case "���h�Q":
                yesb.text = "�����..(��r�԰�)";
                nob.text = "�ï]����";
                break;
            case "chan01":
                yesb.text = "�L�L";
                nob.text = "���`�B���}";
                break;
            case "ns01":
                yesb.text = "�ڦ�";
                nob.text = "�S��";
                break;
            case "ns02":
                yesb.text = "��...";
                nob.text = "�K...";
                break;
            case "ns031":
                yesb.text = "�n";
                nob.text = "���n...";
                break;
            case "ns04":
                yesb.text = "��L...";
                nob.text = "����...";
                break;
            case "ns05":
                yesb.text = "�n";
                nob.text = "���n...";
                break;
            case "ns09":
                yesb.text = "�I�\";
                nob.text = "�n�Y..";
                break;
            case "buyone":
                theshopbutten.SetActive(true);
                yesb.text = "���󪺬G��";
                nob.text = "�S��";
                break;
            case "�p��":
                yesb.text = "����..(��r�԰�)";
                nob.text = "����";
                break;
            case "wiredfish":
                yesb.text = "�R�F��";
                nob.text = "��L";
                break;
            case "thecat":
                yesb.text = "�n��";
                nob.text = "���n";
                break;
            case "thegirl":
                yesb.text = "�n..";
                nob.text = "��.."; 
                break;
            case "noheadgirl":
                yesb.text = "���h�Q";
                nob.text = "�S��";
                break;
            case "passby02":
                yesb.text = "���h�Q";
                nob.text = "�S��";
                break;
            case "passfly":
                yesb.text = "���h�Q";
                nob.text = "�S��";
                break;
            case "passby04":
                yesb.text = "���h�Q";
                nob.text = "�S��";
                break; 
            case "passby05":
                yesb.text = "���h�Q";
                nob.text = "�S��";
                break;
            case "passby06":
                yesb.text = "���h�Q";
                nob.text = "�S��";
                break; 
            case "bamboo05":
                yesb.text = "���h�Q";
                nob.text = "����...";
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
                //�P�D�ު���rbattle
                break;
            case "Emma":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                //�P�D�ު���rbattle
                break;
            case "�q��":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("officebaclgroundmusic");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                //�P�D�ު���rbattle
                break;
            case "����":
                theshopbutten.SetActive(false);
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "��h�C":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "�p��":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "�H�Y�P�L�Y":
                UIcall.instance.somethingopen = true;
                isgotobattle = true;
                st.Afterquastion();
                Audiomanager.instance.StopPlay("townbackground");
                Audiomanager.instance.Play("tobattle");
                Audiomanager.instance.Play("battlemusic");
                break;
            case "���h�Q":
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
            case "��h�C":
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
            case "�H�Y�P�L�Y":
                st.Afterquastion();
                break;
            case "head051":
                Alldialogue.instance.Sendialogue("head05");
                st.Afterquastion();
                break;
            case "���h�Q":
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
            case "����":
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

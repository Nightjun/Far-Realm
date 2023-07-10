using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagsetting : MonoBehaviour
{
    public GameObject missionone, relateone, settingone,howtoplay,missionditel;
    public Text text;
    public notbutten nob;

    public void OpentheMissionone()
    {
        Audiomanager.instance.Play("lobbybuttom");
        missionone.SetActive(true);
        relateone.SetActive(false);
        settingone.SetActive(false);
        howtoplay.SetActive(false);
        missionditel.SetActive(true);
        text.text = "";
    }
    public void OpentheRelate()
    {
        Audiomanager.instance.Play("lobbybuttom");
        relateone.SetActive(true);
        missionone.SetActive(false);
        settingone.SetActive(false);
        howtoplay.SetActive(false);
        missionditel.SetActive(false);
        text.text = "";
        nob.replace();
    }
    public void OpentheSettingbu()
    {
        Audiomanager.instance.Play("lobbybuttom");
        settingone.SetActive(true);
        relateone.SetActive(false);
        missionone.SetActive(false);
        missionditel.SetActive(false);
        text.text = "";

    }

  
    public void Howtoplay()
    {
        howtoplay.SetActive(true);
        missionditel.SetActive(false); 
    }

    public void IGone()
    {
        Application.OpenURL("https://www.instagram.com/far_realm_/");
    }

    public void FBone()
    {
        Application.OpenURL("https://www.facebook.com/ThisisagameUpatree");
    }
}

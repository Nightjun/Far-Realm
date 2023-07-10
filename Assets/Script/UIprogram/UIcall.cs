using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcall : MonoBehaviour
{
    public static UIcall instance;

    public GameObject map, information, bag, setting,mission,relation,emergency;
    public bool somethingopen;
    public bool bagyes, mapyes, informyes;
    public notething missionthing;
    public static bool openwater, firistimeE, firstimeG, firstimetouseit;
    public notbutten nob;
    public Slider vsliderr;

    private void Awake()
    {
        if (instance != this)
            instance = this;
       
    }
    // Update is called once per frame
    void Update()
    {
       
        if (!somethingopen)
        {
            nob.replace();
            if (Input.GetKeyUp(KeyCode.E) && mapyes)
            {
                map.SetActive(true);
                somethingopen = true;
                if (!firistimeE)
                {
                    hintone.instence.Closethehint();
                    teachmanager.instance.sandtheteach("teacmap");
                    firistimeE = true;
               }
                else
                {
                    PlayerControll.instance.isbattle = true;
                }
                
            }
            if (Input.GetKeyUp(KeyCode.Tab) &&informyes)
            {
                if (openwater)
                {
                    Storyinformation.instance.firstimeopentab = true;
                    openwater = false;
                }
                //筆記本
                missionthing.Openit();
                Audiomanager.instance.Play("noteopen");
                information.SetActive(true);
                setting.SetActive(false);
                relation.SetActive(false);
                mission.SetActive(true);
                somethingopen = true;
                PlayerControll.instance.isbattle = true;
            }
            if (Input.GetKeyUp(KeyCode.G) && bagyes)
            {
                bag.SetActive(true);
                somethingopen = true;
                InventoryManager.RefreshItem();
                if (!firstimeG)
                {
                    hintone.instence.Closethehint();
                    teachmanager.instance.sandtheteach("teachbag");
                    firstimeG = true;
                }
                else
                {
                    PlayerControll.instance.isbattle = true;
                }
                //包包
            }
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                //設定
                information.SetActive(true);
                setting.SetActive(true);
                mission.SetActive(false);
                relation.SetActive(false);
                map.SetActive(false);
                bag.SetActive(false);
                somethingopen = true;
                PlayerControll.instance.isbattle = true;
            }
            
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            emergency.SetActive(true);
        }

    }

    public void thebattlenote()
    {
        if (!firstimetouseit)
        {
            teachmanager.instance.sandtheteach("teachboss02");
            firstimetouseit = true;
        }
    }
    public void Turnoffpanel()
    {
        somethingopen = false;
        PlayerControll.instance.isbattle = false;
    }

    public void Quithegame()
    {
        Application.Quit();
    }
    public void jumptothis()
    {
        firistimeE = true;
        firstimeG = true;
        openwater = false;
        firstimetouseit = true;
    }
}

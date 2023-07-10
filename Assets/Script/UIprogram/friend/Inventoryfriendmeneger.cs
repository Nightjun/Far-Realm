using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventoryfriendmeneger : MonoBehaviour
{
    public static Inventoryfriendmeneger instance;

    public eyestime eye;
    public battleplayerchoose bbc;
    public battleinformation bin;
    public Inventoryfriend myfriend;
    public GameObject slotGrid,yesbu,effect;
    public friendslot slotprefab;
    public Text friendInfromation;
    public string friendname;

    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }

    private void OnEnable()
    {
        RefreshItem();
        //instance.friendInfromation.text = "選擇使用同夥";
    }

    public static void UpdateItemInfo(string frienddescription, string friendname)
    {
        instance.friendname = friendname;
        instance.friendInfromation.text = frienddescription;
        instance.yesbu.SetActive(true);
        instance.effect.SetActive(false);
    }

    public static void CreateNewItem(friend friend)
    {
        friendslot newfriend = Instantiate(instance.slotprefab, instance.slotGrid.transform.position, Quaternion.identity);
        newfriend.gameObject.transform.SetParent(instance.slotGrid.transform);
        newfriend.slotfriend= friend;
    }
    public static void RemoveItem(friend friend)
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            if(instance.slotGrid.transform.GetChild(i).gameObject.GetComponent<friend>().friendname==friend.friendname)
                Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
    }

    public static void RefreshItem()
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < instance.myfriend.friendList.Count; i++)
        {
            CreateNewItem(instance.myfriend.friendList[i]);
        }
    }

    public void sendtobin()
    {
        effect.SetActive(true);
        Audiomanager.instance.Play("lobbybuttom");
        friendname += bbc.bossnumber;
        if (friendname == "工程師CQA03")
        {
            bin.isrightanser = true;
        }
        bin.helpbuttem(friendname);
        eye.choosedone();
    }
}

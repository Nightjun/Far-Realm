using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;

    public Inventory mybag;
    public chagethemoney atmoney;
    public GameObject slotGrid,panel;
    public Slot slotprefab;
    public Image image;
    public Text itemInfromation,itemholdnumber,itemname;
    public static bool okclose,firstopen;
    public static int money;


    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }

    public void Turnoffbag()
    {
        panel.SetActive(false);
        UIcall.instance.somethingopen = false;
        if (firstopen||Storyinformation.instance.mantalkdone)
        {
            PlayerControll.instance.isbattle = false;
        }
        else
        {
            firstopen = true;
        }
    }
    private void OnEnable()
    {
        RefreshItem();
        instance.image.gameObject.SetActive(false);
        instance.itemname.text = "";
        instance.itemInfromation.text = "¿ï¾Üª««~";
        instance.itemholdnumber.text = "";
    }
    public static void UpdateItemInfo(string itemdescription,string itemname,int itemnoldnumber, Sprite itemimage)
    {
        instance.image.gameObject.SetActive(true);
        instance.image.sprite= itemimage;
        instance.itemname.text = itemname;
        instance.itemInfromation.text = itemdescription;
        instance.itemholdnumber.text = itemnoldnumber.ToString();
    }
    public static void CreateNewItem(Item item)
    {
        Slot newItem = Instantiate(instance.slotprefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
        if (instance.slotGrid.transform.childCount > 4)
        {
            newItem.gameObject.SetActive(false);
        }
    }

    public static void RefreshItem()
    {
        instance.atmoney.howmuchmoney(money);
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
        for(int i = 0; i < instance.mybag.itemList.Count; i++)
        {
            CreateNewItem(instance.mybag.itemList[i]);
        }
    }
}

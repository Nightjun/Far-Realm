using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Additem : MonoBehaviour
{
    public Inventory baginventory;

    public void Additemtobag(Item thisItem)
    {
        if (!baginventory.itemList.Contains(thisItem))
        {
            baginventory.itemList.Add(thisItem);
            InventoryManager.CreateNewItem(thisItem);
        }
        else
        {
            thisItem.itemHeld += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void Buythings(Item thItem,int howmany)
    {
        if (!baginventory.itemList.Contains(thItem))
        {
            baginventory.itemList.Add(thItem);
            InventoryManager.CreateNewItem(thItem);
            thItem.itemHeld += howmany;
        }
        else
        {
            thItem.itemHeld += howmany;
        }
        InventoryManager.RefreshItem();
    }

    public bool Checkthings(string theitem)
    {
        bool isplayerhave=false;
        for(int i = 0; i < baginventory.itemList.Count; i++)
        {
            if (baginventory.itemList[i].itemName == theitem)
            {
                isplayerhave = true;
            }
        }
        return isplayerhave;
    }
}

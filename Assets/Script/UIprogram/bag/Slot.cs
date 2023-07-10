using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item slotItem;
    public Image slotImage;

    private void Start()
    {
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void ItemOnclicked()
    {
        InventoryManager.UpdateItemInfo(slotItem.itemInfo,slotItem.itemName, slotItem.itemHeld,slotItem.itemImage);
    }
}

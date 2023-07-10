using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relateAdd : MonoBehaviour
{
    public relateInventory inventory;
    public void Addrelatetobook(Relationship thisrelate)
    {
        if (!inventory.relateList.Contains(thisrelate))
        {
            inventory.relateList.Add(thisrelate);
            relateInventoryMenager.CreateNewRelate(thisrelate);
        }
        relateInventoryMenager.RefreshRelate();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addfriend : MonoBehaviour
{
    public Inventoryfriend friendinventory;

    public void Additemtobag(friend thisfriend)
    {
        if (!friendinventory.friendList.Contains(thisfriend))
        {
            friendinventory.friendList.Add(thisfriend);
            Inventoryfriendmeneger.CreateNewItem(thisfriend);
        }
        else
        {
            Debug.Log("somethingwrong");
        }
        Inventoryfriendmeneger.RefreshItem();
    }
    public void Removeitemtobag(friend thisfriend)
    {
        if (!friendinventory.friendList.Contains(thisfriend))
        {
            Debug.Log("somethingwrong");
        }
        else
        {
            friendinventory.friendList.Remove(thisfriend);
            Inventoryfriendmeneger.RemoveItem(thisfriend);
        }
        Inventoryfriendmeneger.RefreshItem();
    }
}

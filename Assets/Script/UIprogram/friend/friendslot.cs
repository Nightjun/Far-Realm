using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class friendslot : MonoBehaviour
{
    public friend slotfriend;
    public Text friendname;
    private void Start()
    {
        friendname.text = slotfriend.friendname;
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void Onclick()
    {
        Inventoryfriendmeneger.UpdateItemInfo(slotfriend.friendinfo, slotfriend.friendname);
    }

}

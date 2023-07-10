using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopitem : MonoBehaviour
{
    public shopone shopsystem;
    [SerializeField]
    private string itemname, itemwork;
    [SerializeField]
    private int itemprice;
    [SerializeField]
    private Item item;


    private void Update()
    {
        if (shopsystem.itemname == itemname)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
    public void buttendown()
    {
        shopsystem.whichwannabuy(itemname,itemprice,item);
    }
}

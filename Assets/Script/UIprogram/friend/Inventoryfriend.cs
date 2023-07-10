using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New friendInventory", menuName = "Inventory/New friendInventory")]

public class Inventoryfriend : ScriptableObject
{
    public List<friend> friendList = new List<friend>();
}

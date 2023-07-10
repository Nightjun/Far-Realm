using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New NOTEInventory", menuName = "Inventory/New NOTEInventory")]

public class noteInventory : ScriptableObject
{
    public List<mission> missionList = new List<mission>();
}

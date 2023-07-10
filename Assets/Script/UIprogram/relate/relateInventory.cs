using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New RelateInventory", menuName = "Inventory/New RelateInventory")]
public class relateInventory : ScriptableObject
{
    public List<Relationship> relateList = new List<Relationship>();
}

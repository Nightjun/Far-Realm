using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New wordInventory", menuName = "Inventory/New wordInventory")]
public class wordInventory : ScriptableObject
{
    public List<wordss> wordList = new List<wordss>();
}

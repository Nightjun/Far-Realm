using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New relate", menuName = "Inventory/New relate")]

public class Relationship : ScriptableObject
{
    public Sprite Image;
    public string theirname;
    public string keyword;
    public string badkeyword;
    public string location;
    public string theirfriend;
    public string power;
    public string story;
}

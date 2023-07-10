using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New talk", menuName = "Inventory/New talk")]

public class talks : ScriptableObject
{
    public string Keyword;
    public int hurtplayer, hurtenemy;
    public bool isendsentence,isbadend;
    

    [TextArea]
    public string[] dialogue;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New helptalk", menuName = "Inventory/New helptalk")]

public class thehelpone : ScriptableObject
{
    public string keyword;
    public int hurtplayer,hurtenemy;

    [TextArea]
    public string[] dialogue;
}

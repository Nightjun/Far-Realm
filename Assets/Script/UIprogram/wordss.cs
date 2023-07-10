using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New word", menuName = "Inventory/New word")]
public class wordss:ScriptableObject 
{
    public string whichfight;

    [TextArea(3, 10)]
    public string theword;

    public string aboutwho;
    public string mainword;
}

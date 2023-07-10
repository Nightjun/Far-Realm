using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New mission", menuName = "Inventory/New mission")]

public class mission : ScriptableObject
{
    public string missiontnumber;
    public string missionName;
    [TextArea]
    public string missionInfo;
}

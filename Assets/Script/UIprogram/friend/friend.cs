using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Friend", menuName = "Inventory/New Friend")]

public class friend : ScriptableObject
{
    public string friendname;
    [TextArea]
    public string friendinfo;
}

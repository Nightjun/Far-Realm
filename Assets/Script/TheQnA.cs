using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New QA", menuName = "Inventory/New QA")]
public class TheQnA : ScriptableObject
{
    public string keyword;
    public float maxtime;
    public int Anserlong;
    public string Quastion,A,B,C,D;
}

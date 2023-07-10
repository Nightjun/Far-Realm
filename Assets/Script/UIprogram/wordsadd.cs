using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordsadd : MonoBehaviour
{
    public wordInventory wi;
    public wordss[] allword;
    public void Addword(string word)
    {
        for (int i = 0; i < allword.Length; i++)
        {
            if (allword[i].aboutwho == word)
            {
                wi.wordList.Add(allword[i]);
                worinventorymanager.CreateNewmission(allword[i]);
            }
        }
        worinventorymanager.Refreshmission();
    }
    public  void Outword(string word)
    {
        for (int i = 0; i < allword.Length; i++)
        {
            if (allword[i].theword == word)
            {
                wi.wordList.Remove(allword[i]);
                return;
            }
        }
        worinventorymanager.Refreshmission();
    }
}

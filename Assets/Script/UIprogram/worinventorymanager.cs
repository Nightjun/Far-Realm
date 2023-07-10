using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class worinventorymanager : MonoBehaviour
{
    static worinventorymanager instance;

    public wordInventory mywords;
    public GameObject slotGrid;
    public textbutten slotprefab;


    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }
    
    private void OnEnable()
    {
        Refreshmission();
    }

   
    public static void CreateNewmission(wordss word)
    {
        textbutten newword = Instantiate(instance.slotprefab, instance.slotGrid.transform.position, Quaternion.identity);
        newword.gameObject.transform.SetParent(instance.slotGrid.transform);
        newword.w = word;
        newword.wordtext.text = word.theword;
    }

    public static void Refreshmission()
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
       
        for (int i = 0; i < instance.mywords.wordList.Count; i++)
        {
            CreateNewmission(instance.mywords.wordList[i]);
        }
    }
}

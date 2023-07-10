using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addmission : MonoBehaviour
{
    public noteInventory noteinventory;
    public wordsadd wadd;
    public mission[] allmission;

    public void MissionIn(string missionnumber)
    {
        for (int i = 0; i < allmission.Length; i++)
        {
            if (allmission[i].missiontnumber == missionnumber)
            {
                Addmissiontonote(allmission[i]);
                hintone.instence.Openthrhint(allmission[i].missionName);
                return;
            }
        }
    }
    public void Removemission(string missionnumber)
    {
        for (int i = 0; i < allmission.Length; i++)
        {
            if (allmission[i].missiontnumber == missionnumber)
            {
                removemissiontonote(allmission[i]);
                return;
            }
        }
    }
    public void Addword(string missionnumber)
    {
        wadd.Addword(missionnumber);
    }
    public void Removeword(string missionnumber)
    {
        wadd.Outword(missionnumber);
    }
    public void Addmissiontonote(mission thismission)
    {
        if (!noteinventory.missionList.Contains(thismission))
        {
            noteinventory.missionList.Add(thismission);
            noteInventoryManager.CreateNewmission(thismission);
        }
        noteInventoryManager.Refreshmission();
    }

    public void removemissiontonote(mission thismission)
    {
        if (noteinventory.missionList.Contains(thismission))
        {
            noteinventory.missionList.Remove(thismission);
        }
        noteInventoryManager.Refreshmission();
    }
}

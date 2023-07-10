using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoffnote : MonoBehaviour
{
    public bool canclose;
    public bagsetting btt;
    public notbutten nob;
    private void OnEnable()
    {
        noteInventoryManager.Refreshmission();
        worinventorymanager.Refreshmission();
    }
    void Update()
    {
        if (UIcall.instance.somethingopen)
        {
            if ((Input.GetKeyUp(KeyCode.Tab) || Input.GetKeyUp(KeyCode.Escape))&&canclose)
            {
                //µ§°O¥»
                turnoffthenote();
            }
        }
        else
        {

            UIcall.instance.somethingopen = true;
        }
        
    }

    public void turnoffthenote()
    {
        nob.replace();
        btt.OpentheMissionone();
        Audiomanager.instance.Play("noteclose");
        gameObject.SetActive(false);
        UIcall.instance.somethingopen = false;
        PlayerControll.instance.isbattle = false;
    }
}

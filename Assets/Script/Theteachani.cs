using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Theteachani : MonoBehaviour
{
   
    private int index;
    private bool istyping;
    private string[] aniname, aniteach;
    private string teachname;

    public bossbattlesample bbs;
    public Animator ani;
    public Text text;
    public float textspeed;
    public GameObject all;

    
    void Update()
    {
        if (!bbs.isplayerchossing)
        {
            bbs.isplayerchossing = true;
        }
        if (Input.GetKeyUp(KeyCode.F) || Input.GetMouseButtonUp(0))
        {
            if (text.text == aniteach[index])
            {
                index++;
                NextLine();
            }
            else
            {
                if (istyping)
                {
                    StopAllCoroutines();
                    text.text = aniteach[index];
                }
                else
                {
                    StopAllCoroutines();
                }
            }
        }
    }

    public void StartDialgue(string[] name, string[] talk,string thename)
    {
        UIcall.instance.somethingopen = true;
        text.text = string.Empty;
        index = 0;
        teachname = thename;
        aniname = name;
        aniteach = talk;
        NextLine();
    }
    void NextLine()
    {
        if (index >= aniteach.Length)
        {
            bbs.isplayerchossing = false;
            UIcall.instance.somethingopen = false;
            all.SetActive(false);
            Storyinformation.instance.Talktowho(teachname);
        }
        else
        {
            text.text = string.Empty;
            Animationchage(aniname[index]);
        }
    }

    public void Animationchage(string aniname)
    {
        ani.Play(aniname);
        StartCoroutine(TypeLine());
    }


    IEnumerator TypeLine()
    {
        foreach (char c in aniteach[index])
        {
            istyping = true;
            text.text += c;
            yield return new WaitForSeconds(textspeed);
        }
        istyping = false;
    }

}

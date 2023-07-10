using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hintone : MonoBehaviour
{
    public static hintone instence;
    public UIcall uicall;
    Animator ani;
    public Text hintword;
    public mapsetting mapp;


    private void Awake()
    {
        ani = gameObject.GetComponent<Animator>();
        if (instence == null)
        {
            instence = this;
        }
        else
        {
            if (instence != this)
            {
                Destroy(gameObject);
            }
        }
    }

   IEnumerator Autoturnoffhint()
    {
        yield return new WaitForSeconds(4); 
        ani.SetBool("hintplayer", false);
        StopAllCoroutines();
    }
    public void Openthrhint(string linenumber)
    {
        switch (linenumber)
        {
            
            case "startani":
                hintword.text = "���U F ��ʵe�i�椬��";
        break;
            case "waterbath":
                hintword.text = "���U tab �i�H�d�ݥ���";
                break;
            case "aftertab":
                hintword.text = "�̾ڥ��ȩһ��A���Amy�ø߰ݸ��";
                break;
            case "thebutten":
                hintword.text = "�ηƹ��i�H�I���ﶵ�@���";
                break;
            case "phone":
                hintword.text = "���U F ���q��";
                break;
            case "map":
                hintword.text = "���U E ���}�a��";
                uicall.mapyes = true;
                mapp.canclose = false;
                break;
            case "bag":
                hintword.text = "���U G ���}�]�]";
                uicall.bagyes = true;
                InventoryManager.okclose = false;
                break;
            default:
                hintword.text = "��������:"+linenumber;
                StartCoroutine(Autoturnoffhint());
                break;
        }
        ani.SetBool("hintplayer", true);
    }
    public void Closethehint()
    {
        ani.SetBool("hintplayer", false);
        hintword.text = "";
    }
}

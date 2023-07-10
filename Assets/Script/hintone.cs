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
                hintword.text = "按下 F 對動畫進行互動";
        break;
            case "waterbath":
                hintword.text = "按下 tab 可以查看任務";
                break;
            case "aftertab":
                hintword.text = "依據任務所說，找到Amy並詢問資料";
                break;
            case "thebutten":
                hintword.text = "用滑鼠可以點擊選項作選擇";
                break;
            case "phone":
                hintword.text = "按下 F 接電話";
                break;
            case "map":
                hintword.text = "按下 E 打開地圖";
                uicall.mapyes = true;
                mapp.canclose = false;
                break;
            case "bag":
                hintword.text = "按下 G 打開包包";
                uicall.bagyes = true;
                InventoryManager.okclose = false;
                break;
            default:
                hintword.text = "接取任務:"+linenumber;
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

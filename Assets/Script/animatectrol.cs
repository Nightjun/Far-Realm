using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatectrol : MonoBehaviour
{
    public static animatectrol instance;
    public Animator c1, b1, b2,d1, e, f, a1, waterbath;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
    //�@�ؾ����ʵe����
    public void Coffeusing()
    {
        c1.SetTrigger("usingcoffe");
    }
    public void Coffetake()
    {
        Audiomanager.instance.Play("playerdrink");
        c1.SetTrigger("takeit");
    }
    //�B�c�W�����ʵe����
    public void Openrifriup()
    {
        Audiomanager.instance.Play("refrigeratoropen");
        b1.SetTrigger("rifriopen");
    }
    //�B�c�U�����ʵe����
    public void Openrifridown()
    {
        Audiomanager.instance.Play("refrigeratoropen");
        b2.SetTrigger("optendownrif");
    }
    //���Ѫ��ʵe����
    public void Openwatersink()
    {
        Audiomanager.instance.Play("sinkopen");
        Audiomanager.instance.Play("bathwater");
        d1.SetTrigger("openwater");
    }
    public void Closewatersink()
    {
        Audiomanager.instance.Play("sinkclose");
        Audiomanager.instance.StopPlay("bathwater");
        d1.SetTrigger("closewater");
    }
    //�L�i�l���ʵe����
    public void Openmicro()
    {
        e.SetTrigger("micropen");
    }
    //�d�l���ʵe����
    public void Opencabinet()
    {
        f.SetBool("cabinetopen", true);
    }
    public void Closecabinet()
    {
        f.SetBool("cabinetopen", false);
    }
    //���������ʵe����
    public void Openwaterdis()
    {
        a1.SetTrigger("openwaterdis");
    }
    //�Z�Ҥ����ʵe����
    public void Openwaterbath()
    {
        waterbath.SetBool("waterbathopen", true);
        Audiomanager.instance.Play("bathwater");
        Audiomanager.instance.Play("bathwateropen");
    }
    public void Closewaterbath()
    {
        waterbath.SetBool("waterbathopen", false);
        Audiomanager.instance.StopPlay("bathwater");
        Audiomanager.instance.Play("bathwateroff");
    }
}

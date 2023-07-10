using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class somethingpopup : MonoBehaviour
{
    public void Grandmapop()
    {
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
        grandmaniall.instance.Grandmapopup();
        Audiomanager.instance.StopPlay("firldbmusic");
        Audiomanager.instance.Play("wiredwind");
    }
    public void grandmazoo()
    {
        Audiomanager.instance.Play("grandmapop");
    }

    public void grandmama()
    {
        PlayerControll.instance.isbattle = false;
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
        grandmaniall.instance.grandmamaaaa();
    }

    public void grandmama2()
    {
        grandmaniall.instance.grandmamaaaa2();
        timetoani.instance.NotAninow();
    }
}

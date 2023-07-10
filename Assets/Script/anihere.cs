using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anihere : MonoBehaviour
{
    public GameObject grandma,grandmapo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            grandma.GetComponent<grandmtouch>().isoktogo = false;
            PlayerControll.instance.isbattle = true;
            PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
            PlayerControll.instance.anim.SetFloat("Vertical", 1);
            grandma.transform.position = grandmapo.transform.position;
            Audiomanager.instance.StopPlay("wiredmusic");
            Audiomanager.instance.Play("yellowbackground");
            grandmaniall.instance.why();
        }
    }
}

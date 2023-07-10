using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phonepickup : MonoBehaviour
{
    Animator ani;
    bool canusef;
    private void Start()
    {
        ani = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && canusef)
        {
            pushtheF();
        }
    }
    public void pushtheF()
    {
        canusef = false;
        Audiomanager.instance.Play("missionhint");
        Audiomanager.instance.StopPlay("phonezoo");
        ani.SetTrigger("phonepickup");
    }
    public void Letperplecanusef()
    {
        canusef = true;
    }
    public void Turntograndmahome()
    {
        FadeUI.instance.Totherscence("grandma");
        Audiomanager.instance.Play("togradmamusic");
        PlayerControll.instance.gameObject.transform.position = new Vector3(0, 0, 0);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobbyset : MonoBehaviour
{
    public Addmission addmission;
    private void Start()
    {
        Audiomanager.instance.Play("lobbymusic");
    }
    public void starthegame()
    {
        Audiomanager.instance.StopPlay("lobbymusic");
        Audiomanager.instance.Play("lobbybuttom");
        SceneManager.LoadScene("SampleScene");
        PlayerControll.instance.gameObject.transform.position = new Vector3(-15, 5, 0);
        PlayerControll.instance.particle.SetActive(false);
    }
    public void hegame()
    {
        Audiomanager.instance.Play("townbackground");
        Audiomanager.instance.StopPlay("lobbymusic");
        Audiomanager.instance.Play("lobbybuttom");
        UIcall.instance.jumptothis();
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
        PlayerControll.instance.particle.SetActive(true);
        PlayerControll.instance.gameObject.transform.position = new Vector3(0, 0, 0);
        addmission.Removemission("amy");
        addmission.Removeword("¸ê®Æ");
        addmission.MissionIn("chan");
        SceneManager.LoadScene("town");
    }
    public void highlightbutten()
    {
        Audiomanager.instance.Play("lobbybuttom");
    }
    public void Quatgame()
    {
        Audiomanager.instance.Play("lobbybuttom");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Theendone : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerControll.instance.isbattle = true;
        UIcall.instance.somethingopen = true;
    }

    public void tothestart()
    {
        UIcall.instance.bagyes = false;
        UIcall.instance.informyes = false;
        UIcall.instance.mapyes = false;
        Storyinformation.istalktoamy = false;
        Storyinformation.istalktoEmma = false;
        Storyinformation.iscomputer = false;
        Storyinformation.isgama01 = false;
        Storyinformation.isgama02 = false;
        Storyinformation.isice01 = false;
        Storyinformation.isice02 = false;
        Storyinformation.isice03 = false;
        Storyinformation.ishead01 = false;
        Storyinformation.ishead02 = false;
        Storyinformation.isnoodles01 = false;
        Storyinformation.isnoodles02 = false;
        Storyinformation.isdonegama = false;
        Storyinformation.isdoneice = false;
        Storyinformation.isdonehead = false;
        Storyinformation.isdonesupork= false;
        Storyinformation.isdonenoodles = false;
        Storyinformation.aftertalkkk = false;
        Audiomanager.instance.StopPlay("townbackground");
        Audiomanager.instance.Play("lobbymusic");
        SceneManager.LoadScene("SampleScene");
        PlayerControll.instance.particle.SetActive(false);
        SceneManager.LoadScene("GameLobby");
    }
}

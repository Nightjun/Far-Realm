using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumptosomewhere : MonoBehaviour
{

    public void theoffice()
    {
        FadeUI.instance.Totherscence("SampleScene");
        Audiomanager.instance.StopPlay("lobbymusic");
        Audiomanager.instance.Play("lobbybuttom");
    }
    public void thegrandma()
    {
        FadeUI.instance.Totherscence("grandma");
        Audiomanager.instance.StopPlay("lobbymusic");
        Audiomanager.instance.Play("firldbmusic");
        Audiomanager.instance.Play("lobbybuttom");
        Storyinformation.instance.afterfistone();
    }
    public void theforest()
    {
        FadeUI.instance.Totherscence("Forest");
        Audiomanager.instance.StopPlay("lobbymusic");
        Audiomanager.instance.Play("forestbackground");
        Audiomanager.instance.Play("lobbybuttom");
        Storyinformation.instance.aftergrandma();
    }
    public void themonsterbefore()
    {
        FadeUI.instance.Totherscence("town");
        Audiomanager.instance.Play("townbackground");
        Audiomanager.instance.StopPlay("lobbymusic");
        Audiomanager.instance.Play("lobbybuttom");
        UIcall.instance.jumptothis();
        Storyinformation.instance.afterforest();

    }
    public void themonsterafter()
    {
        FadeUI.instance.Totherscence("town");
        Audiomanager.instance.StopPlay("lobbymusic");
        Audiomanager.instance.Play("townbackground");
        Audiomanager.instance.Play("lobbybuttom");
        UIcall.instance.jumptothis();
        Storyinformation.instance.aftertalk();
    }
}

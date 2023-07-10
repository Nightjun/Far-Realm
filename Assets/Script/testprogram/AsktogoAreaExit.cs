using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsktogoAreaExit : MonoBehaviour
{
    public AreaEntrance areaEntrance;

    public string loadAreaName;
    public string areatransitionName;
    public GameObject fbu;

    private float waitToLoad = 0.5f;
    private bool shouldLoadAfterFade;
    private bool readytogo = false;
    private void Start()
    {
        areaEntrance.TransitionName = areatransitionName;
    }
    private void Update()
    {
        if (readytogo && Input.GetKeyDown(KeyCode.F))
        {
            shouldLoadAfterFade = true;
            FadeUI.instance.FadetoBlack();
            PlayerControll.instance.areatransitionName = areatransitionName;
            readytogo = false;
        }
        if (shouldLoadAfterFade)
        {
            waitToLoad -= Time.deltaTime;
            if (waitToLoad <= 0)
            {
                shouldLoadAfterFade = false;
                SceneManager.LoadScene(loadAreaName);
            }
        }
        if (readytogo)
        {

            fbu.SetActive(true);
        }
        else
        {

            fbu.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            readytogo = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            readytogo = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    public string loadAreaName;
    public string areatransitionName;

    public AreaEntrance areaEntrance;

    public float waitToLoad = 1f;
    private bool shouldLoadAfterFade;
    private void Start()
    {
        areaEntrance.TransitionName = areatransitionName;
    }
    private void Update()
    {
        if (shouldLoadAfterFade)
        {
            waitToLoad -= Time.deltaTime;
            if (waitToLoad <= 0)
            {
                shouldLoadAfterFade = false;
                SceneManager.LoadScene(loadAreaName);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            shouldLoadAfterFade = true;
            PlayerControll.instance.areatransitionName = areatransitionName;
        } 
    }
}

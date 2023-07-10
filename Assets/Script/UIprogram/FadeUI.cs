using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeUI : MonoBehaviour
{
    public static FadeUI instance;

    public Image fadeScreen;
    public float fadespeed;

    private static string previousSceneName;
    private string scene;
    private bool shouldLoadAfterFade;

    private bool shouldFadeToBlack=false;
    private bool shouldFadeFromBlack=false;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
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
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
        if (shouldFadeToBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 1f, fadespeed * Time.deltaTime));
            if (fadeScreen.color.a == 1f)
            {
                shouldFadeToBlack = false;
                if (shouldLoadAfterFade)
                {
                    SceneManager.LoadScene(scene);
                    FadeFromBlack();
                    PlayerControll.instance.isgofront = false;
                    PlayerControll.instance.gameObject.transform.position = new Vector3(0, 0, 0);
                    shouldLoadAfterFade = false;
                }
            }
        }
        if (shouldFadeFromBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 0f, fadespeed * Time.deltaTime));
            if (fadeScreen.color.a == 0f)
            {
                shouldFadeFromBlack = false;
                gameObject.SetActive(false);
            }
        }
    }

    public void Totherscence(string scencename)
    {
        scene = scencename;
        shouldLoadAfterFade = true;
        FadetoBlack();
    }

    public void FadetoBlack()
    {
        gameObject.SetActive(true);
        shouldFadeToBlack = true;
        shouldFadeFromBlack = false;
    }

    public void FadeFromBlack()
    {
        shouldFadeFromBlack = true;
        shouldFadeToBlack = false;
    }


  
}

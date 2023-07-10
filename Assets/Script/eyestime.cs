using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eyestime : MonoBehaviour
{
    public battleinformation bin;
    public bossbattlesample bbs;
    public GameObject friend, butten;
    public Sprite[] sprites;
    public float time,themaxtime;
    bool istartime;
    private Image thieImage;

    private void Start()
    {
        thieImage = gameObject.GetComponent<Image>();
    }


    private void Update()
    {
        if (istartime&&!bbs.isplayerchossing)
        {
            time += Time.deltaTime;
            Chackthetimeeye();
            if (time >= themaxtime)
            {
                choosedone();
                bin.keyndia(bin.keyword);
            }
        }

    }
    public void Chackthetimeeye()
    {
        if (time < themaxtime)
        {
            thieImage.sprite = sprites[7];
            if (time <= themaxtime / 8 * 7)
            {
                thieImage.sprite = sprites[6];
                if (time <= themaxtime / 8 * 6)
                {
                    thieImage.sprite = sprites[5];
                    if (time <= themaxtime / 8 * 5)
                    {
                        thieImage.sprite = sprites[4];
                        if (time <= themaxtime / 8 * 4)
                        {
                            thieImage.sprite = sprites[3];
                            if (time <= themaxtime / 8 * 3)
                            {
                                thieImage.sprite = sprites[2];
                                if (time <= themaxtime / 8 * 2)
                                {
                                    thieImage.sprite = sprites[1];
                                    if (time <= themaxtime / 8)
                                    {
                                        thieImage.sprite = sprites[0];
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    public void Startocountime(float maxtime)
    {
        Debug.Log("starteyes");
        time = 0;
        Chackthetimeeye();
        themaxtime = maxtime;
        istartime = true;
        Audiomanager.instance.Play("battletime");
    }
    public void choosedone()
    {
        Audiomanager.instance.StopPlay("battletime");
        istartime = false;
        friend.SetActive(false);
        butten.SetActive(false);

    }
}

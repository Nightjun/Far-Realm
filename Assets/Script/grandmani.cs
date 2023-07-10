using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grandmani : MonoBehaviour
{
    public Dialogue1 dia;
    public GameObject npc, player,skipbutten;
    public Text text,npctext,playertext;
    public float textspeed;
    public string whostalking;

    public Animator npcani, playerani;
    bool istyping;
    private int index;
    float time;
    bool startocount;

    [TextArea(3, 10)]
    public string[] sentences;

    public void Start()
    {
        skipbutten.SetActive(true);
        UIcall.instance.somethingopen = true;
        text.text = string.Empty;
        index = 0;
        NextLine();
    }
    void Update()
    {
        if (index >= sentences.Length)
        {
            time += Time.deltaTime;
            if (time <= 2)
            {
                Audiomanager.instance.Play("togradmaring");
                
            }
            if (time >= 5)
            {
                gameObject.SetActive(false);
                dia.Sendthetalk();
                FadeUI.instance.FadeFromBlack();
                //FadeUI.instance.gameObject.SetActive(false);
            }
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.F) || Input.GetMouseButtonUp(0))
            {
                time = 0;
                hintone.instence.Closethehint();
                if (text.text == sentences[index])
                {
                    index++;
                    NextLine();
                }
                else
                {
                    if (istyping)
                    {
                        StopAllCoroutines();
                        text.text = sentences[index];
                    }
                    else
                    {
                        StopAllCoroutines();
                    }
                }
            }
            else
            {
                time += Time.deltaTime;
                if (time >= 10f)
                {
                    hintone.instence.Openthrhint("startani");
                }
            }
        }
        
    }

    IEnumerator TypeLine()
    {
        foreach (char c in sentences[index])
        {
            istyping = true;
            text.text += c;
            Audiomanager.instance.Play(whostalking);
            yield return new WaitForSeconds(textspeed);
        }
        istyping = false;
    }

    void NextLine()
    {
        if (index >= sentences.Length)
        {
            skipbutten.SetActive(false);
            Audiomanager.instance.StopPlay("togradmamusic");
            FadeUI.instance.FadetoBlack();
            npc.SetActive(false);
            player.SetActive(false);
            time = 0;
            PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
            PlayerControll.instance.anim.SetFloat("Vertical", 1);
            
        }
        else
        {
            text.text = string.Empty;
            Checkifname();
            StartCoroutine(TypeLine());
        }
    }

    public void Checkifname()
    {
        if (sentences[index].StartsWith("n-"))
        {
            whostalking = "grandmago";
            index++;
            npc.SetActive(true);
            text = npctext;
            npcani.SetBool("isgrandmatalk", true);
            player.SetActive(false);
            playerani.SetBool("isplayetalk", false);
            //Debug.Log("npcsay");
        }
        if (sentences[index].StartsWith("p-"))
        {
            whostalking = "playertalk";
            index++;

            player.SetActive(true);
            playerani.SetBool("isplayetalk", true);
            text = playertext;
            npc.SetActive(false);
            npcani.SetBool("isgrandmatalk", false);
            // Debug.Log("playersay");
        }
        
    }

    public void skipani()
    {
        StopAllCoroutines();
        Audiomanager.instance.StopPlay("togradmamusic");
        FadeUI.instance.FadetoBlack();
        npc.SetActive(false);
        player.SetActive(false);
        time = 0;
        PlayerControll.instance.anim.SetFloat("Horizonztal", 0);
        PlayerControll.instance.anim.SetFloat("Vertical", 1);
        skipbutten.SetActive(false);
        gameObject.SetActive(false);
        dia.Sendthetalk();
        FadeUI.instance.FadeFromBlack();
    }

}

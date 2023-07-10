using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smalltalkmainsystem : MonoBehaviour
{

    public Text text;
    public GameObject talkcanvas,yesb,nob, allwaustion,panel,nextlintbu;
    public GameObject[] npcs;
    public quastionbutton qb;
    public Vector3 thingup;
    public float textspeed;
    public string linenumber;
    public bool isquation,isomethinghappened,isaning;
    public string whostalking;

    private Button yesbb, nobb;
    private Animator nextlineani;
    private int nownpc = 0;
    private string nowani;
    private GameObject player, UIfade;
    bool istyping;
    private int index;
    string[] talklines;

    private void Awake()
    {
        UIfade = FadeUI.instance.gameObject;
        nextlineani = nextlintbu.GetComponent<Animator>();
        yesbb = yesb.GetComponent<Button>();
        nobb = nob.GetComponent<Button>();
        //panel = gameObject;
    }
    void Update()
    {
        if (isquation)
        {
            qb.Thebuttontext(linenumber);
            yesb.SetActive(true);
            nob.SetActive(true);
            UIfade.SetActive(false);
            nextlintbu.SetActive(false);
        }
        else if (isaning)
        {
            StopAllCoroutines();
        }
        else
        {
            if (!isomethinghappened)
            {
                if (Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0))
                {
                    nextlineani.SetTrigger("yesbu");
                }
                if (Input.GetKeyUp(KeyCode.F)||Input.GetMouseButtonUp(0))
                {
                    if (text.text == talklines[index])
                    {
                        index++; 
                        nextlineani.SetTrigger("mouseup");
                        nextlintbu.SetActive(false);
                        NextLine();
                    }
                    else
                    {
                        if (istyping)
                        {
                            text.text = talklines[index];
                            nextlintbu.SetActive(true);
                            StopAllCoroutines();
                        }
                        else
                        {
                            text.text = talklines[index];
                            StopAllCoroutines();
                        }
                    }
                }
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.F)||Input.GetMouseButtonUp(0))
                {
                    if (istyping)
                    {
                        StopAllCoroutines();
                        text.text = talklines[index];
                    }
                    else
                    {
                        StopAllCoroutines();
                    }
                }
            }
            
        }
        
    }
    public void StartDialgue(Dialogue dialogue,string tthenumber)
    {
        npcs[0] = dialogue.gameObject;
        player = PlayerControll.instance.gameObject;
        linenumber = tthenumber;
        text.text = string.Empty;
        index = 0;
        Storyinformation.instance.Talktowho(linenumber);
        talklines = dialogue.sentences;
        NextLine();
    }

    public void NoFandStartDialgue(Dialogue1 dialogue, string tthenumber)
    {
        npcs[0] = dialogue.gameObject;
        player = PlayerControll.instance.gameObject;
        linenumber = tthenumber;
        text.text = string.Empty;
        index = 0;
        Storyinformation.instance.Talktowho(linenumber);
        talklines = dialogue.sentences;
        NextLine();
    }

    IEnumerator TypeLine()
    {
        foreach (char c in talklines[index])
        {
            istyping = true;
            text.text += c;
            Audiomanager.instance.Play(whostalking);
            yield return new WaitForSeconds(textspeed);
        }
        nextlintbu.SetActive(true);
        istyping = false;
    }

    void NextLine()
    {
        if (index >= talklines.Length)
        {
            panel.SetActive(false);
            gameObject.SetActive(false);
            Storyinformation.instance.Talktowho2(linenumber);
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
        if (talklines[index].StartsWith("n-"))
        {
            nownpc =int.Parse(talklines[index].Substring(2));
            whostalking = linenumber;
            index++;
            talkcanvas.transform.position = npcs[nownpc].transform.position + thingup;
            //Debug.Log("npcsay");
        }
        if (talklines[index].StartsWith("p-"))
        {
            whostalking = "playertalk";
            index++;
            talkcanvas.transform.position = player.transform.position+ new Vector3(-0.3f, 1.2f, 0);
           // Debug.Log("playersay");
        }

        if (talklines[index].StartsWith("q-"))
        {
            yesb.SetActive(true);
            nob.SetActive(true);
            yesbb.Select();
            index++;
            isquation = true;
            //Debug.Log("quastionsay");
        }
        else
        {
            isquation = false;
        }

        if (talklines[index].StartsWith("h-"))
        {
            index++;
            //Debug.Log("hint");
        }
        if (talklines[index].StartsWith("ani-"))
        {
            nowani = talklines[index].Substring(4);
            isaning = true;
            panel.SetActive(false);
            Alltalkani.instance.Whichani(nowani, this);
            timetoani.instance.Aninow();
        }

        if(talklines[index].StartsWith("pq-"))
        {
            index++;
            Storyinformation.instance.Talktowho2(linenumber);
            isomethinghappened = true;
            UIfade.SetActive(false);
            allwaustion.SetActive(true);
            //煞神那邊需要的
        }
    }

    public void Afterani()
    {
        panel.SetActive(true);
        isaning = false;
        index++;
        NextLine();
    }
    
    public void Afterquastion()
    {
        UIfade.SetActive(true);
        yesb.SetActive(false);
        nob.SetActive(false);
        index++;
        NextLine();
        isquation = false;
    }

    public void Afterquastion2()
    {
       // UIfade.SetActive(true);
        yesb.SetActive(false);
        nob.SetActive(false);
        isquation = false;
    }
}

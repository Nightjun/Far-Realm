using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stringbattle : MonoBehaviour
{
    public int maxline;
    public GameObject all, threeline, fourline,theboom;
    public Text t101, t102, t103, t104, t201, t202, t203, t204, t301, t302, t303, t304, t401, t402, t403, t404,qone,effectext; 
    public Animator p101,p102,p103,p104,p201,p202,p203,p204,p301,p302,p303,p304,p401,p402,p403,p404,theboomani;
    public dialoguebattle dialoguebattle;
    public battleplayerchoose battleplayerchoose;
    public eyestime eye;
    public battleinformation bin;
    public bossbattlesample bbs;
    //public float maxtime=8;
    public string thenumber;

    private Vector3 allorigenposition;
    string  anser, R1, R2, R3, a,b,c,d;
    int line,updown;
    char[] anserone, R1one, R2one, R3one,a1,b1,c1,d1;
    string keyword,thesentence;
    private Animator ani;
    bool isreplaceword,canselect;

    public float chagetime;

    private void Awake()
    {
        allorigenposition = all.transform.position;
        ani = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (!bbs.isplayerchossing)
        {
            effectext.text= keyword;
            qone.text = thesentence;
            if (Input.GetKeyUp(KeyCode.W)&&canselect)
            {
                updown--;
                tocircleone();
                Audiomanager.instance.Play("lobbybuttom");
            }
            if (Input.GetKeyUp(KeyCode.S)&&canselect)
            {
                updown++;
                tocircleone();
                Audiomanager.instance.Play("lobbybuttom");
            }
            //這面這邊改成IE讓updown++
            tocircleone();
           
            if (updown >= 4)
            {
                updown = 0;
            }
            if (updown <= -1)
            {
                updown = 3;
            }
            if (line >= maxline)
            {
                canselect = false;
                eye.choosedone(); 
                StartCoroutine(Waitaninite());
            }
            else
            {
                canselect = true;
            }
            if (eye.time >= eye.themaxtime)
            {
                Reseteverything();
            }
        }
    }
    
   IEnumerator Waitaninite()
    {
        yield return new WaitForSeconds(0.3f);
        if (getCurrenClipInfo() == "noboom" && !isreplaceword)
        {
            IsanserRight();
            Reseteverything();
        }
    }

    //還原
    public void Reseteverything()
    {
        qone.text = "";
        all.SetActive(false);
        ani.SetTrigger("first");
        p401.SetBool("isselect", false);
        p402.SetBool("isselect", false);
        p403.SetBool("isselect", false);
        p404.SetBool("isselect", false);
        p301.SetBool("isselect", false);
        p302.SetBool("isselect", false);
        p303.SetBool("isselect", false);
        p304.SetBool("isselect", false);
        p201.SetBool("isselect", false);
        p202.SetBool("isselect", false);
        p203.SetBool("isselect", false);
        p204.SetBool("isselect", false);
        p101.SetBool("isselect", false);
        p102.SetBool("isselect", false);
        p103.SetBool("isselect", false);
        p104.SetBool("isselect", false);

        all.transform.position = allorigenposition;
        threeline.SetActive(true);
        fourline.SetActive(true);
        line = 0;
        keyword = "";
        
    }

    public string getCurrenClipInfo()
    {
        AnimatorClipInfo[] clip = theboomani.GetCurrentAnimatorClipInfo(0);
        return clip[0].clip.name;
    }
    //讓圈圈變成菱形
    public void tocircleone()
    {
        if (!bbs.isplayerchossing)
        {
            if (line < 4)
            {
                p401.SetBool("ischosing", false);
                p402.SetBool("ischosing", false);
                p403.SetBool("ischosing", false);
                p404.SetBool("ischosing", false);
                if (line < 3)
                {
                    p301.SetBool("ischosing", false);
                    p302.SetBool("ischosing", false);
                    p303.SetBool("ischosing", false);
                    p304.SetBool("ischosing", false);
                    if (line < 2)
                    {
                        p201.SetBool("ischosing", false);
                        p202.SetBool("ischosing", false);
                        p203.SetBool("ischosing", false);
                        p204.SetBool("ischosing", false);
                        if (line < 1)
                        {
                            p101.SetBool("ischosing", false);
                            p102.SetBool("ischosing", false);
                            p103.SetBool("ischosing", false);
                            p104.SetBool("ischosing", false);
                        }
                    }
                }

            }
            switch (line)
            {
                case 0:
                    ani.SetTrigger("first");
                    switch (updown)
                    {
                        case 0:
                            p101.SetBool("ischosing", true);
                            if(getCurrenClipInfo()=="noboom")
                                theboom.transform.position = p101.gameObject.transform.position;

                            if ((Input.GetKeyUp(KeyCode.F) ||Input.GetKeyUp(KeyCode.Space))&&canselect)
                            {
                                Selectword(t101);
                                p101.SetBool("isselect", true);
                            }
                            break;
                        case 1:
                            p102.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p102.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t102);
                                p102.SetBool("isselect", true);
                            }
                            break;
                        case 2:
                            p103.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p103.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t103);
                                p103.SetBool("isselect", true);
                            }
                            break;
                        case 3:
                            p104.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p104.gameObject.transform.position;
                            if((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t104);
                                p104.SetBool("isselect", true);
                            }
                            break;

                    }
                    break;
                case 1:
                    ani.SetTrigger("second");
                    switch (updown)
                    {

                        case 0:
                            p201.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p201.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t201);
                                p201.SetBool("isselect", true);
                            }
                            break;
                        case 1:
                            p202.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p202.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t202);
                                p202.SetBool("isselect", true);
                            }
                            break;
                        case 2:
                            p203.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p203.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t203);
                                p203.SetBool("isselect", true);
                            }
                            break;
                        case 3:
                            p204.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p204.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t204);
                                p204.SetBool("isselect", true);
                            }
                            break;

                    }
                    break;
                case 2:
                    ani.SetTrigger("third");
                    switch (updown)
                    {
                        case 0:
                            p301.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p301.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t301);
                                p301.SetBool("isselect", true);
                            }
                            break;
                        case 1:
                            p302.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p302.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t302);
                                p302.SetBool("isselect", true); 
                            }
                            break;
                        case 2:
                            p303.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p303.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t303);
                                p303.SetBool("isselect", true); 
                            }
                            break;
                        case 3:
                            p304.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p304.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t304);
                                p304.SetBool("isselect", true); 
                            }
                            break;

                    }
                    break;
                case 3:
                    ani.SetTrigger("fourth");
                    switch (updown)
                    {
                        case 0:
                            p401.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p401.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t401);
                                p401.SetBool("isselect", true); 
                            }
                            break;
                        case 1:
                            p402.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p402.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t402);
                                p402.SetBool("isselect", true); 
                            }
                            break;
                        case 2:
                            p403.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p403.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t403);
                                p403.SetBool("isselect", true); 
                            }
                            break;
                        case 3:
                            p404.SetBool("ischosing", true);
                            if (getCurrenClipInfo() == "noboom")
                                theboom.transform.position = p404.gameObject.transform.position;
                            if ((Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space)) && canselect)
                            {
                                Selectword(t404);
                                p404.SetBool("isselect", true); 
                            }
                            break;

                    }
                    break;
            }
        }
    }
    //battleplayerchosse裡呼叫的
    public void Invokechosse(string quastionumber, int maxlinec, string a, string b, string c, string d,string thequastion)
    {
        Debug.Log(thequastion+"+"+qone.text);
        thesentence = thequastion;
        maxline = maxlinec;
        thenumber = quastionumber;
        ani.SetTrigger("first");
        if (maxline == 2)
        {
            all.transform.position += new Vector3(90, 0, 0);
            threeline.SetActive(false);
            fourline.SetActive(false);
        }
        if (maxline == 3)
        {
            all.transform.position += new Vector3(45, 0, 0);
            fourline.SetActive(false);
        }
        Thewords(a,b,c,d);

    }

    //所選取的字
    public void Selectword(Text t)
    {
        theboomani.SetTrigger("boomm");
        isreplaceword = true;
        if (line <= maxline)
        {
            Audiomanager.instance.Play("lobbybuttom");
            Replaceword(t);
            keyword += t.text;
            t.text = "";
            line++;
            if (line == maxline)
            {
                if (keyword == anser)
                {
                    bin.UIgood();
                }
                else
                {
                    bin.UIbad();
                }
            }
            updown = 0;
            isreplaceword = false;
        }
        
    }

    public void Replaceword(Text t)
    {
        if (thesentence.IndexOf("Ｏ") >= 0)
        {
            thesentence = thesentence.Insert(thesentence.IndexOf("Ｏ"), t.text);
            thesentence = thesentence.Remove(thesentence.IndexOf("Ｏ"), 1);
        }
      
    }

    //正確答案即其他字
    public void Thewords(string a,string b,string c,string d)
    {
        anser = "";
        R1 = "";
        R2 = "";
        R3 = "";

        anser = a;
        R1 = b;
        R2 = c;
        R3 = d;

        Putwordintext();
    }

    //將字打換放進框框裡
    public void Putwordintext()
    {
        //將每一個答案都變成char陣列然後依據第一排第二排...等等的做分類
        if (anser != null)
        {
            anserone = anser.ToCharArray();
            switch (anserone.Length)
            {
                case 2:
                    a += anserone[0].ToString();
                    b += anserone[1].ToString();
                    break;
                case 3:
                    a += anserone[0].ToString();
                    b += anserone[1].ToString();
                    c += anserone[2].ToString();
                    break;
                case 4:
                    a += anserone[0].ToString();
                    b += anserone[1].ToString();
                    c += anserone[2].ToString();
                    d += anserone[3].ToString();
                    break;
            }
        }
        if (R1 != null)
        {
            R1one = R1.ToCharArray();
            if (R1one.Length >= 2)
            {
                a += R1one[0].ToString();
                b += R1one[1].ToString();
                if (R1one.Length >= 3)
                {
                    c += R1one[2].ToString();
                    if (R1one.Length >= 4)
                    {
                        d += R1one[3].ToString();
                    }
                }
            }
        }
        if (R2 != null)
        {
            R2one = R2.ToCharArray();
            if(R2one.Length>=2)
            {
                a += R2one[0].ToString();
                b += R2one[1].ToString(); 
                if (R2one.Length >= 3)
                {
                    c += R2one[2].ToString();
                    if (R2one.Length >= 4)
                    {
                        d += R2one[3].ToString();
                    }
                }
            }
        }
        if (R3 != null)
        {
            R3one = R3.ToCharArray();
            if (R3one.Length >= 2)
            {
                a += R3one[0].ToString();
                b += R3one[1].ToString();
                if (R3one.Length >= 3)
                {
                    c += R3one[2].ToString();
                    if (R3one.Length >= 4)
                    {
                        d += R3one[3].ToString();
                    }
                }
            }
        }

        //將每一排的字打亂後變成陣列
        if (anserone.Length > 0)
        {
            a1 = a.ToCharArray();
            a1 = Randenit(a1);
            b1 = b.ToCharArray();
            b1 = Randenit(b1);
            if (anserone.Length >2)
             {
                 c1 = c.ToCharArray();
                 c1 = Randenit(c1);
                 if (anserone.Length >3)
                    {
                        d1 = d.ToCharArray();
                        d1 = Randenit(d1);
                    }
             }
        }

        //將每一排字都輸入進去
        if (anserone.Length >=2)
        {
            t101.text = a1[0].ToString();
            t102.text = a1[1].ToString();
            t103.text = a1[2].ToString();
            t104.text = a1[3].ToString();
            t201.text = b1[0].ToString();
            t202.text = b1[1].ToString();
            t203.text = b1[2].ToString();
            t204.text = b1[3].ToString();
            if (anserone.Length >= 3)
            {
                t301.text = c1[0].ToString();
                t302.text = c1[1].ToString();
                t303.text = c1[2].ToString();
                t304.text = c1[3].ToString();
                if (anserone.Length >= 4)
                {
                    t401.text = d1[0].ToString();
                    t402.text = d1[1].ToString();
                    t403.text = d1[2].ToString();
                    t404.text = d1[3].ToString();
                }
            }
        }
        a = "";
        b = "";
        c = "";
        d = "";
    }

    //打亂
    public char[] Randenit(char[] charone)
    {
        char temp;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int randenint = Random.Range(0, 3);
                temp = charone[randenint];
                charone[randenint] = charone[j];
                charone[j] = temp;
            }
        }
        return charone;

    }

    //接應著正確的對話
    public void IsanserRight()
    {
        if (!bin.isplayerGG)
        {
            if (keyword == anser)
            {
                bin.isrightanser = true;
            }
            keyword += thenumber;
            eye.choosedone();
            bin.keyndia(keyword);
        }
    }

    public void somethingwrong()
    {
        Reseteverything();
        bin.keyndia(bin.keyword);
    }

   
}

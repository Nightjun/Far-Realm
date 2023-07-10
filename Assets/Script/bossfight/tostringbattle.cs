using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tostringbattle : MonoBehaviour
{
    public GameObject battlepanel,enemyhealth,effact;
    public Animator noteani;
    public battleinformation[] bin;
    public bossbattlesample bbs;
    public Button persuade, friend;
    public bool startching;
    public Animator startani;
    public Slider playerheath;
    public wordInventory mywords;
    public GameObject slotGrid;
    public textbutten slotfab;

    Animator persuadeani, friendani;
    bool ispersuaopen, isfriendopen;
    int notenumber, theenemy;


    AnimatorStateInfo stateinfo;
    private void Awake()
    {
        persuadeani = persuade.GetComponent<Animator>();
        friendani=friend.GetComponent<Animator>();
        startani = gameObject.GetComponent<Animator>();
        stateinfo = noteani.GetCurrentAnimatorStateInfo(0);
    }

    private void Update()
    {
        if (battlepanel.activeSelf == true)
        {
            //�}�ҮɥD�������
            PlayerControll.instance.isbattle = true;
        }
        else
        {
            if (enemyhealth.transform.childCount != 0)
            {
                Destroy(enemyhealth.transform.GetChild(0).gameObject);
            }
            for (int i = 0; i < slotGrid.transform.childCount; i++)
            {
                Destroy((slotGrid.transform.GetChild(i)).gameObject);
            }
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                ButtenNoteopen();
            }


        }
    }
        //��r�����e����X�O��
        public void Tobigtalk(string linenumber)
        {
            UIcall.instance.somethingopen = true;
            playerheath.value = 100;
            battlepanel.SetActive(true);
            bbs.isplayerchossing = true;
            for (int i = 0; i < bin.Length; i++)
            {
                if (linenumber == bin[i].thisbossname)
                {
                    theenemy = i;
                    break;
                }
            }
            startani.SetTrigger("startfight");
            letstalk();


        }

        public void letstalk()
        {
            bbs.isplayerchossing = false;
            UIcall.instance.somethingopen = true;
            switch (bin[theenemy].thisbossname)
            {
                case "Amy":
                    //�����@�Ǯץ�]�w
                    ispersuaopen = true;
                    isfriendopen = false;
                    forthenot("�Ƨѿ�");
                    bin[theenemy].Starthebattle();
                    break;
                case "Emma":
                    ispersuaopen = true;
                    isfriendopen = false;
                    forthenot("�Ƨѿ�");
                    bin[theenemy].Starthebattle();
                    break;
                case "�q��":
                    ispersuaopen = true;
                    isfriendopen = true;
                    forthenot("�Ƨѿ�");
                    bin[theenemy].Starthebattle();
                    break;
                case "����":
                    ispersuaopen = true;
                    isfriendopen = false;
                    forthenot("�a�J��");
                    bin[theenemy].Starthebattle();
                    break;
                case "��h�C":
                    forthenot("��h�C");
                    ispersuaopen = true;
                    isfriendopen = false;
                    bin[theenemy].Starthebattle();
                    break;
                case "�H�Y�P�L�Y":
                    forthenot("���`��");
                    ispersuaopen = true;
                    isfriendopen = false;
                    bin[theenemy].Starthebattle();
                    break;
                case "���h�Q":
                    forthenot("���h�Q");
                    ispersuaopen = true;
                    isfriendopen = false;
                    bin[theenemy].Starthebattle();
                    break;
                case "�p��":
                    forthenot("�p��");
                    ispersuaopen = true;
                    isfriendopen = false;
                    bin[theenemy].Starthebattle();
                    break;
            }
        }


        //���O���}�άO��
        public void ButtenNoteopen()
        {
            if (bbs.isplayerseenote)
            {
                noteani.SetBool("battlenoteon", false);
                bbs.isplayerseenote = false;
            }
            else
            {
                noteani.SetBool("battlenoteon", true);
                bbs.isplayerseenote = true;
            }
        }

        public void Buttenteach()
        {
            Time.timeScale = 1;
        }
        //���s�ާ@

        public void Buttenno()
        {
            effact.SetActive(true);
            startching = false;
            persuade.interactable = false;
            persuadeani.SetBool("persuadeopen", false);
            friend.interactable = false;
            friendani.SetBool("friendopen", false);
        }
        public void Buttonyes()
        {
            effact.SetActive(false);
            persuade.Select();
            startching = true;
            persuade.interactable = ispersuaopen;
            persuadeani.SetBool("persuadeopen", ispersuaopen);
            friend.interactable = isfriendopen;
            friendani.SetBool("friendopen", isfriendopen);
        }

        public void forthenot(string name)
        {
            for (int i = 0; i < mywords.wordList.Count; i++)
            {
                if (mywords.wordList[i].whichfight == name)
                {
                    textbutten newword = Instantiate(slotfab, slotGrid.transform.position, Quaternion.identity);
                    newword.gameObject.transform.SetParent(slotGrid.transform);
                    newword.w = mywords.wordList[i];
                    newword.wordtext.text = mywords.wordList[i].theword;
                newword.gameObject.GetComponent<Button>().interactable = false;
                }
            }
        }
    
}

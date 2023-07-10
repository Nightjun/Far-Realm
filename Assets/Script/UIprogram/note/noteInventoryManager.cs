using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteInventoryManager : MonoBehaviour
{
    static noteInventoryManager instance;

    public noteInventory mymission;
    public GameObject slotGrid,themissionditail,panel;
    public notslot slotprefab;
    public Text missionInfromation, missionname;
    public UIcall uicall;

    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }
   

    private void OnEnable()
    {
        Refreshmission();
        instance.missionname.text = "";
        instance.missionInfromation.text = "";
    }
    public static void UpdatemissionInfo(string missionname,string missiondescription )
    {
        instance.themissionditail.SetActive(true);
        instance.missionname.text = missionname;
        instance.missionInfromation.text = missiondescription;
    }
    public static void OutmissionInfo()
    {
        instance.themissionditail.SetActive(false);
        instance.missionname.text = "";
        instance.missionInfromation.text = "";
    }
    public static void CreateNewmission(mission mission)
    {
        notslot newmission = Instantiate(instance.slotprefab, instance.slotGrid.transform.position, Quaternion.identity);
        newmission.gameObject.transform.SetParent(instance.slotGrid.transform);
        newmission.slotmission = mission;
        newmission.missionname.text = mission.missionName;
    }

    public static void Refreshmission()
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < instance.mymission.missionList.Count; i++)
        {
            CreateNewmission(instance.mymission.missionList[i]);
        }
    }
}

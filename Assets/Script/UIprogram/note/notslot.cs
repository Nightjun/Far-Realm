using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class notslot : MonoBehaviour,IPointerUpHandler
{ 
    public mission slotmission;
    public Text missionname;
    private void Start()
    {
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);   
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Audiomanager.instance.Play("lobbybuttom");
        noteInventoryManager.UpdatemissionInfo(slotmission.missionName, slotmission.missionInfo);
    }
    public void Buttendown()
    {
        noteInventoryManager.UpdatemissionInfo(slotmission.missionName, slotmission.missionInfo);
    }

    //public void OnPointerEnter(PointerEventData eventData)
    //{


    //}
    // public void OnPointerExit(PointerEventData eventData)
    //{
    //    noteInventoryManager.OutmissionInfo();
    //}
    //, IPointerEnterHandler, IPointerExitHandler

}

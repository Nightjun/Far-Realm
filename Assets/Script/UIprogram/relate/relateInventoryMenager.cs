using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relateInventoryMenager : MonoBehaviour
{
    static relateInventoryMenager instance;

    public relateInventory myrelate;
    public GameObject relategrid;
    public relateSlot relateslotfab;

    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }
    private void OnEnable()
    {
        RefreshRelate();
    }
    public static void UpdaterelateInfo()
    {
        //按了會出現在右邊資訊的東東
    }
    public static void CreateNewRelate(Relationship relateship)
    {
        relateSlot newrelate = Instantiate(instance.relateslotfab, instance.relategrid.transform.position, Quaternion.identity);
        newrelate.relate = relateship;
        newrelate.relateimage.sprite = relateship.Image;
    }

    public static void RefreshRelate ()
    {
        for (int i = 0; i < instance.relategrid.transform.childCount; i++)
        {
            if (instance.relategrid.transform.childCount == 0)
                break;
            Destroy(instance.relategrid.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < instance.myrelate.relateList.Count; i++)
        {
            CreateNewRelate(instance.myrelate.relateList[i]);
        }
    }
}

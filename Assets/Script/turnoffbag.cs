using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoffbag : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerControll.instance.isbattle = true;
    }
    private void Update()
    {

        if (Input.GetKeyUp(KeyCode.G) && UIcall.instance.somethingopen && InventoryManager.okclose)
        {
            //¥]¥]
            gameObject.SetActive(false);
            UIcall.instance.somethingopen = false;
            if (InventoryManager.firstopen)
            {
                PlayerControll.instance.isbattle = false;
            }
            else
            {
                InventoryManager.firstopen = true;
            }
        }
    }

    
}

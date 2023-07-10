using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousetouch : MonoBehaviour
{
    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, -1); ;
        if (Input.GetMouseButtonUp(0))
        {
            if (hit.collider)
            {
                if (hit.transform.gameObject.tag == "redlight")
                {
                    hit.transform.gameObject.GetComponent<Animator>().SetTrigger("stamp");
                }
            }
        }
    }
}

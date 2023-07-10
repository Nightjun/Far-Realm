using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousepunch : MonoBehaviour
{
    public GameObject fight;


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, -1); ;
        if (Input.GetMouseButtonUp(0))
        {
            if (hit.collider)
            {
                if (hit.transform.gameObject.tag == "enemy")
                {
                    Instantiate(fight, transform.position, Quaternion.identity);

                }
            }       
        }
    }
}

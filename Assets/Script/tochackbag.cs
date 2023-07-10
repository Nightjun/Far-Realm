using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class tochackbag : MonoBehaviour
{
    public Additem adi;
    public string itemname;

    bool isright;

    [SerializeField] private UnityEvent thevent;

    private void FixedUpdate()
    {
        isright=adi.Checkthings(itemname);
        if (isright)
        {
            thevent.Invoke();
            isright = false;
        }
    }
}

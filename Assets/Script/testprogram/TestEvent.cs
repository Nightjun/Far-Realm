
using UnityEngine;
using UnityEngine.Events;

public class TestEvent : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            UIcall.instance.thebattlenote();
        }
    }
    public void pauce()
    {
        UIcall.instance.thebattlenote();
    }
}

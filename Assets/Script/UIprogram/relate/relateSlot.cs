using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class relateSlot : MonoBehaviour
{
    public Relationship relate;
    public Image relateimage;

    public void relateOnclicked()
    {
        relateInventoryMenager.UpdaterelateInfo();//�o�̤���[�F��
    }
}

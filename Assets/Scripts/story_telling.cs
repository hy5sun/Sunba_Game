using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //Ŀ�� ��ġ ����

public class story_telling : MonoBehaviour
{

    public void on()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void off()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
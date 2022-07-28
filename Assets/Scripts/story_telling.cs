using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //커서 위치 감지

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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //커서 위치 감지

public class story_telling : MonoBehaviour
{
    //스토리 텍스트 띄우는 함수
        //https://blog.naver.com/an_4_gel/222772438053
        //해당 오브젝트의 자식 오브젝트 setactive?
        //텍스트 보이게 전환. 어케했지 까먹었다.


    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject() ==true) //마우스가 오브젝트 위에 있을 떄
        {
            Debug.Log("응애 나 눌리는 중");
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}

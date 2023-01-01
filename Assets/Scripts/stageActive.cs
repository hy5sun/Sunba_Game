using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageActive : MonoBehaviour
{ // 스테이지 별 배경 및 파트너 활성화
    void Start()
    {
        GameObject.Find("backgrounds").transform.Find(Button._stage).gameObject.SetActive(true);
        GameObject.Find("partners").transform.Find(Button._stage).gameObject.SetActive(true);
    }

}
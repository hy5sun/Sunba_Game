using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageActive : MonoBehaviour
{ // �������� �� ��� �� ��Ʈ�� Ȱ��ȭ
    void Start()
    {
        GameObject.Find("backgrounds").transform.Find(Button._stage).gameObject.SetActive(true);
        GameObject.Find("partners").transform.Find(Button._stage).gameObject.SetActive(true);
    }

}
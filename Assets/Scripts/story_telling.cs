using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //Ŀ�� ��ġ ����

public class story_telling : MonoBehaviour
{
    //���丮 �ؽ�Ʈ ���� �Լ�
        //https://blog.naver.com/an_4_gel/222772438053
        //�ش� ������Ʈ�� �ڽ� ������Ʈ setactive?
        //�ؽ�Ʈ ���̰� ��ȯ. �������� ��Ծ���.


    void Update()
    {
    //    if (EventSystem.current.IsPointerOverGameObject() ==true) //���콺�� ������Ʈ ���� ���� ��
    //    {
    //        Debug.Log("���� �� ������ ��");

    //        //� ������Ʈ ���� �ִ��� Ȯ��.
    //        //�ش� ������Ʈ�� �̸��� ������ ����
    //                                //�����̸�.���⿡
    //        transform.GetChild(0).gameObject.SetActive(true);
    //    }
    //    else
    //    {
    //        transform.GetChild(0).gameObject.SetActive(false);
    //    }
    }
    private void OnMouseEnter()
    {
        Debug.Log("���� �� ������ ��");
        transform.GetChild(0).gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
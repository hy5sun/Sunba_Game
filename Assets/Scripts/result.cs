using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class result : MonoBehaviour
{
    public string scene;
    public int score;

    void Start()
    {
        if (scene == "scene_1")
            scene_1();
        else if (scene == "scene_2")
            scene_2();
        else if (scene == "scene_2")
            scene_3();
        else if (scene == "scene_2")
            scene_4();
        else if (scene == "scene_2")
            scene_5();
    }
    void scene_1()
    {
        //�̹����鵵 �����ؾ���
        if (score == 100)
            Debug.Log("¯~1");
        else if (score >= 80)
            Debug.Log("�ؼ��մϴ�1");
        else if (score >= 60)
            Debug.Log("�ٽ� ��������� �ʽ��ϴ�1");
        else if (score >= 30)
            Debug.Log("������ ���� ���� �ʽ��ϴ�1");
        else if (score >= 0)
            Debug.Log("�����մϴ�1");

    }
    void scene_2()
    {
        if (score == 100)
            Debug.Log("¯~2");
        else if (score >= 80)
            Debug.Log("�ؼ��մϴ�2");
        else if (score >= 60)
            Debug.Log("�ٽ� ��������� �ʽ��ϴ�2");
        else if (score >= 30)
            Debug.Log("������ ���� ���� �ʽ��ϴ�2");
        else if (score >= 0)
            Debug.Log("�����մϴ�2");
    }
    void scene_3()
    {
        if (score == 100)
            Debug.Log("¯~3");
        else if (score >= 80)
            Debug.Log("�ؼ��մϴ�3");
        else if (score >= 60)
            Debug.Log("�ٽ� ��������� �ʽ��ϴ�3");
        else if (score >= 30)
            Debug.Log("������ ���� ���� �ʽ��ϴ�3");
        else if (score >= 0)
            Debug.Log("�����մϴ�3");
    }
    void scene_4()
    {
        if (score == 100)
            Debug.Log("¯~4");
        else if (score >= 80)
            Debug.Log("�ؼ��մϴ�4");
        else if (score >= 60)
            Debug.Log("�ٽ� ��������� �ʽ��ϴ�4");
        else if (score >= 30)
            Debug.Log("������ ���� ���� �ʽ��ϴ�4");
        else if (score >= 0)
            Debug.Log("�����մϴ�4");
    }
    void scene_5()
    {
        if (score == 100)
            Debug.Log("¯~5");
        else if (score >= 80)
            Debug.Log("�ؼ��մϴ�5");
        else if (score >= 60)
            Debug.Log("�ٽ� ��������� �ʽ��ϴ�5");
        else if (score >= 30)
            Debug.Log("������ ���� ���� �ʽ��ϴ�5");
        else if (score >= 0)
            Debug.Log("�����մϴ�5");
    }
}

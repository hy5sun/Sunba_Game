using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int st1_score; //stage1 �� ����
    public int st2_score; //stage2 �� ����
    public int st3_score; //stage3 �� ����
    public int st4_score; //stage4 �� ����
    public int st5_score; //stage5 �� ����




    public int ReturnScore(string stage) //�������� �� �� ���� ��ȯ �Լ�
    {
        switch (stage)
        {
            case "stage1":
                return st1_score;
                break;
            case "stage2":
                return st2_score;
                break;
            case "stage3":
                return st3_score;
                break;
            case "stage4":
                return st4_score;
                break;
            default:
                return st5_score;
                break;
        }

    }
}
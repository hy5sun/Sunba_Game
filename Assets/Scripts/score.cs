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
    public static int _score = 0; //�� ����

    public void plusScore(string _stage) //�� ���� ��� �Լ�
    {
        switch (_stage)
        {
            case "stage1":
                _score += st1_score;
                break;
            case "stage2":
                _score += st2_score;
                break;
            case "stage3":
                _score += st3_score;
                break;
            case "stage4":
                _score += st4_score;
                break;
            default:
                _score += st5_score;
                break;
        }
        Debug.Log(_score);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int st1_score; //stage1 ¿Ê Á¡¼ö
    public int st2_score; //stage2 ¿Ê Á¡¼ö
    public int st3_score; //stage3 ¿Ê Á¡¼ö
    public int st4_score; //stage4 ¿Ê Á¡¼ö
    public int st5_score; //stage5 ¿Ê Á¡¼ö
    public static int _score = 0; //ÃÑ Á¡¼ö

    public void plusScore(string _stage) //¿Ê Á¡¼ö °è»ê ÇÔ¼ö
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

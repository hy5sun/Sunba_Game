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




    public int ReturnScore(string stage) //½ºÅ×ÀÌÁö º° ¿Ê Á¡¼ö ¹ÝÈ¯ ÇÔ¼ö
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
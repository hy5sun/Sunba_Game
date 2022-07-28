using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closet : MonoBehaviour
{
    public GameObject hair;
    public GameObject top;
    public GameObject bottom;
    public GameObject acc;
    public GameObject shoes;
    public GameObject[] closett;

    public void right()
    {
        GameObject thisis=shoes;
        GameObject next=hair;

        for(int i=0;i<4;i++)
        {
            if (closett[i].gameObject.activeSelf == true)
            {
                thisis = closett[i];
                next = closett[i+1];
            }
        }
       
        thisis.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
    }


        public void left() {

        GameObject thisis = hair;
        GameObject next = shoes;

        for (int i = 4; i > 0; i--)
        {
            if (closett[i].gameObject.activeSelf == true)
            {
                thisis = closett[i];
                next = closett[i- 1];
            }
        }

        thisis.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
    }
}

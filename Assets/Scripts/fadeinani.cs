using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fadeinani : MonoBehaviour
{
    public Image image;
    float time = 6f;

    void Awake()
    {
        Application.targetFrameRate = 60; // 60프레임으로 고정.
    }
    void Start()
    {
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine()
    {
        while (time > 0)
        {
            time -= 0.02f;
            yield return new WaitForSeconds(0.005f); //0.005초마다 실행한다.
            image.color = new Color(0, 0, 0, time); //점점밝아져여
        }
        Destroy(image);
    }
}

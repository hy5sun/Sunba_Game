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
        //이미지들도 변경해야함
        if (score == 100)
            Debug.Log("짱~1");
        else if (score >= 80)
            Debug.Log("준수합니다1");
        else if (score >= 60)
            Debug.Log("다시 보고싶지는 않습니다1");
        else if (score >= 30)
            Debug.Log("영원히 보고 싶지 않습니다1");
        else if (score >= 0)
            Debug.Log("끔찍합니다1");

    }
    void scene_2()
    {
        if (score == 100)
            Debug.Log("짱~2");
        else if (score >= 80)
            Debug.Log("준수합니다2");
        else if (score >= 60)
            Debug.Log("다시 보고싶지는 않습니다2");
        else if (score >= 30)
            Debug.Log("영원히 보고 싶지 않습니다2");
        else if (score >= 0)
            Debug.Log("끔찍합니다2");
    }
    void scene_3()
    {
        if (score == 100)
            Debug.Log("짱~3");
        else if (score >= 80)
            Debug.Log("준수합니다3");
        else if (score >= 60)
            Debug.Log("다시 보고싶지는 않습니다3");
        else if (score >= 30)
            Debug.Log("영원히 보고 싶지 않습니다3");
        else if (score >= 0)
            Debug.Log("끔찍합니다3");
    }
    void scene_4()
    {
        if (score == 100)
            Debug.Log("짱~4");
        else if (score >= 80)
            Debug.Log("준수합니다4");
        else if (score >= 60)
            Debug.Log("다시 보고싶지는 않습니다4");
        else if (score >= 30)
            Debug.Log("영원히 보고 싶지 않습니다4");
        else if (score >= 0)
            Debug.Log("끔찍합니다4");
    }
    void scene_5()
    {
        if (score == 100)
            Debug.Log("짱~5");
        else if (score >= 80)
            Debug.Log("준수합니다5");
        else if (score >= 60)
            Debug.Log("다시 보고싶지는 않습니다5");
        else if (score >= 30)
            Debug.Log("영원히 보고 싶지 않습니다5");
        else if (score >= 0)
            Debug.Log("끔찍합니다5");
    }
}

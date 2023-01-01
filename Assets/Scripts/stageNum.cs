using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class stageNum : MonoBehaviour
{
    public TextMeshProUGUI TextStage; //스테이지 텍스트

    void Start()
    {
        if (Button._stage == "stage1")
            TextStage.text = "스테이지 1";
        else if (Button._stage == "stage2")
            TextStage.text = "스테이지 2";
        else if (Button._stage == "stage3")
            TextStage.text = "스테이지 3";
        else if (Button._stage == "stage4")
            TextStage.text = "스테이지 4";
        else if (Button._stage == "stage5")
            TextStage.text = "스테이지 5";
    }

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class stageNum : MonoBehaviour
{
    public TextMeshProUGUI TextStage; //�������� �ؽ�Ʈ

    void Start()
    {
        if (Button._stage == "stage1")
            TextStage.text = "�������� 1";
        else if (Button._stage == "stage2")
            TextStage.text = "�������� 2";
        else if (Button._stage == "stage3")
            TextStage.text = "�������� 3";
        else if (Button._stage == "stage4")
            TextStage.text = "�������� 4";
        else if (Button._stage == "stage5")
            TextStage.text = "�������� 5";
    }

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class results : MonoBehaviour
{
    public TextMeshProUGUI TextScore; //���� �ؽ�Ʈ
    public TextMeshProUGUI TextTalking; //��Ʈ�� ��� �ؽ�Ʈ

    void Start()
    {
        TextScore.text = "Score: " + Button.scoreSum.ToString(); //Button ��ũ��Ʈ ���� scoreSum �ҷ��ͼ� strȭ

        if (Button.scoreSum == 100)
            TextTalking.text = "WOW Perfect!";
        else if (Button.scoreSum >= 80)
            TextTalking.text = "Not bad z";
        else if (Button.scoreSum >= 60)
            TextTalking.text = "OMG,,,,,,,,,,,,,";
        else if (Button.scoreSum >= 30)
            TextTalking.text = "whyrano";
        else if (Button.scoreSum >= 0)
            TextTalking.text = "Eng";
    }
}
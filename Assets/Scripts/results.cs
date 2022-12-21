using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class results : MonoBehaviour
{
    public TextMeshProUGUI TextScore; //점수 텍스트
    public TextMeshProUGUI TextTalking; //파트너 대사 텍스트

    void Start()
    {
        TextScore.text = "Score: " + Button.scoreSum.ToString(); //Button 스크립트 내의 scoreSum 불러와서 str화

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
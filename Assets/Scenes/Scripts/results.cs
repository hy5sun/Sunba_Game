using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//해야하는 것 : 점수에 따른 사운드재생/파트너활성화
//GameObject.Find("parthers").transform.Find("Partner1").gameObject.SetActive(true);
public class results : MonoBehaviour
{
    public TextMeshProUGUI TextScore; //점수 텍스트
    public TextMeshProUGUI TextTalking; //파트너 대사 텍스트

    void Start()
    {
        TextScore.text = "당신의 점수는~~" + Button.scoreSum.ToString() + "점!!!"; //Button 스크립트 내의 scoreSum 불러와서 str화

        if (Button.scoreSum == 100)
            TextTalking.text = "헐 대박!";
        else if (Button.scoreSum >= 80)
            TextTalking.text = "오오 굿보이";
        else if (Button.scoreSum >= 60)
            TextTalking.text = "에?";
        else if (Button.scoreSum >= 30)
            TextTalking.text = "와,,,,와이라노";
        else if (Button.scoreSum >= 0)
            TextTalking.text = "오오 대박 나가세요";
    }
}
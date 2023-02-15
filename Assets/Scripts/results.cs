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
    public AudioClip[] audioclip;
    AudioSource audiosource;

    void Start()
    {
        TextScore.text = Button.scoreSum.ToString(); //Button 스크립트 내의 scoreSum 불러와서 str화
        audiosource = GetComponent<AudioSource>();
        if (Button.scoreSum == 100)
        {
            audiosource.clip = audioclip[0];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 80)
        {
            audiosource.clip = audioclip[1];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 60)
        {
            audiosource.clip = audioclip[2];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 30)
        {
            audiosource.clip = audioclip[3];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 0)
        {
            audiosource.clip = audioclip[4];
            StartCoroutine(delaytime());
        }
        //-----------------------------------------
        if (Button._stage == "stage1") //트위치파티
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "<size=62.6>트하! 유튜브80만 구독자 슈트리머 선바님과 파.트.너로 트위치 파티에 왔습니다 꺆><!";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "<size=71.8>트하! 여러분~ 오늘은 선바님과 트위치 파티에 왔습니다!";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "<size=71.8>아~ 그,,선반? 편하게 입고 오셨네~ 방송이 장난이에요?";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "<size=64.8>트하! 여러분! 오늘은 옆집 개를 데리고 트위치 파티에 와봤습니다!";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "<size=67.4>트하! 여러분~ 오늘은 저 '혼자서' 트위치 파티에 와봤습니다!";
        }
        else if (Button._stage == "stage2") //모니카
        {
            TextTalking.text = "<color=red><size=117.9>선바, 나랑 영원히 함께 하자";
        }
        else if (Button._stage == "stage3") //팬미팅
        {
            if (Button.scoreSum == 100)
                TextTalking.text = @"<size=84.2>선바님 수염이
너무 멋지세요 ><!!!";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "<size=107.7>심뽀찜뽀";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "<size=77.7>선바님 제발 거기서 그렇게 하시면 안돼요 엉엉엉엉..";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "<size=77.7>선반님 아무리 선술잘이어도 그렇지 낮술을 하시나요?";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "<size=51.7>선반님 제가 너무 부끄러워요................................";
        }
        else if (Button._stage == "stage4") //스포티걸
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "<size=72.9>흥 이 정도는 되야 내 파트너지";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "<size=90.8>봐줄만 하네";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "<size=81.4>다시 셍각헤보지그레?";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "<size=69.5>너 이런 옷으로 나랑 파티에 갈 셍각이야?";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "<size=69.5>화분맡고 페션감각도 리샛됫니?";
        }
        else //후배들과의 조별과제
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "<size=69.5>와 SUNBA,, 그렇게 생각보다 댄디보이인 걸?";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "<size=67>사스카 10학번 센빠이! 옷 입는 것부터가 다르다구!!!";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "<size=60.8>선배님 다음부터 안 나오셔도 돼요..! 그냥 발표랑 자료조사만 맡아주세요";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "<size=62>선배님 라떼는 그렇게 안 입었어요";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "<color=red><size=83.5>제 이름 그냥 빼주세요;";
        }
        //-------------------------------
        GameObject.Find("backgrounds").transform.Find(Button._stage.ToString()).gameObject.SetActive(true);
        GameObject.Find("partners").transform.Find(Button._stage.ToString()).gameObject.SetActive(true);
    }

IEnumerator delaytime()
    {
        yield return new WaitForSeconds(4.0f);
        audiosource.Play();
    }
}
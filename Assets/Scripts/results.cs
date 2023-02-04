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
                TextTalking.text = "선바님 옷 진짜 잘입으세요? 패션쪽으로 나가보세요 ㅎㅎ";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "선바님이 눈에 엄청 띄는 거 아시죠 짱이시네 진짜";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "아~ 선반님이요? 안녕하세요~ 편하게 입고 오셨네..!";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "선바님 이러고 오셨어요? 컨셉이신가ㅎㅎ....";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "저 분이 선바님이셔? 그렇구나.......... 글쿤,,";
        }
        else if (Button._stage == "stage2") //모니카
        {
            TextTalking.text = "선바, 나랑 영원히 함께 하자";
        }
        else if (Button._stage == "stage3") //팬미팅
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "선바님 너무 멋지세요 ><!!!";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "와 선바님 옷 머에요!! 너무 멋지잖아요";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "내가 아는 선반님이 아니야,,";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "진짜 스트리머는 다르다. 팬미팅에서까지 컨텐츠 분량을 뽑으시네. 감동이야!!!";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "ㄹㅇ 숭하시다";
        }
        else if (Button._stage == "stage4") //스포티걸
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "흥 이 정도는 돼야 내 파트너지";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "봐줄만 하네 ㅋ";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "다시 생각해보지그래?";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "너 이런 옷으로 나랑 파티에 갈 생각이야?";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "화분으로 패션감각도 리셋됐니?";
        }
        else //후배들과의 조별과제
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "와 SUNBA,, 그렇게 생각보다 댄디보이인 걸?";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "사스카 10학번 센빠이! 옷 입는 것부터가 다르다구!!!";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "혼자 10년대에 멈춰계신거 아니죠?";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "선배님 다음부터 안 나오셔도 돼요..! 그냥 발표랑 자료조사만 맡아주세요";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "제 이름 그냥 빼주세요";
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
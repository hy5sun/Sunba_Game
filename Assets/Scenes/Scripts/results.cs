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
        TextScore.text = "당신의 점수는~~" + Button.scoreSum.ToString() + "점!!!"; //Button 스크립트 내의 scoreSum 불러와서 str화
        audiosource = GetComponent<AudioSource>();
        if (Button.scoreSum == 100)
        {
            TextTalking.text = "헐 대박!";
            audiosource.clip = audioclip[0];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 80)
        {
            TextTalking.text = "오오 굿보이";
            audiosource.clip = audioclip[1];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 60)
        {
            TextTalking.text = "에?";
            audiosource.clip = audioclip[2];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 30)
        {
            TextTalking.text = "와,,,,와이라노";
            audiosource.clip = audioclip[3];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 0)
        {
            TextTalking.text = "오오 대박 나가세요";
            audiosource.clip = audioclip[4];
            StartCoroutine(delaytime());
        }

        switch (Button._stage.ToString()) //파트너활성화
        {
            case "stage1":
                GameObject.Find("partners").transform.Find("Partner1").gameObject.SetActive(true);
                break;
            case "stage2":
                GameObject.Find("partners").transform.Find("Partner2").gameObject.SetActive(true); ;
                break;
            case "stage3":
                GameObject.Find("partners").transform.Find("Partner3").gameObject.SetActive(true);
                break;
            case "stage4":
                GameObject.Find("partners").transform.Find("Partner4").gameObject.SetActive(true);
                break;
            default:
                GameObject.Find("partners").transform.Find("Partner5").gameObject.SetActive(true);
                break;
        }
    }

    IEnumerator delaytime()
    {
        yield return new WaitForSeconds(4.0f);
        audiosource.Play();
    }
}
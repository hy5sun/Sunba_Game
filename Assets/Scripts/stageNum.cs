using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class stageNum : MonoBehaviour
{
    public AudioSource audioSource;//음원
    public Image image;
    float time = 0;
    public TextMeshProUGUI TextStage; //스테이지 텍스트

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (Button._stage == "stage1")
        {
            TextStage.text = "트위치파티";
            Destroy(image);
        }
        else if (Button._stage == "stage2")
        {
            StartCoroutine(FadeCoroutine());
            TextStage.text = "<color=red>모니카와 약혼식";
            audioSource.Play();
        }
        else if (Button._stage == "stage3")
        {
            TextStage.text = "순돌들과의 팬미팅";
            Destroy(image);
        }
        else if (Button._stage == "stage4")
        {
            TextStage.text = "스포티걸과의 파티";
            Destroy(image);
        }
        else if (Button._stage == "stage5")
        {
            TextStage.text = "MZ모임에 낀 화석";
            Destroy(image);
        }
    }
    IEnumerator FadeCoroutine()
    {
        while (time < 3f)
        {
            time += 0.05f;
            yield return new WaitForSeconds(0.01f); //0.01초마다 실행한다.
        }
        Destroy(image);
    }

}

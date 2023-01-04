using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//�ؾ��ϴ� �� : ������ ���� �������/��Ʈ��Ȱ��ȭ
//GameObject.Find("parthers").transform.Find("Partner1").gameObject.SetActive(true);
public class results : MonoBehaviour
{
    public TextMeshProUGUI TextScore; //���� �ؽ�Ʈ
    public TextMeshProUGUI TextTalking; //��Ʈ�� ��� �ؽ�Ʈ
    public AudioClip[] audioclip;
    AudioSource audiosource;


    void Start()
    {
        TextScore.text = "����� ������~~" + Button.scoreSum.ToString() + "��!!!"; //Button ��ũ��Ʈ ���� scoreSum �ҷ��ͼ� strȭ
        audiosource = GetComponent<AudioSource>();
        if (Button.scoreSum == 100)
        {
            TextTalking.text = "�� ���!";
            audiosource.clip = audioclip[0];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 80)
        {
            TextTalking.text = "���� �º���";
            audiosource.clip = audioclip[1];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 60)
        {
            TextTalking.text = "��?";
            audiosource.clip = audioclip[2];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 30)
        {
            TextTalking.text = "��,,,,���̶��";
            audiosource.clip = audioclip[3];
            StartCoroutine(delaytime());
        }
        else if (Button.scoreSum >= 0)
        {
            TextTalking.text = "���� ��� ��������";
            audiosource.clip = audioclip[4];
            StartCoroutine(delaytime());
        }

        switch (Button._stage.ToString()) //��Ʈ��Ȱ��ȭ
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
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class stageNum : MonoBehaviour
{
    public AudioSource audioSource;//����
    public Image image;
    float time = 0;
    public TextMeshProUGUI TextStage; //�������� �ؽ�Ʈ

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (Button._stage == "stage1")
        {
            TextStage.text = "Ʈ��ġ��Ƽ";
            Destroy(image);
        }
        else if (Button._stage == "stage2")
        {
            StartCoroutine(FadeCoroutine());
            TextStage.text = "<color=red>���ī�� ��ȥ��";
            audioSource.Play();
        }
        else if (Button._stage == "stage3")
        {
            TextStage.text = "��������� �ҹ���";
            Destroy(image);
        }
        else if (Button._stage == "stage4")
        {
            TextStage.text = "����Ƽ�ɰ��� ��Ƽ";
            Destroy(image);
        }
        else if (Button._stage == "stage5")
        {
            TextStage.text = "MZ���ӿ� �� ȭ��";
            Destroy(image);
        }
    }
    IEnumerator FadeCoroutine()
    {
        while (time < 3f)
        {
            time += 0.05f;
            yield return new WaitForSeconds(0.01f); //0.01�ʸ��� �����Ѵ�.
        }
        Destroy(image);
    }

}

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

    void Start()
    {
        TextScore.text = "����� ������~~" + Button.scoreSum.ToString() + "��!!!"; //Button ��ũ��Ʈ ���� scoreSum �ҷ��ͼ� strȭ

        if (Button.scoreSum == 100)
            TextTalking.text = "�� ���!";
        else if (Button.scoreSum >= 80)
            TextTalking.text = "���� �º���";
        else if (Button.scoreSum >= 60)
            TextTalking.text = "��?";
        else if (Button.scoreSum >= 30)
            TextTalking.text = "��,,,,���̶��";
        else if (Button.scoreSum >= 0)
            TextTalking.text = "���� ��� ��������";
    }
}
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
        TextScore.text = "����� ������~~" + Button.scoreSum.ToString() + "��!!!"; //Button ��ũ��Ʈ ���� scoreSum �ҷ��ͼ� strȭ

        if (Button._stage == "stage1") //Ʈ��ġ��Ƽ
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "���ٴ� �� ���� ����������? �м������� ����������";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "���ٴ��� ���� ��û ��� �� �ƽ��� ¯�̽ó� ��¥";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "��~ ���ݴ��̿�? �ȳ��ϼ���~ ���ϰ� �԰� ���̳�..!";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "���ٴ� �̷��� ���̾��? �����̽Ű�����....";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "�� ���� ���ٴ��̼�? �׷�����.......... ����,,";
        }
        else if (Button._stage == "stage2") //���ī
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "����, ���� ������ �Բ� ����";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "����, ���� ������ �Բ� ����";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "����, ���� ������ �Բ� ����";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "����, ���� ������ �Բ� ����";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "����, ���� ������ �Բ� ����";
        }
        else if (Button._stage == "stage3") //�ҹ���
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "���ٴ� �ʹ� �������� ><!!!";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "�� ���ٴ� �� �ӿ���!! �ʹ� �����ݾƿ�";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "���� �ƴ� ���ݴ��� �ƴϾ�,,";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "��¥ ��Ʈ���Ӵ� �ٸ���. �ҹ��ÿ������� ������ �з��� �����ó�. �����̾�!!!";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "���� ���Ͻô�";
        }
        else if (Button._stage == "stage4") //����Ƽ��
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "�� �� ������ �ž� �� ��Ʈ����";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "���ٸ� �ϳ� ��";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "�ٽ� �����غ����׷�?";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "�� �̷� ������ ���� ��Ƽ�� �� �����̾�?";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "ȭ������ �мǰ����� ���µƴ�?";
        }
        else //�Ĺ����� ��������
        {
            if (Button.scoreSum == 100)
                TextTalking.text = "�� SUNBA,, �׷��� �������� ������� ��?";
            else if (Button.scoreSum >= 80)
                TextTalking.text = "�罺ī 10�й� ������! �� �Դ� �ͺ��Ͱ� �ٸ��ٱ�!!!";
            else if (Button.scoreSum >= 60)
                TextTalking.text = "ȥ�� 10��뿡 �����Ű� �ƴ���?";
            else if (Button.scoreSum >= 30)
                TextTalking.text = "����� �������� �� �����ŵ� �ſ�..! �׳� ��ǥ�� �ڷ����縸 �þ��ּ���";
            else if (Button.scoreSum >= 0)
                TextTalking.text = "�� �̸� �׳� ���ּ���";
        }

    }
}
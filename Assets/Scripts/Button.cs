using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�� ��ȯ
using UnityEngine.EventSystems; //Ŀ�� ��ġ ����

public class Button : MonoBehaviour //Ư�� ��ư�� ������ �־��� �ڵ尡 �����ϴ� ��ũ��Ʈ
{
    public GameObject img; //��Ÿ���� �� �̹��� ���� (�� ������ ��)
    public GameObject story;
    public static string _stage; //���� �������� (�� ����� �� ���)
    public static int scoreSum = 0;

    public void OnClickStart() //���ӽ��� ��ư�� ������
    {
        Debug.Log("������ �����մϴ�!");
        SceneManager.LoadScene("Choose_stage"); //���丮 ���� â���� �̵�
    }

    public void OnClickHow() //���Ӽ��� ��ư�� ������
    {
        Debug.Log("����â���� �̵��մϴ�.");
        SceneManager.LoadScene("Description"); //����â���� �̵�
    }

    public void OnClickMain() //ó������ ��ư�� ������
    {
        Debug.Log("����ȭ������ �̵��մϴ�.");
        SceneManager.LoadScene("Main Menu"); //����ȭ������ �̵�
    }

    public void OnClickStory() //����ڰ� ���丮�� �����ϸ�
    {
        Debug.Log("�� ������ ������ �̵���!");
        _stage = story.tag;

        SceneManager.LoadScene("main_clothes"); //�� ������ ���� â���� �̵�
    }

    public void ending() //����ڰ� �Ϸ� ��ư�� ������
    {
        
        Debug.Log("�ϼ�!!!");

        //�Ϸ� ��ư�� ������ Ȱ��ȭ �Ǿ��ִ� ������Ʈ���� ���� �ջ��ϱ�
        string[] tagg = { "hair", "bottom", "top", "acc", "shoes" };
        foreach (string k in tagg)
        {
            GameObject[] category = GameObject.FindGameObjectsWithTag(k);
            
            for (int i = 0; i < category.Length; i++)
            {
                if (category[i].gameObject.activeSelf == true)
                {
                    Debug.Log("�������� " + _stage + "�Դϴ�.");
                    scoreSum += category[i].GetComponent<score>().ReturnScore(_stage);
                    Debug.Log("�������� " + scoreSum);
                }
            }
        }
        
        SceneManager.LoadScene("resultscene"); //��� ��ǥ â���� �̵�
    }


    public void OnClickClothes() //����ڰ� ���ϴ� ���� Ŭ���ϸ�
    {
        string tagg = img.tag;
        GameObject set = GameObject.Find("top").transform.Find("top3").gameObject;

        if (tagg == "bottom") //�����ϰ�� ��Ʈ ��Ȱ��ȭ
            set.gameObject.SetActive(false);

        if (tagg == "hair") //�Ӹ� ������ ��� ��Ʈ ��Ȱ��ȭ
            set.gameObject.SetActive(false);

        var category = GameObject.FindGameObjectsWithTag(tagg);
        for (int i = 0; i < category.Length; i++)
        {
            category[i].gameObject.SetActive(false);
        }

        img.SetActive(true); //����ڰ� Ŭ���� �� �׸� Ȱ��ȭ

        if (set.gameObject.activeSelf == true)
        { //���ǰ� ��Ʈ�ΰ�� ����, �Ӹ� ��Ȱ��ȭ
            category = GameObject.FindGameObjectsWithTag("bottom");
            for (int i = 0; i < category.Length; i++)
            {
                category[i].gameObject.SetActive(false);
            }

            category = GameObject.FindGameObjectsWithTag("hair");
            for (int i = 0; i < category.Length; i++)
            {
                category[i].gameObject.SetActive(false);
            }
        }
    }

    public void on() //������Ʈ ���� ���콺�� �ø��� (choose_stage Scene)
    {
        transform.GetChild(0).gameObject.SetActive(true); //child 0�� Ȱ��ȭ
    }

    public void off() //������Ʈ���� ���콺�� ������ (choose_stage Scene)
    {
        transform.GetChild(0).gameObject.SetActive(false); //child 0�� ��Ȱ��ȭ
    }
    public void resetting()
    {//���¹�ư�� ������
        
        string[] tagg = { "hair", "top", "bottom", "acc", "shoes" };
        foreach (string e in tagg) {
            var category = GameObject.FindGameObjectsWithTag(e);
            for (int i = 0; i < category.Length; i++)
            {
                if (category[i].gameObject.activeSelf == true)
                    category[i].gameObject.SetActive(false);
            }
        }
    }
}

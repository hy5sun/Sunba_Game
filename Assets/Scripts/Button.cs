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
    public GameObject hair;
    public GameObject shoes;
    public GameObject[] closett;
    
    public void OnClickQuit()
    {
        Debug.Log("������ �����մϴ�.");
        Application.Quit(); //���� ����
    }

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
    public void right() //�����ư
    {
        GameObject thisis = shoes;
        GameObject next = hair;

        for (int i = 0; i < 4; i++)
        {
            if (closett[i].gameObject.activeSelf == true)
            {
                thisis = closett[i];
                next = closett[i + 1];
            }
        }

        thisis.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
    }


    public void left() //�����ư
    {

        GameObject thisis = hair;
        GameObject next = shoes;

        for (int i = 4; i > 0; i--)
        {
            if (closett[i].gameObject.activeSelf == true)
            {
                thisis = closett[i];
                next = closett[i - 1];
            }
        }

        thisis.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
    }
    public void ending() //����ڰ� �Ϸ� ��ư�� ������
    {
        scoreSum = 0;
        Debug.Log("�ϼ�!!!");

        //�Ϸ� ��ư�� ������ Ȱ��ȭ �Ǿ��ִ� ������Ʈ���� ���� �ջ��ϱ�
        string[] tagg = {"hair", "bottom", "top", "acc", "shoes", "acc-eyewear" };

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
        //��Ʈ�����ݿ�
        if (GameObject.Find("top1") && GameObject.Find("bottom1")) scoreSum += 10; 
        if (GameObject.Find("top2") && GameObject.Find("bottom3")) scoreSum += 10;
        if (GameObject.Find("top3")) scoreSum += 10;
        if (GameObject.Find("top4") && GameObject.Find("bottom4")) scoreSum += 10;
        if (GameObject.Find("top5") && GameObject.Find("bottom6")) scoreSum += 10;
        if (GameObject.Find("top6") && GameObject.Find("bottom5")) scoreSum += 10;
        if (GameObject.Find("top7") && GameObject.Find("bottom7")) scoreSum += 10;
        if (GameObject.Find("top8")) scoreSum += 10;


        GameObject[] beard = GameObject.FindGameObjectsWithTag("acc-beard"); //����������0��
        if(beard.Length==0) scoreSum = 0;
        
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


        if (img.activeSelf == false) { //������ ���°� �ƴ϶��
            var category = GameObject.FindGameObjectsWithTag(tagg);
            for (int i = 0; i < category.Length; i++) 
            {
                category[i].gameObject.SetActive(false); // ���� ī�װ� �� �ߺ� Ȱ��ȭ ����
            }

            img.SetActive(true); //����ڰ� Ŭ���� �� �׸� Ȱ��ȭ
        }
        else //�̹� ������ ���¿��� �� �� �� Ŭ���ѰŸ�
        {
            img.SetActive(false); //�ش� �� ��Ȱ��ȭ
        }

        if (set.gameObject.activeSelf == true)
        { //���ǰ� ��Ʈ�ΰ�� ����, �Ӹ� ��Ȱ��ȭ
            var category = GameObject.FindGameObjectsWithTag("bottom");
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
        
        string[] tagg = { "acc-beard","hair", "top", "bottom", "acc", "acc-eyewear", "shoes" };
        foreach (string e in tagg) {
            var category = GameObject.FindGameObjectsWithTag(e);
                if (category.Length != 0) category[0].gameObject.SetActive(false);
        }
    }
}

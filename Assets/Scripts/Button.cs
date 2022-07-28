using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�� ��ȯ
using UnityEngine.EventSystems; //Ŀ�� ��ġ ����

public class Button : MonoBehaviour //Ư�� ��ư�� ������ �־��� �ڵ尡 �����ϴ� ��ũ��Ʈ
{
    [SerializeField] GameObject img; //��Ÿ���� �� �̹��� ���� (�� ������ ��)

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
        Debug.Log("��� ��ٷ��~");
        SceneManager.LoadScene("main_clothes"); //�� ������ ���� â���� �̵�
    }

    public void OnClickreplay() //����ڰ� �ٽ��ϱ� ��ư�� ������
    {
        SceneManager.LoadScene("Choose_stage"); //���丮 ���� ȭ������ �̵�
    }

    public void OnClickClothes() //����ڰ� ���ϴ� ���� Ŭ���ϸ�
    {
        string tagg = img.tag;
        var t = GameObject.FindGameObjectsWithTag(tagg);
        for(int i = 0; i < t.Length; i++)
        {
            if(t[i].gameObject.activeSelf == true){
                t[i].gameObject.SetActive(false);
                break;
            }
        }

        img.SetActive(true); //����ڰ� Ŭ���� �� �׸� Ȱ��ȭ
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�� ��ȯ

public class Button : MonoBehaviour //Ư�� ��ư�� ������ ���� ����Ǵ� ��ũ��Ʈ
{
    
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

    public void OnClickClothes() //����ڰ� ���丮�� �����ϸ�
    {
        Debug.Log("��� ��ٷ��~");
        SceneManager.LoadScene("main_clothes"); //�� ������ ���� â���� �̵�
    }

    public void OnClickreplay() //����ڰ� �ٽ��ϱ� ��ư�� ������
    {
        SceneManager.LoadScene("Choose_stage"); //���丮 ���� ȭ������ �̵�
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

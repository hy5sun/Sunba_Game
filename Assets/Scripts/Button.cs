using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�� ��ȯ

public class Button : MonoBehaviour //Ư�� ��ư�� ������ ���� ����Ǵ� ��ũ��Ʈ
{
    
    public void OnClickStart() //���ӽ��� ��ư�� ������
    {
        Debug.Log("������ �����մϴ�!");
        SceneManager.LoadScene(2); //���丮 ���� â���� �̵�
    }

    public void OnClickHow() //���Ӽ��� ��ư�� ������
    {
        Debug.Log("����â���� �̵��մϴ�.");
        SceneManager.LoadScene(1); //����â���� �̵�
    }

    public void OnClickMain() //ó������ ��ư�� ������
    {
        Debug.Log("����ȭ������ �̵��մϴ�.");
        SceneManager.LoadScene(0); //����ȭ������ �̵�
    }

    public void OnClickClothes() //����ڰ� ���丮�� �����ϸ�
    {
        Debug.Log("��� ��ٷ��~");
        SceneManager.LoadScene(3); //�� ������ ���� â���� �̵�
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

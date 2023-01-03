using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroySunba : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //���� ĳ���� ������ ���ƿ�
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "choose_stage") //���������� �ٽ��ϱ� ������
            Destroy(gameObject); //���� ���������
    }

}
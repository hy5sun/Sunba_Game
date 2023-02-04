using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroySunba : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //선바 캐릭터 없애지 말아요
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "choose_stage") //점수씬에서 다시하기 누르면
            Destroy(gameObject); //선바 사라지세요
    }

}
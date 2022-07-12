using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬 전환

public class Button : MonoBehaviour //특정 버튼을 누르면 씬이 변경되는 스크립트
{
    
    public void OnClickStart() //게임시작 버튼을 누르면
    {
        Debug.Log("게임을 시작합니다!");
        SceneManager.LoadScene(2); //스토리 고르는 창으로 이동
    }

    public void OnClickHow() //게임설명 버튼을 누르면
    {
        Debug.Log("설명창으로 이동합니다.");
        SceneManager.LoadScene(1); //설명창으로 이동
    }

    public void OnClickMain() //처음으로 버튼을 누르면
    {
        Debug.Log("메인화면으로 이동합니다.");
        SceneManager.LoadScene(0); //메인화면으로 이동
    }

    public void OnClickClothes() //사용자가 스토리를 선택하면
    {
        Debug.Log("잠깐만 기다료봐~");
        SceneManager.LoadScene(3); //옷 입히는 게임 창으로 이동
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

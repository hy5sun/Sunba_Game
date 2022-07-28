using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬 전환
using UnityEngine.EventSystems; //커서 위치 감지

public class Button : MonoBehaviour //특정 버튼을 누르면 주어진 코드가 동작하는 스크립트
{
    [SerializeField] GameObject img; //나타나게 할 이미지 지정 (옷 선택할 때)

    public void OnClickStart() //게임시작 버튼을 누르면
    {
        Debug.Log("게임을 시작합니다!");
        SceneManager.LoadScene("Choose_stage"); //스토리 고르는 창으로 이동
    }

    public void OnClickHow() //게임설명 버튼을 누르면
    {
        Debug.Log("설명창으로 이동합니다.");
        SceneManager.LoadScene("Description"); //설명창으로 이동
    }

    public void OnClickMain() //처음으로 버튼을 누르면
    {
        Debug.Log("메인화면으로 이동합니다.");
        SceneManager.LoadScene("Main Menu"); //메인화면으로 이동
    }

    public void OnClickStory() //사용자가 스토리를 선택하면
    {
        Debug.Log("잠깐만 기다료봐~");
        SceneManager.LoadScene("main_clothes"); //옷 입히는 게임 창으로 이동
    }

    public void OnClickreplay() //사용자가 다시하기 버튼을 누르면
    {
        SceneManager.LoadScene("Choose_stage"); //스토리 선택 화면으로 이동
    }

    public void OnClickClothes() //사용자가 원하는 옷을 클릭하면
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

        img.SetActive(true); //사용자가 클릭한 옷 그림 활성화
    }
    
}

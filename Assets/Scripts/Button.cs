using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬 전환
using UnityEngine.EventSystems; //커서 위치 감지

public class Button : MonoBehaviour //특정 버튼을 누르면 주어진 코드가 동작하는 스크립트
{
    public GameObject img; //나타나게 할 이미지 지정 (옷 선택할 때)
    public GameObject story;
    public static int _score; //총 점수
    public static string _stage; //현재 스테이지 (옷 계산할 때 사용)

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
        Debug.Log("옷 입히기 씬으로 이동중!");
        _stage = story.tag;

        SceneManager.LoadScene("main_clothes"); //옷 입히는 게임 창으로 이동
    }

    public void ending() //사용자가 완료 버튼을 누르면
    {
        
        Debug.Log("완성!!!");

        //완료 버튼을 누르면 활성화 되어있는 오브젝트들의 점수 합산하기
        string[] tagg = { "hair", "bottom", "top", "acc", "shoes" };
        foreach (string k in tagg)
        {
            GameObject[] category = GameObject.FindGameObjectsWithTag(k);
            
            for (int i = 0; i < category.Length; i++)
            {
                if (category[i].gameObject.activeSelf == true)
                {
                    category[i].GetComponent<score>().plusScore(_stage); //score 스크립트 속 plusScore 함수 실행
                }
            }
        }
        
        SceneManager.LoadScene("resultscene"); //결과 발표 창으로 이동
    }


    public void OnClickClothes() //사용자가 원하는 옷을 클릭하면
    {
        string tagg = img.tag;
        GameObject set = GameObject.Find("top").transform.Find("top3").gameObject;

        if (tagg == "bottom") //하의일경우 세트 비활성화
            set.gameObject.SetActive(false);

        if (tagg == "hair") //머리 적용한 경우 세트 비활성화
            set.gameObject.SetActive(false);

        var category = GameObject.FindGameObjectsWithTag(tagg);
        for (int i = 0; i < category.Length; i++)
        {
            category[i].gameObject.SetActive(false);
        }

        img.SetActive(true); //사용자가 클릭한 옷 그림 활성화

        if (set.gameObject.activeSelf == true)
        { //상의가 세트인경우 하의, 머리 비활성화
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

    public void on() //오브젝트 위에 마우스를 올리면 (choose_stage Scene)
    {
        transform.GetChild(0).gameObject.SetActive(true); //child 0을 활성화
    }

    public void off() //오브젝트에서 마우스를 내리면 (choose_stage Scene)
    {
        transform.GetChild(0).gameObject.SetActive(false); //child 0을 비활성화
    }
    public void resetting()
    {//리셋버튼을 누르면
        
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

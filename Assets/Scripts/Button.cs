using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬 전환
using UnityEngine.EventSystems; //커서 위치 감지

public class Button : MonoBehaviour //특정 버튼을 누르면 주어진 코드가 동작하는 스크립트
{
    public GameObject img; //나타나게 할 이미지 지정 (옷 선택할 때)
    public GameObject story;
    public static string _stage; //현재 스테이지 (옷 계산할 때 사용)
    public static int scoreSum = 0;
    public GameObject hair;
    public GameObject shoes;
    public GameObject[] closett;
    
    public void OnClickQuit()
    {
        Debug.Log("게임을 종료합니다.");
        Application.Quit(); //게임 종료
    }

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
    public void right() //옷장버튼
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


    public void left() //옷장버튼
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
    public void ending() //사용자가 완료 버튼을 누르면
    {
        scoreSum = 0;
        Debug.Log("완성!!!");

        //완료 버튼을 누르면 활성화 되어있는 오브젝트들의 점수 합산하기
        string[] tagg = {"hair", "bottom", "top", "acc", "shoes", "acc-eyewear" };

        foreach (string k in tagg)
        {
            GameObject[] category = GameObject.FindGameObjectsWithTag(k);
            for (int i = 0; i < category.Length; i++)
            {
                if (category[i].gameObject.activeSelf == true)
                {
                    Debug.Log("스테이지 " + _stage + "입니다.");
                    scoreSum += category[i].GetComponent<score>().ReturnScore(_stage);
                    Debug.Log("총점수는 " + scoreSum);
                }
            }
        }
        //세트점수반영
        if (GameObject.Find("top1") && GameObject.Find("bottom1")) scoreSum += 10; 
        if (GameObject.Find("top2") && GameObject.Find("bottom3")) scoreSum += 10;
        if (GameObject.Find("top3")) scoreSum += 10;
        if (GameObject.Find("top4") && GameObject.Find("bottom4")) scoreSum += 10;
        if (GameObject.Find("top5") && GameObject.Find("bottom6")) scoreSum += 10;
        if (GameObject.Find("top6") && GameObject.Find("bottom5")) scoreSum += 10;
        if (GameObject.Find("top7") && GameObject.Find("bottom7")) scoreSum += 10;
        if (GameObject.Find("top8")) scoreSum += 10;


        GameObject[] beard = GameObject.FindGameObjectsWithTag("acc-beard"); //수염없으면0점
        if(beard.Length==0) scoreSum = 0;
        
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


        if (img.activeSelf == false) { //착용한 상태가 아니라면
            var category = GameObject.FindGameObjectsWithTag(tagg);
            for (int i = 0; i < category.Length; i++) 
            {
                category[i].gameObject.SetActive(false); // 같은 카테고리 옷 중복 활성화 방지
            }

            img.SetActive(true); //사용자가 클릭한 옷 그림 활성화
        }
        else //이미 착용한 상태에서 한 번 더 클릭한거면
        {
            img.SetActive(false); //해당 옷 비활성화
        }

        if (set.gameObject.activeSelf == true)
        { //상의가 세트인경우 하의, 머리 비활성화
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
        
        string[] tagg = { "acc-beard","hair", "top", "bottom", "acc", "acc-eyewear", "shoes" };
        foreach (string e in tagg) {
            var category = GameObject.FindGameObjectsWithTag(e);
                if (category.Length != 0) category[0].gameObject.SetActive(false);
        }
    }
}

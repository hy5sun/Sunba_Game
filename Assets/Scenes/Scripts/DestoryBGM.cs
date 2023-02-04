using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestoryBGM : MonoBehaviour
{
    public static DestoryBGM Instance;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            Debug.Log("ºÎ¼û");
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "main_clothes")
            Destroy(gameObject);
    }
}

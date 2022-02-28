using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageNameText : MonoBehaviour
{
    private GameObject resultManager;
    void Start()
    {
        resultManager = GameObject.Find("ResultManager");
        if (SceneManager.GetActiveScene().name == "Result")
        {
            gameObject.GetComponent<Text>().text = "冒険からの帰還\n" + resultManager.GetComponent<ResultSceneManager>().stageName;
        }
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            gameObject.GetComponent<Text>().text = "敗走した・・・\n" + resultManager.GetComponent<ResultSceneManager>().stageName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

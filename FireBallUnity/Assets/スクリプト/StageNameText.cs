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
            gameObject.GetComponent<Text>().text = "�`������̋A��\n" + resultManager.GetComponent<ResultSceneManager>().stageName;
        }
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            gameObject.GetComponent<Text>().text = "�s�������E�E�E\n" + resultManager.GetComponent<ResultSceneManager>().stageName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

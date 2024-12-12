using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearTimeText : MonoBehaviour
{
    private GameObject resultManager;
    // Start is called before the first frame update
    void Start()
    {

        resultManager = GameObject.Find("ResultManager");
        resultManager.GetComponent<ResultSceneManager>().a = false;
        if (SceneManager.GetActiveScene().name == "Result")
        {
            gameObject.GetComponent<Text>().text = "クリアタイム " + resultManager.GetComponent<ResultSceneManager>().time.ToString("F2") + "秒";
        }
        else if (SceneManager.GetActiveScene().name == "GameOver")
        {
            gameObject.GetComponent<Text>().text = "生存時間 " + resultManager.GetComponent<ResultSceneManager>().time.ToString("F2") + "秒";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

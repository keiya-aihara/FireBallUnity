using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KakutokuCoinText : MonoBehaviour
{
    private GameObject resultManager;
    // Start is called before the first frame update
    void Start()
    {
        resultManager = GameObject.Find("ResultManager");
        gameObject.GetComponent<Text>().text = "Šl“¾ƒRƒCƒ“ "+resultManager.GetComponent<ResultSceneManager>().kakutokuCoin.ToString("N0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

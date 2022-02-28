using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class KakutokuKyoukasekiText : MonoBehaviour
{
    private GameObject resultManager;
    private ResultSceneManager resultSceneManagerScript;
    void Start()
    {
        resultManager = GameObject.Find("ResultManager");
        resultSceneManagerScript = resultManager.GetComponent<ResultSceneManager>();
        gameObject.GetComponent<TextMeshProUGUI>().text = "älìæã≠âªêŒ  <sprite=0>" + resultSceneManagerScript.kakutokuKyoukasekiSyou.ToString("N0") + "  <sprite=2>" + resultSceneManagerScript.kakutokuKyoukasekiTyuu.ToString("N0") + "  <sprite=1>" + resultSceneManagerScript.kakutokuKyoukasekiDai.ToString("N0");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

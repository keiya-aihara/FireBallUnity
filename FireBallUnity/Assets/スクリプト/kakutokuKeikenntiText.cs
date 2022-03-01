using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kakutokuKeikenntiText : MonoBehaviour
{
    private GameObject resultManager;
    private ResultSceneManager resultSceneManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        resultManager = GameObject.Find("ResultManager");
        resultSceneManagerScript = resultManager.GetComponent<ResultSceneManager>();
        gameObject.GetComponent<Text>().text = "獲得経験値 " + resultSceneManagerScript.kakutokuKeikennti.ToString("N0") + "\nLV " + resultSceneManagerScript.boukennmaeLv.ToString() + " → LV" + GameObject.Find("DataBaseManager").GetComponent<EXPManager>().lv.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

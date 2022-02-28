using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KakutokuItemContent : MonoBehaviour
{
    private GameObject resultManager;
    private ResultSceneManager resultManagerScript;
    public GameObject kakutokuItemNameText;
    public int kakutokuItemSuu;
    void Start()
    {
        resultManager = GameObject.Find("ResultManager");
        resultManagerScript = resultManager.GetComponent<ResultSceneManager>();
        kakutokuItemSuu = resultManagerScript.kakutokuItemName.Count;
        for(int a = 0; a<=kakutokuItemSuu-1;a++)
        {
            kakutokuItemNameText.GetComponent<Text>().text = resultManagerScript.kakutokuItemName[a];
            Instantiate(kakutokuItemNameText, transform.position, transform.rotation, gameObject.transform);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

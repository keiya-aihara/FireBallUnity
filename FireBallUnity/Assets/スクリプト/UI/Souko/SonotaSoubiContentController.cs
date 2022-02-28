using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonotaSoubiContentController : MonoBehaviour
{
    private GameObject databaseManager;
    private SonotaDataBaseManager sonotaDateBaseManagerScript;
    private SonotaSoubiIcon soubiIcon;
    public GameObject sonotaWeponIcon;
    public int weponCount;
    void Start()
    {
        databaseManager = GameObject.Find("DataBaseManager");
        sonotaDateBaseManagerScript = databaseManager.GetComponent<SonotaDataBaseManager>();
        weponCount = sonotaDateBaseManagerScript.weponDataList.weponDatas.Count;
        for (int a = 0; a < weponCount; a++)
        {
            soubiIcon = sonotaDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon.GetComponent<SonotaSoubiIcon>();
            soubiIcon.number = sonotaDateBaseManagerScript.weponDataList.weponDatas[a].no;

            Instantiate(sonotaDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon, transform.position, transform.rotation, gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SonotaContentUpdata()
    {
        foreach (Transform n in gameObject.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
        weponCount = sonotaDateBaseManagerScript.weponDataList.weponDatas.Count;
        for (int a = 0; a < weponCount; a++)
        {
            soubiIcon = sonotaDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon.GetComponent<SonotaSoubiIcon>();
            soubiIcon.number = sonotaDateBaseManagerScript.weponDataList.weponDatas[a].no;

            Instantiate(sonotaDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon, transform.position, transform.rotation, gameObject.transform);
        }
    }
}

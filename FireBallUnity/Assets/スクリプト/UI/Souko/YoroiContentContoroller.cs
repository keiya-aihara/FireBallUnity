using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoroiContentContoroller : MonoBehaviour
{
    private GameObject databaseManager;
    private YoroiDataBaseManager yoroiDateBaseManagerScript;
    private YoroiSoubiIcon soubiIcon;
    public GameObject yoroiWeponIcon;
    public int weponCount;
    void Start()
    {
        databaseManager = GameObject.Find("DataBaseManager");
        yoroiDateBaseManagerScript = databaseManager.GetComponent<YoroiDataBaseManager>();
        weponCount = yoroiDateBaseManagerScript.weponDataList.weponDatas.Count;
        for (int a = 0; a < weponCount; a++)
        {
            soubiIcon = yoroiDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon.GetComponent<YoroiSoubiIcon>();
            soubiIcon.number = yoroiDateBaseManagerScript.weponDataList.weponDatas[a].no;

            Instantiate(yoroiDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon, transform.position, transform.rotation, gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void YoroiContentUpdata()
    {
        foreach (Transform n in gameObject.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
        weponCount = yoroiDateBaseManagerScript.weponDataList.weponDatas.Count;
        for (int a = 0; a < weponCount; a++)
        {
            soubiIcon = yoroiDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon.GetComponent<YoroiSoubiIcon>();
            soubiIcon.number = yoroiDateBaseManagerScript.weponDataList.weponDatas[a].no;

            Instantiate(yoroiDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon, transform.position, transform.rotation, gameObject.transform);
        }
    }
}

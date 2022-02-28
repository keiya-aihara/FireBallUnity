using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KinnkyoriWeponContentController : MonoBehaviour
{
    private GameObject databaseManager;
    private WeponDateBaseManager weponDateBaseManagerScript;
    private KinnkyoriWeponSoubiIcon soubiIcon;
    public GameObject kinnkyoriWeponIcon;
    public int weponCount;
    void Start()
    {
        databaseManager = GameObject.Find("DataBaseManager");
        weponDateBaseManagerScript = databaseManager.GetComponent<WeponDateBaseManager>();

        weponCount = weponDateBaseManagerScript.weponDataList.weponDatas.Count;
        for (int a = 0; a < weponCount; a++)
        {
            soubiIcon = weponDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon.GetComponent<KinnkyoriWeponSoubiIcon>();
            soubiIcon.number = weponDateBaseManagerScript.weponDataList.weponDatas[a].no;

            Instantiate(weponDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon, transform.position, transform.rotation, gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void kinnkyoriWeponContentUpdata()
    {
        foreach (Transform n in gameObject.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
        weponCount = weponDateBaseManagerScript.weponDataList.weponDatas.Count;
        for (int a = 0; a < weponCount; a++)
        {
            soubiIcon = weponDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon.GetComponent<KinnkyoriWeponSoubiIcon>();
            soubiIcon.number = weponDateBaseManagerScript.weponDataList.weponDatas[a].no;

            Instantiate(weponDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon, transform.position, transform.rotation, gameObject.transform);
        }
    }
}

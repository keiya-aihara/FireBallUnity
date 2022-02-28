using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnkyoriWeponContentContoroller : MonoBehaviour
{
    private GameObject databaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDateBaseManagerScript;
    private EnnkyoriWeponSoubiIcon soubiIcon;
    public GameObject EnnkyoriWeponIcon;
    public int weponCount;
    void Start()
    {
        databaseManager = GameObject.Find("DataBaseManager");
        ennkyoriWeponDateBaseManagerScript = databaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
        weponCount = ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas.Count;
        for (int a = 0; a < weponCount; a++)
        {
            soubiIcon = ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon.GetComponent<EnnkyoriWeponSoubiIcon>();
            soubiIcon.number = ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas[a].no;

            Instantiate(ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon, transform.position, transform.rotation, gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void EnnkyoriWeponContentUpdata()
    {
        foreach (Transform n in gameObject.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
        weponCount = ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas.Count;
        for (int a = 0; a < weponCount; a++)
        {
            soubiIcon = ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon.GetComponent<EnnkyoriWeponSoubiIcon>();
            soubiIcon.number = ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas[a].no;

            Instantiate(ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas[a].readoIcon, transform.position, transform.rotation, gameObject.transform);
        }
    }
}

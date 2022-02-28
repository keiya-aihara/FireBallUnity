using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoubityuuIcon : MonoBehaviour
{
    private GameObject dataBaseManager;
    private PlayerStatusDataBase playerStatusDataBase;
    private WeponDateBaseManager weponDateBaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    private YoroiDataBaseManager yoroiDataBaseManager;
    private SonotaDataBaseManager sonotaDataBaseManager1;
    private SonotaDataBaseManager sonotaDataBaseManager2;

    private KinnkyoriWeponSoubiIcon kinnkyoriWeponSoubiIcon;
    private EnnkyoriWeponSoubiIcon ennkyoriWeponSoubiIcon;
    private YoroiSoubiIcon yoroiSoubiIcon;
    private SonotaSoubiIcon sonotaSoubiIcon1;
    private SonotaSoubiIcon sonotaSoubiIcon2;

    private GameObject kinnkyoriWeponReadoIcon;
    private GameObject ennkyoriWeponReadoIcon;
    private GameObject yoroiReadoIcon;
    private GameObject sonotaReadoIcon1;
    private GameObject sonotaReadoIcon2;

    public StatusText[] statusTexts;


    void Start()
    {
        dataBaseManager = GameObject.Find("DataBaseManager");
        playerStatusDataBase = dataBaseManager.GetComponent<PlayerStatusDataBase>();

        weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
        ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
        yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
        sonotaDataBaseManager1 = dataBaseManager.GetComponent<SonotaDataBaseManager>();
        sonotaDataBaseManager2 = dataBaseManager.GetComponent<SonotaDataBaseManager>();

        kinnkyoriWeponSoubiIcon = weponDateBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.kinnkyoriWeponNo).readoIcon.GetComponent<KinnkyoriWeponSoubiIcon>();
        ennkyoriWeponSoubiIcon = ennkyoriWeponDataBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.ennkyoriWeponNo).readoIcon.GetComponent<EnnkyoriWeponSoubiIcon>();
        yoroiSoubiIcon = yoroiDataBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.yoroiNo).readoIcon.GetComponent<YoroiSoubiIcon>();
        sonotaSoubiIcon1 = sonotaDataBaseManager1.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.sonota1No).readoIcon.GetComponent<SonotaSoubiIcon>();
        sonotaSoubiIcon2 = sonotaDataBaseManager2.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.sonota2No).readoIcon.GetComponent<SonotaSoubiIcon>();

        SoubiHennkou();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoubiHennkou()
    {
        foreach(Transform child in this.transform)
        {
            Destroy(child.gameObject);
        }
        playerStatusDataBase.StatusUpdate();
        kinnkyoriWeponReadoIcon = weponDateBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.kinnkyoriWeponNo).readoIcon;
        ennkyoriWeponReadoIcon = ennkyoriWeponDataBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.ennkyoriWeponNo).readoIcon;
        yoroiReadoIcon = yoroiDataBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.yoroiNo).readoIcon;
        sonotaReadoIcon1 = sonotaDataBaseManager1.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.sonota1No).readoIcon;
        sonotaReadoIcon2 = sonotaDataBaseManager2.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.sonota2No).readoIcon;

        kinnkyoriWeponSoubiIcon.number = weponDateBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.kinnkyoriWeponNo).no;
        Instantiate(kinnkyoriWeponReadoIcon, transform.position, transform.rotation, gameObject.transform);
        ennkyoriWeponSoubiIcon.number = ennkyoriWeponDataBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.ennkyoriWeponNo).no;
        Instantiate(ennkyoriWeponReadoIcon, transform.position, transform.rotation, gameObject.transform);
        yoroiSoubiIcon.number = yoroiDataBaseManager.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.yoroiNo).no;
        Instantiate(yoroiReadoIcon, transform.position, transform.rotation, gameObject.transform);
        sonotaSoubiIcon1.number = sonotaDataBaseManager1.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.sonota1No).no;
        Instantiate(sonotaReadoIcon1, transform.position, transform.rotation, gameObject.transform);
        sonotaSoubiIcon2.number = sonotaDataBaseManager2.weponDataList.weponDatas.Find((x) => x.no == playerStatusDataBase.sonota2No).no;
        Instantiate(sonotaReadoIcon2, transform.position, transform.rotation, gameObject.transform);
    }
    public void StatusTextUpdata()
    {
        foreach (var a in statusTexts)
        {
            a.StatusPanelUpdata();
        }
    }
}

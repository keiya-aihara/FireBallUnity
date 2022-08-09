using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonotaSoubiIcon : MonoBehaviour
{
    private GameObject databaseManager;
    private SonotaDataBaseManager sonotaDateBaseManagerScript;
    public int number;
    private GameObject scrollViewKinnKyoriWeponStatus;
    private GameObject scrollViewEnnkyoriWeponStatus;
    private GameObject scrollViewYoroiStatus;
    private GameObject scrollViewSonotaStatus1;
    private GameObject scrollViewSonotaStatus2;
    private GameObject scrollViewSoubiItirann;
    private GameObject[] gameObjectList;

    public GameObject reaCircle;
    public GameObject superReaCircle;
    public GameObject epikReaCircle;

    public GameObject lockKey;
    private Transform lockKeyDelete;

    public GameObject giftLv;

    private PlayerStatusDataBase playerStatusDataBase;
    private SoubityuuIcon soubityuuIcon;
    private GameObject contentSelectSoubi;

    private StatusPanelVector statusPanelVector;

    public GameObject tyekku;
    public GameObject soubityuuTyekku;
    public GameObject soubityuuTyekk2;


    public bool a;
    private bool c1;
    private bool c2;
    void Start()
    {
        databaseManager = GameObject.Find("DataBaseManager");
        sonotaDateBaseManagerScript = databaseManager.GetComponent<SonotaDataBaseManager>();
        playerStatusDataBase = databaseManager.GetComponent<PlayerStatusDataBase>();

        if (SceneManager.GetActiveScene().name == "StatusMenu")
        {
            contentSelectSoubi = GameObject.Find("Content Select Soubi　ステータス");
            soubityuuIcon = contentSelectSoubi.GetComponent<SoubityuuIcon>();
        }
        else
        {
            contentSelectSoubi = GameObject.Find("Content Select Soubi　装備強化・売却");
        }

        Instantiate(sonotaDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).soubiIcon, transform.position, transform.rotation, gameObject.transform);

        if (sonotaDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouRea)
        {
            Instantiate(reaCircle, gameObject.transform.position, transform.rotation, gameObject.transform);
        }
        if (sonotaDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouSuperRea)
        {
            Instantiate(superReaCircle, gameObject.transform.position, transform.rotation, gameObject.transform);
        }
        if (sonotaDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouEpikRea)
        {
            Instantiate(epikReaCircle, gameObject.transform.position, transform.rotation, gameObject.transform);
        }

        if (sonotaDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).bairitu != 0)
        {
            giftLv.GetComponent<GiftLv>().giftLv = sonotaDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).bairitu;
            Instantiate(giftLv, transform.position, transform.rotation, gameObject.transform);
        }

        if (transform.parent.gameObject.name == "Content Select Soubi　ステータス")
        {
            gameObjectList = Resources.FindObjectsOfTypeAll<GameObject>();
            foreach (var a in gameObjectList)
            {
                if (a.name == "Scroll View 近距離武器 ステータス")
                {
                    scrollViewKinnKyoriWeponStatus = a;
                }
                else if (a.name == "Scroll View 遠距離武器 ステータス")
                {
                    scrollViewEnnkyoriWeponStatus = a;
                }
                else if (a.name == "Scroll View 鎧装備 ステータス")
                {
                    scrollViewYoroiStatus = a;
                }
                else if (a.name == "Scroll View その他装備 ステータス1")
                {
                    scrollViewSonotaStatus1 = a;
                }
                else if (a.name == "Scroll View その他装備 ステータス2")
                {
                    scrollViewSonotaStatus2 = a;
                }
                else if (a.name == "装備一覧 Scroll View")
                {
                    scrollViewSoubiItirann = a;
                }
            }
        }

        if (SceneManager.GetActiveScene().name == "Souko")
        {
            if (playerStatusDataBase.sonota1No == number)
            {
                Instantiate(soubityuuTyekku, transform.position, transform.rotation, gameObject.transform);
            }
            else if (playerStatusDataBase.sonota2No == number)
            {
                Instantiate(soubityuuTyekk2, transform.position, transform.rotation, gameObject.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (sonotaDateBaseManagerScript.GetWeponData(number).keyLock)
        {
            if (!transform.Find("ロック(Clone)"))
            {
                Instantiate(lockKey, transform.position, transform.rotation, gameObject.transform);
            }
        }
        if (!sonotaDateBaseManagerScript.GetWeponData(number).keyLock)
        {
            if (transform.Find("ロック(Clone)"))
            {
                lockKeyDelete = transform.Find("ロック(Clone)");
                Destroy(lockKeyDelete.gameObject);
            }
        }

            if (transform.parent.gameObject.name == "Content その他装備 ステータス 1")
            {
                if (playerStatusDataBase.sonota1No == number)
                {
                    if (!transform.Find("装備中チェック(Clone)"))
                    {
                        Instantiate(soubityuuTyekku, transform.position, transform.rotation, gameObject.transform);
                    }
                }
                else
                {
                    if (transform.Find("装備中チェック(Clone)"))
                    {
                        Destroy(GameObject.Find("装備中チェック(Clone)"));
                    }
                }
                if (playerStatusDataBase.sonota2No == number)
                {
                    if (!transform.Find("装備中チェック2(Clone)"))
                    {
                        Instantiate(soubityuuTyekk2, transform.position, transform.rotation, gameObject.transform);

                    }
                }
                else
                {
                    if (transform.Find("装備中チェック2(Clone)"))
                    {
                        Destroy(GameObject.Find("装備中チェック2(Clone)"));
                    }
                }
            }

            else if (transform.parent.gameObject.name == "Content その他装備 ステータス2")
            {
                if (playerStatusDataBase.sonota1No == number)
                {
                    if (!transform.Find("装備中チェック(Clone)"))
                    {
                        Instantiate(soubityuuTyekku, transform.position, transform.rotation, gameObject.transform);

                    }
                }
                else
                {
                    if (transform.Find("装備中チェック(Clone)"))
                    {
                        Destroy(GameObject.Find("装備中チェック(Clone)"));
                    }
                }
                if (playerStatusDataBase.sonota2No == number)
                {
                    if (!transform.Find("装備中チェック2(Clone)"))
                    {
                        Instantiate(soubityuuTyekk2, transform.position, transform.rotation, gameObject.transform);

                    }
                }
                else
                {
                    if (transform.Find("装備中チェック2(Clone)"))
                    {
                        Destroy(GameObject.Find("装備中チェック2(Clone)"));
                    }
                }
            }
        
    }
    public void selectSonotaSoubi()
    {
        if (SceneManager.GetActiveScene().name == "Souko")
        {
            if (GameObject.Find("売却キャンセルBotton"))
            {
                if (!gameObject.transform.Find("ロック(Clone)"))
                {
                    if (gameObject.transform.Find("選択中✔(Clone)"))
                    {
                        Destroy(gameObject.transform.Find("選択中✔(Clone)").gameObject);
                    }
                    else
                    {
                        if (number != playerStatusDataBase.sonota1No&&number!=playerStatusDataBase.sonota2No)
                        {
                            Instantiate(tyekku, transform.position, transform.rotation, gameObject.transform);
                        }
                    }
                }
            }
            else
            {
                gameObject.GetComponent<SoubiIconNagaosi>().SoukoStatusPanel();
                statusPanelVector = GameObject.Find("Scroll View 装備ステータス ステータス2").GetComponent<StatusPanelVector>();
                statusPanelVector.number = number;
                statusPanelVector.kinnkyoriWepon = false;
                statusPanelVector.ennkyoriWepon = false;
                statusPanelVector.yoroi = false;
                statusPanelVector.sonota = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "StatusMenu")
        {
            if (transform.parent.gameObject.name == "Content Select Soubi　ステータス")
            {
                if (number == playerStatusDataBase.sonota1No)
                {
                    scrollViewKinnKyoriWeponStatus.gameObject.SetActive(false);
                    scrollViewEnnkyoriWeponStatus.gameObject.SetActive(false);
                    scrollViewYoroiStatus.gameObject.SetActive(false);
                    scrollViewSonotaStatus1.gameObject.SetActive(true);
                    scrollViewSonotaStatus2.gameObject.SetActive(false);
                    scrollViewSoubiItirann.gameObject.SetActive(true);
                }
                else if (number == playerStatusDataBase.sonota2No)
                {
                    scrollViewKinnKyoriWeponStatus.gameObject.SetActive(false);
                    scrollViewEnnkyoriWeponStatus.gameObject.SetActive(false);
                    scrollViewYoroiStatus.gameObject.SetActive(false);
                    scrollViewSonotaStatus1.gameObject.SetActive(false);
                    scrollViewSonotaStatus2.gameObject.SetActive(true);
                    scrollViewSoubiItirann.gameObject.SetActive(true);
                }

            }

            if (transform.parent.gameObject.name == "Content その他装備 ステータス 1")
            {
                    if(playerStatusDataBase.sonota2No!=number)
                    {
                        playerStatusDataBase.sonota1No = number;
                        soubityuuIcon.SoubiHennkou();
                        soubityuuIcon.StatusTextUpdata();
                    }
            }
            if (transform.parent.gameObject.name == "Content その他装備 ステータス2")
            {
                    if (playerStatusDataBase.sonota1No != number)
                    {
                        playerStatusDataBase.sonota2No = number;
                        soubityuuIcon.SoubiHennkou();
                        soubityuuIcon.StatusTextUpdata();
                    }
            }
        }
    }
}

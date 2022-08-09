using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnnkyoriWeponSoubiIcon : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject databaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDateBaseManagerScript;
    public int number;
    private GameObject[] gameObjectList;
    private GameObject scrollViewKinnKyoriWeponStatus;
    private GameObject scrollViewEnnkyoriWeponStatus;
    private GameObject scrollViewYoroiStatus;
    private GameObject scrollViewSonotaStatus1;
    private GameObject scrollViewSonotaStatus2;
    private GameObject scrollViewSoubiItirann;

    public GameObject lockKey;
    private Transform lockKeyDelete;

    public GameObject giftLv;

    public GameObject reaCircle;
    public GameObject superReaCircle;
    public GameObject epikReaCircle;

    private PlayerStatusDataBase playerStatusDataBase;
    private SoubityuuIcon soubityuuIcon;
    private GameObject contentSelectSoubi;

    private StatusPanelVector statusPanelVector;

    public GameObject tyekku;
    public GameObject soubityuuTyekku;

    public bool a;
    private bool c;
    void Start()
    {
        databaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        ennkyoriWeponDateBaseManagerScript = databaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
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

        Instantiate(ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).soubiIcon, transform.position, transform.rotation, gameObject.transform);

        if (ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouRea)
        {
            Instantiate(reaCircle, gameObject.transform.position, transform.rotation, gameObject.transform);
        }
        if (ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouSuperRea)
        {
            Instantiate(superReaCircle, gameObject.transform.position, transform.rotation, gameObject.transform);
        }
        if (ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouEpikRea)
        {
            Instantiate(epikReaCircle, gameObject.transform.position, transform.rotation, gameObject.transform);
        }

        if (ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).bairitu != 0)
        {
            giftLv.GetComponent<GiftLv>().giftLv = ennkyoriWeponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).bairitu;
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
        if (transform.parent.gameObject.name == "Content 遠距離武器 ステータス" || transform.parent.gameObject.name == "Content Select Soubi　装備強化・売却")
        {
            if (number == playerStatusDataBase.ennkyoriWeponNo)
            {
                soubiTyuu();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ennkyoriWeponDateBaseManagerScript.GetWeponData(number).keyLock)
        {
            if (!transform.Find("ロック(Clone)"))
            {
                Instantiate(lockKey, transform.position, transform.rotation, gameObject.transform);
            }
        }
        if (!ennkyoriWeponDateBaseManagerScript.GetWeponData(number).keyLock)
        {
            if (transform.Find("ロック(Clone)"))
            {
                lockKeyDelete = transform.Find("ロック(Clone)");
                Destroy(lockKeyDelete.gameObject);
            }
        }
    }
    public void selectEnnkyoriWepon()
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
                        if (number != playerStatusDataBase.ennkyoriWeponNo)
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
                statusPanelVector.ennkyoriWepon = true ;
                statusPanelVector.yoroi = false;
                statusPanelVector.sonota = false;
            }
        }
        if (SceneManager.GetActiveScene().name == "StatusMenu")
        {
            if (transform.parent.gameObject.name == "Content Select Soubi　ステータス")
            {
                scrollViewKinnKyoriWeponStatus.gameObject.SetActive(false);
                scrollViewEnnkyoriWeponStatus.gameObject.SetActive(true);
                scrollViewYoroiStatus.gameObject.SetActive(false);
                scrollViewSonotaStatus1.gameObject.SetActive(false);
                scrollViewSonotaStatus2.gameObject.SetActive(false);
                scrollViewSoubiItirann.gameObject.SetActive(true);
            }
            else if (transform.parent.gameObject.name == "Content 遠距離武器 ステータス")
            {
                    if (playerStatusDataBase.ennkyoriWeponNo != number)
                    {
                        c = false;
                    }
                    else
                    {
                        c = true;
                    }
                    playerStatusDataBase.ennkyoriWeponNo = number;
                    soubityuuIcon.SoubiHennkou();
                    soubityuuIcon.StatusTextUpdata();
                soubiTyuu();
            }
        }
    }
    public void soubiTyuu()
    {
        if (c == false)
        {
            if (GameObject.Find("装備中チェック(Clone)"))
            {
                Destroy(GameObject.Find("装備中チェック(Clone)"));
            }
        }
        if (playerStatusDataBase.ennkyoriWeponNo == number)
        {
            if (transform.Find("装備中チェック(Clone)"))
            {

            }
            else
            {
                Instantiate(soubityuuTyekku, transform.position, transform.rotation, gameObject.transform);
            }
        }
        c = false;
    }
}

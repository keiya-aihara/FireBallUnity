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

    public bool a;
    void Start()
    {
        databaseManager = GameObject.Find("DataBaseManager");
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
                if (a.name == "Scroll View 遠距離武器 ステータス")
                {
                    scrollViewEnnkyoriWeponStatus = a;
                }
                if (a.name == "Scroll View 鎧装備 ステータス")
                {
                    scrollViewYoroiStatus = a;
                }
                if (a.name == "Scroll View その他装備 ステータス1")
                {
                    scrollViewSonotaStatus1 = a;
                }
                if (a.name == "Scroll View その他装備 ステータス2")
                {
                    scrollViewSonotaStatus2 = a;
                }
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
                        Instantiate(tyekku, transform.position, transform.rotation, gameObject.transform);
                    }
                }
            }
            else
            {
                gameObject.GetComponent<SoubiIconNagaosi>().SoukoStatusPanel();
                statusPanelVector = GameObject.Find("Scroll View 装備ステータス ステータス2(Clone)").GetComponent<StatusPanelVector>();
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
            }
            if (transform.parent.gameObject.name == "Content 遠距離武器 ステータス")
            {
                if (a)
                {
                    playerStatusDataBase.ennkyoriWeponNo = number;
                    soubityuuIcon.SoubiHennkou();
                    soubityuuIcon.StatusTextUpdata();
                }
            }
        }
    }
}

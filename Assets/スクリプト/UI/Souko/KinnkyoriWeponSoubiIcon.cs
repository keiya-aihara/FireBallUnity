using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KinnkyoriWeponSoubiIcon : MonoBehaviour
{
    private GameObject databaseManager;
    private WeponDateBaseManager weponDateBaseManagerScript;
    private PlayerStatusDataBase playerStatusDataBase;
    private SoubityuuIcon soubityuuIcon;
    private GameObject contentSelectSoubi;
    private GameObject[] gameObjectList;

    private GameObject scrollViewKinnKyoriWeponStatus;
    private GameObject scrollViewEnnkyoriWeponStatus;
    private GameObject scrollViewYoroiStatus;
    private GameObject scrollViewSonotaStatus1;
    private GameObject scrollViewSonotaStatus2;
    private GameObject scrollViewSoubiItirann;

    private GameObject sortBoton;

    public GameObject lockKey;
    private Transform lockKeyDelete;

    public GiftLv giftLv;
    public KyoukaLv kyoukaLv;
    public GameObject zyukurenndo;

    private KyoukaLv kyoukaLvUpdate;

    private StatusPanelVector statusPanelVector;

    public int number;
    public bool a;
    public bool b;
    private bool c;

    public GameObject reaCircle;
    public GameObject superReaCircle;
    public GameObject epikReaCircle;

    public GameObject tyekku;
    public GameObject soubityuuTyekku;
    // Start is called before the first frame update
    void Start()
    {
        databaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        weponDateBaseManagerScript = databaseManager.GetComponent<WeponDateBaseManager>();
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

        Instantiate(weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).soubiIcon, transform.position, transform.rotation, gameObject.transform);

        if(weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouRea)
        {
            Instantiate(reaCircle, gameObject.transform.position, transform.rotation, gameObject.transform) ;
        }
        else if (weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouSuperRea)
        {
            Instantiate(superReaCircle, gameObject.transform.position, transform.rotation, gameObject.transform);
        }
        else if (weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).syougouEpikRea)
        {
            Instantiate(epikReaCircle, gameObject.transform.position, transform.rotation, gameObject.transform);
        }

        if (weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).bairitu != 0)
        {
            giftLv.giftLv = weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).bairitu;
            Instantiate(giftLv, transform.position, transform.rotation, gameObject.transform);
        }
        if (weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).kyoukaLv != 0)
        {
            kyoukaLv.kyoukaLv = weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).kyoukaLv;
            Instantiate(kyoukaLv, transform.position, transform.rotation, gameObject.transform);
            kyoukaLvUpdate = transform.Find("強化LV(Clone)").GetComponent<KyoukaLv>();
        }
        if (weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).zyukurenndo >= 10000)
        {
            Instantiate(zyukurenndo, transform.position, transform.rotation, gameObject.transform);
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
        else if (transform.parent.gameObject.name == "Content 近距離武器　ステータス" || transform.parent.gameObject.name == "Content Select Soubi　装備強化・売却")
        {
            if (number == playerStatusDataBase.kinnkyoriWeponNo)
            {
                soubiTyuu();
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(weponDateBaseManagerScript.GetWeponData(number).keyLock)
        {
            if (!transform.Find("ロック(Clone)"))
            {
                Instantiate(lockKey, transform.position, transform.rotation, gameObject.transform);
            }
        }
        else if (!weponDateBaseManagerScript.GetWeponData(number).keyLock)
        {
            if (transform.Find("ロック(Clone)"))
            {
                lockKeyDelete = transform.Find("ロック(Clone)");
                Destroy(lockKeyDelete.gameObject);
            }
        }
        if (weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).kyoukaLv != 0)
        {
            if (!gameObject.transform.Find("強化LV(Clone)"))
            {
                Instantiate(kyoukaLv, transform.position, transform.rotation, gameObject.transform);
                kyoukaLvUpdate = transform.Find("強化LV(Clone)").GetComponent<KyoukaLv>();
            }
            kyoukaLvUpdate.kyoukaLv = weponDateBaseManagerScript.weponDataList.weponDatas.Find((x) => x.no == number).kyoukaLv;

        }
    }
    public void selectKinnkyoriWepon()
    {
        HaiSEPlay();
        if(SceneManager.GetActiveScene().name=="Souko")
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
                        if (number != playerStatusDataBase.kinnkyoriWeponNo)
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
                statusPanelVector.kinnkyoriWepon = true;
                statusPanelVector.ennkyoriWepon = false;
                statusPanelVector.yoroi = false;
                statusPanelVector.sonota = false;
            }
        }
        else if (SceneManager.GetActiveScene().name == "StatusMenu")
        {
            if (transform.parent.gameObject.name == "Content Select Soubi　ステータス")
            {
                scrollViewKinnKyoriWeponStatus.gameObject.SetActive(true);

                scrollViewEnnkyoriWeponStatus.gameObject.SetActive(false);
                scrollViewYoroiStatus.gameObject.SetActive(false);
                scrollViewSonotaStatus1.gameObject.SetActive(false);
                scrollViewSonotaStatus2.gameObject.SetActive(false);
                scrollViewSoubiItirann.gameObject.SetActive(true);
            }
            else if (transform.parent.gameObject.name == "Content 近距離武器　ステータス")
            {
                if (playerStatusDataBase.kinnkyoriWeponNo != number)
                {
                    c = false;
                }
                else
                {
                    c = true;
                }
                playerStatusDataBase.kinnkyoriWeponNo = number;
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
        if (playerStatusDataBase.kinnkyoriWeponNo == number)
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
    public void HaiSEPlay()
    {
        GameObject.Find("SE").GetComponent<HaiIieButtonSE>().HaiButtonSE();
    }
}

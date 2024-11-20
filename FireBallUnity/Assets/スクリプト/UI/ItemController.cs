using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ItemController : MonoBehaviour
{
    private GameObject player;

    public GameObject dataBaseManager;
    private WeponDateBaseManager weponDateBaseMangerScript;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManagerScript;
    private YoroiDataBaseManager yoroiDataBaseManagerScript;
    private SonotaDataBaseManager sonotaDataBaseManagerScript;
    private KakutokuDataBase kakutokuDataBase;
    private GameObject[] syougous;
    private GameObject[] gifts;
    private GameObject[] dropSoubis;

    private GameObject resultSceneManager;
    private ResultSceneManager resultSceneManagerScript;
    private SystemDatabase systemDatabase;

    private SyougouBase syougouBase;
    private Gift giftBase;
    public int giftHuyoritu = -19;

    private float syougouBairitu;
    private float giftBairitu;

    private float saisyuubairitu;

    public bool syougouBool;
    
    private Vector2 playerPosition;
    private Vector2 itemPosition;

    public float nomalSyougouDorp = 5f;
    public float reaSyougouDorp = 1f;
    public float superReaSyougouDorp = 0.5f;

    public string status;

    private int syokiBaikyakuti;
    private float baikyakuBairitu;

    public float kakuninnTime;

    private bool a;
    public bool b;
    private bool zidouBaikyaku;


    private GameObject gameManager;

    public WeponDataList.WeponData itemStatus = new WeponDataList.WeponData();
    public int dropNumber;
    public int dropNumber2;

    private int syozisuu;

    private KousekiDataBaseManager kousekiDataBaseManager;

    public List<int> sonotasoubiStatus = new List<int>();
    private int sonotasoubiGiftStatusKakutei;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        kousekiDataBaseManager = dataBaseManager.GetComponent<KousekiDataBaseManager>();
        weponDateBaseMangerScript = dataBaseManager.GetComponent<WeponDateBaseManager>();
        ennkyoriWeponDataBaseManagerScript = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
        yoroiDataBaseManagerScript = dataBaseManager.GetComponent<YoroiDataBaseManager>();
        sonotaDataBaseManagerScript = dataBaseManager.GetComponent<SonotaDataBaseManager>();
        systemDatabase = dataBaseManager.GetComponent<SystemDatabase>();
        kakutokuDataBase = dataBaseManager.GetComponent<KakutokuDataBase>();

        resultSceneManagerScript = GameObject.Find("ResultManager").GetComponent<ResultSceneManager>();
        gameManager = GameObject.Find("GameManager");
        a = true;
        b = false;
        zidouBaikyaku = false;
    }
    // Update is called once per frame
    void Update()
    {
        kakuninnTime += Time.deltaTime;
        if (player.transform.position.y <= -2)
        {
            if (kakuninnTime >= 0.3f)
            {
                b = true;
                playerPosition = player.transform.position;
                itemPosition = transform.position;

                itemPosition.x += (playerPosition.x - itemPosition.x) * 0.04f;
                itemPosition.y += (playerPosition.y - itemPosition.y) * 0.04f;
                transform.position = itemPosition;

            }
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (a)
            {
                resultSceneManagerScript.getSoubi.Add(gameObject);
                gameObject.SetActive(false);
                a = false;
            }
        }
    }
    public void SoubiInventryIn()
    {
        kakutokuDataBase.kakutokuNo[itemStatus.no]+=1;
        if (itemStatus.kinnkyoriWepon)
        {
            syozisuu = weponDateBaseMangerScript.weponDataList.weponDatas.Count;
            itemStatus.no = weponDateBaseMangerScript.weponDataList.weponDatas[syozisuu - 1].no + 1;
            
            
            GiftDrop();
            SyougouDrop();

            itemStatus.maxHp = itemStatus.maxHp + Mathf.CeilToInt(itemStatus.maxHp * syougouBairitu);
            itemStatus.maxMp = itemStatus.maxMp + Mathf.CeilToInt(itemStatus.maxMp * syougouBairitu);
            itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.CeilToInt(itemStatus.kougekiryoku * (syougouBairitu + giftBairitu));
            itemStatus.maryoku = itemStatus.maryoku + Mathf.CeilToInt(itemStatus.maryoku * syougouBairitu);
            itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.CeilToInt(itemStatus.bougyoryoiku * syougouBairitu);
            itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * syougouBairitu;
            itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * syougouBairitu;

            itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + giftBairitu));

            itemStatus.kyoukagoMaxHp = itemStatus.maxHp;
            itemStatus.kyoukagoMaxMp = itemStatus.maxMp;
            itemStatus.kyoukagoKougekiryoku = itemStatus.kougekiryoku;
            itemStatus.kyoukagoMaryoku = itemStatus.maryoku;
            itemStatus.kyoukagoBougyoryoku = itemStatus.bougyoryoiku;
            itemStatus.kyoukagoMeityuuritu = itemStatus.meityuuritu;
            itemStatus.kyoukagoKaihiritu = itemStatus.kaihiritu;

            if (giftBairitu > 0)
            {
                giftBairitu *= 100;
                itemStatus.giftName = "〈攻撃力+" + giftBairitu + "%〉";
                itemStatus.giftBairituName = "〈攻撃力+" + giftBairitu + "%〉";
            }
            KousekiAdd();//功績に追加

            if (itemStatus.nomal)//自動売却
            {
                if (systemDatabase.nomalSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.nomalSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if(systemDatabase.nomalMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }
            else if (itemStatus.rea)//自動売却
            {
                if (systemDatabase.reaSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.reaSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.reaMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }
            else if (itemStatus.superRea)//自動売却
            {
                if (systemDatabase.superReaSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.superReaSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.superReaMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }

            if (zidouBaikyaku)//自動売却時のアイテムネーム売却済み
            {
                resultSceneManagerScript.kakutokuItemName.Add("売却金額 "+itemStatus.baikyakuKinngaku.ToString("N0")+" で売却済み");
            }
            else
            {
                weponDateBaseMangerScript.weponDataList.weponDatas.Add(itemStatus);
                resultSceneManagerScript.kakutokuItemName.Add(itemStatus.syougouName + itemStatus.name + itemStatus.giftName);
            }
        }
        else if (itemStatus.ennkyoriWepon)
        {
            syozisuu = ennkyoriWeponDataBaseManagerScript.weponDataList.weponDatas.Count;
            itemStatus.no = ennkyoriWeponDataBaseManagerScript.weponDataList.weponDatas[syozisuu - 1].no + 1;

            GiftDrop();
            SyougouDrop();

            itemStatus.maxHp = itemStatus.maxHp + Mathf.CeilToInt(itemStatus.maxHp * syougouBairitu);
            itemStatus.maxMp = itemStatus.maxMp + Mathf.CeilToInt(itemStatus.maxMp * syougouBairitu);
            itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.CeilToInt(itemStatus.kougekiryoku * syougouBairitu);
            itemStatus.maryoku = itemStatus.maryoku + Mathf.CeilToInt(itemStatus.maryoku * (syougouBairitu + giftBairitu));
            itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.CeilToInt(itemStatus.bougyoryoiku * syougouBairitu);
            itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * syougouBairitu;
            itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * syougouBairitu;

            itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + giftBairitu));

            itemStatus.kyoukagoMaxHp = itemStatus.maxHp;
            itemStatus.kyoukagoMaxMp = itemStatus.maxMp;
            itemStatus.kyoukagoKougekiryoku = itemStatus.kougekiryoku;
            itemStatus.kyoukagoMaryoku = itemStatus.maryoku;
            itemStatus.kyoukagoBougyoryoku = itemStatus.bougyoryoiku;
            itemStatus.kyoukagoMeityuuritu = itemStatus.meityuuritu;
            itemStatus.kyoukagoKaihiritu = itemStatus.kaihiritu;

            if (giftBairitu > 0)
            {
                giftBairitu *= 100;
                itemStatus.giftName = "〈魔力+" + giftBairitu + "%〉";
                itemStatus.giftBairituName = "〈魔力+" + giftBairitu + "%〉";
            }
            KousekiAdd();

            if (itemStatus.nomal)//自動売却
            {
                if (systemDatabase.nomalSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.nomalSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.nomalMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }
            else if (itemStatus.rea)//自動売却
            {
                if (systemDatabase.reaSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.reaSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.reaMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }
            else if (itemStatus.superRea)//自動売却
            {
                if (systemDatabase.superReaSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.superReaSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.superReaMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }

            if (zidouBaikyaku)//自動売却時のアイテムネーム売却済み
            {
                resultSceneManagerScript.kakutokuItemName.Add("売却金額 " + itemStatus.baikyakuKinngaku.ToString("N0") + " で売却済み");
            }
            else
            {
                ennkyoriWeponDataBaseManagerScript.weponDataList.weponDatas.Add(itemStatus);
                resultSceneManagerScript.kakutokuItemName.Add(itemStatus.syougouName + itemStatus.name + itemStatus.giftName);
            }
        }
        else if (itemStatus.yoroi)
        {
            syozisuu = yoroiDataBaseManagerScript.weponDataList.weponDatas.Count;
            itemStatus.no = yoroiDataBaseManagerScript.weponDataList.weponDatas[syozisuu - 1].no + 1;

            GiftDrop();
            SyougouDrop();

            itemStatus.maxHp = itemStatus.maxHp + Mathf.CeilToInt(itemStatus.maxHp * syougouBairitu);
            itemStatus.maxMp = itemStatus.maxMp + Mathf.CeilToInt(itemStatus.maxMp * syougouBairitu);
            itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.CeilToInt(itemStatus.kougekiryoku * syougouBairitu);
            itemStatus.maryoku = itemStatus.maryoku + Mathf.CeilToInt(itemStatus.maryoku * syougouBairitu);
            itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.CeilToInt(itemStatus.bougyoryoiku * (syougouBairitu + giftBairitu));
            itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * syougouBairitu;
            itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * syougouBairitu;

            itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + giftBairitu));

            itemStatus.kyoukagoMaxHp = itemStatus.maxHp;
            itemStatus.kyoukagoMaxMp = itemStatus.maxMp;
            itemStatus.kyoukagoKougekiryoku = itemStatus.kougekiryoku;
            itemStatus.kyoukagoMaryoku = itemStatus.maryoku;
            itemStatus.kyoukagoBougyoryoku = itemStatus.bougyoryoiku;
            itemStatus.kyoukagoMeityuuritu = itemStatus.meityuuritu;
            itemStatus.kyoukagoKaihiritu = itemStatus.kaihiritu;

            if (giftBairitu > 0)
            {
                giftBairitu *= 100;
                itemStatus.giftName = "〈防御力+" + giftBairitu + "%〉";
                itemStatus.giftBairituName = "〈防御力+" + giftBairitu + "%〉";
            }
            KousekiAdd();

            if (itemStatus.nomal)//自動売却
            {
                if (systemDatabase.nomalSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.nomalSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.nomalMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }
            else if (itemStatus.rea)//自動売却
            {
                if (systemDatabase.reaSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.reaSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.reaMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }
            else if (itemStatus.superRea)//自動売却
            {
                if (systemDatabase.superReaSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.superReaSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.superReaMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }

            if (zidouBaikyaku)//自動売却時のアイテムネーム売却済み
            {
                resultSceneManagerScript.kakutokuItemName.Add("売却金額 " + itemStatus.baikyakuKinngaku.ToString("N0") + " で売却済み");
            }
            else
            {
                yoroiDataBaseManagerScript.weponDataList.weponDatas.Add(itemStatus);
                resultSceneManagerScript.kakutokuItemName.Add(itemStatus.syougouName + itemStatus.name + itemStatus.giftName);
            }
        }
        else if (itemStatus.sonota)
        {
            syozisuu = sonotaDataBaseManagerScript.weponDataList.weponDatas.Count;
            itemStatus.no = sonotaDataBaseManagerScript.weponDataList.weponDatas[syozisuu - 1].no + 1;
            syokiBaikyakuti = itemStatus.baikyakuKinngaku;

            GiftDrop();
            SyougouDrop();

            sonotasoubiStatus.Clear();
            if (itemStatus.maxHp != 0)
            {
                sonotasoubiStatus.Add(0);
            }
            if(itemStatus.maxMp!=0)
            {
                sonotasoubiStatus.Add(1);
            }
            if (itemStatus.kougekiryoku != 0)
            {
                sonotasoubiStatus.Add(2);
            }
            if (itemStatus.maryoku != 0)
            {
                sonotasoubiStatus.Add(3);
            }
            if (itemStatus.bougyoryoiku != 0)
            {
                sonotasoubiStatus.Add(4);
            }
            if (itemStatus.meityuuritu != 0)
            {
                sonotasoubiStatus.Add(5);
            }
            if (itemStatus.kaihiritu != 0)
            {
                sonotasoubiStatus.Add(6);
            }

            Debug.Log(string.Join(",", sonotasoubiStatus));

            int giftHuyoStatus = sonotasoubiStatus[ Random.Range(0, sonotasoubiStatus.Count)];
            
            if (giftHuyoStatus == 0)
            {
                itemStatus.maxHp = itemStatus.maxHp + Mathf.CeilToInt(itemStatus.maxHp * (syougouBairitu + giftBairitu));
                itemStatus.sonotaKyoukaStatus = 0;
                baikyakuBairitu = giftBairitu;

                if (itemStatus.maxHp != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "〈HP+" + giftBairitu + "%〉";
                        itemStatus.giftBairituName = "〈HP+" + giftBairitu + "%〉";
                    }
                    else
                    {
                        giftBairitu = 0;
                        itemStatus.bairitu = 0;
                        baikyakuBairitu = giftBairitu;
                    }
                }
                else
                {
                    giftBairitu = 0;
                    itemStatus.bairitu = 0;
                    baikyakuBairitu = giftBairitu;
                }
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.maxHp = itemStatus.maxHp + Mathf.CeilToInt(itemStatus.maxHp * syougouBairitu);
            }

            if (giftHuyoStatus == 1)
            {
                itemStatus.maxMp = itemStatus.maxMp + Mathf.CeilToInt(itemStatus.maxMp * (syougouBairitu + giftBairitu));
                itemStatus.sonotaKyoukaStatus = 1;
                baikyakuBairitu = giftBairitu;
                if (itemStatus.maxMp != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "〈MP+" + giftBairitu + "%〉";
                        itemStatus.giftBairituName = "〈MP+" + giftBairitu + "%〉";
                    }
                    else
                    {
                        giftBairitu = 0;
                        itemStatus.bairitu = 0;
                        baikyakuBairitu = giftBairitu;
                    }
                }
                else
                {
                    giftBairitu = 0;
                    itemStatus.bairitu = 0;
                    baikyakuBairitu = giftBairitu;
                }
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.maxMp = itemStatus.maxMp + Mathf.CeilToInt(itemStatus.maxMp * syougouBairitu);
            }

            if (giftHuyoStatus == 2)
            {
                baikyakuBairitu = giftBairitu;
                itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.CeilToInt(itemStatus.kougekiryoku * (syougouBairitu + giftBairitu));
                itemStatus.sonotaKyoukaStatus = 2;
                if (itemStatus.kougekiryoku != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "〈攻撃力+" + giftBairitu + "%〉";
                        itemStatus.giftBairituName = "〈攻撃力+" + giftBairitu + "%〉";
                    }
                    else
                    {
                        giftBairitu = 0;
                        itemStatus.bairitu = 0;
                        baikyakuBairitu = giftBairitu;
                    }
                }
                else
                {
                    giftBairitu = 0;
                    itemStatus.bairitu = 0;
                    baikyakuBairitu = giftBairitu;
                }
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.CeilToInt(itemStatus.kougekiryoku * syougouBairitu);
            }

            if (giftHuyoStatus == 3)
            {
                itemStatus.sonotaKyoukaStatus = 3;
                baikyakuBairitu = giftBairitu;
                itemStatus.maryoku = itemStatus.maryoku + Mathf.CeilToInt(itemStatus.maryoku * (syougouBairitu + giftBairitu));
                if (itemStatus.maryoku != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "〈魔力+" + giftBairitu + "%〉";
                        itemStatus.giftBairituName = "〈魔力+" + giftBairitu + "%〉";
                    }
                    else
                    {
                        giftBairitu = 0;
                        itemStatus.bairitu = 0;
                        baikyakuBairitu = giftBairitu;
                    }
                }
                else
                {
                    giftBairitu = 0;
                    itemStatus.bairitu = 0;
                    baikyakuBairitu = giftBairitu;
                }
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.maryoku = itemStatus.maryoku + Mathf.CeilToInt(itemStatus.maryoku * syougouBairitu);
            }

            if (giftHuyoStatus == 4)
            {
                itemStatus.sonotaKyoukaStatus = 4;
                baikyakuBairitu = giftBairitu;
                itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.CeilToInt(itemStatus.bougyoryoiku * (syougouBairitu + giftBairitu));
                if (itemStatus.syougouBougyoryoku != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "〈防御力+" + giftBairitu + "%〉";
                        itemStatus.giftBairituName = "〈防御力+" + giftBairitu + "%〉";
                    }
                    else
                    {
                        giftBairitu = 0;
                        itemStatus.bairitu = 0;
                        baikyakuBairitu = giftBairitu;
                    }
                }
                else
                {
                    giftBairitu = 0;
                    itemStatus.bairitu = 0;
                    baikyakuBairitu = giftBairitu;
                }
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.CeilToInt(itemStatus.bougyoryoiku * syougouBairitu);
            }

            if (giftHuyoStatus == 5)
            {
                itemStatus.sonotaKyoukaStatus = 5;
                baikyakuBairitu = giftBairitu;
                itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * (syougouBairitu + giftBairitu);

                if (itemStatus.meityuuritu != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "〈命中率+" + giftBairitu + "%〉";
                        itemStatus.giftBairituName = "〈命中率+" + giftBairitu + "%〉";
                    }
                    else
                    {
                        giftBairitu = 0;
                        itemStatus.bairitu = 0;
                        baikyakuBairitu = giftBairitu;
                    }
                }
                else
                {
                    giftBairitu = 0;
                    itemStatus.bairitu = 0;
                    baikyakuBairitu = giftBairitu;
                }
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * syougouBairitu;
            }

            if (giftHuyoStatus == 6)
            {
                itemStatus.sonotaKyoukaStatus = 6;
                baikyakuBairitu = giftBairitu;
                itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * (syougouBairitu + giftBairitu);

                if (itemStatus.kaihiritu != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "〈回避率+" + giftBairitu + "%〉";
                        itemStatus.giftBairituName = "〈回避率+" + giftBairitu + "%〉";
                    }
                    else
                    {
                        giftBairitu = 0;
                        itemStatus.bairitu = 0;
                        baikyakuBairitu = giftBairitu;
                    }
                }
                else
                {
                    giftBairitu = 0;
                    itemStatus.bairitu = 0;
                    baikyakuBairitu = giftBairitu;
                }
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.CeilToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * syougouBairitu;
            }
            itemStatus.kyoukagoMaxHp = itemStatus.maxHp;
            itemStatus.kyoukagoMaxMp = itemStatus.maxMp;
            itemStatus.kyoukagoKougekiryoku = itemStatus.kougekiryoku;
            itemStatus.kyoukagoMaryoku = itemStatus.maryoku;
            itemStatus.kyoukagoBougyoryoku = itemStatus.bougyoryoiku;
            itemStatus.kyoukagoMeityuuritu = itemStatus.meityuuritu;
            itemStatus.kyoukagoKaihiritu = itemStatus.kaihiritu;
            KousekiAdd();

            if (itemStatus.nomal)//自動売却
            {
                if (systemDatabase.nomalSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.nomalSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.nomalMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }
            else if (itemStatus.rea)//自動売却
            {
                if (systemDatabase.reaSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.reaSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.reaMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }
            else if (itemStatus.superRea)//自動売却
            {
                if (systemDatabase.superReaSinaiBool)
                {
                    zidouBaikyaku = false;
                }
                else if (systemDatabase.superReaSubeteBool)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                    resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                    zidouBaikyaku = true;
                }
                else if (systemDatabase.superReaMuinnBool)
                {
                    if (itemStatus.syougouRea == false & itemStatus.syougouSuperRea == false & itemStatus.syougouEpikRea == false)
                    {
                        if (itemStatus.bairitu == 0)
                        {
                            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().AddMoney(itemStatus.baikyakuKinngaku);
                            resultSceneManagerScript.kakutokuCoin += itemStatus.baikyakuKinngaku;
                            zidouBaikyaku = true;
                        }
                        else
                        {
                            zidouBaikyaku = false;
                        }
                    }
                    else
                        zidouBaikyaku = false;
                }
            }

            if (zidouBaikyaku)//自動売却時のアイテムネーム売却済み
            {
                resultSceneManagerScript.kakutokuItemName.Add("売却金額 " + itemStatus.baikyakuKinngaku.ToString("N0") + " で売却済み");
            }
            else
            {
                sonotaDataBaseManagerScript.weponDataList.weponDatas.Add(itemStatus);
                resultSceneManagerScript.kakutokuItemName.Add(itemStatus.syougouName + itemStatus.name + itemStatus.giftName);
            }
        }
        
    }
    public void SyougouDrop()
    {
        if (dropNumber2 < resultSceneManagerScript.syougous.Count)
        {
            syougouBase = resultSceneManagerScript.syougous[dropNumber2].GetComponent<SyougouBase>();
            SyougouPlus();
            if (syougouBase.syougouStatus.rea)
            {
                itemStatus.syougouRea = true;
                syougouBairitu += 0.25f;
            }
            if (syougouBase.syougouStatus.superRea)
            {
                itemStatus.syougouSuperRea = true;
                syougouBairitu += 0.5f;
            }
            if (syougouBase.syougouStatus.epikRea)
            {
                itemStatus.syougouEpikRea = true;
                syougouBairitu += 1;
            }
            Destroy(resultSceneManagerScript.syougous[dropNumber2]);
        }
    }
    private void SyougouPlus()
    {
        //称号にてプラスされた数値を記録するスクリプト
        itemStatus.syougouName = syougouBase.syougouStatus.syougouName;
        itemStatus.syougouBairitu = syougouBase.syougouStatus.syougouBairitu;
        itemStatus.syougouMaxHp = syougouBase.syougouStatus.maxHpPlus;
        itemStatus.syougouMaxMp = syougouBase.syougouStatus.maxMpPlus;
        itemStatus.syougouFireBallCost = syougouBase.syougouStatus.fireBallCostPlus;
        itemStatus.syougouKougekiryoku = syougouBase.syougouStatus.kougekiryokuPlus;
        itemStatus.syougouKinnkyoriKaisinnritu = syougouBase.syougouStatus.kinnkyoriKaisinnrituPlus;
        itemStatus.syougouMamryoku = syougouBase.syougouStatus.maryokuPlus;
        itemStatus.syougouEnnkyoriKaisinnritu = syougouBase.syougouStatus.ennkyoriKaisinnrituPlus;
        itemStatus.syougouBougyoryoku = syougouBase.syougouStatus.bouggyoryokuPlus;
        itemStatus.syougouKaisinnTaisei = syougouBase.syougouStatus.kaisinnTaisei;
        itemStatus.syougouMeityuuritu = syougouBase.syougouStatus.meityuurituPlus;
        itemStatus.syougouKaihiritu = syougouBase.syougouStatus.kaihirituPlus;

        itemStatus.syougouSyougekiryoku = syougouBase.syougouStatus.syougekiryoku;
        itemStatus.syougouSrushHinndo = syougouBase.syougouStatus.srushHinndo;
        itemStatus.syougouKougekiHanni = syougouBase.syougouStatus.kougekiHanni;

        itemStatus.syougouMazyuuTokkou += syougouBase.syougouStatus.mazyuuTokkou;
        itemStatus.syougouNinngennTokkou += syougouBase.syougouStatus.ninngennTokkou;
        itemStatus.syougouMazinnTokkou += syougouBase.syougouStatus.mazinnTokkou;
        itemStatus.syougouHusiTokkou += syougouBase.syougouStatus.husiTokkou;
        itemStatus.syougouAkumaTokkou += syougouBase.syougouStatus.akumaTokkou;
        itemStatus.syougouRyuuTokkou += syougouBase.syougouStatus.ryuuTokkou;
        itemStatus.syougouKamiTokkou += syougouBase.syougouStatus.kamiTokkou;

        itemStatus.syougouSoubiDropBairitu += syougouBase.syougouStatus.soubiDropBairitu;
        itemStatus.syougouSyougouDropRitu += syougouBase.syougouStatus.syougouDropRitu;
        itemStatus.syougouSoubiGifthuyosoubiDropritu += syougouBase.syougouStatus.soubiGifthuyosoubiDropritu;

        //以下、アイテムステータスに合算スクリプト
        itemStatus.maxHp += syougouBase.syougouStatus.maxHpPlus;
        itemStatus.maxMp += syougouBase.syougouStatus.maxMpPlus;
        itemStatus.fireBallCost += syougouBase.syougouStatus.fireBallCostPlus;
        itemStatus.kougekiryoku += syougouBase.syougouStatus.kougekiryokuPlus;
        itemStatus.kinnkyoriKaisinnritu += syougouBase.syougouStatus.kinnkyoriKaisinnrituPlus;
        itemStatus.maryoku += syougouBase.syougouStatus.maryokuPlus;
        itemStatus.ennkyoriKaisinnsitu += syougouBase.syougouStatus.ennkyoriKaisinnrituPlus;
        itemStatus.bougyoryoiku += syougouBase.syougouStatus.bouggyoryokuPlus;
        itemStatus.kaisinnTaisei += syougouBase.syougouStatus.kaisinnTaisei;
        itemStatus.meityuuritu += syougouBase.syougouStatus.meityuurituPlus;
        itemStatus.kaihiritu += syougouBase.syougouStatus.kaihirituPlus;

        itemStatus.nokkubakku += syougouBase.syougouStatus.syougekiryoku;
        itemStatus.kougekiHinndo += syougouBase.syougouStatus.srushHinndo;
        itemStatus.kougekiHanni += syougouBase.syougouStatus.kougekiHanni;

        itemStatus.soubiMazyuuTokkou += syougouBase.syougouStatus.mazyuuTokkou;
        itemStatus.soubiNinngennTokkou += syougouBase.syougouStatus.ninngennTokkou;
        itemStatus.soubiMazinnTokkou += syougouBase.syougouStatus.mazinnTokkou;
        itemStatus.soubiHusiTokkou += syougouBase.syougouStatus.husiTokkou;
        itemStatus.soubiAkumaTokkou += syougouBase.syougouStatus.akumaTokkou;
        itemStatus.soubiRyuuTokkou += syougouBase.syougouStatus.ryuuTokkou;
        itemStatus.soubiKamiTokkou += syougouBase.syougouStatus.kamiTokkou;

        itemStatus.soubiDropBairitu += syougouBase.syougouStatus.soubiDropBairitu;
        itemStatus.syougouDropRitu+= syougouBase.syougouStatus.syougouDropRitu;
        itemStatus.soubiGifthuyosoubiDropritu += syougouBase.syougouStatus.soubiGifthuyosoubiDropritu;
    }
    public void GiftDrop()
    {
        if(dropNumber<resultSceneManagerScript.gifts.Count)
        {
            giftBase = resultSceneManagerScript.gifts[dropNumber].GetComponent<Gift>();
            giftBairitu = giftBase.giftBairitu / 100f;
            GiftPlus();
            Destroy(resultSceneManagerScript.gifts[dropNumber]);
        }
    }
    
    private void GiftPlus()
    {
        itemStatus.bairitu = giftBase.giftBairitu;
    }
    private void KousekiAdd()
    {
        if(itemStatus.nomal)
        {
            kousekiDataBaseManager.nomalGetSuu++;
        }
        else if(itemStatus.rea)
        {
            kousekiDataBaseManager.reaGetSuu++;
        }
        else if(itemStatus.superRea)
        {
            kousekiDataBaseManager.superReaGetSuu++;
        }
        else if(itemStatus.epik)
        {
            kousekiDataBaseManager.epikReaGetSuu++;
        }
        else if(itemStatus.legendary)
        {
            kousekiDataBaseManager.legendaryReaGetSuu++;
        }
        else if(itemStatus.god)
        {
            kousekiDataBaseManager.godReaGetSuu++;
        }
    }
}


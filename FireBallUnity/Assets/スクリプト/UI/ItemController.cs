using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    private GameObject player;

    public GameObject dataBaseManager;
    private WeponDateBaseManager weponDateBaseMangerScript;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManagerScript;
    private YoroiDataBaseManager yoroiDataBaseManagerScript;
    private SonotaDataBaseManager sonotaDataBaseManagerScript;
    private GameObject[] syougous;
    private GameObject[] gifts;
    private GameObject[] dropSoubis;

    private GameObject resultSceneManager;
    private ResultSceneManager resultSceneManagerScript;

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

    private int syougouHuyoTyuusenn;

    private int tyuusennGift;

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
        resultSceneManager = GameObject.Find("ResultManager");
        resultSceneManagerScript = resultSceneManager.GetComponent<ResultSceneManager>();
        gameManager = GameObject.Find("GameManager");
        a = true;
        b = false;

    }
    // Update is called once per frame
    void Update()
    {
        kakuninnTime += Time.deltaTime;
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
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (a)
            {
                resultSceneManager.GetComponent<ResultSceneManager>().getSoubi.Add(gameObject);
                gameObject.SetActive(false);
                a = false;
            }
        }
    }
    public void SoubiInventryIn()
    {
        if (itemStatus.kinnkyoriWepon)
        {
            syozisuu = weponDateBaseMangerScript.weponDataList.weponDatas.Count;
            itemStatus.no = weponDateBaseMangerScript.weponDataList.weponDatas[syozisuu - 1].no + 1;
            weponDateBaseMangerScript.weponDataList.weponDatas.Add(itemStatus);
            
            GiftDrop();
            SyougouDrop();

            itemStatus.maxHp = itemStatus.maxHp + Mathf.FloorToInt(itemStatus.maxHp * syougouBairitu);
            itemStatus.maxMp = itemStatus.maxMp + Mathf.FloorToInt(itemStatus.maxMp * syougouBairitu);
            itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.FloorToInt(itemStatus.kougekiryoku * (syougouBairitu + giftBairitu));
            itemStatus.maryoku = itemStatus.maryoku + Mathf.FloorToInt(itemStatus.maryoku * syougouBairitu);
            itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.FloorToInt(itemStatus.bougyoryoiku * syougouBairitu);
            itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * syougouBairitu;
            itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * syougouBairitu;

            itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + giftBairitu));

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
                itemStatus.giftName = "ÅqçUåÇóÕ+" + giftBairitu + "%År";
                itemStatus.giftBairituName = "ÅqçUåÇóÕ+" + giftBairitu + "%År";
            }
            KousekiAdd();
            resultSceneManager.GetComponent<ResultSceneManager>().kakutokuItemName.Add(itemStatus.syougouName + itemStatus.name + itemStatus.giftName);
        }
        if (itemStatus.ennkyoriWepon)
        {
            syozisuu = ennkyoriWeponDataBaseManagerScript.weponDataList.weponDatas.Count;
            itemStatus.no = ennkyoriWeponDataBaseManagerScript.weponDataList.weponDatas[syozisuu - 1].no + 1;
            ennkyoriWeponDataBaseManagerScript.weponDataList.weponDatas.Add(itemStatus);

            GiftDrop();
            SyougouDrop();

            itemStatus.maxHp = itemStatus.maxHp + Mathf.FloorToInt(itemStatus.maxHp * syougouBairitu);
            itemStatus.maxMp = itemStatus.maxMp + Mathf.FloorToInt(itemStatus.maxMp * syougouBairitu);
            itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.FloorToInt(itemStatus.kougekiryoku * syougouBairitu);
            itemStatus.maryoku = itemStatus.maryoku + Mathf.FloorToInt(itemStatus.maryoku * (syougouBairitu + giftBairitu));
            itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.FloorToInt(itemStatus.bougyoryoiku * syougouBairitu);
            itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * syougouBairitu;
            itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * syougouBairitu;

            itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + giftBairitu));

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
                itemStatus.giftName = "ÅqñÇóÕ+" + giftBairitu + "%År";
                itemStatus.giftBairituName = "ÅqñÇóÕ+" + giftBairitu + "%År";
            }
            KousekiAdd();
            resultSceneManager.GetComponent<ResultSceneManager>().kakutokuItemName.Add(itemStatus.syougouName + itemStatus.name + itemStatus.giftName);
        }
        if (itemStatus.yoroi)
        {
            syozisuu = yoroiDataBaseManagerScript.weponDataList.weponDatas.Count;
            itemStatus.no = yoroiDataBaseManagerScript.weponDataList.weponDatas[syozisuu - 1].no + 1;
            yoroiDataBaseManagerScript.weponDataList.weponDatas.Add(itemStatus);

            GiftDrop();
            SyougouDrop();

            itemStatus.maxHp = itemStatus.maxHp + Mathf.FloorToInt(itemStatus.maxHp * syougouBairitu);
            itemStatus.maxMp = itemStatus.maxMp + Mathf.FloorToInt(itemStatus.maxMp * syougouBairitu);
            itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.FloorToInt(itemStatus.kougekiryoku * syougouBairitu);
            itemStatus.maryoku = itemStatus.maryoku + Mathf.FloorToInt(itemStatus.maryoku * syougouBairitu);
            itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.FloorToInt(itemStatus.bougyoryoiku * (syougouBairitu + giftBairitu));
            itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * syougouBairitu;
            itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * syougouBairitu;

            itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + giftBairitu));

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
                itemStatus.giftName = "Åqñhå‰óÕ+" + giftBairitu + "%År";
                itemStatus.giftBairituName = "Åqñhå‰óÕ+" + giftBairitu + "%År";
            }
            KousekiAdd();
            resultSceneManager.GetComponent<ResultSceneManager>().kakutokuItemName.Add(itemStatus.syougouName + itemStatus.name + itemStatus.giftName);
        }
        if (itemStatus.sonota)
        {
            syozisuu = sonotaDataBaseManagerScript.weponDataList.weponDatas.Count;
            itemStatus.no = sonotaDataBaseManagerScript.weponDataList.weponDatas[syozisuu - 1].no + 1;
            sonotaDataBaseManagerScript.weponDataList.weponDatas.Add(itemStatus);
            syokiBaikyakuti = itemStatus.baikyakuKinngaku;

            GiftDrop();
            SyougouDrop();
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

            int giftHuyoStatus = sonotasoubiStatus[ Random.Range(0, sonotasoubiStatus.Count)];
           
            if (giftHuyoStatus == 0)
            {
                itemStatus.maxHp = itemStatus.maxHp + Mathf.FloorToInt(itemStatus.maxHp * (syougouBairitu + giftBairitu));
                itemStatus.sonotaKyoukaStatus = 1;
                baikyakuBairitu = giftBairitu;

                if (itemStatus.maxHp != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "ÅqHP+" + giftBairitu + "%År";
                        itemStatus.giftBairituName = "ÅqHP+" + giftBairitu + "%År";
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
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.maxHp = itemStatus.maxHp + Mathf.FloorToInt(itemStatus.maxHp * syougouBairitu);
            }

            if (giftHuyoStatus == 1)
            {
                itemStatus.maxMp = itemStatus.maxMp + Mathf.FloorToInt(itemStatus.maxMp * (syougouBairitu + giftBairitu));
                itemStatus.sonotaKyoukaStatus = 2;
                baikyakuBairitu = giftBairitu;
                if (itemStatus.maxMp != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "ÅqMP+" + giftBairitu + "%År";
                        itemStatus.giftBairituName = "ÅqMP+" + giftBairitu + "%År";
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
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.maxMp = itemStatus.maxMp + Mathf.FloorToInt(itemStatus.maxMp * syougouBairitu);
            }

            if (giftHuyoStatus == 2)
            {
                baikyakuBairitu = giftBairitu;
                itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.FloorToInt(itemStatus.kougekiryoku * (syougouBairitu + giftBairitu));
                itemStatus.sonotaKyoukaStatus = 3;
                if (itemStatus.kougekiryoku != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "ÅqçUåÇóÕ+" + giftBairitu + "%År";
                        itemStatus.giftBairituName = "ÅqçUåÇóÕ+" + giftBairitu + "%År";
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
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.kougekiryoku = itemStatus.kougekiryoku + Mathf.FloorToInt(itemStatus.kougekiryoku * syougouBairitu);
            }

            if (giftHuyoStatus == 3)
            {
                itemStatus.sonotaKyoukaStatus = 4;
                baikyakuBairitu = giftBairitu;
                itemStatus.maryoku = itemStatus.maryoku + Mathf.FloorToInt(itemStatus.maryoku * (syougouBairitu + giftBairitu));
                if (itemStatus.maryoku != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "ÅqñÇóÕ+" + giftBairitu + "%År";
                        itemStatus.giftBairituName = "ÅqñÇóÕ+" + giftBairitu + "%År";
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
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.maryoku = itemStatus.maryoku + Mathf.FloorToInt(itemStatus.maryoku * syougouBairitu);
            }

            if (giftHuyoStatus == 4)
            {
                itemStatus.sonotaKyoukaStatus = 5;
                baikyakuBairitu = giftBairitu;
                itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.FloorToInt(itemStatus.bougyoryoiku * (syougouBairitu + giftBairitu));
                if (itemStatus.syougouBougyoryoku != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "Åqñhå‰óÕ+" + giftBairitu + "%År";
                        itemStatus.giftBairituName = "Åqñhå‰óÕ+" + giftBairitu + "%År";
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
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.bougyoryoiku = itemStatus.bougyoryoiku + Mathf.FloorToInt(itemStatus.bougyoryoiku * syougouBairitu);
            }

            if (giftHuyoStatus == 5)
            {
                baikyakuBairitu = giftBairitu;
                itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * (syougouBairitu + giftBairitu);

                if (itemStatus.meityuuritu != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "ÅqñΩíÜó¶+" + giftBairitu + "%År";
                        itemStatus.giftBairituName = "ÅqñΩíÜó¶+" + giftBairitu + "%År";
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
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

            }
            else
            {
                itemStatus.meityuuritu = itemStatus.meityuuritu + itemStatus.meityuuritu * syougouBairitu;
            }

            if (giftHuyoStatus == 6)
            {
                baikyakuBairitu = giftBairitu;
                itemStatus.kaihiritu = itemStatus.kaihiritu + itemStatus.kaihiritu * (syougouBairitu + giftBairitu);

                if (itemStatus.kaihiritu != 0)
                {
                    if (giftBairitu > 0)
                    {
                        giftBairitu *= 100;
                        itemStatus.giftName = "ÅqâÒîó¶+" + giftBairitu + "%År";
                        itemStatus.giftBairituName = "ÅqâÒîó¶+" + giftBairitu + "%År";
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
                itemStatus.baikyakuKinngaku = itemStatus.baikyakuKinngaku + Mathf.FloorToInt(itemStatus.baikyakuKinngaku * (syougouBairitu + baikyakuBairitu));

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
            resultSceneManager.GetComponent<ResultSceneManager>().kakutokuItemName.Add(itemStatus.syougouName + itemStatus.name + itemStatus.giftName);
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

        itemStatus.maxHp += syougouBase.syougouStatus.maxHpPlus;
        itemStatus.maxMp += syougouBase.syougouStatus.maxMpPlus;
        itemStatus.fireBallCost += syougouBase.syougouStatus.fireBallCostPlus;
        itemStatus.kougekiryoku += syougouBase.syougouStatus.kougekiryokuPlus;
        itemStatus.maryoku += syougouBase.syougouStatus.maryokuPlus;
        itemStatus.bougyoryoiku += syougouBase.syougouStatus.bouggyoryokuPlus;
        itemStatus.meityuuritu += syougouBase.syougouStatus.meityuurituPlus;
        itemStatus.kaihiritu += syougouBase.syougouStatus.kaihirituPlus;
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
        if(itemStatus.rea)
        {
            kousekiDataBaseManager.reaGetSuu++;
        }
        if(itemStatus.superRea)
        {
            kousekiDataBaseManager.superReaGetSuu++;
        }
        if(itemStatus.epik)
        {
            kousekiDataBaseManager.epikReaGetSuu++;
        }
        if(itemStatus.legendary)
        {
            kousekiDataBaseManager.legendaryReaGetSuu++;
        }
        if(itemStatus.god)
        {
            kousekiDataBaseManager.godReaGetSuu++;
        }
    }
}


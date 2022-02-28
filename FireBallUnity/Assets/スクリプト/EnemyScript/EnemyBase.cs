using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public GameObject enemyDataBaseManager;
    public GameObject fireBallDamageEffect;
    private GameObject dataBaseManager;
    private GameObject player;
    private Vector2 enemyPosition;
    private Vector2 playerPosition;
    private PlayerStatus playerStatus;

    private float damageKeisann;
    public int enemyDamage;
    private int saiteihosyouDamage;
    private float damageBairitu;
    public Vector2 damagePosition;
    private float desuTime;

    public int enemyHp;

    public float speed;
    private Rigidbody2D myRigid;

    private float nokkubakkuKyori;
    private float kaihi;

    public int playerDamage;

    public GameObject bikkurimark;

    private bool a;
    public bool b;
    private bool c;
    private bool d;
    public bool e;
    private bool f;
    public bool g;
    private bool h;
    public bool i;
    private bool j;
    public bool k;
    public bool l;

    private SpriteRenderer sprite;
    private float flashTime;
    private float flashColor;
    private float flashCount = 0.3f;

    public float enemyKougeki;
    private float enemyAtackMotion;
    private GameObject playerDamageHanntei;
    private PlayerDamage playerDamageA;

    private EXPManager expManagerScript;
    public GameObject exp;
    private EXPController expControllerScript;
    public GameObject desuEffect;

    public GameObject itienn;
    public GameObject zyuuenn;
    public GameObject hyakuenn;
    public GameObject sennenn;
    public GameObject itimannenn;
    private int itiennCount;
    private int zyuuennCount;
    private int hyakuennCount;
    private int sennennCount;
    private int itimannennCount;
    private int moneyCount;
    private Vector2 desuPosition;
    private Vector2 dropPosition;

    public GameObject itemPrefab;
    public GameObject syougouPrefab;
    private ItemController itemController;

    public GameObject weponBoxNomal;
    public GameObject weponBoxRea;
    public GameObject weponBoxSuperRea;
    public GameObject weponBoxEpik;
    public GameObject weponBoxLegendary;
    public GameObject weponBoxGod;

    private WeponBox weponBoxScript;

    public GameObject gift;
    private Gift giftScript;
    public int giftBairitu;

    private float kaisinn;

    public GameObject kyoukasekiSyou;
    public GameObject kyoukasekiTyuu;
    public GameObject kyoukasekiDai;
    public float kyoukasekisyouDropritu;
    public float kyoukasekityuuDropritu;
    public float kyoukasekidaiDrooritu;
    public float kyoukasekiDropritu;
    public Vector2 kyoukasekiDropPosition;

    public float giftHuyoHanni;
    public float syougouDropRitu;

    private KousekiDataBaseManager kousekiDataBaseManagerScript;

    [Header("エネミーデータ")]
    public EnemyDataList.EnemyData enemyData;

    
    void Start()
    {
        
        player = GameObject.Find("Player");
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        playerStatus = player.GetComponent<PlayerStatus>();
        kousekiDataBaseManagerScript = dataBaseManager.GetComponent<KousekiDataBaseManager>();

        enemyData = dataBaseManager.GetComponent<EnemyDataBaseManager>().GetEnemyData(enemyData.no);
        enemyHp = enemyData.maxHp;


        //???W?b?g?{?f?B?QD??????
        myRigid = gameObject.GetComponent<Rigidbody2D>();
        a = true;
        b = false;
        c = false;
        d = true;
        e = false;
        f = false;
        g = false;
        h = false;
        i = false;

        desuTime = 0;

        sprite = transform.GetComponent<SpriteRenderer>();
        flashCount = 0;
        flashTime = 0.3f;

        enemyKougeki = 0;
        enemyAtackMotion = 0;


        expManagerScript = dataBaseManager.GetComponent<EXPManager>();
        expControllerScript = exp.GetComponent<EXPController>();

        speed = 0.0004f * enemyData.speed;

        
    }

    void Update()
    {
        if (a == true)
        if(player.transform.position.y <= 4)
        {
            Debug.Log("Playerが現れた！！");
            myRigid.isKinematic = true;
            myRigid.velocity = Vector2.down * 3;
            myRigid.isKinematic = true;

            Instantiate(bikkurimark, transform.position, transform.rotation);

            a = false;
        }
        if(b == true)
        {
            enemyPosition = transform.position;
            myRigid.velocity = Vector2.zero;
            enemyPosition.y += speed;
            transform.position = enemyPosition;
        }
        if(c == true)
        {
            b = false;
            myRigid.velocity = Vector2.zero;
            flashCount += Time.deltaTime;
            DamageFlash();
            if(flashCount >= flashTime)
            {
                b = true;
                sprite.color =new Color (255, 255, 255, 255);
                flashCount = 0;
                c = false;
                d = true;
            }
        }
        if(f)
        {
            desuTime += Time.deltaTime;
            if(desuTime >= 0.3f)
            {
                desuPosition = transform.position;
                Instantiate(desuEffect,desuPosition,transform.rotation);
                expDrop();
                itemDrop();
                moneyDrop();
                KyoukasekiDrop();
                KousekiAdd();
                Destroy(gameObject);
            }
        }
        if (player != null)
        {
            if (player.transform.position.y <= 4)
            {
                enemyKougeki += Time.deltaTime;
                playerDamageHanntei = GameObject.Find("DamageHanni(Clone)");

            }
        }
        if(g)
        {
            playerDamageA = playerDamageHanntei.GetComponent<PlayerDamage>();
            myRigid.velocity = Vector2.zero;
            if(enemyKougeki >= enemyData.kougekiHinndo)
            {
                playerDamageA.a = true;
                if (player != null)
                {
                    transform.position = player.transform.position;
                }
                h = true;
                if(enemyAtackMotion >= 0.25f)
                {
                    enemyKougeki = 0;
                    transform.position = new Vector2(Random.Range(-1,1.1f), -7.8f);
                    h = false;
                    enemyAtackMotion = 0f;
                }
            }
        }
        if(h)
        {
            enemyAtackMotion += Time.deltaTime;
        }

    }
    private void KyoukasekiDrop()//強化石ドロップメソッド
    {
        kyoukasekiDropPosition = desuPosition - new Vector2(Random.Range(-0.3f, 0.3f), Random.Range(-0.3f, 0.3f));
        if (enemyData.lebel<=30)
        {
            kyoukasekiDropritu = Random.Range(0.00f, 100.00f);
            if (enemyData.lebel <= 20)
            {
                if (kyoukasekiDropritu <= 20)
                {
                    Instantiate(kyoukasekiSyou, kyoukasekiDropPosition, transform.rotation);
                }
            }
            else if (kyoukasekiDropritu <= enemyData.lebel)
            {
                Instantiate(kyoukasekiSyou, kyoukasekiDropPosition, transform.rotation);
            }
        }
        else if(enemyData.lebel<=60)
        {
            kyoukasekiDropritu = Random.Range(0.00f, 100.00f);
            if(kyoukasekiDropritu<=(100-enemyData.lebel))
            {
                Instantiate(kyoukasekiSyou, kyoukasekiDropPosition, transform.rotation);
            }
            else
            {
                Instantiate(kyoukasekiTyuu, kyoukasekiDropPosition, transform.rotation);
            }
        }
        else
        {
            kyoukasekisyouDropritu = 100 - enemyData.lebel;
            kyoukasekityuuDropritu = enemyData.lebel - enemyData.lebel / 10;
            kyoukasekidaiDrooritu = 100 - kyoukasekisyouDropritu - kyoukasekityuuDropritu;
            kyoukasekiDropritu = Random.Range(0.00f, 100.00f);
            if(kyoukasekiDropritu<=kyoukasekisyouDropritu)
            {
                Instantiate(kyoukasekiSyou, kyoukasekiDropPosition, transform.rotation);
            }
            else if(kyoukasekiDropritu <= kyoukasekityuuDropritu+kyoukasekisyouDropritu)
            {
                Instantiate(kyoukasekiTyuu,kyoukasekiDropPosition,transform.rotation);
            }
            else
            {
                Instantiate(kyoukasekiDai, kyoukasekiDropPosition, transform.rotation);
            }

        }
    }
    private void itemDrop()//アイテムドロップメソッド
    {
        for (int b = 0; b < enemyData.dropSyougou.Length; b++)
        {
            syougouDropRitu = Random.Range(0.00f, 100.00f);
            if(b==0)
            {
                if (enemyData.reaSyougouDropRitu >= syougouDropRitu)
                {
                    Instantiate(enemyData.dropSyougou[b]);
                    Debug.Log("レア称号ドロップ");
                }
            }
            if(b==1)
            {
                if(enemyData.superReaSyougouDropRitu >= syougouDropRitu)
                {
                    Instantiate(enemyData.dropSyougou[b]);             
                    Debug.Log("スーパーレア称号ドロップ");

                }
            }
            if(b==2)
            {
                if(enemyData.epikSyougouDropRitu >= syougouDropRitu)
                {
                    Instantiate(enemyData.dropSyougou[b]);
                    Debug.Log("エピック称号ドロップ");
                }
            }

            //b==0でレア称号　b==1でスーパーレア称号 b==2でエピックレア称号　b==3以降はアプデで追加？
        }
        //ギフトドロップ
        if (Random.Range(0.00f, 100.00f) <= enemyData.giftDropRitu)
        {
            Debug.Log("ギフトドロップ");
            if (enemyData.lebel <= 10)
            {
                Debug.Log("LV10以下の敵のギフトがドロップ");
                giftBairitu = Random.Range(1, enemyData.lebel + 1);
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 20)
            {
                Debug.Log("LV20以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 40.00f)
                {
                    giftBairitu = Random.Range(11, enemyData.lebel + 1);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 30)
            {
                Debug.Log("LV30以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 20.00f)
                {
                    giftBairitu = Random.Range(21, enemyData.lebel + 1);
                }
                else if (giftHuyoHanni <= 50)
                {
                    giftBairitu = Random.Range(11, 21);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 40)
            {
                Debug.Log("LV40以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 10.00f)
                {
                    giftBairitu = Random.Range(31, enemyData.lebel + 1);
                }
                else if (giftHuyoHanni <= 30.00f)
                {
                    giftBairitu = Random.Range(21, 31);
                }
                else if (giftHuyoHanni <= 60.00f)
                {
                    giftBairitu = Random.Range(11, 21);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 50)
            {
                Debug.Log("LV50以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 10.00f)
                {
                    giftBairitu = Random.Range(41, enemyData.lebel + 1);
                }
                else if (giftHuyoHanni <= 25.00f)
                {
                    giftBairitu = Random.Range(31, 41);
                }
                else if (giftHuyoHanni <= 45.00f)
                {
                    giftBairitu = Random.Range(21, 31);
                }
                else if (giftHuyoHanni <= 70.00f)
                {
                    giftBairitu = Random.Range(11, 21);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 60)
            {
                Debug.Log("LV60以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 9.00f)
                {
                    giftBairitu = Random.Range(51, enemyData.lebel + 1);
                }
                else if (giftHuyoHanni <= 20.00f)
                {
                    giftBairitu = Random.Range(41, 51);
                }
                else if (giftHuyoHanni <= 35.00f)
                {
                    giftBairitu = Random.Range(31, 41);
                }
                else if (giftHuyoHanni <= 52.00f)
                {
                    giftBairitu = Random.Range(21, 31);
                }
                else if (giftHuyoHanni <= 70.00f)
                {
                    giftBairitu = Random.Range(11, 21);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 70)
            {
                Debug.Log("LV70以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 8.00f)
                {
                    giftBairitu = Random.Range(61, enemyData.lebel + 1);
                }
                else if (giftHuyoHanni <=18.00f)
                {
                    giftBairitu = Random.Range(51, 61);
                }
                else if (giftHuyoHanni <= 30.00f)
                {
                    giftBairitu = Random.Range(41, 51);
                }
                else if (giftHuyoHanni <= 45.00f)
                {
                    giftBairitu = Random.Range(31, 41);
                }
                else if (giftHuyoHanni <= 62.00f)
                {
                    giftBairitu = Random.Range(21, 31);
                }
                else if (giftHuyoHanni <= 80.00f)
                {
                    giftBairitu = Random.Range(11, 21);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 80)
            {
                Debug.Log("LV80以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if(giftHuyoHanni <=3.00f)
                {
                    giftBairitu = Random.Range(71, enemyData.lebel + 1);
                }
                else if (giftHuyoHanni <= 9.00f)
                {
                    giftBairitu = Random.Range(61, 71);
                }
                else if (giftHuyoHanni <= 18.00f)
                {
                    giftBairitu = Random.Range(51, 61);
                }
                else if (giftHuyoHanni <= 30.00f)
                {
                    giftBairitu = Random.Range(41, 51);
                }
                else if (giftHuyoHanni <= 45.00f)
                {
                    giftBairitu = Random.Range(31, 41);
                }
                else if (giftHuyoHanni <= 62.00f)
                {
                    giftBairitu = Random.Range(21, 31);
                }
                else if (giftHuyoHanni <= 80.00f)
                {
                    giftBairitu = Random.Range(11, 21);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 90)
            {
                Debug.Log("LV90以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if(giftHuyoHanni <= 2.00f)
                {
                    giftBairitu = Random.Range(81, enemyData.lebel + 1);
                }
                else if (giftHuyoHanni <= 5.00f)
                {
                    giftBairitu = Random.Range(71, 81);
                }
                else if (giftHuyoHanni <= 10.00f)
                {
                    giftBairitu = Random.Range(61, 71);
                }
                else if (giftHuyoHanni <= 18.00f)
                {
                    giftBairitu = Random.Range(51, 61);
                }
                else if (giftHuyoHanni <= 30.00f)
                {
                    giftBairitu = Random.Range(41, 51);
                }
                else if (giftHuyoHanni <= 45.00f)
                {
                    giftBairitu = Random.Range(31, 41);
                }
                else if (giftHuyoHanni <= 62.00f)
                {
                    giftBairitu = Random.Range(21, 31);
                }
                else if (giftHuyoHanni <= 80.00f)
                {
                    giftBairitu = Random.Range(11, 21);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyData.lebel <= 100)
            {
                Debug.Log("LV100以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if(giftHuyoHanni<=1.00f)
                {
                    giftBairitu = Random.Range(91, enemyData.lebel + 1);
                }
                else if (giftHuyoHanni <= 3.00f)
                {
                    giftBairitu = Random.Range(81, 91);
                }
                else if (giftHuyoHanni <= 6.00f)
                {
                    giftBairitu = Random.Range(71, 81);
                }
                else if (giftHuyoHanni <= 11.00f)
                {
                    giftBairitu = Random.Range(61, 71);
                }
                else if (giftHuyoHanni <= 19.00f)
                {
                    giftBairitu = Random.Range(51, 61);
                }
                else if (giftHuyoHanni <= 30.00f)
                {
                    giftBairitu = Random.Range(41, 51);
                }
                else if (giftHuyoHanni <= 45.00f)
                {
                    giftBairitu = Random.Range(31, 41);
                }
                else if (giftHuyoHanni <= 62.00f)
                {
                    giftBairitu = Random.Range(21, 31);
                }
                else if (giftHuyoHanni <= 80.00f)
                {
                    giftBairitu = Random.Range(11, 21);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
        }


            for (int a = 0; a < enemyData.dropItemSuu; a++)
        {
            
            dropPosition = desuPosition - new Vector2(Random.Range(-0.3f, 0.3f), Random.Range(-0.3f, 0.3f));

            int itemNo = enemyData.dropItemNos[a];
            itemPrefab = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<EnemyDataBaseManager>(). GetDropItemPrefabDate(itemNo);
            
            itemController = itemPrefab.GetComponent<ItemController>();

            if (itemController.itemStatus.god)
            {
                if (Random.Range(0.0f, 100.0f) <= enemyData.godDropRitu)
                {
                    weponBoxScript = weponBoxGod.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxGod, dropPosition, transform.rotation);
                }
            }
            if(itemController.itemStatus.legendary)
            {
                if (Random.Range(0.0f, 100.0f) <= enemyData.legendaryDropRitu)
                {
                    weponBoxScript = weponBoxLegendary.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxLegendary, dropPosition, transform.rotation);
                }
            }
            if (itemController.itemStatus.epik)
            {
                if (Random.Range(0.0f, 100.0f) <= enemyData.epikDropRitu)
                {
                    weponBoxScript = weponBoxEpik.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxEpik, dropPosition, transform.rotation);
                }
            }
            if (itemController.itemStatus.superRea)
            {
                if (Random.Range(0.0f, 100.0f) <= enemyData.superReaDropRitu)
                {
                    weponBoxScript = weponBoxSuperRea.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxSuperRea, dropPosition, transform.rotation);
                }
            }
            if (itemController.itemStatus.rea)
            {
                if (Random.Range(0.0f, 100.0f) <= enemyData.reaDropRitu)
                {
                    weponBoxScript = weponBoxRea.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxRea, dropPosition, transform.rotation);
                }
            }
            if (itemController.itemStatus.nomal)
            {
                if (Random.Range(0.0f, 100.0f) <= enemyData.nomalDropRitu)
                {
                    weponBoxScript = weponBoxNomal.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxNomal, dropPosition, transform.rotation); 
                }
            }
        }
        
    }
    
    private void moneyDrop()//Moneyドロップメソッド
    {
        moneyCount = enemyData.gold;
        itimannennCount = Mathf.FloorToInt(moneyCount / 10000);
        moneyCount = moneyCount - itimannennCount * 10000;
        sennennCount = Mathf.FloorToInt(moneyCount / 1000);
        moneyCount = moneyCount - sennennCount * 1000;
        hyakuennCount = Mathf.FloorToInt(moneyCount / 100);
        moneyCount = moneyCount - hyakuennCount * 100;
        zyuuennCount = Mathf.FloorToInt(moneyCount / 10);
        moneyCount = moneyCount - zyuuennCount * 10;
        itiennCount = Mathf.FloorToInt(moneyCount / 1);
        moneyCount = moneyCount - itiennCount * 1;
        for (int countItimannenn = 0; itimannennCount > countItimannenn; countItimannenn++)
        {
            desuPosition.x += Random.Range(0.1f, -0.1f);
            desuPosition.y += Random.Range(0.1f, -0.1f);
            Instantiate(itimannenn, desuPosition, transform.rotation);
        }
        for (int countSennenn = 0; sennennCount > countSennenn; countSennenn++)
        {
            desuPosition.x += Random.Range(0.1f, -0.1f);
            desuPosition.y += Random.Range(0.1f, -0.1f);
            Instantiate(sennenn, desuPosition, transform.rotation);
        }
        for (int countHyakuenn = 0; hyakuennCount > countHyakuenn; countHyakuenn++)
        {
            desuPosition.x += Random.Range(0.1f, -0.1f);
            desuPosition.y += Random.Range(0.1f, -0.1f);
            Instantiate(hyakuenn, desuPosition, transform.rotation);
        }
        for (int countZyuuenn = 0; zyuuennCount > countZyuuenn; countZyuuenn++)
        {
            desuPosition.x += Random.Range(0.1f, -0.1f);
            desuPosition.y += Random.Range(0.1f, -0.1f);
            Instantiate(zyuuenn, desuPosition, transform.rotation);
        }
        for (int countItienn = 0; itiennCount > countItienn; countItienn++)
        {
            desuPosition.x += Random.Range(0.1f, -0.1f);
            desuPosition.y += Random.Range(0.1f, -0.1f);
            Instantiate(itienn, desuPosition, transform.rotation);
        }
    }
    public void expDrop()
    {
        expControllerScript.exp = enemyData.exp;
        Instantiate(exp, desuPosition, transform.rotation);
    }
    public void KousekiAdd()
    {
        if(enemyData.mazyuu)
        {
            kousekiDataBaseManagerScript.mazyuuToubatuSuu++;
        }
        else if(enemyData.ninngenn)
        {
            kousekiDataBaseManagerScript.ninngennToubatuSuu++;
        }
        else if(enemyData.mazinn)
        {
            kousekiDataBaseManagerScript.mazinnToubatuSuu++;
        }
        else if(enemyData.husi)
        {
            kousekiDataBaseManagerScript.mazinnToubatuSuu++;
        }
        else if(enemyData.akuma)
        {
            kousekiDataBaseManagerScript.akumaToubatuSuu++;
        }
        else if(enemyData.ryuu)
        {
            kousekiDataBaseManagerScript.ryuuTToubatuSuu++;
        }
        else if(enemyData.kami)
        {
            kousekiDataBaseManagerScript.kamiToubatuSuu++;
        }
        if(enemyData.rea)
        {
            kousekiDataBaseManagerScript.reaEnemyToubatuSuu++;
        }
    }
    public void DamageFlash()
    {
        flashColor = Mathf.Sin(Time.time * 100) / 2 + 0.5f;
        Color color = sprite.color;
        color.a = flashColor;
        sprite.color = color;
    }
    //ダメージ計算メゾット
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "FireBall")
        {
            damagePosition = collision.transform.position;

            if (i)
            {
                Instantiate(fireBallDamageEffect, transform.position, transform.rotation);
                saiteihosyouDamage = Random.Range(0, 2);
                damageBairitu = Random.Range(0.8f, 1.21f);
                damageKeisann = (playerStatus.maryoku - enemyData.mahouBougyoryoku) * damageBairitu;
                kaisinn = playerStatus.ennkyoriKaisinnritu - enemyData.kaisinnTaisei;
                if(kaisinn>= Random.Range(0.0f,100.0f))
                {
                    damageKeisann *= 2;
                    l = true;
                }
                if (damageKeisann < 1)
                {
                    enemyDamage = saiteihosyouDamage;
                    enemyHp -= enemyDamage;
                    e = true;
                //    Debug.Log(enemyData.enemyName + "に" + saiteihosyouDamage.ToString("N0") + "のダメージを与えた！！");
                }
                else
                {
                    enemyDamage = Mathf.CeilToInt(damageKeisann);
                    enemyHp -= enemyDamage;
                  //  Debug.Log(enemyData.enemyName + "に" + enemyDamage.ToString("N0") + "のダメージを与えた！！");
                    e = true;
                }
                if (enemyHp <= 0)
                {

                    f = true;
                }
                i = false;
            }
        }
        if (collision.gameObject.tag == "Srush")
        {
            if (d)
            {
                d = false;
                nokkubakkuKyori = playerStatus.nokkubakku - enemyData.nokkubakkuBougyo;
                enemyPosition = transform.position;
                enemyPosition.y -= nokkubakkuKyori;
                transform.position = enemyPosition;

                damagePosition = transform.position;

                kaihi = 100 - (playerStatus.meityuuritu - enemyData.kaihiritu);

                if(Random.Range(0.0f,100.0f) <= kaihi)
                {
                    Debug.Log(kaihi);
                    j = true;
                    if (kaihi >= 95)
                    {
                        if (Random.Range(0.0f, 100.0f) <= 5)
                        {
                            j = false;
                        }
                        else
                        {
                            k = true;
                        }
                    }
                    else
                    {
                        k = true;
                    }
                }
                if (j == false)
                {
                    damageBairitu = Random.Range(0.8f, 1.21f);
                    saiteihosyouDamage = Random.Range(0, 2);
                    damageKeisann = (playerStatus.kougekiryoku - enemyData.bougyoryoku) * damageBairitu;
                    kaisinn = playerStatus.kinnkyoriKaisinnritu - enemyData.kaisinnTaisei;
                    if (kaisinn >= Random.Range(0.0f, 100.0f))
                    {
                        damageKeisann *= 2;
                        l = true;
                    }
                    if (damageKeisann <= 1)
                    {
                        enemyDamage = saiteihosyouDamage;
                        enemyHp -= enemyDamage;
                        e = true;
                      //  Debug.Log(enemyData.enemyName + "に" + saiteihosyouDamage.ToString("N0") + "のダメージを与えた！！");
                    }
                    else
                    {
                        enemyDamage = Mathf.CeilToInt(damageKeisann);
                        enemyHp -= enemyDamage;
                        e = true;
                        //Debug.Log(enemyData.enemyName + "に" + enemyDamage.ToString("N0") + "のダメージを与えた！！");
                    }
                }
                c = true;
                if (enemyHp <= 0)
                {
                    f = true;
                }
                j = false;
            }
        }

        if (collision.gameObject.tag == "LowLowWall")
        {
            myRigid.isKinematic  = false;
            b = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}

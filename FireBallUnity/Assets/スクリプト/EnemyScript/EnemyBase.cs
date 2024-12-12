using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBase : MonoBehaviour
{   
    public int enemyLv;    
    [Header("エネミーデータ")]
    public EnemyDataList.EnemyData enemyData;
    [Header("HP")]
    public int maxHp;
    public int hp;
    [Header("攻撃力")]
    public int kougekiryoku;
    [Header("会心率")]
    public float kaisinnritu;
    [Header("防御力")]
    public int bougyoryoku;
    [Header("会心耐性")]
    public float kaisinnTaisei;
    [Header("魔法防御力")]
    public int mahouBougyoryoku;
    [Header("命中率")]
    public float meityuuritu;
    [Header("回避率")]
    public float kaihiritu;
    [Header("攻撃頻度")]
    public float kougekiHinndo;
   //[Header("攻撃範囲")]
   // public float kougekiHanni;
    [Header("速度")]
    public float enemySpeed;
    [Header("緩衝力")]
    public float nokkubakkuBougyo;
    [Header("ゴールド")]
    public int money;
    [Header("経験値")]
    public int enemyExp;

    public Text lvText;
    public GameObject enemyDataBaseManager;
    public GameObject fireBallDamageEffect;
    private GameObject dataBaseManager;
    private GameObject player;
    public Atack atack;
    private Vector2 enemyPosition;
    private PlayerStatus playerStatus;

    private float damageKeisann;
    public int enemyDamage;
    private int saiteihosyouDamage;
    private float damageBairitu;
    private float tokkouBairitu;
    public Vector2 damagePosition;
    private float desuTime;

    private float itemDropRitu;


    public float speed;
    private Rigidbody2D myRigid;

    private float nokkubakkuKyori;
    private float kaihi;

    public int playerDamage;


    public GameObject bikkurimark;

    private bool kinnsetuSentouBool;
    public bool collisionEnterLowLowWallBool;
    private bool damegeBool;
    private bool damegeIkkaiBool;
    public bool damageTextIkkaiBool;
    private bool deadBool;
    public bool collisionEnterKougekiWallBool;
    private bool enemuKougekiTimeBool;
    public bool damageEffectBool;
    private bool kaihiBool;
    public bool missTextBool;
    public bool kaisinnBool;
    private bool kougekiTimeBool=false;
    private bool kougekiAnime;

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

    public DamageTaxtCanvas damageTaxtCanvas;

    private KousekiDataBaseManager kousekiDataBaseManagerScript;
    private PlayerStatusDataBase playerStatusDataBase;

    private ResultSceneManager resultSceneManager;

    private SoubiSkillDatabase soubiSkillDatabase;
    private bool saikutuBool;
    private SoubiSkillDataList.SoubiSkillData saikutuData;
    private bool kyuusyuuBool;
    private SoubiSkillDataList.SoubiSkillData kyuusyuuData;
    private int kyuusyuuSuuti;
    private bool atackSetteiBool=true;
    private bool kyougiriBool;
    private SoubiSkillDataList.SoubiSkillData kyougiriData;
    private bool asidBallBool;
    private SoubiSkillDataList.SoubiSkillData asidBallData;
    private bool asidSrushBool;
    private SoubiSkillDataList.SoubiSkillData asidSrushData;
    private bool asidMode;
    private float asidTime;
    private int asidDamage;
    private int asidCount;
    public bool sekikaMode;
    private int sekikaTime=3;
    private float sekikaCountTime;
    public Color sekikaColor;

    public Nannido nannido;

    private SenntouBGMManager senntouBGMManager;

    void Start()
    {
        player = GameObject.Find("Player");
        resultSceneManager = GameObject.Find("ResultManager").GetComponent<ResultSceneManager>();
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        playerStatus = player.GetComponent<PlayerStatus>();
        senntouBGMManager = dataBaseManager.GetComponent<SenntouBGMManager>();
        kousekiDataBaseManagerScript = dataBaseManager.GetComponent<KousekiDataBaseManager>();
        playerStatusDataBase = dataBaseManager.GetComponent<PlayerStatusDataBase>();
        nannido = dataBaseManager.GetComponent<Nannido>();
        enemyData = dataBaseManager.GetComponent<EnemyDataBaseManager>().GetEnemyData(enemyData.no);

        if(nannido.syosinnsyanoMiti)
        {
            enemyLv *= 1;
        }
        else if(nannido.boukennsyanoSirenn)
        {
            enemyLv =enemyLv * 2 + Random.Range(0, 11);
        }
        else if(nannido.eiyuunoMiti)
        {
            enemyLv =enemyLv * 3 + Random.Range(10, 31);
        }
        else if(nannido.yuusyanoTyousenn)
        {
            enemyLv =enemyLv * 4 + Random.Range(20, 51);
        }
        else if(nannido.dennsetunoSirenn)
        {
            enemyLv = enemyLv * 5 + Random.Range(30, 71);
        }
        else if(nannido.kamigaminoRyouiki)
        {
            enemyLv = enemyLv * 6 + Random.Range(40, 101);
        }

            maxHp = enemyData.maxHp*enemyLv;
            kougekiryoku = enemyData.kougekiryoku*enemyLv;
            kaisinnritu = enemyData.kaisinnritu*enemyLv;
            bougyoryoku = enemyData.bougyoryoku * enemyLv;
            kaisinnTaisei = enemyData.kaisinnTaisei * enemyLv;
            mahouBougyoryoku = enemyData.mahouBougyoryoku * enemyLv;
            meityuuritu = (enemyData.meityuuritu-100)*enemyLv+100;
            kaihiritu = enemyData.kaihiritu * enemyLv;
            kougekiHinndo = enemyData.kougekiHinndo;
           // kougekiHanni = enemyData.kougekiHanni;
            enemySpeed = enemyData.speed;
            nokkubakkuBougyo = enemyData.nokkubakkuBougyo;
            money = enemyData.gold * enemyLv;
            enemyExp = enemyData.exp * enemyLv;

        hp = maxHp;
        lvText.text = "Lv" + enemyLv;

        //???W?b?g?{?f?B?QD??????
        myRigid = gameObject.GetComponent<Rigidbody2D>();
        kinnsetuSentouBool = true;
        collisionEnterLowLowWallBool = false;
        damegeBool = false;
        damegeIkkaiBool = true;
        damageTextIkkaiBool = false;
        deadBool = false;
        collisionEnterKougekiWallBool = false;
        enemuKougekiTimeBool = false;
        damageEffectBool = false;
        kougekiAnime = true;

        desuTime = 0;

        sprite = transform.GetComponent<SpriteRenderer>();
        flashCount = 0;
        flashTime = 0.3f;

        enemyKougeki = 0;
        enemyAtackMotion = 0;


        expManagerScript = dataBaseManager.GetComponent<EXPManager>();
        expControllerScript = exp.GetComponent<EXPController>();

        speed = 0.03f+(enemySpeed/10000);
        SoubiSkillSettei();
    }

    void Update()
    {
        if (kinnsetuSentouBool == true)//近接戦闘が始まったら
        {
            if (player.transform.position.y <= 4)
            {
                //Debug.Log("Playerが現れた！！");
                myRigid.isKinematic = true;
                myRigid.velocity = Vector2.down * 3;
                myRigid.isKinematic = true;

                Instantiate(bikkurimark, transform.position, transform.rotation);

                kinnsetuSentouBool = false;
            }
        }
        if(collisionEnterLowLowWallBool == true)
        {
            enemyPosition = transform.position;
            myRigid.velocity = Vector2.zero;
            enemyPosition.y += speed;
            transform.position = enemyPosition;
        }
        if(damegeBool == true)//ダメージを受けたら
        {
            collisionEnterLowLowWallBool = false;
            myRigid.velocity = Vector2.zero;
            flashCount += Time.deltaTime;
            
            if(!asidMode)
            DamageFlash();

            if(flashCount >= flashTime)
            {
                collisionEnterLowLowWallBool = true;

                if(!asidMode)
                sprite.color =new Color (255, 255, 255, 255);

                flashCount = 0;
                damegeBool = false;
                damegeIkkaiBool = true;
            }
        }

        if(asidMode)//アシッド状態になったら
        {
            Debug.Log(asidDamage);
            asidTime += Time.deltaTime;
            if(asidCount==0)
            {
                if(asidTime>=1)
                {
                    enemyDamage = asidDamage;
                    damagePosition = transform.position;
                    damageTaxtCanvas.DamageTextPopUp();
                    hp -= asidDamage;
                    asidCount++;
                }
            }
            else if(asidCount==1)
            {
                if(asidTime>=2)
                {
                    enemyDamage = asidDamage;
                    damagePosition = transform.position;
                    damageTaxtCanvas.DamageTextPopUp();
                    hp -= asidDamage;
                    asidCount++;
                }
            }
            else if (asidCount == 2)
            {
                if (asidTime >= 3)
                {
                    enemyDamage = asidDamage;
                    damagePosition = transform.position;
                    damageTaxtCanvas.DamageTextPopUp();
                    hp -= asidDamage;
                    asidCount++;
                }
            }
            else if (asidCount == 3)
            {
                if (asidTime >= 4)
                {
                    enemyDamage = asidDamage;
                    damagePosition = transform.position;
                    damageTaxtCanvas.DamageTextPopUp();
                    hp -= asidDamage;
                    asidCount++;
                }
            }
            else if (asidCount == 4)
            {
                if (asidTime >= 5)
                {
                    enemyDamage = asidDamage;
                    damagePosition = transform.position;
                    damageTaxtCanvas.DamageTextPopUp();
                    hp -= asidDamage;
                    asidCount++;
                }
            }
            else if(asidCount==5)
            {
                asidTime = 0;
                asidCount = 0;
                sprite.color = new Color(255, 255, 255, 255);
                asidMode = false;
            }
            if (hp <= 0)
            {
                deadBool = true;
            }
        }
        if(sekikaMode)//石化状態になったら
        {
            sekikaCountTime += Time.deltaTime;
            if(sekikaCountTime<=sekikaTime)
            {
                enemyKougeki = 0;
                gameObject.GetComponent<SpriteRenderer>().color = sekikaColor;
            }
            else
            {
                sekikaMode = false;
                sekikaCountTime = 0;
                gameObject.GetComponent<SpriteRenderer>().color = new Color(255f,255f,255f);

            }
        }

        if(deadBool)//死んだら
        {
            desuTime += Time.deltaTime;
            if(desuTime >= 0.4f)
            {
                desuPosition = transform.position;
                Instantiate(desuEffect,desuPosition,transform.rotation);
                expDrop();
                itemDrop();
                moneyDrop();

                if (!saikutuBool)
                {
                    KyoukasekiDrop();
                }
                else//採掘初小津
                {
                    for (int a = 0; a <= saikutuData.saikutuKaisuu; a++)
                    {
                        Debug.Log(a+1+ "回目の採掘発動！！");
                        KyoukasekiDrop();
                    }
                }

                KousekiAdd();
                DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KakutokuDataBase>().enemyGekihasuuNo[enemyData.no]++;
                Destroy(gameObject);
            }
        }
        if (player != null)//playerが現れたら
        {
            if (kougekiTimeBool == true)
            {
                enemyKougeki += Time.deltaTime;
                playerDamageHanntei = GameObject.Find("DamageHanni(Clone)");

            }
        }
        if(collisionEnterKougekiWallBool)
        {
            playerDamageA = playerDamageHanntei.GetComponent<PlayerDamage>();
            if(kougekiAnime)
            {
                myRigid.velocity = Vector2.zero;
                kougekiAnime = false;
            }
            
            if(enemyKougeki >= kougekiHinndo)//
            {
                playerDamageA.a = true;
                if (player != null)
                {
                    transform.position = player.transform.position;
                    //myRigid.AddForce(new Vector3(0,5),ForceMode2D.Force);
                }
                enemuKougekiTimeBool = true;
                if (enemyAtackMotion >= 0.25f)
                {
                    enemyKougeki = 0;
                    transform.position = new Vector2(Random.Range(-1, 1.1f), -7.8f);
                    enemuKougekiTimeBool = false;
                    enemyAtackMotion = 0f;
                }
            }
        }
        if(enemuKougekiTimeBool)
        {
            enemyAtackMotion += Time.deltaTime;
        }
        if (player.transform.position.y >= 5.5f)
        {
            enemyPosition = transform.position;
            if (enemyPosition.y <= -5.2f)
            {
                enemyPosition.y += 0.5f;
                transform.position = enemyPosition;
            }
            else if(enemyPosition.y>=-2.0f)
            {
                Debug.Log("位置修正");
                myRigid.velocity = Vector2.zero;
                enemyPosition.y = -2.1f;
                transform.position = enemyPosition;
            }
            else if(enemyPosition.x<=-2.4f)
            {
                myRigid.velocity = Vector2.zero;
                enemyPosition.x = -2.3f;
                transform.position = enemyPosition;
            }
            else if(enemyPosition.x>=2.4f)
            {
                myRigid.velocity = Vector2.zero;
                enemyPosition.x = 2.3f;
                transform.position = enemyPosition;
            }
        }


    }
    private void KyoukasekiDrop()//強化石ドロップメソッド
    {
        kyoukasekiDropPosition = desuPosition - new Vector2(Random.Range(-0.3f, 0.3f), Random.Range(-0.3f, 0.3f));
        if (enemyLv<=30)
        {
            kyoukasekiDropritu = Random.Range(0.00f, 100.00f);
            if (enemyLv <= 20)
            {
                if (kyoukasekiDropritu <= 20)
                {
                    Instantiate(kyoukasekiSyou, kyoukasekiDropPosition, transform.rotation);
                }
            }
            else if (kyoukasekiDropritu <= enemyLv)
            {
                Instantiate(kyoukasekiSyou, kyoukasekiDropPosition, transform.rotation);
            }
        }
        else if(enemyLv <= 60)
        {
            kyoukasekiDropritu = Random.Range(0.00f, 100.00f);
            if(kyoukasekiDropritu<=(100- enemyLv))
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
            kyoukasekisyouDropritu = 100 - enemyLv;
            kyoukasekityuuDropritu = enemyLv - enemyLv / 10;
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
                if (enemyData.reaSyougouDropRitu+playerStatusDataBase.syougouDropRitu >= syougouDropRitu)
                {
                    Instantiate(enemyData.dropSyougou[b]);
                   // Debug.Log("レア称号ドロップ");
                }
            }
            if(b==1)
            {
                if(enemyData.superReaSyougouDropRitu + playerStatusDataBase.syougouDropRitu >= syougouDropRitu)
                {
                    Instantiate(enemyData.dropSyougou[b]);             
                   // Debug.Log("スーパーレア称号ドロップ");

                }
            }
            if(b==2)
            {
                if(enemyData.epikSyougouDropRitu + playerStatusDataBase.syougouDropRitu >= syougouDropRitu)
                {
                    Instantiate(enemyData.dropSyougou[b]);
                   // Debug.Log("エピック称号ドロップ");
                }
            }

            //b==0でレア称号　b==1でスーパーレア称号 b==2でエピックレア称号　b==3以降はアプデで追加？
        }
        //ギフトドロップ
        if (Random.Range(0.00f, 100.00f) <= enemyData.giftDropRitu+playerStatusDataBase.giftHuyoSoubiDropritu)
        {
            //Debug.Log("ギフトドロップ");
            if (enemyLv <= 10)
            {
                //Debug.Log("LV10以下の敵のギフトがドロップ");
                giftBairitu = Random.Range(1, enemyLv + 1);
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyLv <= 20)
            {
                //Debug.Log("LV20以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 40.00f)
                {
                    giftBairitu = Random.Range(11, enemyLv + 1);
                }
                else
                {
                    giftBairitu = Random.Range(1, 11);
                }
                gift.GetComponent<Gift>().giftBairitu = giftBairitu;
                Instantiate(gift);
                giftBairitu = 0;
            }
            else if (enemyLv <= 30)
            {
                //Debug.Log("LV30以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 20.00f)
                {
                    giftBairitu = Random.Range(21, enemyLv + 1);
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
            else if (enemyLv <= 40)
            {
                //Debug.Log("LV40以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 10.00f)
                {
                    giftBairitu = Random.Range(31, enemyLv + 1);
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
            else if (enemyLv <= 50)
            {
                //Debug.Log("LV50以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 10.00f)
                {
                    giftBairitu = Random.Range(41, enemyLv + 1);
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
            else if (enemyLv <= 60)
            {
                //Debug.Log("LV60以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 9.00f)
                {
                    giftBairitu = Random.Range(51, enemyLv + 1);
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
            else if (enemyLv <= 70)
            {
                //Debug.Log("LV70以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 8.00f)
                {
                    giftBairitu = Random.Range(61, enemyLv + 1);
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
            else if (enemyLv <= 80)
            {
                //Debug.Log("LV80以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if(giftHuyoHanni <=3.00f)
                {
                    giftBairitu = Random.Range(71, enemyLv + 1);
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
            else if (enemyLv <= 90)
            {
                //Debug.Log("LV90以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if(giftHuyoHanni <= 2.00f)
                {
                    giftBairitu = Random.Range(81, enemyLv + 1);
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
            else if (enemyLv <= 100)
            {
                //Debug.Log("LV100以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if(giftHuyoHanni<=1.00f)
                {
                    giftBairitu = Random.Range(91, enemyLv + 1);
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
            else if (enemyLv <= 120)
            {
                //Debug.Log("LV120以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 1.00f)
                {
                    giftBairitu = Random.Range(101, enemyLv + 1);
                }
                else if(giftHuyoHanni<=2.5f)
                {
                    giftBairitu = Random.Range(91, 101);
                }
                else if (giftHuyoHanni <= 4.50f)
                {
                    giftBairitu = Random.Range(81, 91);
                }
                else if (giftHuyoHanni <= 7.00f)
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
            else if (enemyLv <= 140)
            {
                //Debug.Log("LV140以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 1.00f)
                {
                    giftBairitu = Random.Range(121, enemyLv + 1);
                }
                else if (giftHuyoHanni <= 2f)
                {
                    giftBairitu = Random.Range(101, 121);
                }
                else if (giftHuyoHanni <= 3.5f)
                {
                    giftBairitu = Random.Range(91, 101);
                }
                else if (giftHuyoHanni <= 5.5)
                {
                    giftBairitu = Random.Range(81, 91);
                }
                else if (giftHuyoHanni <= 7.00f)
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
            else if (enemyLv <= 160)
            {
                //Debug.Log("LV160以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 1.00f)
                {
                    giftBairitu = Random.Range(141, enemyLv + 1);
                }
                else if (giftHuyoHanni <= 2f)
                {
                    giftBairitu = Random.Range(121, 141);
                }
                else if (giftHuyoHanni <= 3.5f)
                {
                    giftBairitu = Random.Range(101, 121);
                }
                else if (giftHuyoHanni <= 5.5f)
                {
                    giftBairitu = Random.Range(91, 101);
                }
                else if (giftHuyoHanni <= 8.00f)
                {
                    giftBairitu = Random.Range(81, 91);
                }
                else if (giftHuyoHanni <= 11.00f)
                {
                    giftBairitu = Random.Range(71, 81);
                }
                else if (giftHuyoHanni <= 14.50f)
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
            else if (enemyLv <= 180)
            {
                //Debug.Log("LV180以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 1.00f)
                {
                    giftBairitu = Random.Range(161, enemyLv + 1);
                }
                else if (giftHuyoHanni <= 2f)
                {
                    giftBairitu = Random.Range(141, 161);
                }
                else if (giftHuyoHanni <= 3.5f)
                {
                    giftBairitu = Random.Range(121, 141);
                }
                else if (giftHuyoHanni <= 5.5f)
                {
                    giftBairitu = Random.Range(101, 121);
                }
                else if (giftHuyoHanni <= 8.00f)
                {
                    giftBairitu = Random.Range(91, 101);
                }
                else if (giftHuyoHanni <= 11.00f)
                {
                    giftBairitu = Random.Range(81, 91);
                }
                else if (giftHuyoHanni <= 14.50f)
                {
                    giftBairitu = Random.Range(71, 81);
                }
                else if (giftHuyoHanni <= 18.50f)
                {
                    giftBairitu = Random.Range(61, 71);
                }
                else if (giftHuyoHanni <= 23.00f)
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
            else if (enemyLv <= 1000)
            {
                //Debug.Log("LV1000以下の敵のギフトがドロップ");
                giftHuyoHanni = Random.Range(0.00f, 100.00f);
                if (giftHuyoHanni <= 1.00f)
                {
                    giftBairitu = Random.Range(181, enemyLv + 1);
                }
                else if (giftHuyoHanni <= 2f)
                {
                    giftBairitu = Random.Range(161, 181);
                }
                else if (giftHuyoHanni <= 3.5f)
                {
                    giftBairitu = Random.Range(141, 161);
                }
                else if (giftHuyoHanni <= 5.5f)
                {
                    giftBairitu = Random.Range(121, 141);
                }
                else if (giftHuyoHanni <= 8.00f)
                {
                    giftBairitu = Random.Range(101, 121);
                }
                else if (giftHuyoHanni <= 11.00f)
                {
                    giftBairitu = Random.Range(91, 101);
                }
                else if (giftHuyoHanni <= 14.50f)
                {
                    giftBairitu = Random.Range(81, 91);
                }
                else if (giftHuyoHanni <= 18.50f)
                {
                    giftBairitu = Random.Range(71, 81);
                }
                else if (giftHuyoHanni <= 23.00f)
                {
                    giftBairitu = Random.Range(61, 71);
                }
                else if (giftHuyoHanni <= 30.00f)
                {
                    giftBairitu = Random.Range(51, 61);
                }
                else if (giftHuyoHanni <= 37.5f)
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
            Debug.Log(itemNo);
            itemPrefab = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<EnemyDataBaseManager>().GetDropItemPrefabDate(itemNo);

            itemController = itemPrefab.GetComponent<ItemController>();
            

            if (itemController.itemStatus.god)
            {
                itemDropRitu = (enemyData.godDropRitu * (1.00f + playerStatusDataBase.godReaDropRitu / 100.00f));
                if (Random.Range(0.0f, 100.0f) <= itemDropRitu)
                {
                    weponBoxScript = weponBoxGod.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxGod, dropPosition, transform.rotation);
                }
            }
           else if (itemController.itemStatus.legendary)
            {
                itemDropRitu = (enemyData.legendaryDropRitu * (1.00f + playerStatusDataBase.legendaryReaDropRitu / 100.00f));
                if (Random.Range(0.0f, 100.0f) <= itemDropRitu)
                {
                    weponBoxScript = weponBoxLegendary.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxLegendary, dropPosition, transform.rotation);
                }
            }
            else if (itemController.itemStatus.epik)
            {
                itemDropRitu = (enemyData.epikDropRitu * (1.00f + playerStatusDataBase.epikReaDropRitu / 100.00f));
                if (Random.Range(0.0f, 100.0f) <= itemDropRitu)
                {
                    weponBoxScript = weponBoxEpik.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxEpik, dropPosition, transform.rotation);
                }
            }
            else if (itemController.itemStatus.superRea)
            {
                itemDropRitu = (enemyData.superReaDropRitu * (1.00f + playerStatusDataBase.superReaDropRitu / 100.00f));
                if (Random.Range(0.0f, 100.0f) <= itemDropRitu)
                {
                    weponBoxScript = weponBoxSuperRea.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxSuperRea, dropPosition, transform.rotation);
                }
            }
            else if (itemController.itemStatus.rea)
            {
                itemDropRitu = (enemyData.reaDropRitu * (1.00f + playerStatusDataBase.reaDropRitu / 100.00f));
                if (Random.Range(0.0f, 100.0f) <= itemDropRitu)
                {
                    weponBoxScript = weponBoxRea.GetComponent<WeponBox>();
                    weponBoxScript.itemPrefab = itemPrefab;
                    Instantiate(weponBoxRea, dropPosition, transform.rotation);
                }
            }
            else if (itemController.itemStatus.nomal)
            {
                itemDropRitu = (enemyData.nomalDropRitu * (1.00f + playerStatusDataBase.nomalDropRitu / 100.00f));
                //Debug.Log(itemDropRitu);
                if (Random.Range(0.0f, 100.0f) <= itemDropRitu)
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
        moneyCount = money;
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
        expControllerScript.exp = enemyExp;
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
            kousekiDataBaseManagerScript.husiToubatuSuu++;
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
    public void OnTriggerEnter2D(Collider2D collision)//ダメージ計算メゾット
    {
        if(collision.gameObject.tag == "FireBall")
        {
            senntouBGMManager.FireBallSEPlay();

            damagePosition = collision.transform.position;
            if (damageEffectBool)
            {
                Instantiate(fireBallDamageEffect, transform.position, transform.rotation);
                saiteihosyouDamage = 1;
                damageBairitu = Random.Range(0.8f, 1.21f);
                damageKeisann = (playerStatus.maryoku/2 - mahouBougyoryoku/3) * damageBairitu;
                //Debug.Log(damageBairitu);
                kaisinn = playerStatus.ennkyoriKaisinnritu - kaisinnTaisei;

                if (kaisinn >= Random.Range(0.0f, 100.0f))//会心だったら
                {
                    damageKeisann = (playerStatus.maryoku * 2 / 2 - mahouBougyoryoku / 3) * damageBairitu;
                    kaisinnBool = true;
                    Debug.Log("会心");
                }
                
                if (damageKeisann < 1)
                {
                    enemyDamage = saiteihosyouDamage;
                    hp -= enemyDamage;
                    damageTextIkkaiBool = true;
                //    Debug.Log(enemyData.enemyName + "に" + saiteihosyouDamage.ToString("N0") + "のダメージを与えた！！");
                }
                else
                {
                    if (enemyData.mazyuu)
                    {
                        tokkouBairitu = 1+((playerStatusDataBase.kousekiMazyuuTokkou + playerStatusDataBase.soubiMazyuuTokkou)/100.00f);
                        //Debug.Log(tokkouBairitu.ToString("F4"));
                    }
                    else if(enemyData.husi)
                    {
                        tokkouBairitu = 1 + ((playerStatusDataBase.kousekiHusiTokkou + playerStatusDataBase.soubiHusiTokkou) / 100.00f);
                    }
                    else if (enemyData.akuma)
                    {
                        tokkouBairitu = 1 + ((playerStatusDataBase.kousekiAkumaTokkou + playerStatusDataBase.soubiHusiTokkou) / 100.00f);
                    }
                    else if (enemyData.mazinn)
                    {
                        tokkouBairitu = 1 + ((playerStatusDataBase.kousekiMazinnTokkou + playerStatusDataBase.soubiMazinnTokkou) / 100.00f);
                    }
                    else if (enemyData.ninngenn)
                    {
                        tokkouBairitu = 1 + ((playerStatusDataBase.kousekiNinngennTokkou + playerStatusDataBase.soubiNinngennTokkou) / 100.00f);
                    }
                    else if (enemyData.ryuu)
                    {
                        tokkouBairitu = 1 + ((playerStatusDataBase.kousekiRyuuTokkou + playerStatusDataBase.soubiRyuuTokkou) / 100.00f);
                    }
                    else if (enemyData.kami)
                    {
                        tokkouBairitu = 1 + ((playerStatusDataBase.kousekiKamiTokkou + playerStatusDataBase.soubiKamiTokkou) / 100.00f);
                    }

                    enemyDamage = Mathf.CeilToInt(damageKeisann * tokkouBairitu);
                    hp -= enemyDamage;

                    //  Debug.Log(enemyData.enemyName + "に" + enemyDamage.ToString("N0") + "のダメージを与えた！！");
                    damageTextIkkaiBool = true;
                }

                if(asidBallBool)//アシッドボール発動
                {
                    if(Random.Range(0,101)<asidBallData.asidBallKakuritu)
                    {
                        asidMode = true;
                        gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 150, 0, 255);
                    }
                }

                if (hp <= 0)
                {

                    deadBool = true;
                }
                damageEffectBool = false;
            }
        }
        if (collision.gameObject.tag == "Srush")
        {
            
            if (atackSetteiBool) atack = GameObject.Find("攻撃範囲Canvas").GetComponent<Atack>();
            if (damegeIkkaiBool)
            {
                damegeIkkaiBool = false;
                nokkubakkuKyori = playerStatus.nokkubakku - nokkubakkuBougyo;
                enemyPosition = transform.position;
                enemyPosition.y -= nokkubakkuKyori;
                transform.position = enemyPosition;

                damagePosition = transform.position;

                kaihi = 100 - (playerStatus.meityuuritu -kaihiritu);

                if(Random.Range(0.0f,100.0f) <= kaihi)
                {
                    Debug.Log(kaihi);
                    kaihiBool = true;
                    if (kaihi >= 95)
                    {
                        if (Random.Range(0.0f, 100.0f) <= 5)
                        {
                            kaihiBool = false;
                        }
                        else
                        {
                            senntouBGMManager.MissSEPlay();
                            missTextBool = true;
                        }
                    }
                    else
                    {
                        senntouBGMManager.MissSEPlay();
                        missTextBool = true;
                    }
                }
                if (kaihiBool == false)
                {
                    senntouBGMManager.PlayerAtackSEPlay();
                    damageBairitu = Random.Range(0.8f, 1.21f);
                    saiteihosyouDamage = 1;
                    //damageKeisann = (playerStatus.kougekiryoku - bougyoryoku) * damageBairitu;
                    kaisinn = playerStatus.kinnkyoriKaisinnritu - kaisinnTaisei;
                    if (kaisinn >= Random.Range(0.0f, 100.0f))
                    {
                        if (kyougiriBool)//強斬りスキルダメージ計算
                        {
                            if (atack.srushKaisuu % kyougiriData.kyougiriHinndo == 0)
                            {
                                damageKeisann = (playerStatus.kougekiryoku/2 * kyougiriData.iryoku / 100 * 2 - bougyoryoku/4) * damageBairitu;
                            }
                            else
                            {
                                damageKeisann = (playerStatus.kougekiryoku/2 * 2 - bougyoryoku/4) * damageBairitu;
                            }
                        }
                        else
                        {
                            damageKeisann = (playerStatus.kougekiryoku/2 * 2 - bougyoryoku/4) * damageBairitu;
                        }
                        kaisinnBool = true;
                    }
                    else
                    {
                        if (kyougiriBool)//強斬りスキルダメージ計算
                        {
                            if (atack.srushKaisuu % kyougiriData.kyougiriHinndo == 0)
                            {
                                damageKeisann = (playerStatus.kougekiryoku/2 * kyougiriData.iryoku / 100  - bougyoryoku/4) * damageBairitu;
                            }
                            else
                            {
                                damageKeisann = (playerStatus.kougekiryoku/2  - bougyoryoku/4) * damageBairitu;
                                Debug.Log(damageKeisann);
                            }
                        }
                        else
                        {
                            damageKeisann = (playerStatus.kougekiryoku/2  - bougyoryoku/4) * damageBairitu;
                        }
                    }
                    if (damageKeisann <= 1)
                    {
                        enemyDamage = saiteihosyouDamage;
                        hp -= enemyDamage;
                        damageTextIkkaiBool = true;
                      //  Debug.Log(enemyData.enemyName + "に" + saiteihosyouDamage.ToString("N0") + "のダメージを与えた！！");
                    }
                    else
                    {
                        if (enemyData.mazyuu)
                        {
                            tokkouBairitu = 1 + playerStatusDataBase.mazyuuTokkou / 100.00f;
                            //Debug.Log(tokkouBairitu.ToString("F4"));
                        }
                        else if (enemyData.husi)
                        {
                            tokkouBairitu = 1 + playerStatusDataBase.husiTokkou / 100.00f;
                        }
                        else if (enemyData.akuma)
                        {
                            tokkouBairitu = 1 + playerStatusDataBase.akumaTokkou/ 100.00f;
                        }
                        else if (enemyData.mazinn)
                        {
                            tokkouBairitu = 1 + playerStatusDataBase.mazinnTokkou/ 100.00f;
                        }
                        else if (enemyData.ninngenn)
                        {
                            tokkouBairitu = 1 + playerStatusDataBase.ninngennTokkou / 100.00f;
                        }
                        else if (enemyData.ryuu)
                        {
                            tokkouBairitu = 1 + playerStatusDataBase.ryuuTokkou / 100.00f;
                        }
                        else if (enemyData.kami)
                        {
                            tokkouBairitu = 1 + playerStatusDataBase.kamiTokkou / 100.00f;
                        }

                        /*if(kyougiriBool)//強斬りスキルダメージ計算
                        {
                            if(atack.srushKaisuu%kyougiriData.kyougiriHinndo==0)
                            {
                                damageKeisann *=  kyougiriData.iryoku/100;
                            }
                        }*/
                       // Debug.Log(damageKeisann);
                        enemyDamage = Mathf.CeilToInt(damageKeisann * tokkouBairitu);
                        hp -= enemyDamage;

                        if (asidSrushBool)//アシッドスラッシュ発動
                        {
                            if (Random.Range(0, 101) < asidSrushData.asidSrushKakuritu)
                            {
                                asidMode = true;
                                gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 150, 0, 255);
                            }
                        }
                        if (kyuusyuuBool)//吸収スキル
                        {
                            kyuusyuuSuuti = Mathf.CeilToInt(enemyDamage * (kyuusyuuData.kyuusyuuWariai / 100.0f));
                            soubiSkillDatabase.kaihukuHpText.GetComponent<Text>().text = kyuusyuuSuuti.ToString("N0");

                            playerStatus.hp += kyuusyuuSuuti;

                            atack.KaihukuTextInstantiate(kyuusyuuSuuti);//Atackスクリプトのメソッドを使用する。

                            if (playerStatus.maxHp < playerStatus.hp) playerStatus.hp = playerStatus.maxHp;
                        }

                        damageTextIkkaiBool = true;
                        //Debug.Log(enemyData.enemyName + "に" + enemyDamage.ToString("N0") + "のダメージを与えた！！");
                    }
                }
                damegeBool = true;
                if (hp <= 0)
                {
                    resultSceneManager.weponZyukurenndo++;
                    deadBool = true;
                }
                kaihiBool = false;
            }

        }
        if (collision.gameObject.tag == "MakennotikaraHi")
        {
            senntouBGMManager.FireBallSEPlay();

            damagePosition = collision.transform.position;

            Instantiate(fireBallDamageEffect, transform.position, transform.rotation);
            saiteihosyouDamage = 1;
            damageBairitu = Random.Range(0.8f, 1.21f);
            damageKeisann = (playerStatus.maryoku / 2 - mahouBougyoryoku / 3) * damageBairitu;
            //Debug.Log(damageBairitu);
            kaisinn = playerStatus.ennkyoriKaisinnritu - kaisinnTaisei;
            if (kaisinn >= Random.Range(0.0f, 100.0f))//会心だったら
            {
                damageKeisann = (playerStatus.maryoku * 2 / 2 - mahouBougyoryoku / 3) * damageBairitu;
                kaisinnBool = true;
            }
            if (damageKeisann < 1)
            {
                enemyDamage = saiteihosyouDamage;
                hp -= enemyDamage;
                damageTextIkkaiBool = true;
                //    Debug.Log(enemyData.enemyName + "に" + saiteihosyouDamage.ToString("N0") + "のダメージを与えた！！");
            }
            else
            {
                if (enemyData.mazyuu)
                {
                    tokkouBairitu = 1 + ((playerStatusDataBase.kousekiMazyuuTokkou + playerStatusDataBase.soubiMazyuuTokkou) / 100.00f);
                    //Debug.Log(tokkouBairitu.ToString("F4"));
                }
                else if (enemyData.husi)
                {
                    tokkouBairitu = 1 + ((playerStatusDataBase.kousekiHusiTokkou + playerStatusDataBase.soubiHusiTokkou) / 100.00f);
                }
                else if (enemyData.akuma)
                {
                    tokkouBairitu = 1 + ((playerStatusDataBase.kousekiAkumaTokkou + playerStatusDataBase.soubiHusiTokkou) / 100.00f);
                }
                else if (enemyData.mazinn)
                {
                    tokkouBairitu = 1 + ((playerStatusDataBase.kousekiMazinnTokkou + playerStatusDataBase.soubiMazinnTokkou) / 100.00f);
                }
                else if (enemyData.ninngenn)
                {
                    tokkouBairitu = 1 + ((playerStatusDataBase.kousekiNinngennTokkou + playerStatusDataBase.soubiNinngennTokkou) / 100.00f);
                }
                else if (enemyData.ryuu)
                {
                    tokkouBairitu = 1 + ((playerStatusDataBase.kousekiRyuuTokkou + playerStatusDataBase.soubiRyuuTokkou) / 100.00f);
                }
                else if (enemyData.kami)
                {
                    tokkouBairitu = 1 + ((playerStatusDataBase.kousekiKamiTokkou + playerStatusDataBase.soubiKamiTokkou) / 100.00f);
                }

                enemyDamage = Mathf.CeilToInt(damageKeisann * tokkouBairitu);
                hp -= enemyDamage;

                //  Debug.Log(enemyData.enemyName + "に" + enemyDamage.ToString("N0") + "のダメージを与えた！！");
                damageTextIkkaiBool = true;
            }

            if (asidBallBool)//アシッドボール発動
            {
                if (Random.Range(0, 101) < asidBallData.asidBallKakuritu)
                {
                    asidMode = true;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 150, 0, 255);
                }
            }

            if (hp <= 0)
            {

                deadBool = true;
            }
            damageEffectBool = false;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "LowLowWall")
        {
            myRigid.isKinematic  = false;
            collisionEnterLowLowWallBool = true;
            kougekiTimeBool = true;
        }

    }
    private void SoubiSkillSettei()
    {
        soubiSkillDatabase = dataBaseManager.GetComponent<SoubiSkillDatabase>();
        for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
        {
            if (soubiSkillDatabase.skillNumber[a] == 3)//採掘Lv.1
            {
                saikutuBool = true;
                saikutuData = soubiSkillDatabase.GetSoubiSkillData(3);
            }
            if (soubiSkillDatabase.skillNumber[a] == 5)//吸収Lv.1
            {
                kyuusyuuBool = true;
                kyuusyuuData = soubiSkillDatabase.GetSoubiSkillData(5);
            }
            if (soubiSkillDatabase.skillNumber[a] == 6)//強斬りLv.1
            {
                kyougiriBool = true;
                kyougiriData = soubiSkillDatabase.GetSoubiSkillData(6);
            }
            if (soubiSkillDatabase.skillNumber[a] == 7) //アシッドボールLv1
            {
                asidBallBool = true;
                asidBallData = soubiSkillDatabase.GetSoubiSkillData(7);
                asidDamage = Mathf.CeilToInt(maxHp * 0.06f);
            }
            if(soubiSkillDatabase.skillNumber[a]==8)//アシッドスラッシュLv1
            {
                asidSrushBool = true;
                asidSrushData = soubiSkillDatabase.GetSoubiSkillData(8);
                asidDamage = Mathf.CeilToInt(maxHp * 0.06f);
            }
            if (soubiSkillDatabase.skillNumber[a] == 12)//強斬りLv.2
            {
                kyougiriBool = true;
                kyougiriData = soubiSkillDatabase.GetSoubiSkillData(12);
            }
            if (soubiSkillDatabase.skillNumber[a] == 13)//採掘Lv.2
            {
                saikutuBool = true;
                saikutuData = soubiSkillDatabase.GetSoubiSkillData(13);
            }
            if (soubiSkillDatabase.skillNumber[a] == 15)//吸収Lv.2
            {
                kyuusyuuBool = true;
                kyuusyuuData = soubiSkillDatabase.GetSoubiSkillData(15);
            }
        }
    }
}

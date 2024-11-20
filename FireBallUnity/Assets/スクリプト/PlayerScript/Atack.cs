using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atack : MonoBehaviour
{
    public GameObject player;
    private PlayerStatus playerStatus;
    private GameObject mainCameraCanvas;

    public GameObject srushEffect;

    public float startSrushTime;
    public float endSrushTime;

    public Vector3 atackPosition;

    private Animator anim;
    private int attack;

    private bool startPlayerKougeki = true;
    private bool endPlayerKougeki = true;
    public bool startHukusuuSrush;

    private GameObject dataBaseManger;

    [Header("武器の番号。インスペクターで指定する")]
    public int weponNo;
    [Header("武器の情報。番号で検索して、スクリプタブル・オブジェクトから取得する")]
    public WeponDataList.WeponData weponData;

    private SoubiSkillDatabase soubiSkillDatabase;

    public int srushKaisuu=0;//スラッシュ回数（攻撃〇回ごとにスキル発動等に使用する）

    private bool rennzokugiriBool = false;
    private bool hokyuuBool = false;
    private bool kyougiriBool = false;
    private bool makennnoTikaraBool = false;
    private SoubiSkillDataList.SoubiSkillData rennzokugiriData;
    private SoubiSkillDataList.SoubiSkillData hokyuuSkillData;
    private SoubiSkillDataList.SoubiSkillData kyougiriSkillData;
    private SoubiSkillDataList.SoubiSkillData makennnoTikaraHiData;

    public AudioSource audioSource;
    public AudioClip srushClip;
    public AudioClip kougekiSkillClip;
    public AudioClip kaihukuClip;
    public AudioClip suburiClip;

    public bool endSrush=false;

    public GameObject makennnotikaraEffect;
    void Start()
    {

        playerStatus = player.GetComponent<PlayerStatus>();
        mainCameraCanvas = GameObject.Find("MainCameraCanvas");
        anim = player.GetComponent<Animator>();
        weponNo = playerStatus.weponNo;

        dataBaseManger = DontDestroyOnloadDataBaseManager.DataBaseManager;
        weponData = dataBaseManger.GetComponent<WeponDateBaseManager>().GetWeponData(weponNo);

        attack = 0;
        startSrushTime = 0;
        SoubiSkillSettei();

        attack = anim.GetInteger("Attack");
    }
    private void SoubiSkillSettei()
    {
        soubiSkillDatabase = dataBaseManger.GetComponent<SoubiSkillDatabase>();
        for (int a=0; a<soubiSkillDatabase.skillNumber.Length;a++)
        {
            if (soubiSkillDatabase.skillNumber[a] == 1)//連続斬りLv.1
            {
                rennzokugiriBool = true;
                rennzokugiriData = soubiSkillDatabase.GetSoubiSkillData(1);

            }
            if (soubiSkillDatabase.skillNumber[a] == 2)//補給Lv.1
            {
                hokyuuBool = true;
                hokyuuSkillData = soubiSkillDatabase.GetSoubiSkillData(2);
            }
            if (soubiSkillDatabase.skillNumber[a] == 6)//強斬りLv.1エフェクト用
            {
                kyougiriBool = true;
                kyougiriSkillData = soubiSkillDatabase.GetSoubiSkillData(6);
            }
            if (soubiSkillDatabase.skillNumber[a] == 9)//魔剣の力[火]Lv.1エフェクト用
            {
                makennnoTikaraBool = true;
                makennnoTikaraHiData = soubiSkillDatabase.GetSoubiSkillData(9);
            }
            if (soubiSkillDatabase.skillNumber[a] == 12)//強斬りLv.2エフェクト用
            {
                kyougiriBool = true;
                kyougiriSkillData = soubiSkillDatabase.GetSoubiSkillData(12);
            }
            if (soubiSkillDatabase.skillNumber[a] == 16)//補給Lv.2
            {
                hokyuuBool = true;
                hokyuuSkillData = soubiSkillDatabase.GetSoubiSkillData(16);
            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y <= 4)//playerが現れたら
        {
            if (startPlayerKougeki)
                startSrushTime += Time.deltaTime;
            if (endPlayerKougeki)
                endSrushTime += Time.deltaTime;

            if (startSrushTime >= playerStatus.kougekiHinndo)
                 playerAtack();

            if (startHukusuuSrush)//連続斬り
            {
                if (rennzokugiriBool)
                {
                    RenzokuGiri();
                }
            }

            if (transform.position.y <= -6f)
                playerAtackTime();
        }
    }

    private void playerAtackTime()//アタック時のポジションを元に戻すメソッド
    {
        if (endSrush)
        {
            if (!startHukusuuSrush)
            {
                attack -= 2;
                anim.SetInteger("Attack", attack);

                atackPosition.y += 0.3f;
                player.transform.position = atackPosition;
            }
        }
            
    }
    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerAtack();
        }
    }*/

    private void playerAtack()//アタック時のエフェクトの表示や前方移動のメソッド
    {
        attack += 2;
        anim.SetInteger("Attack", attack);

        atackPosition = player.transform.position;
        atackPosition.y -= 0.3f;
        player.transform.position = atackPosition;
        srushKaisuu++;
        audioSource.PlayOneShot(suburiClip);
        endSrush = false;
        srushEffect = Instantiate(weponData.srushEffect, transform.position, transform.rotation, gameObject.transform);

        startPlayerKougeki = false;
        endPlayerKougeki = false;
        startSrushTime = 0;
        endSrushTime = 0;

        if (rennzokugiriBool)//連続斬り処理スタート
        {
            if (rennzokugiriData.rennzokugiriKaisuu == 2)//スラッシュ回数が二回の場合
            {
                if (Random.Range(0.0f, 100.0f) <= rennzokugiriData.rennzokugiriKakuritu) startHukusuuSrush = true;
                else
                {
                    startPlayerKougeki = true;
                    endPlayerKougeki = true;
                }
            }
        }
        else
        {
            startPlayerKougeki = true;
            endPlayerKougeki = true;
        }

        if (hokyuuBool)//補給発動
        {
            if (Random.Range(0.0f, 100.0f) <= hokyuuSkillData.hokyuuKakuritu)
            {
                Hokyuu();
                Debug.Log("補給発動");
            }
        }
        if (kyougiriBool)//強斬り
        {
            Debug.Log(srushKaisuu % kyougiriSkillData.kyougiriHinndo);
            if (srushKaisuu % kyougiriSkillData.kyougiriHinndo == 0)
            {
                KougekiTextInstantiate();
                srushEffect.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        if(makennnoTikaraBool)//魔剣の力[火]Lv.1
        {
            if (Random.Range(0, 100) <= makennnoTikaraHiData.makennnotikaraKakuritu)
            {
                for (int a = 0; a <= makennnoTikaraHiData.makennnotikaraHassyasuu; a++)
                {
                    Instantiate(makennnotikaraEffect,new Vector2(player.transform.position.x,player.transform.position.y-1.2f),transform.rotation);
                }
                KougekiTextInstantiate();
            }
        }
    }
    private void RenzokuGiri()
    {

        if (endSrush)
        {
            Debug.Log("連続斬りLv.1発動");
            KougekiTextInstantiate();
            endSrush = false;
            srushEffect = Instantiate(weponData.srushEffect, transform.position, transform.rotation, gameObject.transform);
            audioSource.PlayOneShot(suburiClip);
            srushEffect.transform.GetChild(0).gameObject.SetActive(true);
            startPlayerKougeki = true;
            endPlayerKougeki = true;
            startHukusuuSrush = false;
        }
    }
    private void Hokyuu()
    {
        int kaihukuHp =Mathf.FloorToInt(playerStatus.maxHp * (hokyuuSkillData.hokyuuKaihukuWariai*0.01f));
        KaihukuTextInstantiate(kaihukuHp);
        playerStatus.hp += kaihukuHp;
        if (playerStatus.maxHp < playerStatus.hp) playerStatus.hp = playerStatus.maxHp;
    }
    public void KougekiTextInstantiate()
    {
        audioSource.PlayOneShot(kougekiSkillClip);
        Instantiate(soubiSkillDatabase.kougekiSkillText, new Vector3(0, -5f), transform.rotation, mainCameraCanvas.gameObject.transform);
    }
    public void KaihukuTextInstantiate(int kaihukuHp)
    {
        audioSource.PlayOneShot(kaihukuClip);
        soubiSkillDatabase.kaihukuHpText.GetComponent<Text>().text = kaihukuHp.ToString("N0");
        Instantiate(soubiSkillDatabase.kaihukuHpText, new Vector3(Random.Range(-0.5f,0.5f), -5f), transform.rotation, mainCameraCanvas.gameObject.transform);
    }
}


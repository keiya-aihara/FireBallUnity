using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private GameObject dataBaseManager;
    public PlayerStatusDataBase playerStatusDataBase;
    public EXPManager expManagerScript;
    public BallGenerator ballGenerator;
    public GameObject firstStageCanvas;
    private int lv;

    public int maxHp;
    public int hp;
    public int maxMp;
    public int mp;
    public int fireBallCost;
    public int kougekiryoku;
    public float kinnkyoriKaisinnritu;
    public int maryoku;
    public float ennkyoriKaisinnritu;
    public int bougyoryoku;
    public float kaisinntaisei;
    public float meityuuritu;
    public float kaihiritu;
    public float nokkubakku;
    //public float destroyTime;
    public float srushSpeed;
    public float kougekiHinndo;
    public float kougekiHanni;

    public int weponNo;

    public FireBallDestroy fireSpireScript;
    public FireBallDestroy rapidFireScript;
    public FireBallDestroy fireBomScript;

    public GameObject fireWallSyou;
    public GameObject fireWallDai;
    private Vector2 fireWall1Vector = new Vector2(0, 2.732f);
    private Vector2 fireWall2Vector = new Vector2(-1.548f, 2.732f);
    private Vector2 fireWall3Vector = new Vector2(1.548f, 2.732f);
    private int fireWallPosition;

    public GameObject comboCounterGameObject;
    public ComboCounter comboCounter;
    public float comboBairitu;

    public int tazyuuEisyouSaisyouHassyasuu;
    public int tazyuuEisyouSaidaiHassyasuu;

    public Rigidbody2D fireBallGravity;
    public Rigidbody2D fireSpireGravity;
    public Rigidbody2D rapidFireGravity;
    public Rigidbody2D fireBomGravity;

    public float rennsyaSpeed;

    private SoubiSkillDatabase soubiSkillDatabase;

    private bool maryokuBousouBool = false;
    private SoubiSkillDataList.SoubiSkillData maryokuBousouData;
    private int nowMp;
    private int modoruMaryoku;
    private bool hatudou=false;

    void Start()
    {
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        playerStatusDataBase = dataBaseManager.GetComponent<PlayerStatusDataBase>();
        expManagerScript = dataBaseManager.GetComponent<EXPManager>();
        lv = expManagerScript.lv;

        weponNo = playerStatusDataBase.kinnkyoriWeponNo;

        maxHp = playerStatusDataBase.maxHp;
        maxMp = playerStatusDataBase.maxMp;
        fireBallCost = playerStatusDataBase.fireBallCost;
        kougekiryoku = playerStatusDataBase.kougekiryoku;
        kinnkyoriKaisinnritu = playerStatusDataBase.kinnkyoriKaisinnritu;
        maryoku = playerStatusDataBase.maryoku;
        ennkyoriKaisinnritu = playerStatusDataBase.ennkyoriKaisinnritu;
        bougyoryoku = playerStatusDataBase.bougyoryoku;
        kaisinntaisei = playerStatusDataBase.kaisinnTaisei;
        meityuuritu = playerStatusDataBase.meityuuritu;
        kaihiritu = playerStatusDataBase.kaihiritu;

        nokkubakku = playerStatusDataBase.nokkubakku;
        //destroyTime = playerStatusDataBase.destroyTime;
        srushSpeed = playerStatusDataBase.srushSpeed;
        kougekiHinndo = playerStatusDataBase.kougekiHinndo;
        kougekiHanni = playerStatusDataBase.kougekiHanni;

        hp = maxHp;
        mp = maxMp;

        SoubiSkillSettei();
        FireSpireBall();
        RapidFireBall();
        BomFireBall();
        FireWall();
        FireCombo();
        Tazyuueisyou();
        FireGravity();
        EisyouTannsyuku();
    }

    // Update is called once per frame
    void Update()
    {
        if(lv < expManagerScript.lv)
        {
            maxHp = playerStatusDataBase.maxHp;
            maxMp = playerStatusDataBase.maxMp;
            fireBallCost = playerStatusDataBase.fireBallCost;
            kougekiryoku = playerStatusDataBase.kougekiryoku;
            kinnkyoriKaisinnritu = playerStatusDataBase.kinnkyoriKaisinnritu;
            maryoku = playerStatusDataBase.maryoku;
            ennkyoriKaisinnritu = playerStatusDataBase.ennkyoriKaisinnritu;
            bougyoryoku = playerStatusDataBase.bougyoryoku;
            meityuuritu = playerStatusDataBase.meityuuritu;
            kaihiritu = playerStatusDataBase.kaihiritu;

            kougekiryoku = Mathf.CeilToInt(kougekiryoku * (1 + (comboCounter.comboBairitu / 100.00f)));
        }

        if(maryokuBousouBool)
        {
            
            
            if(nowMp>mp)
            {
                if(hatudou)
                {
                    hatudou = false;
                    maryoku = modoruMaryoku;
                }
                if (hatudou == false)
                {
                    if (Random.Range(0, 100) <= maryokuBousouData.maryokuBousoukakuritu)
                    {
                        hatudou = true;
                        modoruMaryoku = maryoku;
                        maryoku = maryoku * 2;
                    }
                }
            }
            nowMp = mp;
        }
    }

    private void SoubiSkillSettei()
    {
        soubiSkillDatabase = dataBaseManager.GetComponent<SoubiSkillDatabase>();
        for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
        {
            if (soubiSkillDatabase.skillNumber[a] == 14)//魔力暴走Lv.1
            {
                maryokuBousouBool = true;
                maryokuBousouData = soubiSkillDatabase.GetSoubiSkillData(14);
            }
            
        }

    }
    public void FireWall()
    {
        if (playerStatusDataBase.firewallLv >= 1)
        {
            if (playerStatusDataBase.firewallLv == 1)
            {
                fireWallPosition = Random.Range(0, 3);
                if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                else if (fireWallPosition == 1) Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                else if (fireWallPosition == 2) Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
            }
            else if (playerStatusDataBase.firewallLv == 2)
            {
                fireWallPosition = Random.Range(0, 3);
                if (fireWallPosition == 0)
                {
                    Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 4);
                    if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                    else if (fireWallPosition == 1) Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                    else return;
                }
                else if (fireWallPosition == 1)
                {
                    Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 4);
                    if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    else if (fireWallPosition == 1) Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                    else return;
                }
                else if (fireWallPosition == 2)
                {
                    Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 4);
                    if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    else if (fireWallPosition == 1) Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                    else return;
                }
            }
            else if (playerStatusDataBase.firewallLv == 3)
            {
                fireWallPosition = Random.Range(0, 3);
                if (fireWallPosition == 0)
                {
                    Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 2);
                    if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                    else if (fireWallPosition == 1) Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                }
                else if (fireWallPosition == 1)
                {
                    Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 2);
                    if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    else if (fireWallPosition == 1) Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                }
                else if (fireWallPosition == 2)
                {
                    Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 2);
                    if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    else if (fireWallPosition == 1) Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                }
            }
            else if (playerStatusDataBase.firewallLv == 4)
            {
                fireWallPosition = Random.Range(0, 3);
                if (fireWallPosition == 0)
                {
                    Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 2);
                    if (fireWallPosition == 0)
                    {
                        Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                        fireWallPosition = Random.Range(0, 2);
                        if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                    }
                    else if (fireWallPosition == 1)
                    {
                        Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                        fireWallPosition = Random.Range(0, 2);
                        if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                    }
                }
                else if (fireWallPosition == 1)
                {
                    Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 2);
                    if (fireWallPosition == 0)
                    {
                        Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                        fireWallPosition = Random.Range(0, 2);
                        if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                    }
                    else if (fireWallPosition == 1)
                    {
                        Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                        fireWallPosition = Random.Range(0, 2);
                        if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    }
                }
                else if (fireWallPosition == 2)
                {
                    Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
                    fireWallPosition = Random.Range(0, 2);
                    if (fireWallPosition == 0)
                    {
                        Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                        fireWallPosition = Random.Range(0, 2);
                        if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                    }
                    else if (fireWallPosition == 1)
                    {
                        Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                        fireWallPosition = Random.Range(0, 2);
                        if (fireWallPosition == 0) Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                    }
                }
            }
            else if (playerStatusDataBase.firewallLv == 5)
            {
                Instantiate(fireWallSyou, fireWall1Vector, transform.rotation);
                Instantiate(fireWallSyou, fireWall2Vector, transform.rotation);
                Instantiate(fireWallSyou, fireWall3Vector, transform.rotation);
            }
        }
    }
    public void FireCombo()
    {
        if(playerStatusDataBase.fireComboLv>=1)
        {
            if(playerStatusDataBase.fireComboLv==1)
            {
                comboBairitu = 0.1f;
            }
            else if(playerStatusDataBase.fireComboLv==2)
            {
                comboBairitu = 0.2f;
            }
            else if(playerStatusDataBase.fireComboLv==3)
            {
                comboBairitu = 0.3f;
            }
            else if (playerStatusDataBase.fireComboLv == 4)
            {
                comboBairitu = 0.4f;
            }
            else if (playerStatusDataBase.fireComboLv == 5)
            {
                comboBairitu = 0.5f;
            }
        }
    }
    public void Tazyuueisyou()
    {
        if(playerStatusDataBase.tazyuuEisyouLv>=1)
        {
            if(playerStatusDataBase.tazyuuEisyouLv==1)
            {
                tazyuuEisyouSaisyouHassyasuu = 1;
                tazyuuEisyouSaidaiHassyasuu = 2;
            }
            else if(playerStatusDataBase.tazyuuEisyouLv==2)
            {
                tazyuuEisyouSaisyouHassyasuu = 1;
                tazyuuEisyouSaidaiHassyasuu = 3;
            }
        }
        else
        {
            tazyuuEisyouSaisyouHassyasuu = 1;
            tazyuuEisyouSaidaiHassyasuu = 1;
        }
    }
    public void FireGravity()
    {
        if(playerStatusDataBase.fireGrabityLv>=1)
        {
            if(playerStatusDataBase.fireGrabityLv==1)
            {
                fireBallGravity.gravityScale = 1.5f;
                fireSpireGravity.gravityScale = 1.5f;
                rapidFireGravity.gravityScale = 1.5f;
                fireBomGravity.gravityScale = 1.5f;
            }
            else if(playerStatusDataBase.fireGrabityLv==2)
            {
                fireBallGravity.gravityScale = 2;
                fireSpireGravity.gravityScale = 2;
                //rapidFireGravity.gravityScale = 2;
                fireBomGravity.gravityScale = 2;
            }
            else if(playerStatusDataBase.fireGrabityLv==3)
            {
                fireBallGravity.gravityScale = 2.6f;
                fireSpireGravity.gravityScale = 2.6f;
                //rapidFireGravity.gravityScale = 2.6f;
                fireBomGravity.gravityScale = 2.6f;
            }
            else if (playerStatusDataBase.fireGrabityLv == 4)
            {
                fireBallGravity.gravityScale = 3.2f;
                fireSpireGravity.gravityScale = 3.2f;
                //rapidFireGravity.gravityScale = 3.2f;
                fireBomGravity.gravityScale = 3.2f;
            }
            else if (playerStatusDataBase.fireGrabityLv == 5)
            {
                fireBallGravity.gravityScale = 4;
                fireSpireGravity.gravityScale = 4;
                //rapidFireGravity.gravityScale = 4;
                fireBomGravity.gravityScale = 4;
            }
        }
        else
        {
            fireBallGravity.gravityScale = 1;
            fireSpireGravity.gravityScale = 1;
            rapidFireGravity.gravityScale = 1;
            fireBomGravity.gravityScale = 1;
        }
    }
    public void EisyouTannsyuku()
    {
        if (playerStatusDataBase.eisyouTannsyukuLv == 1)
        {
            rennsyaSpeed = 0.4f;
        }
        else rennsyaSpeed = 0.6f;
        if (playerStatusDataBase.mueisyouLv == 1)
        {
            rennsyaSpeed = 0.2f;
        }
        ballGenerator.rennsyaSpeed = rennsyaSpeed;
    }
    public void FireSpireBall()
    {
        if (playerStatusDataBase.fireSpireLv >= 1)
        {
            if (playerStatusDataBase.fireSpireLv == 1)
            {
                fireSpireScript.kanntuuKakuritu = 100;
                fireSpireScript.kanntuuGennsuiritu = 50;
            }
            else if (playerStatusDataBase.fireSpireLv == 2)
            {
                fireSpireScript.kanntuuKakuritu = 110;
                fireSpireScript.kanntuuGennsuiritu = 40;
            }
            else if (playerStatusDataBase.fireSpireLv == 3)
            {
                fireSpireScript.kanntuuKakuritu = 120;
                fireSpireScript.kanntuuGennsuiritu = 30;
            }
            else if (playerStatusDataBase.fireSpireLv == 4)
            {
                fireSpireScript.kanntuuKakuritu = 130;
                fireSpireScript.kanntuuGennsuiritu = 25;
            }
            else if (playerStatusDataBase.fireSpireLv == 5)
            {
                fireSpireScript.kanntuuKakuritu = 140;
                fireSpireScript.kanntuuGennsuiritu = 20;
            }
        }
        else fireSpireScript.kanntuuKakuritu = 0;
    }
    public void RapidFireBall()
    {
        if (playerStatusDataBase.rapidGireLv >= 1)
        {
            if (playerStatusDataBase.rapidGireLv == 1)
            {
                rapidFireScript.rapidKakuritu = 100;
                rapidFireScript.rapidGennsuiritu = 50;
            }
            else if (playerStatusDataBase.rapidGireLv == 2)
            {
                rapidFireScript.rapidKakuritu = 110;
                rapidFireScript.rapidGennsuiritu = 40;
            }
            else if (playerStatusDataBase.rapidGireLv == 3)
            {
                rapidFireScript.rapidKakuritu = 120;
                rapidFireScript.rapidGennsuiritu = 30;
            }
            else if (playerStatusDataBase.rapidGireLv == 4)
            {
                rapidFireScript.rapidKakuritu = 130;
                rapidFireScript.rapidGennsuiritu = 25;
            }
            else if (playerStatusDataBase.rapidGireLv == 5)
            {
                rapidFireScript.rapidKakuritu = 140;
                rapidFireScript.rapidGennsuiritu = 20;
            }
        }
        else rapidFireScript.rapidKakuritu = 0;
    }
    public void BomFireBall()
    {
        if (playerStatusDataBase.fireBomLv >= 1)
        {
            if (playerStatusDataBase.fireBomLv == 1)
            {
                fireBomScript.bakuhatuKakuritu = 5;
                fireBomScript.bakuhatuGennsuiBairitu = 0.5f;
            }
            else if (playerStatusDataBase.fireBomLv == 2)
            {
                fireBomScript.bakuhatuKakuritu = 10;
                fireBomScript.bakuhatuGennsuiBairitu = 0.6f;
            }
            else if (playerStatusDataBase.fireBomLv == 3)
            {
                fireBomScript.bakuhatuKakuritu = 15;
                fireBomScript.bakuhatuGennsuiBairitu = 0.7f;
            }
            else if (playerStatusDataBase.fireBomLv == 4)
            {
                fireBomScript.bakuhatuKakuritu = 20;
                fireBomScript.bakuhatuGennsuiBairitu = 0.75f;
            }
            else if (playerStatusDataBase.fireBomLv == 5)
            {
                fireBomScript.bakuhatuKakuritu = 25;
                fireBomScript.bakuhatuGennsuiBairitu = 0.8f;
            }
        }
        else fireBomScript.bakuhatuKakuritu = 0;
    }
}

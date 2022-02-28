using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private GameObject dataBaseManager;
    public PlayerStatusDataBase playerStatusDataBase;
    public EXPManager expManagerScript;
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
    public float meityuuritu;
    public float kaihiritu;
    public float nokkubakku;
    public float destroyTime;
    public float srushSpeed;
    public float kougekiHinndo;
    public float kougekiHanni;

    public int weponNo;

    void Start()
    {
        dataBaseManager = GameObject.Find("DataBaseManager");
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
        meityuuritu = playerStatusDataBase.meityuuritu;
        kaihiritu = playerStatusDataBase.kaihiritu;

        nokkubakku = playerStatusDataBase.nokkubakku;
        destroyTime = playerStatusDataBase.destroyTime;
        srushSpeed = playerStatusDataBase.srushSpeed;
        kougekiHinndo = playerStatusDataBase.kougekiHinndo;
        kougekiHanni = playerStatusDataBase.kougekiHanni;

        hp = maxHp;
        mp = maxMp;
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

            hp = maxHp;
            mp = maxMp;
        }
    }

}

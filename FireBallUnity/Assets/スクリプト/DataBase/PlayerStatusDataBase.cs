using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatusDataBase : MonoBehaviour
{
    public WeponDateBaseManager weponDateBaseManager;
    public EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    public YoroiDataBaseManager yoroiDataBaseManager;
    public SonotaDataBaseManager sonotaDataBaseManager;
    [Space(1)]
    public EXPManager expManagerScript;
    [Space(1)]
    public int kinnkyoriWeponNo = 1 ;
    public int ennkyoriWeponNo = 1;
    public int yoroiNo = 1;
    public int sonota1No = 1;
    public int sonota2No = 2;
    [Space(1)]
    public int statusMaxHp = 10;
    public int statusMaxMp = 10;
    public int statusFireBallCost = 3;
    public int statusKougekiryoku = 1;
    public float statusKinnkyoriKaisinnritu = 0;
    public int statusMaryoku = 1;
    public float statusEnnkyoriKaisinnritu = 0;
    public int statusBougyoryoku = 1;
    public float statusKaisinnTaisei = 0;
    public float statusMeityuuritu = 100;
    public float statusKaihiritu;
    [Space(1)]
    public int soubiMaxHp;
    public int soubiMaxMp;
    public int soubiFireBallCost;
    public int soubiKougekiryoku;
    public float soubiKinnkyoriKaisinnritu;
    public int soubiMaryoku;
    public float soubiEnnkyoriKaisinnritu;
    public int soubiBougyoryoiku;
    public float soubiKaisinnTisei;
    public float soubiMeityuuritu;
    public float soubiKaihiritu;

    public float soubiNokkubakku;
    public float soubiKougekiHinndo;
    public float soubiKougekiHanni;

    public float soubiDestroyTime;
    public float soubiSrushSpeed;
    [Space(1)]
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
    public float kaisinnTaisei;
    public float meityuuritu;
    public float kaihiritu;

    public float srushSpeed;
    public float kougekiHinndo;
    public float kougekiHanni;

    public float nokkubakku;
    public float destroyTime;
    [Space(1)]
    [Header("武器の情報。番号で検索して、スクリプタブル・オブジェクトから取得する")]
    public WeponDataList.WeponData kinnkyoriWeponData;
    public WeponDataList.WeponData ennkyoriWeponData;
    public WeponDataList.WeponData yoroiData;
    public WeponDataList.WeponData sonota1Data;
    public WeponDataList.WeponData sonota2Data;


    void Start()
    {
        StatusUpdate();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StatusUpdate()
    {
        kinnkyoriWeponData = weponDateBaseManager.GetWeponData(kinnkyoriWeponNo);
        ennkyoriWeponData = ennkyoriWeponDataBaseManager.GetWeponData(ennkyoriWeponNo);
        yoroiData = yoroiDataBaseManager.GetWeponData(yoroiNo);
        sonota1Data = sonotaDataBaseManager.GetWeponData(sonota1No);
        sonota2Data = sonotaDataBaseManager.GetWeponData(sonota2No);

        soubiMaxHp = kinnkyoriWeponData.kyoukagoMaxHp + ennkyoriWeponData.kyoukagoMaxHp + yoroiData.kyoukagoMaxHp + sonota1Data.maxHp + sonota2Data.kyoukagoMaxHp;
        soubiMaxMp = kinnkyoriWeponData.kyoukagoMaxMp + ennkyoriWeponData.kyoukagoMaxMp + yoroiData.maxMp + sonota1Data.kyoukagoMaxMp + sonota2Data.kyoukagoMaxMp;
        soubiFireBallCost = kinnkyoriWeponData.fireBallCost + ennkyoriWeponData.fireBallCost + yoroiData.fireBallCost + sonota1Data.fireBallCost + sonota2Data.fireBallCost;
        soubiKougekiryoku = kinnkyoriWeponData.kyoukagoKougekiryoku + ennkyoriWeponData.kyoukagoKougekiryoku + yoroiData.kyoukagoKougekiryoku + sonota1Data.kyoukagoKougekiryoku + sonota2Data.kyoukagoKougekiryoku;
        soubiKinnkyoriKaisinnritu = kinnkyoriWeponData.kinnkyoriKaisinnritu + ennkyoriWeponData.kinnkyoriKaisinnritu + yoroiData.kinnkyoriKaisinnritu + sonota1Data.kinnkyoriKaisinnritu + sonota2Data.kinnkyoriKaisinnritu;
        soubiMaryoku = kinnkyoriWeponData.kyoukagoMaryoku + ennkyoriWeponData.kyoukagoMaryoku + yoroiData.kyoukagoMaryoku + sonota1Data.kyoukagoMaryoku + sonota2Data.kyoukagoMaryoku;
        soubiEnnkyoriKaisinnritu = kinnkyoriWeponData.ennkyoriKaisinnsitu + ennkyoriWeponData.ennkyoriKaisinnsitu + yoroiData.ennkyoriKaisinnsitu + sonota1Data.ennkyoriKaisinnsitu + sonota2Data.ennkyoriKaisinnsitu;
        soubiBougyoryoiku = kinnkyoriWeponData.kyoukagoBougyoryoku + ennkyoriWeponData.kyoukagoBougyoryoku + yoroiData.kyoukagoBougyoryoku + sonota1Data.kyoukagoBougyoryoku + sonota2Data.kyoukagoBougyoryoku;
        soubiKaisinnTisei = kinnkyoriWeponData.kaisinnTaisei + ennkyoriWeponData.kaisinnTaisei + yoroiData.kaisinnTaisei + sonota1Data.kaisinnTaisei + sonota2Data.kaisinnTaisei;
        soubiMeityuuritu = kinnkyoriWeponData.kyoukagoMeityuuritu + ennkyoriWeponData.kyoukagoMeityuuritu + yoroiData.kyoukagoMeityuuritu + sonota1Data.kyoukagoMeityuuritu + sonota2Data.kyoukagoMeityuuritu;
        soubiKaihiritu = kinnkyoriWeponData.kyoukagoKaihiritu + ennkyoriWeponData.kyoukagoKaihiritu + yoroiData.kyoukagoKaihiritu + sonota1Data.kyoukagoKaihiritu + sonota2Data.kyoukagoKaihiritu;
        soubiNokkubakku = kinnkyoriWeponData.nokkubakku + ennkyoriWeponData.nokkubakku + yoroiData.nokkubakku + sonota1Data.nokkubakku + sonota2Data.nokkubakku;
        soubiKougekiHinndo = kinnkyoriWeponData.kougekiHinndo + ennkyoriWeponData.kougekiHinndo + yoroiData.kougekiHinndo + sonota1Data.kougekiHinndo + sonota2Data.kougekiHinndo;

        maxHp = statusMaxHp + soubiMaxHp;
        maxMp = statusMaxMp + soubiMaxMp;
        fireBallCost = statusFireBallCost + soubiFireBallCost;
        kougekiryoku = statusKougekiryoku + soubiKougekiryoku;
        kinnkyoriKaisinnritu = statusKinnkyoriKaisinnritu + soubiKinnkyoriKaisinnritu;
        maryoku = statusMaryoku + soubiMaryoku;
        ennkyoriKaisinnritu = statusEnnkyoriKaisinnritu + soubiEnnkyoriKaisinnritu;
        bougyoryoku = statusBougyoryoku + soubiBougyoryoiku;
        kaisinnTaisei = statusKaisinnTaisei + soubiKaisinnTisei;
        meityuuritu = statusMeityuuritu + soubiMeityuuritu;
        kaihiritu = statusKaihiritu + soubiKaihiritu;

        nokkubakku = soubiNokkubakku;
        kougekiHinndo = soubiKougekiHinndo;

        kougekiHanni = kinnkyoriWeponData.kougekiHanni;

        destroyTime = kinnkyoriWeponData.destroyTime;
        srushSpeed = kinnkyoriWeponData.srushSpeed;

        hp = maxHp;
        mp = maxMp;
    }
}

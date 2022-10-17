using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
public class PlayerStatusDataBase : MonoBehaviour
{
    public WeponDateBaseManager weponDateBaseManager;
    public EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    public YoroiDataBaseManager yoroiDataBaseManager;
    public SonotaDataBaseManager sonotaDataBaseManager;

    public WeponDataList kinnkyoriWeponDatas;
    public WeponDataList ennkyoriWeponDatas;
    public WeponDataList yoroiDatas;
    public WeponDataList sonotaDatas;
    [Space(1)]
    public EXPManager expManagerScript;
    [Space(1)]
    public int kinnkyoriWeponNo = 1;
    public int ennkyoriWeponNo = 1;
    public int yoroiNo = 1;
    public int sonota1No = 1;
    public int sonota2No = 2;
    [Space(1)]
    [Header("基礎ステータス")]
    public int statusMaxHp = 10;
    public int statusMaxMp = 10;
    public int statusFireBallCost = 3;
    public int statusKougekiryoku = 1;
    public int statusMaryoku = 1;
    public float statusKinnkyoriKaisinnritu = 0;
    public float statusEnnkyoriKaisinnritu = 0;
    public int statusBougyoryoku = 1;
    public float statusKaisinnTaisei = 0;
    public float statusMeityuuritu = 100;
    public float statusKaihiritu;
    [Space(1)]
    [Header("装備ステータス")]
    public int soubiMaxHp;
    public int soubiMaxMp;
    public int soubiFireBallCost;
    public int soubiKougekiryoku;
    public int soubiMaryoku;
    public float soubiKinnkyoriKaisinnritu;
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
    [Header("基礎・装備ステータスの合計")]
    public int maxHp;
    public int hp;
    public int maxMp;
    public int mp;
    public int fireBallCost;
    public int kougekiryoku;
    public int maryoku;
    public float kinnkyoriKaisinnritu;
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
    [Header("倍率")]
    [Header("功績特攻数値")]
    public int kousekiMazyuuTokkou;
    public int kousekiNinngennTokkou;
    public int kousekiMazinnTokkou;
    public int kousekiHusiTokkou;
    public int kousekiAkumaTokkou;
    public int kousekiRyuuTokkou;
    public int kousekiKamiTokkou;
    [Header("装備特攻数値")]
    public int soubiMazyuuTokkou;
    public int soubiNinngennTokkou;
    public int soubiMazinnTokkou;
    public int soubiHusiTokkou;
    public int soubiAkumaTokkou;
    public int soubiRyuuTokkou;
    public int soubiKamiTokkou;
    [Header("レア度別ドロップ率ボーナス")]
    public int nomalDropRitu;
    public int reaDropRitu;
    public int superReaDropRitu;
    public int epikReaDropRitu;
    public int legendaryReaDropRitu;
    public int godReaDropRitu;
    [Header("強化対価減少率")]
    public int kyoukataikaGennsyouritu;
    [Header("ギフト付与装備ドロップ率")]
    public int giftHuyoSoubiDropritu;

    [Space(1)]
    [Header("スキル")]
    public int syoziSp;
    [Header("ファイヤースピア")]
    [Header("アクティブスキル")]
    public int fireSpireLv;
    public int kanntuuKakuritu;
    public int kanntuuGennsuiritu;
    [Header("ラピットファイヤー")]
    public int rapidGireLv;
    public int rapidKakuritu;
    public int rapidGennsuiritu;
    [Header("ファイヤーボム")]
    public int fireBomLv;
    public int bakuhatuKakuritu;
    public float bakuhatuGennsuiBairitu;
    [Header("ファイヤーウォール")]
    [Header("パッシブスキル")]
    public int firewallLv;
    public int fireWallTennkaisuu;
    public int fireWallHannizoukakakuritu;
    [Header("増殖数")]
    public int zousyokusuuLv;
    public int saisyouZousyokusuu;
    public int saidaiZousyokusuu;
    [Header("ファイヤーコンボ")]
    public int fireComboLv;
    [Header("ウォールコンボ")]
    public int wallChainLv;
    public float fireComboZyousyouritu;
    [Header("多重詠唱")]
    public int tazyuuEisyouLv;
    public int tazyuuEisyouSaisyouhassyasuu;
    public int tazyuuEisyouSaidaihassyasuu;
    [Header("ファイヤーグラビティ")]
    public int fireGrabityLv;
    public int zyuuryouBairitu;
    [Header("詠唱短縮")]
    public int eisyouTannsyukuLv;
    [Header("無詠唱")]
    public int mueisyouLv;
    [Header("魔力アップ")]
    public int maryokuUpLv;
    public int maryokuZyousyouritu;
    [Header("FBコストダウン")]
    public int fbCostDownLv;
    public int fireBallCostDownRitu;
    [Space(1)]
    [Header("武器の情報。番号で検索して、スクリプタブル・オブジェクトから取得する")]
    public WeponDataList.WeponData kinnkyoriWeponData;
    public WeponDataList.WeponData ennkyoriWeponData;
    public WeponDataList.WeponData yoroiData;
    public WeponDataList.WeponData sonota1Data;
    public WeponDataList.WeponData sonota2Data;

    public StatusSaveData statusSaveData;
    public SkillSaveData skillSaveData;
    public SoubiSaveData soubiSaveData;
    void Start()
    {
        StatusLoad();
        SkillLoad();
        expManagerScript.lvUpExp = expManagerScript.GetLvupExp(expManagerScript.lv);
        StatusUpdate();
        //Debug.Log(Application.persistentDataPath);
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
        FBCostDownLvText();
        fireBallCost = Mathf.FloorToInt(statusFireBallCost - ((statusFireBallCost * fireBallCostDownRitu)) / 100) + soubiFireBallCost;
        //Debug.Log(statusFireBallCost - Mathf.CeilToInt((statusFireBallCost * fireBallCostDownRitu) / 100) + soubiFireBallCost);
        kougekiryoku = statusKougekiryoku + soubiKougekiryoku;
        kinnkyoriKaisinnritu = statusKinnkyoriKaisinnritu + soubiKinnkyoriKaisinnritu;
        MaryokuUpLvUpText();
        maryoku = Mathf.CeilToInt(statusMaryoku * (100 + maryokuZyousyouritu) / 100 + soubiMaryoku);
        //Debug.Log(Mathf.CeilToInt(statusMaryoku * (100 + maryokuZyousyouritu)/100));
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

        StatusSave();
        SkillSave();
    }

    public void FireSpireLvText()
    {
        if (fireSpireLv == 1)
        {
            kanntuuKakuritu = 100;
            kanntuuGennsuiritu = 50;
        }
        else if (fireSpireLv == 2)
        {
            kanntuuKakuritu = 110;
            kanntuuGennsuiritu = 40;
        }
        else if (fireSpireLv == 3)
        {
            kanntuuKakuritu = 120;
            kanntuuGennsuiritu = 30;
        }
        else if (fireSpireLv == 4)
        {
            kanntuuKakuritu = 130;
            kanntuuGennsuiritu = 25;
        }
        else if (fireSpireLv == 5)
        {
            kanntuuKakuritu = 140;
            kanntuuGennsuiritu = 20;
        }
    }
    public void RapidFireLvText()
    {
        if (rapidGireLv == 1)
        {
            rapidKakuritu = 100;
            rapidGennsuiritu = 50;
        }
        else if (rapidGireLv == 2)
        {
            rapidKakuritu = 110;
            rapidGennsuiritu = 40;
        }
        else if (rapidGireLv == 3)
        {
            rapidKakuritu = 120;
            rapidGennsuiritu = 30;
        }
        else if (rapidGireLv == 4)
        {
            rapidKakuritu = 130;
            rapidGennsuiritu = 25;
        }
        else if (rapidGireLv == 5)
        {
            rapidKakuritu = 140;
            rapidGennsuiritu = 20;
        }
    }
    public void FireBomLvText()
    {
        if (fireBomLv == 1)
        {
            bakuhatuKakuritu = 5;
            bakuhatuGennsuiBairitu = 0.5f;
        }
        else if (fireBomLv == 2)
        {
            bakuhatuKakuritu = 10;
            bakuhatuGennsuiBairitu = 0.6f;
        }
        else if (fireBomLv == 3)
        {
            bakuhatuKakuritu = 15;
            bakuhatuGennsuiBairitu = 0.7f;
        }
        else if (fireBomLv == 4)
        {
            bakuhatuKakuritu = 20;
            bakuhatuGennsuiBairitu = 0.75f;
        }
        else if (fireBomLv == 5)
        {
            bakuhatuKakuritu = 25;
            bakuhatuGennsuiBairitu = 0.8f;
        }
    }
    public void FireWallLvUpText()
    {
        if (firewallLv == 1)
        {
            fireWallTennkaisuu = 1;
            fireWallHannizoukakakuritu = 0;
        }
        else if (firewallLv == 2)
        {
            fireWallTennkaisuu = 2;
            fireWallHannizoukakakuritu = 0;
        }
        else if (firewallLv == 3)
        {
            fireWallTennkaisuu = 3;
            fireWallHannizoukakakuritu = 0;
        }
        else if (firewallLv == 4)
        {
            fireWallTennkaisuu = 3;
            fireWallHannizoukakakuritu = 15;
        }
        else if (firewallLv == 5)
        {
            fireWallTennkaisuu = 3;
            fireWallHannizoukakakuritu = 30;
        }
    }
    public void WallZousyokusuuLvUpText()
    {
        if (zousyokusuuLv == 1)
        {
            saisyouZousyokusuu = 1;
            saidaiZousyokusuu = 2;
        }
        else if (zousyokusuuLv == 2)
        {
            saisyouZousyokusuu = 1;
            saidaiZousyokusuu = 3;
        }
        else if (zousyokusuuLv == 3)
        {
            saisyouZousyokusuu = 1;
            saidaiZousyokusuu = 4;
        }
        else if (zousyokusuuLv == 4)
        {
            saisyouZousyokusuu = 1;
            saidaiZousyokusuu = 5;
        }
        else if (zousyokusuuLv == 5)
        {
            saisyouZousyokusuu = 2;
            saidaiZousyokusuu = 6;
        }
    }
    public void FireComboLvUpText()
    {
        if (fireComboLv == 1)
        {
            fireComboZyousyouritu = 0.01f;
        }
        else if (fireComboLv == 2)
        {
            fireComboZyousyouritu = 0.02f;
        }
        else if (fireComboLv == 3)
        {
            fireComboZyousyouritu = 0.03f;
        }
        else if (fireComboLv == 4)
        {
            fireComboZyousyouritu = 0.04f;
        }
        else if (fireComboLv == 5)
        {
            fireComboZyousyouritu = 0.05f;
        }
    }
    public void TazyuueisyouLvText()
    {
        if (tazyuuEisyouLv == 1)
        {
            tazyuuEisyouSaisyouhassyasuu = 1;
            tazyuuEisyouSaidaihassyasuu = 2;
        }
        else if (tazyuuEisyouLv == 2)
        {
            tazyuuEisyouSaisyouhassyasuu = 1;
            tazyuuEisyouSaidaihassyasuu = 3;
        }
    }
    public void FireGravityLvText()
    {
        if (fireGrabityLv == 1)
        {
            zyuuryouBairitu = 50;
        }
        else if (fireGrabityLv == 2)
        {
            zyuuryouBairitu = 100;
        }
        else if (fireGrabityLv == 3)
        {
            zyuuryouBairitu = 160;
        }
        else if (fireGrabityLv == 4)
        {
            zyuuryouBairitu = 220;
        }
        else if (fireGrabityLv == 5)
        {
            zyuuryouBairitu = 300;
        }
    }
    public void MaryokuUpLvUpText()
    {
        if (maryokuUpLv == 1)
        {
            maryokuZyousyouritu = 15;
        }
        else if (maryokuUpLv == 2)
        {
            maryokuZyousyouritu = 30;
        }
        else if (maryokuUpLv == 3)
        {
            maryokuZyousyouritu = 45;
        }
        else if (maryokuUpLv == 4)
        {
            maryokuZyousyouritu = 60;
        }
        else if (maryokuUpLv == 5)
        {
            maryokuZyousyouritu = 75;
        }
        else if (maryokuUpLv == 6)
        {
            maryokuZyousyouritu = 90;
        }
        else if (maryokuUpLv == 7)
        {
            maryokuZyousyouritu = 105;
        }
        else if (maryokuUpLv == 8)
        {
            maryokuZyousyouritu = 120;
        }
        else if (maryokuUpLv == 9)
        {
            maryokuZyousyouritu = 135;
        }
        else if (maryokuUpLv == 10)
        {
            maryokuZyousyouritu = 150;
        }
        else if (maryokuUpLv == 11)
        {
            maryokuZyousyouritu = 165;
        }
        else if (maryokuUpLv == 12)
        {
            maryokuZyousyouritu = 180;
        }
        else if (maryokuUpLv == 13)
        {
            maryokuZyousyouritu = 200;
        }
    }
    public void FBCostDownLvText()
    {
        if (fbCostDownLv == 1)
        {
            fireBallCostDownRitu = 3;
        }
        else if (fbCostDownLv == 2)
        {
            fireBallCostDownRitu = 6;
        }
        else if (fbCostDownLv == 3)
        {
            fireBallCostDownRitu = 9;
        }
        else if (fbCostDownLv == 4)
        {
            fireBallCostDownRitu = 12;
        }
        else if (fbCostDownLv == 5)
        {
            fireBallCostDownRitu = 15;
        }
        else if (fbCostDownLv == 6)
        {
            fireBallCostDownRitu = 18;
        }
        else if (fbCostDownLv == 7)
        {
            fireBallCostDownRitu = 22;
        }
        else if (fbCostDownLv == 8)
        {
            fireBallCostDownRitu = 26;
        }
        else if (fbCostDownLv == 9)
        {
            fireBallCostDownRitu = 30;
        }
        else if (fbCostDownLv == 10)
        {
            fireBallCostDownRitu = 34;
        }
        else if (fbCostDownLv == 11)
        {
            fireBallCostDownRitu = 39;
        }
        else if (fbCostDownLv == 12)
        {
            fireBallCostDownRitu = 44;
        }
        else if (fbCostDownLv == 13)
        {
            fireBallCostDownRitu = 50;
        }
    }

    public void StatusSave()
    {
        statusSaveData = new StatusSaveData();
        statusSaveData.lv = expManagerScript.lv;
        statusSaveData.exp_stock = expManagerScript.exp_stokku;

        statusSaveData.sp = syoziSp;

        statusSaveData.statusMaxHp = statusMaxHp;
        statusSaveData.statusMaxMp = statusMaxMp;
        statusSaveData.statusFireBallCost = statusFireBallCost;
        statusSaveData.statusKougekiryoku = statusKougekiryoku;
        statusSaveData.statusMaryoku = statusMaryoku;
        statusSaveData.statusKinnkyoriKaisinnritu = statusKinnkyoriKaisinnritu;
        statusSaveData.statusEnnkyoriKaisinnritu = statusEnnkyoriKaisinnritu;
        statusSaveData.statusBougyoryoku = statusBougyoryoku;
        statusSaveData.statusKaisinnTaisei = statusKaisinnTaisei;
        statusSaveData.statusMeityuuritu = statusMeityuuritu;
        statusSaveData.statusKaihiritu = statusKaihiritu;
        // Debug.Log(JsonUtility.ToJson(saveData));

        string json = JsonUtility.ToJson(statusSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.status.json", json);
    }
    public void SkillSave()
    {
        skillSaveData = new SkillSaveData();

        skillSaveData.fireSpireLv = fireSpireLv;
        skillSaveData.rapidFireLv = rapidGireLv;
        skillSaveData.fireBomLv = fireBomLv;
        skillSaveData.firewallLv = firewallLv;
        skillSaveData.zousyokusuuLv = zousyokusuuLv;
        skillSaveData.fireComboLv = fireComboLv;
        skillSaveData.wallChainLv = wallChainLv;
        skillSaveData.tazyuuEisyouLv = tazyuuEisyouLv;
        skillSaveData.fireGrabityLv = fireGrabityLv;
        skillSaveData.eisyouTannsyukuLv = eisyouTannsyukuLv;
        skillSaveData.mueisyouLv = mueisyouLv;
        skillSaveData.maryokuUpLv = maryokuUpLv;
        skillSaveData.fbCostDownLv = fbCostDownLv;
        // Debug.Log(JsonUtility.ToJson(saveData));

        string json = JsonUtility.ToJson(skillSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.skill.json", json);
    }
    public void StatusLoad()
    {
        string path = Application.persistentDataPath + "/savefile.status.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            Debug.Log(json);
            StatusSaveData loadData = JsonUtility.FromJson<StatusSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換
            expManagerScript.lv = loadData.lv;
            expManagerScript.exp_stokku = loadData.exp_stock;

            syoziSp = loadData.sp;

            statusMaxHp = loadData.statusMaxHp;
            statusMaxMp = loadData.statusMaxMp;
            statusFireBallCost = loadData.statusFireBallCost;
            statusKougekiryoku = loadData.statusKougekiryoku;
            statusMaryoku = loadData.statusMaryoku;
            statusKinnkyoriKaisinnritu = loadData.statusKinnkyoriKaisinnritu;
            statusEnnkyoriKaisinnritu = loadData.statusEnnkyoriKaisinnritu;
            statusBougyoryoku = loadData.statusBougyoryoku;
            statusKaisinnTaisei = loadData.statusKaisinnTaisei;
            statusMeityuuritu = loadData.statusMeityuuritu;
            statusKaihiritu = loadData.statusKaihiritu;
        }
    }
    public void SkillLoad()
    {
        string path = Application.persistentDataPath + "/savefile.skill.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            Debug.Log(json);
            SkillSaveData loadData = JsonUtility.FromJson<SkillSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換
            
            fireSpireLv = loadData.fireSpireLv;
            rapidGireLv = loadData.rapidFireLv;
            fireBomLv = loadData.fireBomLv;
            firewallLv = loadData.firewallLv;
            zousyokusuuLv = loadData.zousyokusuuLv;
            fireComboLv = loadData.fireComboLv;
            wallChainLv = loadData.wallChainLv;
            tazyuuEisyouLv = loadData.tazyuuEisyouLv;
            fireGrabityLv = loadData.fireGrabityLv;
            eisyouTannsyukuLv = loadData.eisyouTannsyukuLv;
            mueisyouLv = loadData.mueisyouLv;
            maryokuUpLv = loadData.maryokuUpLv;
            fbCostDownLv = loadData.fbCostDownLv;
        }
    }
    public void SoubiScritableSave()
    {
        //ダーティとしてマークする(変更があった事を記録する)
        EditorUtility.SetDirty(kinnkyoriWeponDatas);
        EditorUtility.SetDirty(ennkyoriWeponDatas);
        EditorUtility.SetDirty(yoroiDatas);
        EditorUtility.SetDirty(sonotaDatas);
        //保存する
        AssetDatabase.SaveAssets();
        Debug.Log("装備を保存した");
    }
    public void StatusSyokika()
    {
        expManagerScript.lv = 1;
        expManagerScript.exp_stokku = 0;
        expManagerScript.lvUpExp = expManagerScript.GetLvupExp(expManagerScript.lv);
        syoziSp = 0;
        statusMaxHp = 10;
        statusMaxMp = 10;
        statusFireBallCost = 3;
        statusKougekiryoku = 1;
        statusMaryoku = 1;
        statusKinnkyoriKaisinnritu = 0;
        statusEnnkyoriKaisinnritu = 0;
        statusBougyoryoku = 1;
        statusKaisinnTaisei = 0;
        statusMeityuuritu = 100;
        statusKaihiritu=100;

        fireSpireLv = 0;
        rapidGireLv = 0;
        fireBomLv = 0;
        firewallLv = 0;
        zousyokusuuLv = 0;
        fireComboLv = 0;
        wallChainLv = 0;
        tazyuuEisyouLv = 0;
        fireGrabityLv = 0;
        eisyouTannsyukuLv = 0;
        mueisyouLv = 0;
        maryokuUpLv = 0;
        fbCostDownLv = 0;
        StatusSave();
        SkillSave();
    }
}

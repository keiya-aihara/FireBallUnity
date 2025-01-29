using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerStatusDataBase : MonoBehaviour
{
    public WeponDateBaseManager weponDateBaseManager;
    public EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    public YoroiDataBaseManager yoroiDataBaseManager;
    public SonotaDataBaseManager sonotaDataBaseManager;

    public SoubiSkillDatabase soubiSkillDatabase;

    public WeponDataList kinnkyoriWeponDatas;
    public WeponDataList ennkyoriWeponDatas;
    public WeponDataList yoroiDatas;
    public WeponDataList sonotaDatas;

    public SoubiSaveZone soubiSaveZone;
    /*
    public List<WeponDataList.WeponData> kinnkyoriWeponDatas;
    public List<WeponDataList.WeponData> ennkyoriWeponDatas;
    public List<WeponDataList.WeponData> yoroiDatas;
    public List<WeponDataList.WeponData> sonotaDatas;
    */
    public WeponDataList.WeponData[] soubiItirann;

    public KousekiDataBaseManager kousekiDataBaseManager;
    public KakutokuDataBase soubiKakutokuDataBase;

    public SystemDatabase systemDatabase;
    public StageZissekiDatabase stageZissekiDatabase;
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

    //public float soubiDestroyTime;
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
    //public float destroyTime;
    [Space(2)]
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
    [Header("特攻数値")]
    public int mazyuuTokkou;
    public int ninngennTokkou;
    public int mazinnTokkou;
    public int husiTokkou;
    public int akumaTokkou;
    public int ryuuTokkou;
    public int kamiTokkou;
    [Space(1)]
    [Header("功績レア度別ドロップ率ボーナス")]
    public int kousekiNomalDropRitu;
    public int kousekiReaDropRitu;
    public int kousekiSuperReaDropRitu;
    public int kousekiEpikReaDropRitu;
    public int kousekiLegendaryReaDropRitu;
    public int kousekiGodReaDropRitu;
    [Header("装備レア度別ドロップ率ボーナス")]
    public int soubiNomalDropRitu;
    public int soubiReaDropRitu;
    public int soubiSuperReaDropRitu;
    public int soubiEpikReaDropRitu;
    public int soubiLegendaryReaDropRitu;
    public int soubiGodReaDropRitu;
    [Header("レア度別ドロップ率ボーナス")]
    public int nomalDropRitu;
    public int reaDropRitu;
    public int superReaDropRitu;
    public int epikReaDropRitu;
    public int legendaryReaDropRitu;
    public int godReaDropRitu;
    [Space(1)]
    [Header("称号ドロップ率")]
    public int syougouDropRitu;
    [Space(1)]
    [Header("強化対価減少率")]
    public int kyoukataikaGennsyouritu;
    [Space(1)]
    [Header("功績ギフト付与装備ドロップ率")]
    public int kousekiGiftHuyoSoubiDropritu;
    [Header("装備ギフト付与装備ドロップ率")]
    public int soubiGiftHuyoSoubiDropritu;
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
    public int fireWallTennkaisuuSyou;
    public int fireWallTennkaisuuDai;
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
    public int skillMaryokuZyousyouritu;
    [Header("FBコストダウン")]
    public int fbCostDownLv;
    public int skillFireBallCostDownRitu;
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

    void Awake()
    {
        StatusLoad();
        SkillLoad();
        BairituLoad();
        kousekiDataBaseManager.TorophyLoad();
        SoubiScritableLoad();
        systemDatabase.SystemLoad();
        stageZissekiDatabase.StageZissekiDataLoad();
        soubiKakutokuDataBase.KakutokuLoad();
        soubiKakutokuDataBase.GekihasuuLoad();
        expManagerScript.lvUpExp = expManagerScript.GetLvupExp(expManagerScript.lv);
        StatusUpdate();
        //Debug.Log(Application.persistentDataPath);
        systemDatabase.StageNameLoad();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void StatusUpdate()
    {
       Debug.Log("ステータスアップデート");
        //装備中装備データ取得
        kinnkyoriWeponData = weponDateBaseManager.GetWeponData(kinnkyoriWeponNo);
        ennkyoriWeponData = ennkyoriWeponDataBaseManager.GetWeponData(ennkyoriWeponNo);
        yoroiData = yoroiDataBaseManager.GetWeponData(yoroiNo);
        sonota1Data = sonotaDataBaseManager.GetWeponData(sonota1No);
        sonota2Data = sonotaDataBaseManager.GetWeponData(sonota2No);
        //装備中装備ステータス合算
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
        if (kinnkyoriWeponData.zyukurenndo == 0)
            soubiKougekiHinndo = kinnkyoriWeponData.kougekiHinndo + ennkyoriWeponData.kougekiHinndo + yoroiData.kougekiHinndo + sonota1Data.kougekiHinndo + sonota2Data.kougekiHinndo;
        else soubiKougekiHinndo = kinnkyoriWeponData.zyukurenndoKougekiHinndo + ennkyoriWeponData.kougekiHinndo + yoroiData.kougekiHinndo + sonota1Data.kougekiHinndo + sonota2Data.kougekiHinndo;

        soubiKougekiHanni= kinnkyoriWeponData.kougekiHanni + ennkyoriWeponData.kougekiHanni + yoroiData.kougekiHanni + sonota1Data.kougekiHanni + sonota2Data.kougekiHanni;
        //装備中装備特攻倍率合算
        soubiMazyuuTokkou = kinnkyoriWeponData.soubiMazyuuTokkou + ennkyoriWeponData.soubiMazyuuTokkou + yoroiData.soubiMazyuuTokkou + sonota1Data.soubiMazyuuTokkou + sonota2Data.soubiMazyuuTokkou;
        soubiNinngennTokkou = kinnkyoriWeponData.soubiNinngennTokkou + ennkyoriWeponData.soubiNinngennTokkou + yoroiData.soubiNinngennTokkou + sonota1Data.soubiNinngennTokkou + sonota2Data.soubiNinngennTokkou;
        soubiMazinnTokkou = kinnkyoriWeponData.soubiMazinnTokkou + ennkyoriWeponData.soubiMazinnTokkou + yoroiData.soubiMazinnTokkou + sonota1Data.soubiMazinnTokkou + sonota2Data.soubiMazinnTokkou;
        soubiHusiTokkou = kinnkyoriWeponData.soubiHusiTokkou + ennkyoriWeponData.soubiHusiTokkou + yoroiData.soubiHusiTokkou + sonota1Data.soubiHusiTokkou + sonota2Data.soubiHusiTokkou;
        soubiAkumaTokkou = kinnkyoriWeponData.soubiAkumaTokkou + ennkyoriWeponData.soubiAkumaTokkou + yoroiData.soubiAkumaTokkou + sonota1Data.soubiAkumaTokkou + sonota2Data.soubiAkumaTokkou;
        soubiRyuuTokkou = kinnkyoriWeponData.soubiRyuuTokkou + ennkyoriWeponData.soubiRyuuTokkou + yoroiData.soubiRyuuTokkou + sonota1Data.soubiRyuuTokkou + sonota2Data.soubiRyuuTokkou;
        soubiKamiTokkou = kinnkyoriWeponData.soubiKamiTokkou + ennkyoriWeponData.soubiKamiTokkou + yoroiData.soubiKamiTokkou + sonota1Data.soubiKamiTokkou + sonota2Data.soubiKamiTokkou;
        //装備中装備トレハン倍率合算
        soubiNomalDropRitu = kinnkyoriWeponData.soubiDropBairitu + ennkyoriWeponData.soubiDropBairitu + yoroiData.soubiDropBairitu + sonota1Data.soubiDropBairitu + sonota2Data.soubiDropBairitu;
        soubiReaDropRitu = kinnkyoriWeponData.soubiDropBairitu + ennkyoriWeponData.soubiDropBairitu + yoroiData.soubiDropBairitu + sonota1Data.soubiDropBairitu + sonota2Data.soubiDropBairitu;
        soubiSuperReaDropRitu = kinnkyoriWeponData.soubiDropBairitu + ennkyoriWeponData.soubiDropBairitu + yoroiData.soubiDropBairitu + sonota1Data.soubiDropBairitu + sonota2Data.soubiDropBairitu;
        soubiEpikReaDropRitu = kinnkyoriWeponData.soubiDropBairitu + ennkyoriWeponData.soubiDropBairitu + yoroiData.soubiDropBairitu + sonota1Data.soubiDropBairitu + sonota2Data.soubiDropBairitu;
        soubiLegendaryReaDropRitu = kinnkyoriWeponData.soubiDropBairitu + ennkyoriWeponData.soubiDropBairitu + yoroiData.soubiDropBairitu + sonota1Data.soubiDropBairitu + sonota2Data.soubiDropBairitu;
        soubiGodReaDropRitu = kinnkyoriWeponData.soubiDropBairitu + ennkyoriWeponData.soubiDropBairitu + yoroiData.soubiDropBairitu + sonota1Data.soubiDropBairitu + sonota2Data.soubiDropBairitu;
        syougouDropRitu = kinnkyoriWeponData.syougouDropRitu + ennkyoriWeponData.syougouDropRitu + yoroiData.syougouDropRitu + sonota1Data.syougouDropRitu + sonota2Data.syougouDropRitu;
        soubiGiftHuyoSoubiDropritu = kinnkyoriWeponData.soubiGifthuyosoubiDropritu + ennkyoriWeponData.soubiGifthuyosoubiDropritu + yoroiData.soubiGifthuyosoubiDropritu + sonota1Data.soubiGifthuyosoubiDropritu + sonota2Data.soubiGifthuyosoubiDropritu;
        //基礎ステータス・装備中装備ステータス合算。最終ステータス数値確定
        maxHp = statusMaxHp + soubiMaxHp;
        maxMp = statusMaxMp + soubiMaxMp;
        FBCostDownLvText();
        fireBallCost = Mathf.FloorToInt(statusFireBallCost - ((statusFireBallCost * skillFireBallCostDownRitu)) / 100) + soubiFireBallCost;
        //Debug.Log(statusFireBallCost - Mathf.CeilToInt((statusFireBallCost * fireBallCostDownRitu) / 100) + soubiFireBallCost);
        kougekiryoku = statusKougekiryoku + soubiKougekiryoku;
        kinnkyoriKaisinnritu = statusKinnkyoriKaisinnritu + soubiKinnkyoriKaisinnritu;
        MaryokuUpLvUpText();
        maryoku = Mathf.CeilToInt(statusMaryoku * (100 + skillMaryokuZyousyouritu) / 100 + soubiMaryoku);
        //Debug.Log(Mathf.CeilToInt(statusMaryoku * (100 + maryokuZyousyouritu)/100));
        ennkyoriKaisinnritu = statusEnnkyoriKaisinnritu + soubiEnnkyoriKaisinnritu;
        bougyoryoku = statusBougyoryoku + soubiBougyoryoiku;
        kaisinnTaisei = statusKaisinnTaisei + soubiKaisinnTisei;
        meityuuritu = statusMeityuuritu + soubiMeityuuritu;
        kaihiritu = statusKaihiritu + soubiKaihiritu;

        nokkubakku = soubiNokkubakku;
        kougekiHinndo = soubiKougekiHinndo;

        kougekiHanni = soubiKougekiHanni;
        Debug.Log(kougekiHanni);

        //destroyTime = kinnkyoriWeponData.destroyTime;
        srushSpeed = kinnkyoriWeponData.srushSpeed;

        mazyuuTokkou = kousekiMazyuuTokkou + soubiMazyuuTokkou;
        ninngennTokkou = kousekiNinngennTokkou + soubiNinngennTokkou;
        mazinnTokkou = kousekiMazinnTokkou + soubiMazinnTokkou;
        husiTokkou = kousekiHusiTokkou + soubiHusiTokkou;
        akumaTokkou = kousekiAkumaTokkou + soubiAkumaTokkou;
        ryuuTokkou = kousekiRyuuTokkou + soubiRyuuTokkou;
        kamiTokkou = kousekiKamiTokkou + soubiKamiTokkou;

        nomalDropRitu = kousekiNomalDropRitu + soubiNomalDropRitu;
        reaDropRitu = kousekiReaDropRitu + soubiReaDropRitu;
        superReaDropRitu = kousekiSuperReaDropRitu + soubiSuperReaDropRitu;
        epikReaDropRitu = kousekiEpikReaDropRitu + soubiEpikReaDropRitu;
        legendaryReaDropRitu = kousekiLegendaryReaDropRitu + soubiLegendaryReaDropRitu;
        godReaDropRitu = kousekiGodReaDropRitu + soubiGodReaDropRitu;

        giftHuyoSoubiDropritu = kousekiGiftHuyoSoubiDropritu + soubiGiftHuyoSoubiDropritu;

        if (kinnkyoriWeponData.skill) soubiSkillDatabase.skillNumber[0] = kinnkyoriWeponData.skillNo;
        else soubiSkillDatabase.skillNumber[0] = 0;
        if (ennkyoriWeponData.skill) soubiSkillDatabase.skillNumber[1] = ennkyoriWeponData.skillNo;
        else soubiSkillDatabase.skillNumber[1] = 0;
        if (yoroiData.skill) soubiSkillDatabase.skillNumber[2] = yoroiData.skillNo;
        else soubiSkillDatabase.skillNumber[2] = 0;
        if (sonota1Data.skill) soubiSkillDatabase.skillNumber[3] = sonota1Data.skillNo;
        else soubiSkillDatabase.skillNumber[3] = 0;
        if (sonota2Data.skill) soubiSkillDatabase.skillNumber[4] = sonota2Data.skillNo;
        else soubiSkillDatabase.skillNumber[4] = 0;

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
            fireWallTennkaisuuSyou = 1;
            fireWallTennkaisuuDai = 1;
        }
        else if (firewallLv == 2)
        {
            fireWallTennkaisuuSyou = 1;
            fireWallTennkaisuuDai = 2;
        }
        else if (firewallLv == 3)
        {
            fireWallTennkaisuuSyou = 2;
            fireWallTennkaisuuDai = 2;
        }
        else if (firewallLv == 4)
        {
            fireWallTennkaisuuSyou = 2;
            fireWallTennkaisuuDai = 3;
        }
        else if (firewallLv == 5)
        {
            fireWallTennkaisuuSyou = 3;
            fireWallTennkaisuuDai = 3;
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
            saisyouZousyokusuu = 2;
            saidaiZousyokusuu = 3;
        }
        else if (zousyokusuuLv == 3)
        {
            saisyouZousyokusuu = 3;
            saidaiZousyokusuu = 4;
        }
        else if (zousyokusuuLv == 4)
        {
            saisyouZousyokusuu = 4;
            saidaiZousyokusuu = 5;
        }
        else if (zousyokusuuLv == 5)
        {
            saisyouZousyokusuu = 4;
            saidaiZousyokusuu = 6;
        }
    }
    public void FireComboLvUpText()
    {
        if (fireComboLv == 1)
        {
            fireComboZyousyouritu = 0.1f;
        }
        else if (fireComboLv == 2)
        {
            fireComboZyousyouritu = 0.2f;
        }
        else if (fireComboLv == 3)
        {
            fireComboZyousyouritu = 0.3f;
        }
        else if (fireComboLv == 4)
        {
            fireComboZyousyouritu = 0.4f;
        }
        else if (fireComboLv == 5)
        {
            fireComboZyousyouritu = 0.5f;
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
            skillMaryokuZyousyouritu = 15;
        }
        else if (maryokuUpLv == 2)
        {
            skillMaryokuZyousyouritu = 30;
        }
        else if (maryokuUpLv == 3)
        {
            skillMaryokuZyousyouritu = 45;
        }
        else if (maryokuUpLv == 4)
        {
            skillMaryokuZyousyouritu = 60;
        }
        else if (maryokuUpLv == 5)
        {
            skillMaryokuZyousyouritu = 75;
        }
        else if (maryokuUpLv == 6)
        {
            skillMaryokuZyousyouritu = 90;
        }
        else if (maryokuUpLv == 7)
        {
            skillMaryokuZyousyouritu = 105;
        }
        else if (maryokuUpLv == 8)
        {
            skillMaryokuZyousyouritu = 120;
        }
        else if (maryokuUpLv == 9)
        {
            skillMaryokuZyousyouritu = 135;
        }
        else if (maryokuUpLv == 10)
        {
            skillMaryokuZyousyouritu = 150;
        }
        else if (maryokuUpLv == 11)
        {
            skillMaryokuZyousyouritu = 165;
        }
        else if (maryokuUpLv == 12)
        {
            skillMaryokuZyousyouritu = 180;
        }
        else if (maryokuUpLv == 13)
        {
            skillMaryokuZyousyouritu = 200;
        }
    }
    public void FBCostDownLvText()
    {
        if (fbCostDownLv == 1)
        {
            skillFireBallCostDownRitu = 3;
        }
        else if (fbCostDownLv == 2)
        {
            skillFireBallCostDownRitu = 6;
        }
        else if (fbCostDownLv == 3)
        {
            skillFireBallCostDownRitu = 9;
        }
        else if (fbCostDownLv == 4)
        {
            skillFireBallCostDownRitu = 12;
        }
        else if (fbCostDownLv == 5)
        {
            skillFireBallCostDownRitu = 15;
        }
        else if (fbCostDownLv == 6)
        {
            skillFireBallCostDownRitu = 18;
        }
        else if (fbCostDownLv == 7)
        {
            skillFireBallCostDownRitu = 22;
        }
        else if (fbCostDownLv == 8)
        {
            skillFireBallCostDownRitu = 26;
        }
        else if (fbCostDownLv == 9)
        {
            skillFireBallCostDownRitu = 30;
        }
        else if (fbCostDownLv == 10)
        {
            skillFireBallCostDownRitu = 34;
        }
        else if (fbCostDownLv == 11)
        {
            skillFireBallCostDownRitu = 39;
        }
        else if (fbCostDownLv == 12)
        {
            skillFireBallCostDownRitu = 44;
        }
        else if (fbCostDownLv == 13)
        {
            skillFireBallCostDownRitu = 50;
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
        //Debug.Log("ステータスをセーブ");
        statusSaveData.kinnkyoriWeponNo = kinnkyoriWeponNo;
        statusSaveData.ennkyoriWeponNo = ennkyoriWeponNo;
        statusSaveData.yoroiNo = yoroiNo;
        statusSaveData.sonota1No = sonota1No;
        statusSaveData.sonota2No = sonota2No;


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
        //Debug.Log("スキルをセーブ");

        string json = JsonUtility.ToJson(skillSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.skill.json", json);
    }
    public void BairituSave()
    {
        statusSaveData = new StatusSaveData();

        statusSaveData.kousekiMazyuuTokkou = kousekiMazyuuTokkou;
        statusSaveData.kousekiNinngennTokkou = kousekiNinngennTokkou;
        statusSaveData.kousekiMazinnTokkou = kousekiMazinnTokkou;
        statusSaveData.kousekiHusiTokkou = kousekiHusiTokkou;
        statusSaveData.kousekiAkumaTokkou = kousekiAkumaTokkou;
        statusSaveData.kousekiRyuuTokkou = kousekiRyuuTokkou;
        statusSaveData.kousekiKamiTokkou = kousekiKamiTokkou;
        statusSaveData.kousekiNomalDropRitu = kousekiNomalDropRitu;
        statusSaveData.kousekiReaDropRitu = kousekiReaDropRitu;
        statusSaveData.kousekiSuperReaDropRitu = kousekiSuperReaDropRitu;
        statusSaveData.kousekiEpikReaDropRitu = kousekiEpikReaDropRitu;
        statusSaveData.kousekiLegendaryReaDropRitu = kousekiLegendaryReaDropRitu;
        statusSaveData.kousekiGodReaDropRitu = kousekiGodReaDropRitu;
        statusSaveData.kyoukataikaGennsyouritu = kyoukataikaGennsyouritu;
        statusSaveData.kousekiGiftHuyoSoubiDropritu = kousekiGiftHuyoSoubiDropritu;

        string json = JsonUtility.ToJson(statusSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.kousekiBairitu.json", json);
    }
    public void StatusLoad()
    {
        string path = Application.persistentDataPath + "/savefile.status.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
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
            kinnkyoriWeponNo = loadData.kinnkyoriWeponNo;
            ennkyoriWeponNo = loadData.ennkyoriWeponNo;
            yoroiNo = loadData.yoroiNo;
            sonota1No = loadData.sonota1No;
            sonota2No = loadData.sonota2No;
        }
    }
    public void SkillLoad()
    {
        string path = Application.persistentDataPath + "/savefile.skill.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
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
    public void BairituLoad()
    {
        string path = Application.persistentDataPath + "/savefile.kousekiBairitu.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            StatusSaveData loadData = JsonUtility.FromJson<StatusSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            kousekiMazyuuTokkou = loadData.kousekiMazyuuTokkou;
            kousekiNinngennTokkou = loadData.kousekiNinngennTokkou;
            kousekiMazinnTokkou = loadData.kousekiMazinnTokkou;
            kousekiHusiTokkou = loadData.kousekiHusiTokkou;
            kousekiAkumaTokkou = loadData.kousekiAkumaTokkou;
            kousekiRyuuTokkou = loadData.kousekiRyuuTokkou;
            kousekiKamiTokkou = loadData.kousekiKamiTokkou;
            kousekiNomalDropRitu = loadData.kousekiNomalDropRitu;
            kousekiReaDropRitu = loadData.kousekiReaDropRitu;
            kousekiSuperReaDropRitu = loadData.kousekiSuperReaDropRitu;
            kousekiEpikReaDropRitu = loadData.kousekiEpikReaDropRitu;
            kousekiLegendaryReaDropRitu = loadData.kousekiLegendaryReaDropRitu;
            kousekiGodReaDropRitu = loadData.kousekiGodReaDropRitu;
            kyoukataikaGennsyouritu = loadData.kyoukataikaGennsyouritu;
            kousekiGiftHuyoSoubiDropritu = loadData.kousekiGiftHuyoSoubiDropritu;
        }
    }
    public void SoubiScritableSave()
    {
        //ダーティとしてマークする(変更があった事を記録する)
        //EditorUtility.SetDirty(kinnkyoriWeponDatas);
        //EditorUtility.SetDirty(ennkyoriWeponDatas);
        //EditorUtility.SetDirty(yoroiDatas);
        //EditorUtility.SetDirty(sonotaDatas);
        //保存する
        //AssetDatabase.SaveAssets();
        //Debug.Log("装備を保存した");

        soubiSaveData = new SoubiSaveData();

        soubiSaveData.kinnkyoriWeponDatas = kinnkyoriWeponDatas.weponDatas;
        soubiSaveData.ennkyoriWeponDatas = ennkyoriWeponDatas.weponDatas;
        soubiSaveData.yoroiDatas = yoroiDatas.weponDatas;
        soubiSaveData.sonotaDatas = sonotaDatas.weponDatas;

        /*
        kinnkyoriWeponDatas = weponDateBaseManager.weponDataList.weponDatas;
        ennkyoriWeponDatas = ennkyoriWeponDataBaseManager.weponDataList.weponDatas;
        yoroiDatas = yoroiDataBaseManager.weponDataList.weponDatas;
        sonotaDatas = sonotaDataBaseManager.weponDataList.weponDatas;

        soubiSaveData.kinnkyoriWeponDatas = kinnkyoriWeponDatas;
        soubiSaveData.ennkyoriWeponDatas = ennkyoriWeponDatas;
        soubiSaveData.yoroiDatas = yoroiDatas;
        soubiSaveData.sonotaDatas = sonotaDatas;
        */

        string json = JsonUtility.ToJson(soubiSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.soubi.json", json);
    }
    public void SoubiScritableLoad()
    {

        string path = Application.persistentDataPath + "/savefile.soubi.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            SoubiSaveData loadData = JsonUtility.FromJson<SoubiSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            kinnkyoriWeponDatas.weponDatas = loadData.kinnkyoriWeponDatas;
            ennkyoriWeponDatas.weponDatas = loadData.ennkyoriWeponDatas;
            yoroiDatas.weponDatas = loadData.yoroiDatas;
            sonotaDatas.weponDatas = loadData.sonotaDatas;
            
            for(int a=0;a<kinnkyoriWeponDatas.weponDatas.Count;a++)
            {
                kinnkyoriWeponDatas.weponDatas[a].srushEffect = soubiSaveZone.srushEffect[kinnkyoriWeponDatas.weponDatas[a].zukannNo];
                kinnkyoriWeponDatas.weponDatas[a].soubiIcon = soubiSaveZone.kinnkyoriWeponSoubiIcon[kinnkyoriWeponDatas.weponDatas[a].zukannNo];

                if (kinnkyoriWeponDatas.weponDatas[a].nomal)
                    kinnkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.kinnkyoriWeponReadoIcon[0];
                else if (kinnkyoriWeponDatas.weponDatas[a].rea)
                    kinnkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.kinnkyoriWeponReadoIcon[1];
                else if (kinnkyoriWeponDatas.weponDatas[a].superRea)
                    kinnkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.kinnkyoriWeponReadoIcon[2];
                else if(kinnkyoriWeponDatas.weponDatas[a].epik)
                    kinnkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.kinnkyoriWeponReadoIcon[3];
                else if(kinnkyoriWeponDatas.weponDatas[a].legendary)
                    kinnkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.kinnkyoriWeponReadoIcon[4];
                else if(kinnkyoriWeponDatas.weponDatas[a].god)
                    kinnkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.kinnkyoriWeponReadoIcon[5];

            }
            for (int a = 0; a < ennkyoriWeponDatas.weponDatas.Count; a++)
            {
                ennkyoriWeponDatas.weponDatas[a].soubiIcon = soubiSaveZone.ennkyoriWeponSoubiIcon[ennkyoriWeponDatas.weponDatas[a].zukannNo];

                if (ennkyoriWeponDatas.weponDatas[a].nomal)
                    ennkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.ennkyoriWeponReadoIcon[0];
                else if(ennkyoriWeponDatas.weponDatas[a].rea)
                    ennkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.ennkyoriWeponReadoIcon[1];
                else if(ennkyoriWeponDatas.weponDatas[a].superRea)
                    ennkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.ennkyoriWeponReadoIcon[2];
                else if(ennkyoriWeponDatas.weponDatas[a].epik)
                    ennkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.ennkyoriWeponReadoIcon[3];
                else if(ennkyoriWeponDatas.weponDatas[a].legendary)
                    ennkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.ennkyoriWeponReadoIcon[4];
                else if(ennkyoriWeponDatas.weponDatas[a].god)
                    ennkyoriWeponDatas.weponDatas[a].readoIcon = soubiSaveZone.ennkyoriWeponReadoIcon[5];
            }
            for (int a = 0; a < yoroiDatas.weponDatas.Count; a++)
            {
                yoroiDatas.weponDatas[a].soubiIcon = soubiSaveZone.yoroiSoubiIcon[yoroiDatas.weponDatas[a].zukannNo];

                if (yoroiDatas.weponDatas[a].nomal)
                    yoroiDatas.weponDatas[a].readoIcon = soubiSaveZone.yoroiReadoIcon[0];
                else if (yoroiDatas.weponDatas[a].rea)
                    yoroiDatas.weponDatas[a].readoIcon = soubiSaveZone.yoroiReadoIcon[1];
                else if(yoroiDatas.weponDatas[a].superRea)
                    yoroiDatas.weponDatas[a].readoIcon = soubiSaveZone.yoroiReadoIcon[2];
                else if(yoroiDatas.weponDatas[a].epik)
                    yoroiDatas.weponDatas[a].readoIcon = soubiSaveZone.yoroiReadoIcon[3];
                else if(yoroiDatas.weponDatas[a].legendary)
                    yoroiDatas.weponDatas[a].readoIcon = soubiSaveZone.yoroiReadoIcon[4];
                else if(yoroiDatas.weponDatas[a].god)
                    yoroiDatas.weponDatas[a].readoIcon = soubiSaveZone.yoroiReadoIcon[5];
            }
            for (int a = 0; a < sonotaDatas.weponDatas.Count; a++)
            {
                sonotaDatas.weponDatas[a].soubiIcon = soubiSaveZone.sonotaSoubiIcon[sonotaDatas.weponDatas[a].zukannNo];

                if (sonotaDatas.weponDatas[a].nomal)
                    sonotaDatas.weponDatas[a].readoIcon = soubiSaveZone.sonotaReadoIcon[0];
                else if(sonotaDatas.weponDatas[a].rea)
                    sonotaDatas.weponDatas[a].readoIcon = soubiSaveZone.sonotaReadoIcon[1];
                else if(sonotaDatas.weponDatas[a].superRea)
                    sonotaDatas.weponDatas[a].readoIcon = soubiSaveZone.sonotaReadoIcon[2];
                else if(sonotaDatas.weponDatas[a].epik)
                    sonotaDatas.weponDatas[a].readoIcon = soubiSaveZone.sonotaReadoIcon[3];
                else if(sonotaDatas.weponDatas[a].legendary)
                    sonotaDatas.weponDatas[a].readoIcon = soubiSaveZone.sonotaReadoIcon[4];
                else if(sonotaDatas.weponDatas[a].god)
                    sonotaDatas.weponDatas[a].readoIcon = soubiSaveZone.sonotaReadoIcon[5];
            }
            /*
            kinnkyoriWeponDatas = loadData.kinnkyoriWeponDatas;
            ennkyoriWeponDatas = loadData.ennkyoriWeponDatas;
            yoroiDatas = loadData.yoroiDatas;
            sonotaDatas = loadData.sonotaDatas;

            weponDateBaseManager.weponDataList.weponDatas = kinnkyoriWeponDatas;
            ennkyoriWeponDataBaseManager.weponDataList.weponDatas = ennkyoriWeponDatas;
            yoroiDataBaseManager.weponDataList.weponDatas = yoroiDatas;
            sonotaDataBaseManager.weponDataList.weponDatas = sonotaDatas;
            */
        }
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
        statusKaihiritu=10;

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

        kinnkyoriWeponNo = 1;
        ennkyoriWeponNo = 1;
        yoroiNo = 1;
        sonota1No = 1;
        sonota2No = 2;

        kousekiMazyuuTokkou = 0;
        kousekiNinngennTokkou = 0;
        kousekiMazinnTokkou = 0;
        kousekiHusiTokkou = 0;
        kousekiAkumaTokkou = 0;
        kousekiRyuuTokkou = 0;
        kousekiKamiTokkou = 0;
        kousekiNomalDropRitu = 0;
        kousekiReaDropRitu = 0;
        kousekiSuperReaDropRitu = 0;
        kousekiEpikReaDropRitu = 0;
        kousekiLegendaryReaDropRitu = 0;
        kousekiGodReaDropRitu = 0;
        kyoukataikaGennsyouritu = 0;
        kousekiGiftHuyoSoubiDropritu = 0;

        StatusSave();
        SkillSave();
        BairituSave();
    }
}

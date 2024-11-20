using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenEnemyZukannPanel : MonoBehaviour
{
    public bool openMonsterZukanBool = true;

    private GameObject databaseManger;
    private EnemyDataBaseManager enemyDataBaseManager;
    public EnemyDataList.EnemyData enemyData;
    private KakutokuDataBase soubiKakutokuDataBase;

    public int enemyNumber;

    public GameObject questionPanel;

    public GameObject zukannPanel;
    public GameObject zukannEnemyIconHaikei;
    private GameObject zukannEnemyIcon;
    public Text zukannEnemyName;

    public Text keikenntiText;
    public Text moneyText;

    public GameObject iconNamePanel;

    private GameObject instantiateSyuzokuIcon;
    public GameObject mazyuuIcon;
    public GameObject husiIcon;
    public GameObject akumaIcon;
    public GameObject mazinnIcon;
    public GameObject ninngennIcon;
    public GameObject ryuuIcon;
    public GameObject kamiIcon;

    public Text hp;
    public Text kougekiryoku;
    public Text kaisinnritu;
    public Text bougyoryoku;
    public Text kaisinnTaisei;
    public Text mahoubougyo;
    public Text meityuuritu;
    public Text kaihiritu;
    public Text kougekiHinndo;
    public Text kougekiHanni;
    public Text sokudo;
    public Text kannryouryoku;

    public GameObject dropSoubiPanel;

    public GameObject nomalSoubiIconHaikeiPreffab;
    public GameObject reaSoubiIconHaikeiPrefab;
    public GameObject superReaSoubiIconHaikeiPrefab;
    public GameObject epikReaSoubiIconHaikeiPrefab;
    public GameObject legendaryReaSoubiIconHaikeiPrefab;
    public GameObject godReaSoubiIconHaikeiPrefab;

    public GameObject dropSoubiStatusPanel;
    public OpenSoubiZukan nomalOpenSoubiZukan;
    public OpenSoubiZukan reaOpenSoubiZukan;
    public OpenSoubiZukan superReaOpenSoubiZukan;
    public OpenSoubiZukan epikReaOpenSoubiZukan;
    public OpenSoubiZukan legendaryReaOpenSoubiZukan;
    public OpenSoubiZukan godReaOpenSoubiZukan;

    public GameObject[] soubiIconHaikeis;
    public GameObject[] soubiIcons;
    public WeponDataList.WeponData[] soubiDatas;

    public GameObject soubiIconHaikeiSoubiZukan;
    public GameObject questionPanelPrefab;
    private OpenSoubiZukan soubiIconHaikei;

    public Text soubiName;
    public Text baikyakuKinngaku;

    public Text hpSoubiZukan;
    public Text mpSoubiZukan;
    public Text fbCostSoubiZukan;
    public Text kougekiryokuSoubiZukan;
    public Text maryokuSoubiZukan;
    public Text kinnkyoriKaisinnrituSoubiZukan;
    public Text ennkyoriKaisinnrituSoubiZukan;
    public Text bougyoryokuSoubiZukan;
    public Text kaisinnTaiseiSoubiZukan;
    public Text meityuurituSoubiZukan;
    public Text kaihirituSoubiZukan;
    public Text kougekiHinndoSoubiZukan;
    public Text syougekiryokuSoubiZukan;
    public Text kougekiHanniSoubiZukan;
    public Text mazyuuTokkouSoubiZukan;
    public Text ninngennTokkouSoubiZukan;
    public Text mazinnTokkouSoubiZukan;
    public Text husiTokkouSoubiZukan;
    public Text akumaTokkouSoubiZukan;
    public Text ryuuTokkouSoubiZukan;
    public Text kamiTokkouSoubiZukan;
    public Text soubiDropBairituSoubiZukan;
    public Text syougouHuyorituSoubiZukan;
    public Text giftHuyorituSoubiZukan;


    public GameObject hpText;
    public GameObject mp;
    public GameObject fbCost;
    public GameObject kougekiryokuText;
    public GameObject maryoku;
    public GameObject kinnkyori;
    public GameObject ennkyori;
    public GameObject bougyoryokuText;
    public GameObject kaisinnTaiseiText;
    public GameObject meityuurituText;
    public GameObject kaihirituText;
    public GameObject kougekiHinndoText;
    public GameObject syougekiryoku;
    public GameObject kougekiHanniText;
    public GameObject mazyuuTokkouText;
    public GameObject ninngennTokkouText;
    public GameObject mazinnTokkouText;
    public GameObject husiTokkouText;
    public GameObject akumaTokkouText;
    public GameObject ryuuTokkouText;
    public GameObject kamiTokkouText;
    public GameObject soubiDropBairituText;
    public GameObject syougouHuyorituText;
    public GameObject giftHuyorituText;


    public Text hpSyougouZukan;
    public Text mpSyougouZukan;
    public Text fbCostSyougouZukan;
    public Text kougekiryokuSyougouZukan;
    public Text maryokuSyougouZukan;
    public Text kinnkyoriKaisinnrituSyougouZukan;
    public Text ennkyoriKaisinnrituSyougouZukan;
    public Text bougyoryokuSyougouZukan;
    public Text kaisinnTaiseiSyougouZukan;
    public Text meityuurituSyougouZukan;
    public Text kaihirituSyougouZukan;
    public Text syougekiryokuSyougouZukan;
    public Text srushHinndoSyougouZukan;
    public Text kougekiHanniSyougouZukan;
    public Text mazyuuTokkouSyougouZukan;
    public Text ninngennTokkouSyougouZukan;
    public Text mazinnTokkouSyougouZukan;
    public Text husiTokkouSyougouZukan;
    public Text akumaTokkouSyougouZukan;
    public Text ryuuTokkouSyougouZukan;
    public Text kamiTokkouSyougouZukan;
    public Text soubiDropBairituSyougouZukan;
    public Text syougouDropRituSyougouZukan;
    public Text soubiGifthuyosoubiDroprituSyougouZukan;

    public GameObject hpSyougouZukanG;
    public GameObject mpSyougouZukanG;
    public GameObject fbCostSyougouZukanG;
    public GameObject kougekiryokuSyougouZukanG;
    public GameObject maryokuSyougouZukanG;
    public GameObject kinnkyoriKaisinnrituSyougouZukanG;
    public GameObject ennkyoriKaisinnrituSyougouZukanG;
    public GameObject bougyoryokuSyougouZukanG;
    public GameObject kaisinnTaiseiSyougouZukanG;
    public GameObject meityuurituSyougouZukanG;
    public GameObject kaihirituSyougouZukanG;
    public GameObject syougekiryokuSyougouZukanG;
    public GameObject srushHinndoSyougouZukanG;
    public GameObject kougekiHanniSyougouZukanG;
    public GameObject mazyuuTokkouSyougouZukanG;
    public GameObject ninngennTokkouSyougouZukanG;
    public GameObject mazinnTokkouSyougouZukanG;
    public GameObject husiTokkouSyougouZukanG;
    public GameObject akumaTokkouSyougouZukanG;
    public GameObject ryuuTokkouSyougouZukanG;
    public GameObject kamiTokkouSyougouZukanG;
    public GameObject soubiDropBairituSyougouZukanG;
    public GameObject syougouDropRituSyougouZukanG;
    public GameObject soubiGifthuyosoubiDroprituSyougouZukanG;

    public OpenSyougouStatusPanel openSyougouStatusPanelRea;
    public OpenSyougouStatusPanel openSyougouStatusPanelSuperRea;
    public OpenSyougouStatusPanel openSyougouStatusPanelEpikRea;

    public GameObject syougouStatusPanel;

    public GameObject reaSyougou;
    public GameObject superReaSyougou;
    public GameObject epikReaSyougou;
    public Text reaSyougouText;
    public Text superReaSyougouText;
    public Text epikReaSyougouText;

    public GameObject seisokutiPanel;
    public OpenSeisokutiPanel openSeisokutiPanel;

    public SoubiSkillDatabase soubiSkillDatabase;
    public SoubiSkillDataList.SoubiSkillData soubiSkillData;
    public GameObject soubiSkillPanel;
    public Text skillName;
    public Text skillNameFromPanel;
    public Text skillSyousai;
    public Text skillIryoku;
    public bool skill;
    public GameObject skillButton;
    private void Update()
    {
        if(openMonsterZukanBool)
        {
            databaseManger = DontDestroyOnloadDataBaseManager.DataBaseManager;
            enemyDataBaseManager = databaseManger.GetComponent<EnemyDataBaseManager>();
            soubiKakutokuDataBase = databaseManger.GetComponent<KakutokuDataBase>();
            enemyData = databaseManger.GetComponent<EnemyDataBaseManager>().GetEnemyData(enemyNumber);
            if (soubiKakutokuDataBase.enemyGekihasuuNo[enemyData.no]>=1) questionPanel.SetActive(false);
            
            openMonsterZukanBool = false;
        }
    }
    public void OpenMonsterZukann()
    {
        if (soubiKakutokuDataBase.enemyGekihasuuNo[enemyData.no] == 0) return;
        zukannEnemyIcon = gameObject.transform.GetChild(0).gameObject;
        zukannPanel.SetActive(true);
        Instantiate(zukannEnemyIcon, zukannEnemyIconHaikei.transform);
        zukannEnemyName.text = enemyData.enemyName;

        keikenntiText.text = enemyData.exp.ToString("N0");
        moneyText.text = enemyData.gold.ToString("N0");

        if (enemyData.mazyuu) instantiateSyuzokuIcon = Instantiate(mazyuuIcon, iconNamePanel.transform);
        else if (enemyData.husi) instantiateSyuzokuIcon = Instantiate(husiIcon, iconNamePanel.transform);
        else if (enemyData.akuma) instantiateSyuzokuIcon = Instantiate(akumaIcon, iconNamePanel.transform);
        else if (enemyData.mazinn) instantiateSyuzokuIcon = Instantiate(mazinnIcon, iconNamePanel.transform);
        else if (enemyData.ninngenn) instantiateSyuzokuIcon = Instantiate(ninngennIcon, iconNamePanel.transform);
        else if (enemyData.ryuu) instantiateSyuzokuIcon = Instantiate(ryuuIcon, iconNamePanel.transform);
        else if (enemyData.kami) instantiateSyuzokuIcon = Instantiate(kamiIcon, iconNamePanel.transform);
        instantiateSyuzokuIcon.transform.localPosition = new Vector3(316, 0);

        hp.text = enemyData.maxHp.ToString();
        kougekiryoku.text = enemyData.kougekiryoku.ToString();
        kaisinnritu.text = enemyData.kaisinnritu.ToString() + "%";
        bougyoryoku.text = enemyData.bougyoryoku.ToString();
        kaisinnTaisei.text = enemyData.kaisinnTaisei.ToString() + "%";
        mahoubougyo.text = enemyData.mahouBougyoryoku.ToString();
        meityuuritu.text = enemyData.meityuuritu.ToString() + "%";
        kaihiritu.text = enemyData.kaihiritu.ToString() + "%";
        kougekiHinndo.text = enemyData.kougekiHinndo.ToString() + "秒";
        //kougekiHanni.text = enemyData.kougekiHanni.ToString();
        sokudo.text = enemyData.speed.ToString();
        kannryouryoku.text = enemyData.nokkubakkuBougyo.ToString();

        //装備アイコン背景を生成
        System.Array.Clear(soubiIconHaikeis, 0, soubiIconHaikeis.Length);
        for (int a = 5; a < enemyData.dropItemSuu; a++)
        {
            if (enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.nomal)
            {
                nomalOpenSoubiZukan = Instantiate(nomalSoubiIconHaikeiPreffab, dropSoubiPanel.transform).GetComponent<OpenSoubiZukan>();
                nomalOpenSoubiZukan.dropSoubiStatusPanel = dropSoubiStatusPanel;
                nomalOpenSoubiZukan.soubiNumber = enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.no;
            }
            else if (enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.rea)
            {
                reaOpenSoubiZukan = Instantiate(reaSoubiIconHaikeiPrefab, dropSoubiPanel.transform).GetComponent<OpenSoubiZukan>();
                reaOpenSoubiZukan.dropSoubiStatusPanel = dropSoubiStatusPanel;
                reaOpenSoubiZukan.soubiNumber = enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.no;
            }
            else if (enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.superRea)
            {
                superReaOpenSoubiZukan = Instantiate(superReaSoubiIconHaikeiPrefab, dropSoubiPanel.transform).GetComponent<OpenSoubiZukan>();
                superReaOpenSoubiZukan.dropSoubiStatusPanel = dropSoubiStatusPanel;
                superReaOpenSoubiZukan.soubiNumber = enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.no;
            }
            else if (enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.epik)
            {
                epikReaOpenSoubiZukan = Instantiate(epikReaSoubiIconHaikeiPrefab, dropSoubiPanel.transform).GetComponent<OpenSoubiZukan>();
                epikReaOpenSoubiZukan.dropSoubiStatusPanel = dropSoubiStatusPanel;
                epikReaOpenSoubiZukan.soubiNumber = enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.no;
            }
            else if (enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.legendary)
            {
                legendaryReaOpenSoubiZukan = Instantiate(legendaryReaSoubiIconHaikeiPrefab, dropSoubiPanel.transform).GetComponent<OpenSoubiZukan>();
                legendaryReaOpenSoubiZukan.dropSoubiStatusPanel = dropSoubiStatusPanel;
                legendaryReaOpenSoubiZukan.soubiNumber = enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.no;
            }
            else if (enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.god)
            {
                godReaOpenSoubiZukan = Instantiate(godReaSoubiIconHaikeiPrefab, dropSoubiPanel.transform).GetComponent<OpenSoubiZukan>();
                godReaOpenSoubiZukan.dropSoubiStatusPanel = dropSoubiStatusPanel;
                godReaOpenSoubiZukan.soubiNumber = enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus.no;
            }
        }
        soubiIconHaikeis = GameObject.FindGameObjectsWithTag("SoubiIconHaikei");//パネルを閉じるときに全削除する

        //装備アイコンを装備アイコンの子オブジェクトとして生成

        System.Array.Clear(soubiIcons, 0, soubiIcons.Length);
        soubiDatas = new WeponDataList.WeponData[enemyData.dropItemSuu - 5];
        for (int a = 5; a < enemyData.dropItemSuu; a++)
        {
            soubiDatas[a - 5] = enemyDataBaseManager.dropItemPrefabs[enemyData.dropItemNos[a]].GetComponent<ItemController>().itemStatus;
            if (soubiKakutokuDataBase.kakutokuNo[soubiDatas[a-5].no]>0)Instantiate(soubiDatas[a - 5].soubiIcon, soubiIconHaikeis[a - 5].transform);
            else Instantiate(questionPanelPrefab, soubiIconHaikeis[a - 5].transform);
        }

        for (int a = 0; a < soubiIconHaikeis.Length; a++)
        {
            soubiIconHaikei = soubiIconHaikeis[a].GetComponent<OpenSoubiZukan>();
            soubiIconHaikei.openEnemyZukannPanel = this;
            soubiIconHaikei.enemyData = enemyData;
            soubiIconHaikei.enemyDataBaseManager = enemyDataBaseManager;
            soubiIconHaikei.soubiNumber = enemyData.dropItemNos[a + 5];
        }

        //以下、称号関係
        openSyougouStatusPanelRea.syougouBase = enemyData.dropSyougou[0].GetComponent<SyougouBase>();
        openSyougouStatusPanelSuperRea.syougouBase = enemyData.dropSyougou[1].GetComponent<SyougouBase>();
        openSyougouStatusPanelEpikRea.syougouBase = enemyData.dropSyougou[2].GetComponent<SyougouBase>();

        reaSyougouText.text = enemyData.dropSyougou[0].GetComponent<SyougouBase>().syougouStatus.syougouName;
        superReaSyougouText.text = enemyData.dropSyougou[1].GetComponent<SyougouBase>().syougouStatus.syougouName;
        epikReaSyougouText.text = enemyData.dropSyougou[2].GetComponent<SyougouBase>().syougouStatus.syougouName;

        //以下、生息地関係
        openSeisokutiPanel.enemyBase = enemyData;
    }
    public void SoubiSkillSet(WeponDataList.WeponData weponData)
    {
        soubiSkillDatabase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SoubiSkillDatabase>();
        if (weponData.skill)
        {
            soubiSkillData = soubiSkillDatabase.GetSoubiSkillData(weponData.skillNo);
            skill = true;
        }
        else skill = false;

        if (skill) skillName.text = "スキル:"+soubiSkillData.skillName;
        else skillName.text = "スキル:なし";

        skillButton.GetComponent<EnemyZukanSoubiSkillButton>().openEnemyZukannPanel = this;
    }
    public void OpenSoubiSkillPanel()
    {
        if (skill)
        {
            soubiSkillPanel.SetActive(true);
            skillNameFromPanel.text = soubiSkillData.skillName;
            skillSyousai.text = soubiSkillData.skillSetumei;
            if (soubiSkillData.iryoku == 0) skillIryoku.gameObject.SetActive(false);
            else skillIryoku.text = "威力:"+soubiSkillData.iryoku;
        }
    }
    public void CloseMonsterZukann()
    {
        foreach (Transform child in dropSoubiPanel.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in zukannEnemyIconHaikei.transform)
        {
            Destroy(child.gameObject);
        }
        Destroy(instantiateSyuzokuIcon);

        if (dropSoubiStatusPanel.activeSelf) CloseSoubiStatusPanel();
        if (syougouStatusPanel.activeSelf) CloseSyougouStatusPanel();
        if (seisokutiPanel.activeSelf) openSeisokutiPanel.CloseSeisokutiPanelMesod();

        zukannPanel.SetActive(false);
    }
    public void CloseSoubiStatusPanel()
    {
        baikyakuKinngaku.gameObject.SetActive(true);
        hpSoubiZukan.gameObject.SetActive(true);
        mpSoubiZukan.gameObject.SetActive(true);
        fbCostSoubiZukan.gameObject.SetActive(true);
        kougekiryokuSoubiZukan.gameObject.SetActive(true);
        maryokuSoubiZukan.gameObject.SetActive(true);
        kinnkyoriKaisinnrituSoubiZukan.gameObject.SetActive(true);
        ennkyoriKaisinnrituSoubiZukan.gameObject.SetActive(true);
        bougyoryokuSoubiZukan.gameObject.SetActive(true);
        kaisinnTaiseiSoubiZukan.gameObject.SetActive(true);
        meityuurituSoubiZukan.gameObject.SetActive(true);
        kaihirituSoubiZukan.gameObject.SetActive(true);
        kougekiHinndoSoubiZukan.gameObject.SetActive(true);
        syougekiryokuSoubiZukan.gameObject.SetActive(true);
        kougekiHanniSoubiZukan.gameObject.SetActive(true);

        hpText.gameObject.SetActive(true);
        mp.gameObject.SetActive(true);
        fbCost.gameObject.SetActive(true);
        kougekiryokuText.gameObject.SetActive(true);
        maryoku.gameObject.SetActive(true);
        kinnkyori.gameObject.SetActive(true);
        ennkyori.gameObject.SetActive(true);
        bougyoryokuText.gameObject.SetActive(true);
        kaisinnTaiseiText.gameObject.SetActive(true);
        meityuurituText.gameObject.SetActive(true);
        kaihirituText.gameObject.SetActive(true);
        kougekiHinndoText.gameObject.SetActive(true);
        syougekiryoku.gameObject.SetActive(true);
        kougekiHanniText.gameObject.SetActive(true);

        mazyuuTokkouText.SetActive(true);
        mazyuuTokkouSoubiZukan.gameObject.SetActive(true);
        ninngennTokkouText.SetActive(true);
        ninngennTokkouSoubiZukan.gameObject.SetActive(true);
        mazinnTokkouText.SetActive(true);
        mazinnTokkouSoubiZukan.gameObject.SetActive(true);
        husiTokkouText.SetActive(true);
        husiTokkouSoubiZukan.gameObject.SetActive(true);
        akumaTokkouText.SetActive(true);
        akumaTokkouSoubiZukan.gameObject.SetActive(true);
        ryuuTokkouText.SetActive(true);
        ryuuTokkouSoubiZukan.gameObject.SetActive(true);
        kamiTokkouText.SetActive(true);
        kamiTokkouSoubiZukan.gameObject.SetActive(true);
        soubiDropBairituText.SetActive(true);
        soubiDropBairituSoubiZukan.gameObject.SetActive(true);
        syougouHuyorituText.SetActive(true);
        syougouHuyorituSoubiZukan.gameObject.SetActive(true);
        giftHuyorituText.SetActive(true);
        giftHuyorituSoubiZukan.gameObject.SetActive(true);

        foreach (Transform child in soubiIconHaikeiSoubiZukan.transform)
        {
            Destroy(child.gameObject);
        }

        dropSoubiStatusPanel.SetActive(false);
    }
    public void CloseSyougouStatusPanel()
    {
        hpSyougouZukan.gameObject.SetActive(true);
        hpSyougouZukanG.SetActive(true);
        mpSyougouZukan.gameObject.SetActive(true);
        mpSyougouZukanG.SetActive(true);
        fbCostSyougouZukan.gameObject.SetActive(true);
        fbCostSyougouZukanG.SetActive(true);
        kougekiryokuSyougouZukan.gameObject.SetActive(true);
        kougekiryokuSyougouZukanG.SetActive(true);
        maryokuSyougouZukan.gameObject.SetActive(true);
        maryokuSyougouZukanG.SetActive(true);
        kinnkyoriKaisinnrituSyougouZukan.gameObject.SetActive(true);
        kinnkyoriKaisinnrituSyougouZukanG.SetActive(true);
        ennkyoriKaisinnrituSyougouZukan.gameObject.SetActive(true);
        ennkyoriKaisinnrituSyougouZukanG.SetActive(true);
        bougyoryokuSyougouZukan.gameObject.SetActive(true);
        bougyoryokuSyougouZukanG.SetActive(true);
        kaisinnTaiseiSyougouZukan.gameObject.SetActive(true);
        kaisinnTaiseiSyougouZukanG.SetActive(true);
        meityuurituSyougouZukan.gameObject.SetActive(true);
        meityuurituSyougouZukanG.SetActive(true);
        kaihirituSyougouZukan.gameObject.SetActive(true);
        kaihirituSyougouZukanG.SetActive(true);
        syougekiryokuSyougouZukan.gameObject.SetActive(true);
        syougekiryokuSyougouZukanG.SetActive(true);
        srushHinndoSyougouZukan.gameObject.SetActive(true);
        srushHinndoSyougouZukanG.SetActive(true);
        kougekiHanniSyougouZukan.gameObject.SetActive(true);
        kougekiHanniSyougouZukanG.SetActive(true);
        mazyuuTokkouSyougouZukan.gameObject.SetActive(true);
        mazyuuTokkouSyougouZukanG.SetActive(true);
        ninngennTokkouSyougouZukan.gameObject.SetActive(true);
        ninngennTokkouSyougouZukanG.SetActive(true);
        mazinnTokkouSyougouZukan.gameObject.SetActive(true);
        mazinnTokkouSyougouZukanG.SetActive(true);
        husiTokkouSyougouZukan.gameObject.SetActive(true);
        husiTokkouSyougouZukanG.SetActive(true);
        akumaTokkouSyougouZukan.gameObject.SetActive(true);
        akumaTokkouSyougouZukanG.SetActive(true);
        ryuuTokkouSyougouZukan.gameObject.SetActive(true);
        ryuuTokkouSyougouZukanG.SetActive(true);
        kamiTokkouSyougouZukan.gameObject.SetActive(true);
        kamiTokkouSyougouZukanG.SetActive(true);
        soubiDropBairituSyougouZukan.gameObject.SetActive(true);
        soubiDropBairituSyougouZukanG.SetActive(true);
        syougouDropRituSyougouZukan.gameObject.SetActive(true);
        syougouDropRituSyougouZukanG.SetActive(true);
        soubiGifthuyosoubiDroprituSyougouZukan.gameObject.SetActive(true);
        soubiGifthuyosoubiDroprituSyougouZukanG.SetActive(true);

        syougouStatusPanel.SetActive(false);
    }
}

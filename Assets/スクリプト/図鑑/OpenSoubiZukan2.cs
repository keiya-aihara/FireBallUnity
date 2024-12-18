using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSoubiZukan2 : MonoBehaviour
{
    private EnemyDataBaseManager enemyDataBaseManager;
    private KakutokuDataBase soubiKakutokuDataBase;
    private OpenSoubiStatusPanel openSoubiStatusPanel;

    public GameObject nomalHaikei;
    public GameObject reaHaikei;
    public GameObject superReaHaikei;
    public GameObject epikReaHaikei;
    public GameObject legendaryReaHaikei;
    public GameObject godReaHaikei;

    public GameObject haikeiPanel;
    public GameObject[] haikeiPanels;

    public GameObject questionPanel;

    public GameObject soubiZukanContent;

    public GameObject soubiZukan;

    public GameObject soubiStatusPanel;

    public GameObject soubiIconHaikei;

    public Text soubiName;
    public Text baikyakuKinngaku;

    public GameObject hp;
    public GameObject mp;
    public GameObject fbCost;
    public GameObject kougekiryoku;
    public GameObject maryoku;
    public GameObject kinnkyoriKaisinnritu;
    public GameObject ennkyoriKaisinnritu;
    public GameObject bougyoryoku;
    public GameObject kaisinnTaisei;
    public GameObject meityuuritu;
    public GameObject kaihiritu;
    public GameObject kougekiHinndo;
    public GameObject syougekiryoku;
    public GameObject kougekiHanni;
    public GameObject mazyuuTokkou;
    public GameObject ninngennTokkou;
    public GameObject mazinnTokkou;
    public GameObject husiTokkou;
    public GameObject akumaTokkou;
    public GameObject ryuuTokkou;
    public GameObject kamiTokkou;
    public GameObject soubiDropBairitu;
    public GameObject syougouHuyoritu;
    public GameObject giftHuyoritu;

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

    private WeponDataList.WeponData weponData2;
    private SoubiSkillDatabase soubiSkillDatabase;
    public SoubiSkillDataList.SoubiSkillData soubiSkillData;
    public GameObject soubiSkillPanel;
    public Text skillName;
    public Text skillNameFromPanel;
    public Text skillSyousai;
    public Text skillIryoku;
    public void OpenSoubiZukan()
    {
        enemyDataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<EnemyDataBaseManager>();
        soubiKakutokuDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KakutokuDataBase>();
        soubiZukan.SetActive(true);
        for (int a = 0; a < enemyDataBaseManager.dropItemPrefabs.Length; a++)
        {
            if (enemyDataBaseManager.dropItemPrefabs[a].GetComponent<ItemController>().itemStatus.nomal) haikeiPanel = Instantiate(nomalHaikei, soubiZukanContent.transform);
            else if (enemyDataBaseManager.dropItemPrefabs[a].GetComponent<ItemController>().itemStatus.rea) haikeiPanel = Instantiate(reaHaikei, soubiZukanContent.transform);
            else if (enemyDataBaseManager.dropItemPrefabs[a].GetComponent<ItemController>().itemStatus.superRea) haikeiPanel = Instantiate(superReaHaikei, soubiZukanContent.transform);
            else if (enemyDataBaseManager.dropItemPrefabs[a].GetComponent<ItemController>().itemStatus.epik) haikeiPanel = Instantiate(epikReaHaikei, soubiZukanContent.transform);
            else if (enemyDataBaseManager.dropItemPrefabs[a].GetComponent<ItemController>().itemStatus.legendary) haikeiPanel = Instantiate(legendaryReaHaikei, soubiZukanContent.transform);
            else if (enemyDataBaseManager.dropItemPrefabs[a].GetComponent<ItemController>().itemStatus.god) haikeiPanel = Instantiate(godReaHaikei, soubiZukanContent.transform);

            openSoubiStatusPanel = haikeiPanel.GetComponent<OpenSoubiStatusPanel>();
            openSoubiStatusPanel.weponData = enemyDataBaseManager.dropItemPrefabs[a].GetComponent<ItemController>().itemStatus;
           
            if (soubiKakutokuDataBase.kakutokuNo[a] > 0) Instantiate(openSoubiStatusPanel.weponData.soubiIcon, haikeiPanel.transform);
            else Instantiate(questionPanel, haikeiPanel.transform);
        }
    }
    public void CloseSoubiZukan()
    {
        foreach (Transform child in soubiZukanContent.transform)
        {
            Destroy(child.gameObject);
        }
        if (soubiStatusPanel.activeSelf) CloseSoubiStatusPanel();

        soubiZukan.SetActive(false);
    }
    public void CloseSoubiStatusPanel()
    {
        foreach (Transform n in soubiIconHaikei.transform)
        {
            GameObject.Destroy(n.gameObject);
        }

        hp.SetActive(true);
        hpSoubiZukan.gameObject.SetActive(true);
        mp.SetActive(true);
        mpSoubiZukan.gameObject.SetActive(true);
        fbCost.SetActive(true);
        gameObject.SetActive(true);
        kougekiryoku.SetActive(true);
        kougekiryokuSoubiZukan.gameObject.SetActive(true);
        maryoku.SetActive(true);
        maryokuSoubiZukan.gameObject.SetActive(true);
        kinnkyoriKaisinnritu.SetActive(true);
        kinnkyoriKaisinnrituSoubiZukan.gameObject.SetActive(true);
        ennkyoriKaisinnritu.SetActive(true);
        ennkyoriKaisinnrituSoubiZukan.gameObject.SetActive(true);
        bougyoryoku.SetActive(true);
        bougyoryokuSoubiZukan.gameObject.SetActive(true);
        kaisinnTaisei.SetActive(true);
        kaisinnTaiseiSoubiZukan.gameObject.SetActive(true);
        meityuuritu.SetActive(true);
        meityuurituSoubiZukan.gameObject.SetActive(true);
        kaihiritu.SetActive(true);
        kaihirituSoubiZukan.gameObject.SetActive(true);
        kougekiHinndo.SetActive(true);
        kougekiHinndoSoubiZukan.gameObject.SetActive(true);
        syougekiryoku.SetActive(true);
        syougekiryokuSoubiZukan.gameObject.SetActive(true);
        kougekiHanni.SetActive(true);
        kougekiHanniSoubiZukan.gameObject.SetActive(true);
        mazyuuTokkou.SetActive(true);
        mazyuuTokkouSoubiZukan.gameObject.SetActive(true);
        ninngennTokkou.SetActive(true);
        ninngennTokkouSoubiZukan.gameObject.SetActive(true);
        mazinnTokkou.SetActive(true);
        mazinnTokkouSoubiZukan.gameObject.SetActive(true);
        husiTokkou.SetActive(true);
        husiTokkouSoubiZukan.gameObject.SetActive(true);
        akumaTokkou.SetActive(true);
        akumaTokkouSoubiZukan.gameObject.SetActive(true);
        ryuuTokkou.SetActive(true);
        ryuuTokkouSoubiZukan.gameObject.SetActive(true);
        kamiTokkou.SetActive(true);
        kamiTokkouSoubiZukan.gameObject.SetActive(true);
        soubiDropBairitu.SetActive(true);
        soubiDropBairituSoubiZukan.gameObject.SetActive(true);
        syougouHuyoritu.SetActive(true);
        syougouHuyorituSoubiZukan.gameObject.SetActive(true);
        giftHuyoritu.SetActive(true);
        giftHuyorituSoubiZukan.gameObject.SetActive(true);

        soubiStatusPanel.SetActive(false);
    }
    public void OpenSoubiStatusPanelMesod(WeponDataList.WeponData weponData,GameObject soubiReadoHaikeiPrefab)
    {
        if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KakutokuDataBase>().kakutokuNo[weponData.no] == 0) return;
        if (gameObject.transform.parent.name == "装備アイコン背景") return;

        soubiStatusPanel.SetActive(true);
        Instantiate(soubiReadoHaikeiPrefab, soubiIconHaikei.transform);

        soubiName.text = weponData.name;
        baikyakuKinngaku.text = weponData.baikyakuKinngaku.ToString("N0");

        soubiSkillDatabase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SoubiSkillDatabase>();
        soubiSkillData = soubiSkillDatabase.GetSoubiSkillData(weponData.skillNo);
        if (weponData.skill) skillName.text = "スキル:" + soubiSkillData.skillName;
        else skillName.text = "スキル:なし";

        if (weponData.maxHp == 0)
        {
            hpSoubiZukan.gameObject.SetActive(false);
            hp.SetActive(false);
        }
        else hpSoubiZukan.text = weponData.maxHp.ToString("N0");
        if (weponData.maxMp == 0)
        {
            mpSoubiZukan.gameObject.SetActive(false);
            mp.SetActive(false);
        }
        else mpSoubiZukan.text = weponData.maxMp.ToString("N0");
        if (weponData.fireBallCost == 0)
        {
            fbCostSoubiZukan.gameObject.SetActive(false);
            fbCost.SetActive(false);
        }
        else fbCostSoubiZukan.text = weponData.fireBallCost.ToString("N0");
        if (weponData.kougekiryoku == 0)
        {
            kougekiryokuSoubiZukan.gameObject.SetActive(false);
            kougekiryoku.SetActive(false);
        }
        else kougekiryokuSoubiZukan.text = weponData.kougekiryoku.ToString("N0");
        if (weponData.maryoku == 0)
        {
            maryokuSoubiZukan.gameObject.SetActive(false);
            maryoku.SetActive(false);
        }
        else maryokuSoubiZukan.text = weponData.maryoku.ToString("N0");
        if (weponData.kinnkyoriKaisinnritu == 0)
        {
            kinnkyoriKaisinnrituSoubiZukan.gameObject.SetActive(false);
            kinnkyoriKaisinnritu.SetActive(false);
        }
        else kinnkyoriKaisinnrituSoubiZukan.text = weponData.kinnkyoriKaisinnritu.ToString("N0") + "%";
        if (weponData.ennkyoriKaisinnsitu == 0)
        {
            ennkyoriKaisinnrituSoubiZukan.gameObject.SetActive(false);
            ennkyoriKaisinnritu.SetActive(false);
        }
        else ennkyoriKaisinnrituSoubiZukan.text = weponData.ennkyoriKaisinnsitu.ToString("N0") + "%";
        if (weponData.bougyoryoiku == 0)
        {
            bougyoryokuSoubiZukan.gameObject.SetActive(false);
            bougyoryoku.SetActive(false);
        }
        else bougyoryokuSoubiZukan.text = weponData.bougyoryoiku.ToString("N0");
        if (weponData.kaisinnTaisei == 0)
        {
            kaisinnTaiseiSoubiZukan.gameObject.SetActive(false);
            kaisinnTaisei.SetActive(false);
        }
        else kaisinnTaiseiSoubiZukan.text = weponData.kaisinnTaisei.ToString("N0") + "%";
        if (weponData.meityuuritu == 0)
        {
            meityuurituSoubiZukan.gameObject.SetActive(false);
            meityuuritu.SetActive(false);
        }
        else meityuurituSoubiZukan.text = weponData.meityuuritu.ToString("N0") + "%";
        if (weponData.kaihiritu == 0)
        {
            kaihirituSoubiZukan.gameObject.SetActive(false);
            kaihiritu.SetActive(false);
        }
        else kaihirituSoubiZukan.text = weponData.kaihiritu.ToString("N0") + "%";
        if (weponData.kougekiHinndo == 0)
        {
            kougekiHinndoSoubiZukan.gameObject.SetActive(false);
            kougekiHinndo.SetActive(false);
        }
        else kougekiHinndoSoubiZukan.text = weponData.kougekiHinndo.ToString("N0") + "秒";
        if (weponData.nokkubakku == 0)
        {
            syougekiryokuSoubiZukan.gameObject.SetActive(false);
            syougekiryoku.SetActive(false);
        }
        else syougekiryokuSoubiZukan.text = weponData.nokkubakku.ToString("N0");
        if (weponData.kougekiHanni == 0)
        {
            kougekiHanniSoubiZukan.gameObject.SetActive(false);
            kougekiHanni.SetActive(false);
        }
        else kougekiHanniSoubiZukan.text = weponData.kougekiHanni.ToString("N0") + "m";
        if (weponData.soubiMazyuuTokkou == 0)
        {
            mazyuuTokkouSoubiZukan.gameObject.SetActive(false);
            mazyuuTokkou.SetActive(false);
        }
        else mazyuuTokkouSoubiZukan.text = weponData.soubiMazyuuTokkou.ToString("N0") + "%";
        if (weponData.soubiNinngennTokkou == 0)
        {
            ninngennTokkouSoubiZukan.gameObject.SetActive(false);
            ninngennTokkou.SetActive(false);
        }
        else ninngennTokkouSoubiZukan.text = weponData.soubiNinngennTokkou.ToString("N0") + "%";
        if (weponData.soubiMazinnTokkou == 0)
        {
            mazinnTokkouSoubiZukan.gameObject.SetActive(false);
            mazinnTokkou.SetActive(false);
        }
        else mazinnTokkouSoubiZukan.text = weponData.soubiMazinnTokkou.ToString("N0") + "%";
        if (weponData.soubiHusiTokkou == 0)
        {
            husiTokkouSoubiZukan.gameObject.SetActive(false);
            husiTokkou.SetActive(false);
        }
        else husiTokkouSoubiZukan.text = weponData.soubiHusiTokkou.ToString("N0") + "%";
        if (weponData.soubiAkumaTokkou == 0)
        {
            akumaTokkouSoubiZukan.gameObject.SetActive(false);
            akumaTokkou.SetActive(false);
        }
        else akumaTokkouSoubiZukan.text = weponData.soubiAkumaTokkou.ToString("N0") + "%";
        if (weponData.soubiRyuuTokkou == 0)
        {
            ryuuTokkouSoubiZukan.gameObject.SetActive(false);
            ryuuTokkou.SetActive(false);
        }
        else ryuuTokkouSoubiZukan.text = weponData.soubiRyuuTokkou.ToString("N0") + "%";
        if (weponData.soubiKamiTokkou == 0)
        {
            kamiTokkouSoubiZukan.gameObject.SetActive(false);
            kamiTokkou.SetActive(false);
        }
        else kamiTokkouSoubiZukan.text = weponData.soubiKamiTokkou.ToString("N0") + "%";
        if (weponData.soubiDropBairitu == 0)
        {
            soubiDropBairituSoubiZukan.gameObject.SetActive(false);
            soubiDropBairitu.SetActive(false);
        }
        else soubiDropBairituSoubiZukan.text = weponData.soubiDropBairitu.ToString("N0") + "%";
        if (weponData.syougouDropRitu == 0)
        {
            syougouHuyorituSoubiZukan.gameObject.SetActive(false);
            syougouHuyoritu.SetActive(false);
        }
        else syougouHuyorituSoubiZukan.text = weponData.syougouDropRitu.ToString("N0") + "%";
        if (weponData.soubiGifthuyosoubiDropritu == 0)
        {
            giftHuyorituSoubiZukan.gameObject.SetActive(false);
            giftHuyoritu.SetActive(false);
        }
        else giftHuyorituSoubiZukan.text = weponData.soubiGifthuyosoubiDropritu.ToString("N0") + "%";

        weponData2 = weponData;
    }
    public void OpenSkillPanel()
    {
        if (weponData2.skill)
        {
            soubiSkillPanel.SetActive(true);
            skillNameFromPanel.text = soubiSkillData.skillName;
            skillSyousai.text = soubiSkillData.skillSetumei;
            if (soubiSkillData.iryoku == 0) skillIryoku.gameObject.SetActive(false);
            else skillIryoku.text = "威力:" + soubiSkillData.iryoku.ToString();
        }
    }
}

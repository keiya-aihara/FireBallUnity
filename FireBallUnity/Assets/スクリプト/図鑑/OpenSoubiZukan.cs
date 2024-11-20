using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSoubiZukan : MonoBehaviour
{
    public OpenEnemyZukannPanel openEnemyZukannPanel;
    public GameObject dropSoubiStatusPanel;

    public  EnemyDataBaseManager enemyDataBaseManager;
    public EnemyDataList.EnemyData enemyData;
    private WeponDataList.WeponData weponData;
    private KakutokuDataBase soubiKakutokuDataBase;

    public GameObject nomalIconHaikei;
    public GameObject reaIconHaikei;
    public GameObject superReaIconHaikei;
    public GameObject epikReaIconHaikei;
    public GameObject legendaryReaIconHaikei;
    public GameObject godReaIconHaikei;

    public int soubiNumber;

    private GameObject soubiIconHaikeiSoubiZukan;
    private GameObject soubiIconSoubizukan;

    private Text soubiName;
    private Text baikyakuKinngaku;

    private Text hpSoubiZukan;
    private Text mpSoubiZukan;
    private Text fbCostSoubiZukan;
    private Text kougekiryokuSoubiZukan;
    private Text maryokuSoubiZukan;
    private Text kinnkyoriKaisinnrituSoubiZukan;
    private Text ennkyoriKaisinnrituSoubiZukan;
    private Text bougyoryokuSoubiZukan;
    private Text kaisinnTaiseiSoubiZukan;
    private Text meityuurituSoubiZukan;
    private Text kaihirituSoubiZukan;
    private Text kougekiHinndoSoubiZukan;
    private Text syougekiryokuSoubiZukan;
    private Text kougekiHanniSoubiZukan;
    private Text mazyuuTokkouSoubiZukan;
    private Text ninngennTokkouSoubiZukan;
    private Text mazinnTokkouSoubiZukan;
    private Text husiTokkouSoubiZukan;
    private Text akumaTokkouSoubiZukan;
    private Text ryuuTokkouSoubiZukan;
    private Text kamiTokkouSoubiZukan;
    private Text soubiDropBairituSoubiZukan;
    private Text syougouHuyorituSoubiZukan;
    private Text giftHuyorituSoubiZukan;

    private GameObject hp;
    private GameObject mp;
    private GameObject fbCost;
    private GameObject kougekiryoku;
    private GameObject maryoku;
    private GameObject kinnkyoriKaisinnritu;
    private GameObject ennkyoriKaisinnritu;
    private GameObject bougyoryoku;
    private GameObject kaisinnTaisei;
    private GameObject meityuuritu;
    private GameObject kaihiritu;
    private GameObject kougekiHinndo;
    private GameObject syougekiryoku;
    private GameObject kougekiHanni;
    private GameObject mazyuuTokkou;
    private GameObject ninngennTokkou;
    private GameObject mazinnTokkou;
    private GameObject husiTokkou;
    private GameObject akumaTokkou;
    private GameObject ryuuTokkou;
    private GameObject kamiTokkou;
    private GameObject soubiDropBairitu;
    private GameObject syougouHuyoritu;
    private GameObject giftHuyoritu;

    private GameObject sePlayer;
    // Start is called before the first frame update
    public void OpenSoubiStatusPanel()
    {
        sePlayer = GameObject.FindGameObjectWithTag("SE");
        SEPlay();

        soubiKakutokuDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KakutokuDataBase>();
        weponData = enemyDataBaseManager.dropItemPrefabs[soubiNumber].GetComponent<ItemController>().itemStatus;

        if (soubiKakutokuDataBase.kakutokuNo[weponData.no]==0) return;
        if (gameObject.transform.parent.name == "装備アイコン背景") return;

        dropSoubiStatusPanel.SetActive(true);

        soubiIconHaikeiSoubiZukan = openEnemyZukannPanel.soubiIconHaikeiSoubiZukan;
        soubiName = openEnemyZukannPanel.soubiName;
        baikyakuKinngaku = openEnemyZukannPanel.baikyakuKinngaku;
        hpSoubiZukan = openEnemyZukannPanel.hpSoubiZukan;
        mpSoubiZukan = openEnemyZukannPanel.mpSoubiZukan;
        fbCostSoubiZukan = openEnemyZukannPanel.fbCostSoubiZukan;
        kougekiryokuSoubiZukan = openEnemyZukannPanel.kougekiryokuSoubiZukan;
        maryokuSoubiZukan = openEnemyZukannPanel.maryokuSoubiZukan;
        kinnkyoriKaisinnrituSoubiZukan = openEnemyZukannPanel.kinnkyoriKaisinnrituSoubiZukan;
        ennkyoriKaisinnrituSoubiZukan = openEnemyZukannPanel.ennkyoriKaisinnrituSoubiZukan;
        bougyoryokuSoubiZukan = openEnemyZukannPanel.bougyoryokuSoubiZukan;
        kaisinnTaiseiSoubiZukan = openEnemyZukannPanel.kaisinnTaiseiSoubiZukan;
        meityuurituSoubiZukan = openEnemyZukannPanel.meityuurituSoubiZukan;
        kaihirituSoubiZukan = openEnemyZukannPanel.kaihirituSoubiZukan;
        kougekiHinndoSoubiZukan = openEnemyZukannPanel.kougekiHinndoSoubiZukan;
        syougekiryokuSoubiZukan = openEnemyZukannPanel.syougekiryokuSoubiZukan;
        kougekiHanniSoubiZukan = openEnemyZukannPanel.kougekiHanniSoubiZukan;
        mazyuuTokkouSoubiZukan = openEnemyZukannPanel.mazyuuTokkouSoubiZukan;
        ninngennTokkouSoubiZukan = openEnemyZukannPanel.ninngennTokkouSoubiZukan;
        mazinnTokkouSoubiZukan = openEnemyZukannPanel.mazinnTokkouSoubiZukan;
        husiTokkouSoubiZukan = openEnemyZukannPanel.husiTokkouSoubiZukan;
        akumaTokkouSoubiZukan = openEnemyZukannPanel.akumaTokkouSoubiZukan;
        ryuuTokkouSoubiZukan = openEnemyZukannPanel.ryuuTokkouSoubiZukan;
        kamiTokkouSoubiZukan = openEnemyZukannPanel.kamiTokkouSoubiZukan;
        soubiDropBairituSoubiZukan = openEnemyZukannPanel.soubiDropBairituSoubiZukan;
        syougouHuyorituSoubiZukan = openEnemyZukannPanel.syougouHuyorituSoubiZukan;
        giftHuyorituSoubiZukan = openEnemyZukannPanel.giftHuyorituSoubiZukan;

        hp = openEnemyZukannPanel.hpText;
        mp = openEnemyZukannPanel.mp;
        fbCost = openEnemyZukannPanel.fbCost;
        kougekiryoku = openEnemyZukannPanel.kougekiryokuText;
        maryoku = openEnemyZukannPanel.maryoku;
        kinnkyoriKaisinnritu = openEnemyZukannPanel.kinnkyori;
        ennkyoriKaisinnritu = openEnemyZukannPanel.ennkyori;
        bougyoryoku = openEnemyZukannPanel.bougyoryokuText;
        kaisinnTaisei = openEnemyZukannPanel.kaisinnTaiseiText;
        meityuuritu = openEnemyZukannPanel.meityuurituText;
        kaihiritu = openEnemyZukannPanel.kaihirituText;
        kougekiHinndo = openEnemyZukannPanel.kougekiHinndoText;
        syougekiryoku = openEnemyZukannPanel.syougekiryoku;
        kougekiHanni = openEnemyZukannPanel.kougekiHanniText;
        mazyuuTokkou = openEnemyZukannPanel.mazyuuTokkouText;
        ninngennTokkou = openEnemyZukannPanel.ninngennTokkouText;
        mazinnTokkou = openEnemyZukannPanel.mazinnTokkouText;
        husiTokkou = openEnemyZukannPanel.husiTokkouText;
        akumaTokkou = openEnemyZukannPanel.akumaTokkouText;
        ryuuTokkou = openEnemyZukannPanel.ryuuTokkouText;
        kamiTokkou = openEnemyZukannPanel.kamiTokkouText;
        soubiDropBairitu = openEnemyZukannPanel.soubiDropBairituText;
        syougouHuyoritu = openEnemyZukannPanel.syougouHuyorituText;
        giftHuyoritu = openEnemyZukannPanel.giftHuyorituText;

        if (weponData.nomal) Instantiate(nomalIconHaikei, soubiIconHaikeiSoubiZukan.transform);
        else if (weponData.rea) Instantiate(reaIconHaikei, soubiIconHaikeiSoubiZukan.transform);
        else if (weponData.superRea) Instantiate(superReaIconHaikei, soubiIconHaikeiSoubiZukan.transform);
        else if (weponData.epik) Instantiate(epikReaIconHaikei, soubiIconHaikeiSoubiZukan.transform);
        else if (weponData.legendary) Instantiate(legendaryReaIconHaikei, soubiIconHaikeiSoubiZukan.transform);
        else if (weponData.god) Instantiate(godReaIconHaikei, soubiIconHaikeiSoubiZukan.transform);


        //soubiIconSoubizukan = Instantiate(weponData.soubiIcon, soubiIconHaikeiSoubiZukan.transform);

        soubiName.text = weponData.name;
        baikyakuKinngaku.text = weponData.baikyakuKinngaku.ToString("N0");

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
        else kinnkyoriKaisinnrituSoubiZukan.text = weponData.kinnkyoriKaisinnritu.ToString("N0")+"%";
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
        if (weponData.kougekiHinndo == 0)
        {
            kougekiHinndoSoubiZukan.gameObject.SetActive(false);
            kougekiHinndo.SetActive(false);
        }
        else kougekiHinndoSoubiZukan.text = weponData.kougekiHinndo.ToString("N0") + "秒";
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

        openEnemyZukannPanel.SoubiSkillSet(weponData);
    }
    /*public void ChangeSoubiStatusPanel()
    {
        GameObject.Find("1ブルースライム").GetComponent<OpenEnemyZukannPanel>().CloseSoubiStatusPanel();
    }*/
    public void SEPlay()
    {
        sePlayer.GetComponent<AudioSource>().Play();
    }
}

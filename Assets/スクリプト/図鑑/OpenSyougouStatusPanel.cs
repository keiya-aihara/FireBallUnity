using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenSyougouStatusPanel : MonoBehaviour
{
    public GameObject dropSyougouStatusPanel;

    public EnemyDataBaseManager enemyDataBaseManager;
    public EnemyDataList.EnemyData enemyData;
    public SyougouBase syougouBase;

    public OpenEnemyZukannPanel openEnemyZukannPanel;


    public bool rea;
    public bool superRea;
    public bool epikRea;

    public Text syougouName;

    public Text syougouBairitu;

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
    public void OpenSyougouPanel()
    {
        dropSyougouStatusPanel.SetActive(true);

        if (rea)
        {
            syougouName.text = syougouBase.syougouStatus.syougouName;
            syougouBairitu.text = "ステータス倍率\n×1.25";
        }
        else if (superRea)
        {
            syougouName.text = syougouBase.syougouStatus.syougouName;
            syougouBairitu.text = "ステータス倍率\n×1.5";
        }
        else if (epikRea)
        {
            syougouName.text = syougouBase.syougouStatus.syougouName;
            syougouBairitu.text = "ステータス倍率\n×2";
        }

        if (syougouBase.syougouStatus.maxHpPlus == 0)
        {
            hpSyougouZukan.gameObject.SetActive(false);
            hpSyougouZukanG.SetActive(false);
        }
        else hpSyougouZukan.text = syougouBase.syougouStatus.maxHpPlus.ToString("N0");
        if (syougouBase.syougouStatus.maxMpPlus == 0)
        {
            mpSyougouZukan.gameObject.SetActive(false);
            mpSyougouZukanG.SetActive(false);
        }
        else mpSyougouZukan.text = syougouBase.syougouStatus.maxMpPlus.ToString("N0");
        if (syougouBase.syougouStatus.fireBallCostPlus == 0)
        {
            fbCostSyougouZukan.gameObject.SetActive(false);
            fbCostSyougouZukanG.SetActive(false);
        }
        else hpSyougouZukan.text = syougouBase.syougouStatus.maxHpPlus.ToString("N0");
        if (syougouBase.syougouStatus.kougekiryokuPlus == 0)
        {
            kougekiryokuSyougouZukan.gameObject.SetActive(false);
            kougekiryokuSyougouZukanG.SetActive(false);
        }
        else kougekiryokuSyougouZukan.text = syougouBase.syougouStatus.kougekiryokuPlus.ToString("N0");
        if (syougouBase.syougouStatus.maryokuPlus == 0)
        {
            maryokuSyougouZukan.gameObject.SetActive(false);
            maryokuSyougouZukanG.SetActive(false);
        }
        else maryokuSyougouZukan.text = syougouBase.syougouStatus.maryokuPlus.ToString("N0");
        if (syougouBase.syougouStatus.kinnkyoriKaisinnrituPlus == 0)
        {
            kinnkyoriKaisinnrituSyougouZukan.gameObject.SetActive(false);
            kinnkyoriKaisinnrituSyougouZukanG.SetActive(false);
        }
        else kinnkyoriKaisinnrituSyougouZukan.text = syougouBase.syougouStatus.kinnkyoriKaisinnrituPlus.ToString("N0");
        if (syougouBase.syougouStatus.ennkyoriKaisinnrituPlus == 0)
        {
            ennkyoriKaisinnrituSyougouZukan.gameObject.SetActive(false);
            ennkyoriKaisinnrituSyougouZukanG.SetActive(false);
        }
        else ennkyoriKaisinnrituSyougouZukan.text = syougouBase.syougouStatus.ennkyoriKaisinnrituPlus.ToString("N0");
        if (syougouBase.syougouStatus.bouggyoryokuPlus == 0)
        {
            bougyoryokuSyougouZukan.gameObject.SetActive(false);
            bougyoryokuSyougouZukanG.SetActive(false);
        }
        else bougyoryokuSyougouZukan.text = syougouBase.syougouStatus.bouggyoryokuPlus.ToString("N0");
        if (syougouBase.syougouStatus.kaisinnTaisei == 0)
        {
            kaisinnTaiseiSyougouZukan.gameObject.SetActive(false);
            kaisinnTaiseiSyougouZukanG.SetActive(false);
        }
        else kaisinnTaiseiSyougouZukan.text = syougouBase.syougouStatus.kaisinnTaisei.ToString("N0");
        if (syougouBase.syougouStatus.meityuurituPlus == 0)
        {
            meityuurituSyougouZukan.gameObject.SetActive(false);
            meityuurituSyougouZukanG.SetActive(false);
        }
        else meityuurituSyougouZukan.text = syougouBase.syougouStatus.meityuurituPlus.ToString("N0");
        if (syougouBase.syougouStatus.kaihirituPlus == 0)
        {
            kaihirituSyougouZukan.gameObject.SetActive(false);
            kaihirituSyougouZukanG.SetActive(false);
        }
        else kaihirituSyougouZukan.text = syougouBase.syougouStatus.kaihirituPlus.ToString("N0");
        if (syougouBase.syougouStatus.syougekiryoku == 0)
        {
            syougekiryokuSyougouZukan.gameObject.SetActive(false);
            syougekiryokuSyougouZukanG.SetActive(false);
        }
        else syougekiryokuSyougouZukan.text = syougouBase.syougouStatus.syougekiryoku.ToString("N0");
        if (syougouBase.syougouStatus.srushHinndo == 0)
        {
            srushHinndoSyougouZukan.gameObject.SetActive(false);
            srushHinndoSyougouZukanG.SetActive(false);
        }
        else srushHinndoSyougouZukan.text = syougouBase.syougouStatus.srushHinndo.ToString("N0");
        if (syougouBase.syougouStatus.kougekiHanni == 0)
        {
            kougekiHanniSyougouZukan.gameObject.SetActive(false);
            kougekiHanniSyougouZukanG.SetActive(false);
        }
        else kougekiHanniSyougouZukan.text = syougouBase.syougouStatus.kougekiHanni.ToString("N0");
        if (syougouBase.syougouStatus.mazyuuTokkou == 0)
        {
            mazyuuTokkouSyougouZukan.gameObject.SetActive(false);
            mazyuuTokkouSyougouZukanG.SetActive(false);
        }
        else mazyuuTokkouSyougouZukan.text = syougouBase.syougouStatus.mazyuuTokkou.ToString("N0");
        if (syougouBase.syougouStatus.ninngennTokkou == 0)
        {
            ninngennTokkouSyougouZukan.gameObject.SetActive(false);
            ninngennTokkouSyougouZukanG.SetActive(false);
        }
        else ninngennTokkouSyougouZukan.text = syougouBase.syougouStatus.ninngennTokkou.ToString("N0");
        if (syougouBase.syougouStatus.mazinnTokkou == 0)
        {
            mazinnTokkouSyougouZukan.gameObject.SetActive(false);
            mazinnTokkouSyougouZukanG.SetActive(false);
        }
        else mazinnTokkouSyougouZukan.text = syougouBase.syougouStatus.mazinnTokkou.ToString("N0");
        if (syougouBase.syougouStatus.husiTokkou == 0)
        {
            husiTokkouSyougouZukan.gameObject.SetActive(false);
            husiTokkouSyougouZukanG.SetActive(false);
        }
        else husiTokkouSyougouZukan.text = syougouBase.syougouStatus.husiTokkou.ToString("N0");
        if (syougouBase.syougouStatus.akumaTokkou == 0)
        {
            akumaTokkouSyougouZukan.gameObject.SetActive(false);
            akumaTokkouSyougouZukanG.SetActive(false);
        }
        else akumaTokkouSyougouZukan.text = syougouBase.syougouStatus.akumaTokkou.ToString("N0");
        if (syougouBase.syougouStatus.ryuuTokkou == 0)
        {
            ryuuTokkouSyougouZukan.gameObject.SetActive(false);
            ryuuTokkouSyougouZukanG.SetActive(false);
        }
        else ryuuTokkouSyougouZukan.text = syougouBase.syougouStatus.ryuuTokkou.ToString("N0");
        if (syougouBase.syougouStatus.kamiTokkou == 0)
        {
            kamiTokkouSyougouZukan.gameObject.SetActive(false);
            kamiTokkouSyougouZukanG.SetActive(false);
        }
        else kamiTokkouSyougouZukan.text = syougouBase.syougouStatus.kamiTokkou.ToString("N0");
        if (syougouBase.syougouStatus.soubiDropBairitu == 0)
        {
            soubiDropBairituSyougouZukan.gameObject.SetActive(false);
            soubiDropBairituSyougouZukanG.SetActive(false);
        }
        else soubiDropBairituSyougouZukan.text = syougouBase.syougouStatus.soubiDropBairitu.ToString("N0");
        if (syougouBase.syougouStatus.syougouDropRitu == 0)
        {
            syougouDropRituSyougouZukan.gameObject.SetActive(false);
            syougouDropRituSyougouZukanG.SetActive(false);
        }
        else syougouDropRituSyougouZukan.text = syougouBase.syougouStatus.syougouDropRitu.ToString("N0");
        if (syougouBase.syougouStatus.soubiGifthuyosoubiDropritu == 0)
        {
            soubiGifthuyosoubiDroprituSyougouZukan.gameObject.SetActive(false);
            soubiGifthuyosoubiDroprituSyougouZukanG.SetActive(false);
        }
        else soubiGifthuyosoubiDroprituSyougouZukan.text = syougouBase.syougouStatus.soubiGifthuyosoubiDropritu.ToString("N0");
    }

}

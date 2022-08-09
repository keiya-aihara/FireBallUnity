using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusText : MonoBehaviour
{
    private GameObject databaseManager;
    private PlayerStatusDataBase playerStatusDataBase;
    private KousekiDataBaseManager kousekiDataBaseManager;
    private EXPManager expManagerScript;
    private Text text;


    void Start()
    {
        databaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        playerStatusDataBase = databaseManager.GetComponent<PlayerStatusDataBase>();
        kousekiDataBaseManager = databaseManager.GetComponent<KousekiDataBaseManager>();
        expManagerScript = databaseManager.GetComponent<EXPManager>();
        StatusPanelUpdata();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StatusPanelUpdata()
    {
        text = gameObject.GetComponent<Text>();

        if (gameObject.name == "レベル")
        {
            text.text = expManagerScript.lv.ToString("N0");
        }
        else if (gameObject.name == "HP")
        {
            text.text = playerStatusDataBase.maxHp.ToString("N0");
        }
        else if (gameObject.name == "MP")
        {
            text.text = playerStatusDataBase.maxMp.ToString("N0");
        }
        else if (gameObject.name == "FBコスト")
        {
            text.text = playerStatusDataBase.fireBallCost.ToString("N0");
        }
        else if (gameObject.name == "攻撃力")
        {
            text.text = playerStatusDataBase.kougekiryoku.ToString("N0");
        }
        else if (gameObject.name == "魔力")
        {
            text.text = playerStatusDataBase.maryoku.ToString("N0");
        }
        else if (gameObject.name == "近距離会心率")
        {
            text.text = playerStatusDataBase.kinnkyoriKaisinnritu.ToString("N2") + "%";
        }
        else if (gameObject.name == "遠距離会心率")
        {
            text.text = playerStatusDataBase.ennkyoriKaisinnritu.ToString("N2") + "%";
        }
        else if (gameObject.name == "防御力")
        {
            text.text = playerStatusDataBase.bougyoryoku.ToString("N0");
        }
        else if (gameObject.name == "会心耐性")
        {
            text.text = playerStatusDataBase.kaisinnTaisei.ToString("N2") + "%";
        }
        else if (gameObject.name == "命中率")
        {
            text.text = playerStatusDataBase.meityuuritu.ToString("N2") + "%";
        }
        else if (gameObject.name == "回避率")
        {
            text.text = playerStatusDataBase.kaihiritu.ToString("N2") + "%";
        }
        else if (gameObject.name == "衝撃力")
        {
            text.text = playerStatusDataBase.nokkubakku.ToString() + "ｍ";
        }
        else if (gameObject.name == "攻撃速度")
        {
            text.text = playerStatusDataBase.kougekiHinndo.ToString() + "秒";
        }
        else if (gameObject.name == "攻撃範囲")
        {
            text.text = "半径" + playerStatusDataBase.kougekiHanni.ToString() + "ｍ";
        }
        else if (gameObject.name == "魔獣特攻")
        {
            text.text = "+" + playerStatusDataBase.kousekiMazyuuTokkou + "%";
        }
        else if (gameObject.name == "不死特攻")
        {
            text.text = "+" + playerStatusDataBase.kousekiHusiTokkou + "%";
        }
        else if (gameObject.name == "悪魔特攻")
        {
            text.text = "+" + playerStatusDataBase.kousekiAkumaTokkou + "%";
        }
        else if (gameObject.name == "魔人特攻")
        {
            text.text = "+" + playerStatusDataBase.kousekiMazinnTokkou + "%";
        }
        else if (gameObject.name == "人間特攻")
        {
            text.text = "+" + playerStatusDataBase.kousekiHusiTokkou + "%";
        }
        else if (gameObject.name == "竜特攻")
        {
            text.text = "+" + playerStatusDataBase.kousekiRyuuTokkou + "%";
        }
        else if (gameObject.name == "神特攻")
        {
            text.text = "+" + playerStatusDataBase.kousekiKamiTokkou + "%";
        }
        else if (gameObject.name == "Nアイテムドロップ率")
        {
            text.text = "+" + playerStatusDataBase.nomalDropRitu + "%";
        }
        else if (gameObject.name == "Rアイテムドロップ率")
        {
            text.text = "+" + playerStatusDataBase.reaDropRitu + "%";
        }
        else if (gameObject.name == "SRアイテムドロップ率")
        {
            text.text = "+" + playerStatusDataBase.superReaDropRitu + "%";
        }
        else if (gameObject.name == "ERアイテムドロップ率")
        {
            text.text = "+" + playerStatusDataBase.epikReaDropRitu + "%";
        }
        else if (gameObject.name == "LRアイテムドロップ率")
        {
            text.text = "+" + playerStatusDataBase.legendaryReaDropRitu + "%";
        }
        else if (gameObject.name == "GRアイテムドロップ率")
        {
            text.text = "+" + playerStatusDataBase.godReaDropRitu + "%";
        }
        else if (gameObject.name == "強化時対価消費率")
        {
            text.text = "-" + playerStatusDataBase.kyoukataikaGennsyouritu + "%";
        }
        else if (gameObject.name == "ギフト付与率")
        {
            text.text = "+" + playerStatusDataBase.giftHuyoSoubiDropritu + "%";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusText : MonoBehaviour
{
    private GameObject databaseManager;
    private PlayerStatusDataBase playerStatusDataBase;
    private EXPManager expManagerScript;
    private Text text;


    void Start()
    {
        databaseManager = GameObject.Find("DataBaseManager");
        playerStatusDataBase = databaseManager.GetComponent<PlayerStatusDataBase>();
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
            text.text = playerStatusDataBase.soubiMaxHp.ToString("N0");
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
            text.text = playerStatusDataBase.kinnkyoriKaisinnritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "遠距離会心率")
        {
            text.text = playerStatusDataBase.ennkyoriKaisinnritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "防御力")
        {
            text.text = playerStatusDataBase.bougyoryoku.ToString("N0");
        }
        else if (gameObject.name == "会心耐性")
        {
            text.text = playerStatusDataBase.kaisinnTaisei.ToString("N2")+"%";
        }
        else if (gameObject.name == "命中率")
        {
            text.text = playerStatusDataBase.meityuuritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "回避率")
        {
            text.text = playerStatusDataBase.kaihiritu.ToString("N2")+"%";
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
    }
}

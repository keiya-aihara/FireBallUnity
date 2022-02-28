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

        if (gameObject.name == "ƒŒƒxƒ‹")
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
        else if (gameObject.name == "FBƒRƒXƒg")
        {
            text.text = playerStatusDataBase.fireBallCost.ToString("N0");
        }
        else if (gameObject.name == "UŒ‚—Í")
        {
            text.text = playerStatusDataBase.kougekiryoku.ToString("N0");
        }
        else if (gameObject.name == "–‚—Í")
        {
            text.text = playerStatusDataBase.maryoku.ToString("N0");
        }
        else if (gameObject.name == "‹ß‹——£‰ïS—¦")
        {
            text.text = playerStatusDataBase.kinnkyoriKaisinnritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "‰“‹——£‰ïS—¦")
        {
            text.text = playerStatusDataBase.ennkyoriKaisinnritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "–hŒä—Í")
        {
            text.text = playerStatusDataBase.bougyoryoku.ToString("N0");
        }
        else if (gameObject.name == "‰ïS‘Ï«")
        {
            text.text = playerStatusDataBase.kaisinnTaisei.ToString("N2")+"%";
        }
        else if (gameObject.name == "–½’†—¦")
        {
            text.text = playerStatusDataBase.meityuuritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "‰ñ”ğ—¦")
        {
            text.text = playerStatusDataBase.kaihiritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "ÕŒ‚—Í")
        {
            text.text = playerStatusDataBase.nokkubakku.ToString() + "‚";
        }
        else if (gameObject.name == "UŒ‚‘¬“x")
        {
            text.text = playerStatusDataBase.kougekiHinndo.ToString() + "•b";
        }
        else if (gameObject.name == "UŒ‚”ÍˆÍ")
        {
            text.text = "”¼Œa" + playerStatusDataBase.kougekiHanni.ToString() + "‚";
        }
    }
}

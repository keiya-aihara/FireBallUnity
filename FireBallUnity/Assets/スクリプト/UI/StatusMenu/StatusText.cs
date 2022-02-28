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

        if (gameObject.name == "���x��")
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
        else if (gameObject.name == "FB�R�X�g")
        {
            text.text = playerStatusDataBase.fireBallCost.ToString("N0");
        }
        else if (gameObject.name == "�U����")
        {
            text.text = playerStatusDataBase.kougekiryoku.ToString("N0");
        }
        else if (gameObject.name == "����")
        {
            text.text = playerStatusDataBase.maryoku.ToString("N0");
        }
        else if (gameObject.name == "�ߋ�����S��")
        {
            text.text = playerStatusDataBase.kinnkyoriKaisinnritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "��������S��")
        {
            text.text = playerStatusDataBase.ennkyoriKaisinnritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "�h���")
        {
            text.text = playerStatusDataBase.bougyoryoku.ToString("N0");
        }
        else if (gameObject.name == "��S�ϐ�")
        {
            text.text = playerStatusDataBase.kaisinnTaisei.ToString("N2")+"%";
        }
        else if (gameObject.name == "������")
        {
            text.text = playerStatusDataBase.meityuuritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "���")
        {
            text.text = playerStatusDataBase.kaihiritu.ToString("N2")+"%";
        }
        else if (gameObject.name == "�Ռ���")
        {
            text.text = playerStatusDataBase.nokkubakku.ToString() + "��";
        }
        else if (gameObject.name == "�U�����x")
        {
            text.text = playerStatusDataBase.kougekiHinndo.ToString() + "�b";
        }
        else if (gameObject.name == "�U���͈�")
        {
            text.text = "���a" + playerStatusDataBase.kougekiHanni.ToString() + "��";
        }
    }
}

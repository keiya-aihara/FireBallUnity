using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPManager : MonoBehaviour
{
    public GameObject dataBaseManager;
    private PlayerStatusDataBase playerStatusDataBase;

    public int exp_stokku = 0;
    public int lvUpExp;
    public int needExp;
    public int overExp;
    public int lv = 1;
    public static EXPManager instance;
    public int[] experienceTable; // 必要経験値テーブル

    void Start()
    {

        playerStatusDataBase = dataBaseManager.GetComponent<PlayerStatusDataBase>();
        /*
        experienceTable = new int[300]; // レベル1000までのテーブルを作成

        experienceTable[0] = 0; // レベル1に必要な経験値は0
        experienceTable[1] = 5; // レベル2に必要な経験値は10

        // レベル3以上の必要経験値を計算してテーブルに格納
        for (int i = 2; i < experienceTable.Length; i++)
        {
            if(i<=50)
            experienceTable[i] = Mathf.CeilToInt(experienceTable[i - 1] * 1.1f);
            else if (i <= 99)
                experienceTable[i] = Mathf.CeilToInt(experienceTable[i - 1] * 1.08f);
            else if(i<=149)
                experienceTable[i] = Mathf.CeilToInt(experienceTable[i - 1] * 1.07f);
            else if(i<=199)
                experienceTable[i] = Mathf.CeilToInt(experienceTable[i - 1] * 1.06f);
            else if (i <= 249)
                experienceTable[i] = Mathf.CeilToInt(experienceTable[i - 1] * 1.05f);
            else if (i <= 299)
                experienceTable[i] = Mathf.CeilToInt(experienceTable[i - 1] * 1.04f);
        */

    }


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }


    }
    public void AddExp(int exp)
    {
        exp_stokku += exp;
        for (; lvUpExp <= exp_stokku;)
        {
            lv++;
            if (lvUpExp < exp_stokku)overExp = exp_stokku - lvUpExp;
            lvUpExp = GetLvupExp(lv);
            playerStatusDataBase.statusMaxHp += 5;
            playerStatusDataBase.statusMaxMp += 3;
            playerStatusDataBase.statusKougekiryoku += 1;
            playerStatusDataBase.statusKinnkyoriKaisinnritu += 0.5f;
            playerStatusDataBase.statusMaryoku += 1;
            playerStatusDataBase.statusEnnkyoriKaisinnritu += 0.3f;
            playerStatusDataBase.statusBougyoryoku += 1;
            playerStatusDataBase.statusMeityuuritu += 0.5f;
            playerStatusDataBase.statusKaihiritu += 0.4f;
            if (lv % 3 == 0)
            {
                playerStatusDataBase.statusFireBallCost += 1;
            }
            playerStatusDataBase.syoziSp++;
            exp_stokku = 0;
            exp_stokku += overExp;
            overExp = 0;
        }
        playerStatusDataBase.statusSaveData.lv = lv;

        playerStatusDataBase.StatusUpdate();
    }
    public int GetLvupExp(int lv)
    {
        return experienceTable[lv];
    }
    void Update()
    {
        needExp = lvUpExp - exp_stokku;
    }
}

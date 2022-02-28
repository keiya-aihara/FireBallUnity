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
    public int lv = 1;
    public static EXPManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        lvUpExp = GetLvupExp(lv);
    }
    void Start()
    {
        playerStatusDataBase = dataBaseManager.GetComponent<PlayerStatusDataBase>();
    }

    public void AddExp(int exp)
    {
        exp_stokku += exp;
        for(; lvUpExp <= exp_stokku;)
        {
            lv++;
            lvUpExp = GetLvupExp(lv);

            playerStatusDataBase.statusMaxHp += 5;
            playerStatusDataBase.statusMaxMp += 3;
            playerStatusDataBase.statusKougekiryoku += 1;
            playerStatusDataBase.statusKinnkyoriKaisinnritu += 0.05f;
            playerStatusDataBase.statusMaryoku += 1;
            playerStatusDataBase.statusEnnkyoriKaisinnritu += 0.03f;
            playerStatusDataBase.statusBougyoryoku += 1;
            playerStatusDataBase.statusMeityuuritu += 0.5f;
            playerStatusDataBase.statusKaihiritu += 0.2f;
            if(lv % 5 == 0 )
            {
                playerStatusDataBase.statusFireBallCost += 1;
            }
        }
        playerStatusDataBase.StatusUpdate();
    }
    private int GetLvupExp(int lv)
    {
        return ((lv + 1) * (lv * 100) / 2);
    }
    void Update()
    {
        needExp = lvUpExp - exp_stokku;
    }
}

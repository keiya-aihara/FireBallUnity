﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultSceneManager : MonoBehaviour
{
    public static ResultSceneManager instance;

    public float time; 
    public bool a;
    public bool b;
    public List<GameObject> getSoubi = new List<GameObject>();
    public List<GameObject> gifts = new List<GameObject>();
    public List<GameObject> syougous = new List<GameObject>();
    public List<string> kakutokuItemName = new List<string>();

    private GameObject databaseManager;
    private EXPManager expManagerScript;

    public string stageName;
    public int kakutokuCoin;
    public int kakutokuKyoukasekiSyou;
    public int kakutokuKyoukasekiTyuu;
    public int kakutokuKyoukasekiDai;
    public int kakutokuKeikennti;
    public int boukennmaeLv;
    public int boukenngoLv;
    public int weponZyukurenndo;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            stageName = SceneManager.GetActiveScene().name;
            kakutokuItemName.Clear();
            kakutokuCoin = 0;
            kakutokuKyoukasekiSyou = 0;
            kakutokuKyoukasekiTyuu = 0;
            kakutokuKyoukasekiDai = 0;
            kakutokuKeikennti = 0;

            databaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
            expManagerScript = databaseManager.GetComponent<EXPManager>();
            boukennmaeLv = expManagerScript.lv;
            b= false;
        }


    }
    private void Start()
    {
        a = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            time += Time.deltaTime;
        }
        if(b)
        {
            for(int a = 0;a<getSoubi.Count;a++)
            {
                getSoubi[a].GetComponent<ItemController>().SoubiInventryIn();

            }
            b = false;
            //Debug.Log("熟練度プラス");
            databaseManager.GetComponent<WeponDateBaseManager>().GetWeponData(databaseManager.GetComponent<PlayerStatusDataBase>().kinnkyoriWeponNo).zyukurenndo += weponZyukurenndo;
            databaseManager.GetComponent<WeponDateBaseManager>().GetWeponData(databaseManager.GetComponent<PlayerStatusDataBase>().kinnkyoriWeponNo).ZyukurennWepon();
            GameObject.Find("GameManager").GetComponent<GameManager>().a = true;
        }
        
    }
}

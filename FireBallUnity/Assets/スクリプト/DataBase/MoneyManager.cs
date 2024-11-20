using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;
    public int money;
    public MoneyKyoukasekiSaveData moneyKyoukasekiSaveData;
    public AudioSource audioSource;
    public AudioClip moneyClip;
    void Awake()
    {

    }
    void Start()
    {
        MoneyLoad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddMoney(int addMoney)
    {
        money += addMoney;
        MoneyClipPlay();

    }
    public void MoneySave()
    {
        moneyKyoukasekiSaveData = new MoneyKyoukasekiSaveData();

        moneyKyoukasekiSaveData.money = money;

        string json = JsonUtility.ToJson(moneyKyoukasekiSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.money.json", json);
    }
    public void MoneyLoad()
    {
        string path = Application.persistentDataPath + "/savefile.money.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            MoneyKyoukasekiSaveData loadData = JsonUtility.FromJson<MoneyKyoukasekiSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            money = loadData.money;
        }
    }
    public void MoneySyokika()
    {
        money = 0;
        MoneySave();
        MoneyLoad();
    }
    public void MoneyClipPlay()
    {
        audioSource.PlayOneShot(moneyClip);
    }
}

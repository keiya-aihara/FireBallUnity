using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class KyoukasekiManager : MonoBehaviour
{
    public int kyoukasekiSyou;
    public int kyoukasekiTyuu;
    public int kyoukasekiDai;
    private MoneyKyoukasekiSaveData moneyKyoukasekiSaveData;
    void Start()
    {
        KyoukasekiLoad();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void KyoukasekiSave()
    {
        moneyKyoukasekiSaveData = new MoneyKyoukasekiSaveData();

        moneyKyoukasekiSaveData.kyoukasekiSyou = kyoukasekiSyou;
        moneyKyoukasekiSaveData.kyoukasekiTyuu = kyoukasekiTyuu;
        moneyKyoukasekiSaveData.kyoukasekiDai = kyoukasekiDai;

        string json = JsonUtility.ToJson(moneyKyoukasekiSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.kyoukaseki.json", json);
    }
    public void KyoukasekiLoad()
    {
        string path = Application.persistentDataPath + "/savefile.kyoukaseki.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            MoneyKyoukasekiSaveData loadData = JsonUtility.FromJson<MoneyKyoukasekiSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            kyoukasekiSyou = loadData.kyoukasekiSyou;
            kyoukasekiTyuu = loadData.kyoukasekiTyuu;
            kyoukasekiDai = loadData.kyoukasekiDai;
        }
    }
    public void KyoukasekiSyokika()
    {
        kyoukasekiSyou = 0;
        kyoukasekiTyuu = 0;
        kyoukasekiDai = 0;
        KyoukasekiSave();
        KyoukasekiLoad();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StageZissekiDatabase : MonoBehaviour
{
    public List<int> stageNo;
    public List<StageNannidoZisseki> stageNannidoZissekis = new List<StageNannidoZisseki>();
    public StageZissekiDatabaseSaveData stageZissekiDatabaseSaveData;
    public void StageKuriaKaisuu(int a,int b)
    {
        stageNo[a - 1] ++;
        if (b == 0) stageNannidoZissekis[a - 1].syosinnsyanoMiti++;
        else if (b == 1) stageNannidoZissekis[a - 1].boukennsyanoSirenn++;
        else if (b == 2) stageNannidoZissekis[a - 1].eiyuunoMiti++;
        else if (b == 3) stageNannidoZissekis[a - 1].yuusyanoTyousenn++;
        else if (b == 4) stageNannidoZissekis[a - 1].dennsetunoSirenn++;
        else if (b == 5) stageNannidoZissekis[a - 1].kamigaminoRyouiki++;

        StageZissekiDataSave();
    }
    public int GetStageKuriaKaisuu(int b)
    {
        return stageNo[b - 1];
    }

    public void StageZissekiDataSave()
    {
        stageZissekiDatabaseSaveData = new StageZissekiDatabaseSaveData();
        stageZissekiDatabaseSaveData.stageNo = stageNo;
        stageZissekiDatabaseSaveData.stageNannidoZissekis = stageNannidoZissekis;
        for (int a = 0; a < stageNo.Count; a++)
        {
            stageZissekiDatabaseSaveData.stageNo[a] = stageNo[a];
        }
        for (int a = 0; a < stageNannidoZissekis.Count; a++)
        {
            stageZissekiDatabaseSaveData.stageNannidoZissekis[a] = stageNannidoZissekis[a];
        }
        string json = JsonUtility.ToJson(stageZissekiDatabaseSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.stageZisseki.json", json);
        //Debug.Log("クリア回数をセーブした。");
    }
    public void StageZissekiDataLoad()
    {
        string path = Application.persistentDataPath + "/savefile.stageZisseki.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            StageZissekiDatabaseSaveData loadData = JsonUtility.FromJson<StageZissekiDatabaseSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換
            stageNo = loadData.stageNo;
            stageNannidoZissekis = loadData.stageNannidoZissekis;
            for (int a = 0; a < stageNo.Count; a++)
            {
                stageNo[a] = loadData.stageNo[a];
            }
            for (int a = 0; a < stageNannidoZissekis.Count; a++)
            {
                stageNannidoZissekis[a] = loadData.stageNannidoZissekis[a];
            }
            //Debug.Log("クリア回数をロードした。");
        }
    }
    public void StaziZissekiSyokika()
    {
        for (int a = 0; a < stageNo.Count; a++)
        {
            stageNo[a] = 0;
        }
        for (int a = 0; a < stageNannidoZissekis.Count; a++)
        {
            stageNannidoZissekis[a].syosinnsyanoMiti = 0;
            stageNannidoZissekis[a].boukennsyanoSirenn = 0;
            stageNannidoZissekis[a].eiyuunoMiti = 0;
            stageNannidoZissekis[a].yuusyanoTyousenn = 0;
            stageNannidoZissekis[a].dennsetunoSirenn = 0;
            stageNannidoZissekis[a].kamigaminoRyouiki = 0;
        }
        StageZissekiDataSave();
    }
    [Serializable]
    public class StageNannidoZisseki
    {
        public int syosinnsyanoMiti;
        public int boukennsyanoSirenn;
        public int eiyuunoMiti;
        public int yuusyanoTyousenn;
        public int dennsetunoSirenn;
        public int kamigaminoRyouiki;
    }
}

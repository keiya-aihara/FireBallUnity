using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StageZissekiDatabase : MonoBehaviour
{
    public List<int> stageNo;
    public StageZissekiDatabaseSaveData stageZissekiDatabaseSaveData;
    public void StageKuriaKaisuu(int a)
    {
        stageNo[a - 1] ++;
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
        for (int a = 0; a < stageNo.Count; a++)
        {
            stageZissekiDatabaseSaveData.stageNo[a] = stageNo[a];
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
            for (int a = 0; a < stageNo.Count; a++)
            {
                stageNo[a] = loadData.stageNo[a];
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
        StageZissekiDataSave();
    }
}

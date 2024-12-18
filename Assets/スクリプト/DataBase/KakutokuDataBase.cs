using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class KakutokuDataBase : MonoBehaviour
{
    public int[] kakutokuNo;
    public int[] enemyGekihasuuNo;
    public KakutokusuuSavedata kakutokusuuSavedata;

    public void GekihasuuSave()
    {
        kakutokusuuSavedata = new KakutokusuuSavedata();
        kakutokusuuSavedata.enemyGekihaSuuNo = new int[enemyGekihasuuNo.Length];

        for (int a = 0; a < enemyGekihasuuNo.Length; a++)
        {
            kakutokusuuSavedata.enemyGekihaSuuNo[a] = enemyGekihasuuNo[a];
        }

        string json = JsonUtility.ToJson(kakutokusuuSavedata);
        File.WriteAllText(Application.persistentDataPath + "/savefile.gekihasuu.json", json);
        Debug.Log(kakutokusuuSavedata.enemyGekihaSuuNo);
    }
    public void GekihasuuLoad()
    {
        string path = Application.persistentDataPath + "/savefile.gekihasuu.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            KakutokusuuSavedata loadData = JsonUtility.FromJson<KakutokusuuSavedata>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            for (int a = 0; a < loadData.enemyGekihaSuuNo.Length; a++)
            {
                enemyGekihasuuNo[a] = loadData.enemyGekihaSuuNo[a];
            }

        }
    }
    public void KakutokuSave()
    {
        kakutokusuuSavedata = new KakutokusuuSavedata();
        kakutokusuuSavedata.kakutokuNo =new int[ kakutokuNo.Length];

        for(int a=0;a<kakutokuNo.Length;a++)
        {
            kakutokusuuSavedata.kakutokuNo[a] = kakutokuNo[a];
        }

        string json = JsonUtility.ToJson(kakutokusuuSavedata);
        File.WriteAllText(Application.persistentDataPath + "/savefile.soubiKakutoku.json", json);
        Debug.Log(kakutokusuuSavedata.kakutokuNo);
    }
    public void KakutokuLoad()
    {
        string path = Application.persistentDataPath + "/savefile.soubiKakutoku.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            KakutokusuuSavedata loadData = JsonUtility.FromJson<KakutokusuuSavedata>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            for(int a=0; a<loadData.kakutokuNo.Length;a++)
            {
                kakutokuNo[a] =loadData.kakutokuNo[a];
            }
            
        }
    }
    public void KakutokuSuuSyokika()
    {
        for(int a=0;a< kakutokusuuSavedata.kakutokuNo.Length;a++)
        {
            kakutokusuuSavedata.kakutokuNo[a]=0;
        }
        for (int a = 0; a < kakutokusuuSavedata.enemyGekihaSuuNo.Length; a++)
        {
            kakutokusuuSavedata.enemyGekihaSuuNo[a]=0;
        }
        KakutokuSave();
        GekihasuuSave();
    }
}

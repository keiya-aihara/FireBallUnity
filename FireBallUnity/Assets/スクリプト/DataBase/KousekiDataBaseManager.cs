using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class KousekiDataBaseManager : MonoBehaviour
{
    public KousekiSaveData kousekiSaveData;
    public static KousekiDataBaseManager instance;
    [Header("討伐数カウント")]
    public int mazyuuToubatuSuu;
    public int ninngennToubatuSuu;
    public int mazinnToubatuSuu;
    public int husiToubatuSuu;
    public int akumaToubatuSuu;
    public int ryuuTToubatuSuu;
    public int kamiToubatuSuu;
    [Header("レア度別取得アイテム数カウント")]
    public int nomalGetSuu;
    public int reaGetSuu;
    public int superReaGetSuu;
    public int epikReaGetSuu;
    public int legendaryReaGetSuu;
    public int godReaGetSuu;
    [Header("強化回数カウント")]
    public int kyoukakaisuu;
    [Header("レア種撃破数カウント")]
    public int reaEnemyToubatuSuu;
    [Header("撃破数トロフィー所持数")]
    public int buronzuTorophy;
    public int sirubaaTorophy;
    public int goorudoTorophy;
    public int puratinaTorophy;
    public int daiamonndoTorophy;
    [Header("レア度別アイテムトロフィー所持数")]
    public int whiteTorophy;
    public int greenTorophy;
    public int buleeTorophy;
    public int redTorophy;
    public int purpleTorophy;
    public int godTorophy;
    [Header("強化数トロフィー所持数")]
    public int kyoukasekiTorophy;
    [Header("レア種撃破トロフィー所持数")]
    public int reaTorophy;
    // Update is called once per frame
    public void TrophySave()
    {
        kousekiSaveData = new KousekiSaveData();
        //Debug.Log("トロフィーセーブ");
        kousekiSaveData.mazyuuToubatuSuu = mazyuuToubatuSuu;
        kousekiSaveData.ninngennToubatuSuu = ninngennToubatuSuu;
        kousekiSaveData.mazinnToubatuSuu = mazinnToubatuSuu;
        kousekiSaveData.husiToubatuSuu = husiToubatuSuu;
        kousekiSaveData.akumaToubatuSuu = akumaToubatuSuu;
        kousekiSaveData.ryuuTToubatuSuu = ryuuTToubatuSuu;
        kousekiSaveData.kamiToubatuSuu = kamiToubatuSuu;
        kousekiSaveData.nomalGetSuu = nomalGetSuu;
        kousekiSaveData.reaGetSuu = reaGetSuu;
        kousekiSaveData.superReaGetSuu = superReaGetSuu;
        kousekiSaveData.epikReaGetSuu = epikReaGetSuu;
        kousekiSaveData.legendaryReaGetSuu = legendaryReaGetSuu;
        kousekiSaveData.godReaGetSuu = godReaGetSuu;
        kousekiSaveData.kyoukakaisuu = kyoukakaisuu;

        kousekiSaveData.reaEnemyToubatuSuu = reaEnemyToubatuSuu;
        kousekiSaveData.buronzuTorophy = buronzuTorophy;
        kousekiSaveData.sirubaaTorophy = sirubaaTorophy;
        kousekiSaveData.goorudoTorophy = goorudoTorophy;
        kousekiSaveData.puratinaTorophy = puratinaTorophy;
        kousekiSaveData.daiamonndoTorophy = daiamonndoTorophy;
        kousekiSaveData.whiteTorophy = whiteTorophy;
        kousekiSaveData.greenTorophy = greenTorophy;
        kousekiSaveData.buleeTorophy = buleeTorophy;
        kousekiSaveData.redTorophy = redTorophy;
        kousekiSaveData.purpleTorophy = purpleTorophy;
        kousekiSaveData.godTorophy = godTorophy;
        kousekiSaveData.kyoukasekiTorophy = kyoukasekiTorophy;
        kousekiSaveData.reaTorophy = reaTorophy;
        string json = JsonUtility.ToJson(kousekiSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.kouseki.json", json);
    }
    public void TorophyLoad()
    {
        string path = Application.persistentDataPath + "/savefile.kouseki.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            KousekiSaveData loadData = JsonUtility.FromJson<KousekiSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

           // Debug.Log("トロフィーロード");
            mazyuuToubatuSuu =loadData.mazyuuToubatuSuu;
            ninngennToubatuSuu = loadData.ninngennToubatuSuu;
            mazinnToubatuSuu = loadData.mazinnToubatuSuu;
            husiToubatuSuu = loadData.husiToubatuSuu;
            akumaToubatuSuu = loadData.akumaToubatuSuu;
            ryuuTToubatuSuu = loadData.ryuuTToubatuSuu;
            kamiToubatuSuu = loadData.kamiToubatuSuu;
            nomalGetSuu = loadData.nomalGetSuu;
            reaGetSuu = loadData.reaGetSuu;
            superReaGetSuu = loadData.superReaGetSuu;
            epikReaGetSuu = loadData.epikReaGetSuu;
            legendaryReaGetSuu = loadData.legendaryReaGetSuu;
            godReaGetSuu = loadData.godReaGetSuu;
            kyoukakaisuu = loadData.kyoukakaisuu;
            reaEnemyToubatuSuu = loadData.reaEnemyToubatuSuu;
            buronzuTorophy = loadData.buronzuTorophy;
            sirubaaTorophy = loadData.sirubaaTorophy;
            goorudoTorophy = loadData.goorudoTorophy;
            puratinaTorophy = loadData.puratinaTorophy;
            daiamonndoTorophy = loadData.daiamonndoTorophy;
            whiteTorophy = loadData.whiteTorophy;
            greenTorophy = loadData.greenTorophy;
            buleeTorophy = loadData.buleeTorophy;
            redTorophy = loadData.redTorophy;
            purpleTorophy = loadData.purpleTorophy;
            godTorophy = loadData.godTorophy;
            kyoukasekiTorophy = loadData.kyoukasekiTorophy;
            reaTorophy = loadData.reaTorophy;
        }
    }
    public void TorophySyokika()
    {
        mazyuuToubatuSuu = 0;
        ninngennToubatuSuu = 0;
        mazinnToubatuSuu = 0;
        husiToubatuSuu = 0;
        akumaToubatuSuu = 0;
        ryuuTToubatuSuu = 0;
        kamiToubatuSuu = 0;
        nomalGetSuu = 0;
        reaGetSuu = 0;
        superReaGetSuu = 0;
        epikReaGetSuu = 0;
        legendaryReaGetSuu = 0;
        godReaGetSuu = 0;
        kyoukakaisuu = 0;
        reaEnemyToubatuSuu = 0;
        buronzuTorophy = 0;
        sirubaaTorophy = 0;
        goorudoTorophy = 0;
        puratinaTorophy = 0;
        daiamonndoTorophy = 0;
        whiteTorophy = 0;
        greenTorophy = 0;
        buleeTorophy = 0;
        redTorophy = 0;
        purpleTorophy = 0;
        godTorophy = 0;
        kyoukasekiTorophy = 0;
        reaTorophy = 0;

        TrophySave();
    }
}

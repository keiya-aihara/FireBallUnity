using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class KousekiSaveData
{
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

    public bool kakutokuzumi;
}

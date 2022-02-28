using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KousekiDataBaseManager : MonoBehaviour
{
    
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
    [Header("特攻数値")]
    public int mazyuuTokkou;
    public int ninngennTokkou;
    public int mazinnTokkou;
    public int husiTokkou;
    public int akumaTokkou;
    public int RyuuTokkou;
    public int KamiTokkou;
    [Header("レア度別ドロップ率ボーナス")]
    public int nomalDropRitu;
    public int reaDropRitu;
    public int superReaDropRitu;
    public int epikReaDropRitu;
    public int legendaryReaDropRitu;
    public int godReaDropRitu;
    [Header("強化対価減少率")]
    public int kyoukataikaGennsyouritu;
    [Header("ギフト付与装備ドロップ率")]
    public int giftHuyoSoubiDropritu;
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
    void Update()
    {
        
    }
}

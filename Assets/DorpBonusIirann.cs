using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DorpBonusIirann : MonoBehaviour
{
    private PlayerStatusDataBase playerStatusDataBase;

    public bool nomalDropBairitu;
    public bool reaDropBairitu;
    public bool superReaDropBairitu;
    public bool epikReaDropBairitu;
    public bool legendaryReaDropBairitu;
    public bool godReaDropBairitu;

    public bool syougouDropRitu;
    public bool giftDropRitu;

    public bool reaSyutugennRitu;

    public Text text;

    public int kuriaKaisuu;
    public int stageNo;
    public float reaKakuritu;
    public Text stageNameText;

    void Update()
    {
        TorehannUpdate();
    }
    public void TorehannUpdate()
    {
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
        if (nomalDropBairitu)
            text.text = "Nドロップ倍率 × " + playerStatusDataBase.nomalDropRitu.ToString("N0") + "%";
        else if (reaDropBairitu)
            text.text = "Rドロップ倍率 × " + playerStatusDataBase.reaDropRitu.ToString("N0") + "%";
        else if (superReaDropBairitu)
            text.text = "SRドロップ倍率 × " + playerStatusDataBase.superReaDropRitu.ToString("N0") + "%";
        else if (epikReaDropBairitu)
            text.text = "ERドロップ倍率 × " + playerStatusDataBase.epikReaDropRitu.ToString("N0") + "%";
        else if (legendaryReaDropBairitu)
            text.text = "LRドロップ倍率 × " + playerStatusDataBase.legendaryReaDropRitu.ToString("N0") + "%";
        else if (godReaDropBairitu)
            text.text = "GRドロップ倍率 × " + playerStatusDataBase.godReaDropRitu.ToString("N0") + "%";
        else if (syougouDropRitu)
            text.text = "称号ドロップ率 ＋ " + playerStatusDataBase.syougouDropRitu.ToString("N0") + "%";
        else if (giftDropRitu)
            text.text = "ギフトドロップ率 ＋ " + playerStatusDataBase.giftHuyoSoubiDropritu.ToString("N0") + "%";
        else if (reaSyutugennRitu)
        {
            stageNo = int.Parse(stageNameText.text.Substring(0, 2));
            kuriaKaisuu = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<StageZissekiDatabase>().GetStageKuriaKaisuu(stageNo);
            if (kuriaKaisuu >= 300) reaKakuritu = 30;
            else reaKakuritu = kuriaKaisuu / 10.00f + 1.00f;
            text.text = "レア敵出現率 + " + reaKakuritu.ToString("N2") + "%";
        }
    }
}

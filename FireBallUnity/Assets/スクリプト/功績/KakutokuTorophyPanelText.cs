using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KakutokuTorophyPanelText : MonoBehaviour
{
    public KousekiCopy kousekiCopy;
    public Text text;
    [Header("トロフィー数")]
    public bool buronnzuTorophy;
    public bool sirubaaTorophy;
    public bool goorudoTorophy;
    public bool puratinaTorophy;
    public bool daiamonndoTorophy;
    public bool whiteTorophy;
    public bool greenTorophy;
    public bool buleeTorophy;
    public bool redTorophy;
    public bool purpleTorophy;
    public bool godTorophy;
    public bool kyoukasekiTorophy;
    public bool reaTorophy;
    [Header("恩恵数値")]
    public bool mazyuutokkou;
    public bool husitokkou;
    public bool akumatokkou;
    public bool mazinntokkou;
    public bool ninngenntokkou;
    public bool ryuutokkkou;
    public bool gottokkou;
    public bool nomalItemDrop;
    public bool reaItemDrop;
    public bool superReaItemDrop;
    public bool epikReaItemDrop;
    public bool legendaryReaItemDrop;
    public bool godReaITemDrop;
    public bool kyoukazitaikasyouhiryou;
    public bool giftHuyoritu;
    void Start()
    {
        TextUpdata();
    }

    // Update is called once per frame
    void Update()
    {
        if(kousekiCopy.a)
        {
            TextUpdata();
        }
    }
    void TextUpdata()
    {
        if (buronnzuTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.buronzuTorophy;
        else if (sirubaaTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.sirubaaTorophy;
        else if (goorudoTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.goorudoTorophy;
        else if (puratinaTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.puratinaTorophy;
        else if (daiamonndoTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.daiamonndoTorophy;
        else if (whiteTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.whiteTorophy;
        else if (greenTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.greenTorophy;
        else if (buleeTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.buleeTorophy;
        else if (redTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.redTorophy;
        else if (purpleTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.purpleTorophy;
        else if (godTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.godTorophy;
        else if (kyoukasekiTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.kyoukasekiTorophy;
        else if (reaTorophy) text.text = "×" + kousekiCopy.kousekiDataBaseManager.reaTorophy;

        else if (mazyuutokkou) text.text = "魔獣特攻+" + kousekiCopy.kousekiDataBaseManager.mazyuuTokkou + "%";
        else if (husitokkou) text.text = "不死特攻+" + kousekiCopy.kousekiDataBaseManager.husiTokkou + "%";
        else if (akumatokkou) text.text = "悪魔特攻+" + kousekiCopy.kousekiDataBaseManager.akumaTokkou + "%";
        else if (mazinntokkou) text.text = "魔人特攻+" + kousekiCopy.kousekiDataBaseManager.mazinnTokkou + "%";
        else if (ninngenntokkou) text.text = "人間特攻+" + kousekiCopy.kousekiDataBaseManager.ninngennTokkou + "%";
        else if (ryuutokkkou) text.text = "竜  特攻+" + kousekiCopy.kousekiDataBaseManager.RyuuTokkou + "%";
        else if (gottokkou) text.text = "神  特攻+" + kousekiCopy.kousekiDataBaseManager.KamiTokkou + "%";
        else if (nomalItemDrop) text.text = "Nアイテムドロップ率+" + kousekiCopy.kousekiDataBaseManager.nomalDropRitu + "%";
        else if (reaItemDrop) text.text = "Rアイテムドロップ率+" + kousekiCopy.kousekiDataBaseManager.reaDropRitu + "%";
        else if (superReaItemDrop) text.text = "SRアイテムドロップ率+" + kousekiCopy.kousekiDataBaseManager.superReaDropRitu + "%";
        else if (epikReaItemDrop) text.text = "ERアイテムドロップ率+" + kousekiCopy.kousekiDataBaseManager.epikReaDropRitu + "%";
        else if (legendaryReaItemDrop) text.text = "LRアイテムドロップ率+" + kousekiCopy.kousekiDataBaseManager.legendaryReaDropRitu + "%";
        else if (godReaITemDrop) text.text = "GRアイテムドロップ率+" + kousekiCopy.kousekiDataBaseManager.godReaDropRitu + "%";
        else if (kyoukazitaikasyouhiryou) text.text = "強化時対価消費量-" + kousekiCopy.kousekiDataBaseManager.kyoukataikaGennsyouritu + "%";
        else if (giftHuyoritu) text.text = "ギフト付与率+" + kousekiCopy.kousekiDataBaseManager.giftHuyoSoubiDropritu + "%";
    }
}

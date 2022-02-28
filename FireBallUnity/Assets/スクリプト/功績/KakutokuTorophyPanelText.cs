using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KakutokuTorophyPanelText : MonoBehaviour
{
    public KousekiCopy kousekiCopy;
    public Text text;
    [Header("�g���t�B�[��")]
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
    [Header("���b���l")]
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
        if (buronnzuTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.buronzuTorophy;
        else if (sirubaaTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.sirubaaTorophy;
        else if (goorudoTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.goorudoTorophy;
        else if (puratinaTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.puratinaTorophy;
        else if (daiamonndoTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.daiamonndoTorophy;
        else if (whiteTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.whiteTorophy;
        else if (greenTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.greenTorophy;
        else if (buleeTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.buleeTorophy;
        else if (redTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.redTorophy;
        else if (purpleTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.purpleTorophy;
        else if (godTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.godTorophy;
        else if (kyoukasekiTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.kyoukasekiTorophy;
        else if (reaTorophy) text.text = "�~" + kousekiCopy.kousekiDataBaseManager.reaTorophy;

        else if (mazyuutokkou) text.text = "���b���U+" + kousekiCopy.kousekiDataBaseManager.mazyuuTokkou + "%";
        else if (husitokkou) text.text = "�s�����U+" + kousekiCopy.kousekiDataBaseManager.husiTokkou + "%";
        else if (akumatokkou) text.text = "�������U+" + kousekiCopy.kousekiDataBaseManager.akumaTokkou + "%";
        else if (mazinntokkou) text.text = "���l���U+" + kousekiCopy.kousekiDataBaseManager.mazinnTokkou + "%";
        else if (ninngenntokkou) text.text = "�l�ԓ��U+" + kousekiCopy.kousekiDataBaseManager.ninngennTokkou + "%";
        else if (ryuutokkkou) text.text = "��  ���U+" + kousekiCopy.kousekiDataBaseManager.RyuuTokkou + "%";
        else if (gottokkou) text.text = "�_  ���U+" + kousekiCopy.kousekiDataBaseManager.KamiTokkou + "%";
        else if (nomalItemDrop) text.text = "N�A�C�e���h���b�v��+" + kousekiCopy.kousekiDataBaseManager.nomalDropRitu + "%";
        else if (reaItemDrop) text.text = "R�A�C�e���h���b�v��+" + kousekiCopy.kousekiDataBaseManager.reaDropRitu + "%";
        else if (superReaItemDrop) text.text = "SR�A�C�e���h���b�v��+" + kousekiCopy.kousekiDataBaseManager.superReaDropRitu + "%";
        else if (epikReaItemDrop) text.text = "ER�A�C�e���h���b�v��+" + kousekiCopy.kousekiDataBaseManager.epikReaDropRitu + "%";
        else if (legendaryReaItemDrop) text.text = "LR�A�C�e���h���b�v��+" + kousekiCopy.kousekiDataBaseManager.legendaryReaDropRitu + "%";
        else if (godReaITemDrop) text.text = "GR�A�C�e���h���b�v��+" + kousekiCopy.kousekiDataBaseManager.godReaDropRitu + "%";
        else if (kyoukazitaikasyouhiryou) text.text = "�������Ή������-" + kousekiCopy.kousekiDataBaseManager.kyoukataikaGennsyouritu + "%";
        else if (giftHuyoritu) text.text = "�M�t�g�t�^��+" + kousekiCopy.kousekiDataBaseManager.giftHuyoSoubiDropritu + "%";
    }
}

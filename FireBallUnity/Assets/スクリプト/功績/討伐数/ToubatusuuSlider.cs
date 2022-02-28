using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToubatusuuSlider : MonoBehaviour
{
    public GameObject mazyuuCountText;
    private Slider slider;
    public GameObject kousekiCopy;
    private KousekiCopy kousekiCopyScript;
    public GameObject tyekkuBotton;
    public GameObject kakutokuBotton;
    private KousekiDataBaseManager kousekiDataBaseManager;

    public GameObject torophyKakutokuPanel;
    public GameObject torophyKakutokuText;
    public GameObject kinnwakuImage;
    public GameObject tokkouText;
    private string syuzoku;
    private int tokkou;
    private string torophy;
    public GameObject buronzuTorophy;
    public GameObject sirubaaTorophy;
    public GameObject goorudoTorophy;
    public GameObject puratinaTorophy;
    public GameObject daiamonndoTorophy;

    public bool mazyuu;
    public bool ninngenn;
    public bool mazinn;
    public bool husi;
    public bool akuma;
    public bool ryuu;
    public bool kami;

    public bool tokkou10;
    public bool tokkou15;
    public bool tokkou20;
    public bool tokkou25;
    public bool tokkou30;

    public bool kakutokuZumi;
    // Start is called before the first frame update
    void Start()
    {
        
        kousekiCopyScript = kousekiCopy.GetComponent<KousekiCopy>();
        slider = gameObject.GetComponent<Slider>();
        if(mazyuu)
        {
            slider.value = kousekiCopyScript.kousekiDataBaseManager.mazyuuToubatuSuu;
        }
        if(ninngenn)
        {
            slider.value = kousekiCopyScript.kousekiDataBaseManager.ninngennToubatuSuu;
        }
        if (mazinn)
        {
            slider.value = kousekiCopyScript.kousekiDataBaseManager.mazinnToubatuSuu;
        }
        if (husi)
        {
            slider.value = kousekiCopyScript.kousekiDataBaseManager.husiToubatuSuu;
        }
        if (akuma)
        {
            slider.value = kousekiCopyScript.kousekiDataBaseManager.akumaToubatuSuu;
        }
        if(ryuu)
        {
            slider.value = kousekiCopyScript.kousekiDataBaseManager.ryuuTToubatuSuu;
        }
        if (kami)
        {
            slider.value = kousekiCopyScript.kousekiDataBaseManager.kamiToubatuSuu;
        }

        mazyuuCountText.GetComponent<CountText>().a = true;
        if(kakutokuZumi)
        {
            tyekkuBotton.SetActive(true);
            kakutokuBotton.SetActive(false);
        }
        else
        {
            if (slider.value == slider.maxValue)
            {
                tyekkuBotton.SetActive(true);
                kakutokuBotton.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TorophyKakutoku()
    {
        kousekiDataBaseManager = GameObject.Find("DataBaseManager").GetComponent<KousekiDataBaseManager>();
        kakutokuZumi = true;
        kakutokuBotton.SetActive(false);
        TokkouAdd();
        KakutokuTorophyPanel();
    }
    private void TokkouAdd()
    {
        if (tokkou10)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 10;
                syuzoku = "魔獣";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 10;
                syuzoku = "人間";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 10;
                syuzoku = "魔人";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 10;
                syuzoku = "不死";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 10;
                syuzoku = "悪魔";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 10;
                syuzoku = "竜";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 10;
                syuzoku = "神";
            }
            tokkou = 10;
            torophy = "ブロンズトロフィー";
            kousekiDataBaseManager.buronzuTorophy++;
        }
        else if (tokkou15)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 15;
                syuzoku = "魔獣";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 15;
                syuzoku = "人間";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 15;
                syuzoku = "魔人";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 15;
                syuzoku = "不死";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 15;
                syuzoku = "悪魔";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 15;
                syuzoku = "竜";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 15;
                syuzoku = "神";
            }
            tokkou = 15;
            torophy = "シルバートロフィー";
            kousekiDataBaseManager.sirubaaTorophy++;
        }
        else if (tokkou20)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 20;
                syuzoku = "魔獣";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 20;
                syuzoku = "人間";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 20;
                syuzoku = "魔人";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 20;
                syuzoku = "不死";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 20;
                syuzoku = "悪魔";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 20;
                syuzoku = "竜";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 20;
                syuzoku = "神";
            }
            tokkou = 20;
            torophy = "ゴールドトロフィー";
            kousekiDataBaseManager.goorudoTorophy++;
        }
        else if (tokkou25)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 25;
                syuzoku = "魔獣";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 25;
                syuzoku = "人間";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 25;
                syuzoku = "魔人";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 25;
                syuzoku = "不死";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 25;
                syuzoku = "悪魔";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 25;
                syuzoku = "竜";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 25;
                syuzoku = "神";
            }
            tokkou = 25;
            torophy = "プラチナトロフィー";
            kousekiDataBaseManager.puratinaTorophy++;
        }
        else if (tokkou30)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 30;
                syuzoku = "魔獣";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 30;
                syuzoku = "人間";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 30;
                syuzoku = "魔人";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 30;
                syuzoku = "不死";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 30;
                syuzoku = "悪魔";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 30;
                syuzoku = "竜";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 30;
                syuzoku = "神";
            }
            tokkou = 30;
            torophy = "ダイアモンドトロフィー";
            kousekiDataBaseManager.daiamonndoTorophy++;
        }
    }
    public void KakutokuTorophyPanel()
    {
        torophyKakutokuPanel.SetActive(true);
        torophyKakutokuText.GetComponent<Text>().text = "「種族・" + syuzoku + "を"+slider.maxValue.ToString("N0")+"体討伐する」\n" + torophy + "を獲得しました";
        tokkouText.GetComponent<Text>().text = syuzoku + "に対する与ダメージが" + tokkou + "%上昇します";
        if (tokkou10) Instantiate(buronzuTorophy, transform.localPosition, transform.rotation, kinnwakuImage.transform);
        else if (tokkou15) Instantiate(sirubaaTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (tokkou20) Instantiate(goorudoTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (tokkou25) Instantiate(puratinaTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (tokkou30) Instantiate(daiamonndoTorophy, transform.position,transform.rotation, kinnwakuImage.transform);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
public class ReadobetuItemSlider : MonoBehaviour
{
    public GameObject countText;
    private Slider slider;
    public GameObject kousekiCopy;
    private KousekiCopy kousekiCopyScript;
    public GameObject tyekkuBotton;
    public GameObject kakutokuBotton;
    private KousekiDataBaseManager kousekiDataBaseManager;
    private PlayerStatusDataBase playerStatusDataBase;
    private bool kakutokuzumi;

    public GameObject torophyKakutokuPanel;
    public GameObject torophyKakutokuText;
    public GameObject dropBonusText;
    public GameObject kinnwakuImage;

    public GameObject whiteTorophy;
    public GameObject greenTorophy;
    public GameObject buleeTorophy;
    public GameObject redTorophy;
    public GameObject purpleTorophy;
    public GameObject godTorophy;

    public bool nomal;
    public bool rea;
    public bool superRea;
    public bool epikRea;
    public bool legendaryRea;
    public bool godRea;

    private string reado;
    private string torophy;

    void Start()
    {
        
        slider = gameObject.GetComponent<Slider>();
        kousekiCopyScript = kousekiCopy.GetComponent<KousekiCopy>();
        kousekiDataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KousekiDataBaseManager>();
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
        if (nomal) slider.value = kousekiCopyScript.kousekiDataBaseManager.nomalGetSuu;
        else if (rea) slider.value = kousekiCopyScript.kousekiDataBaseManager.reaGetSuu;
        else if (superRea) slider.value = kousekiCopyScript.kousekiDataBaseManager.superReaGetSuu;
        else if (epikRea) slider.value = kousekiCopyScript.kousekiDataBaseManager.epikReaGetSuu;
        else if (legendaryRea) slider.value = kousekiCopyScript.kousekiDataBaseManager.legendaryReaGetSuu;
        else if (godRea) slider.value = kousekiCopyScript.kousekiDataBaseManager.godReaGetSuu;
        countText.GetComponent<CountText>().a = true;

        if (nomal)
        {
            if (slider.maxValue == 100)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 50)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 500)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 100)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 1000)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 150)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 5000)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 200)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 10000)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 250)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 50000)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 300)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 100000)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 350)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 300000)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 400)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 500000)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 450)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 1000000)
            {
                if (playerStatusDataBase.kousekiNomalDropRitu >= 500)
                    kakutokuzumi = true;
            }
        }
        else if (rea)
        {
            if (slider.maxValue == 75)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 50)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 375)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 100)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 750)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 150)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 3750)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 200)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 7500)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 250)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 37500)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 300)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 75000)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 350)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 150000)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 400)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 300000)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 450)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 750000)
            {
                if (playerStatusDataBase.kousekiReaDropRitu >= 500)
                    kakutokuzumi = true;
            }
        }
        else if (superRea)
        {
            if (slider.maxValue == 50)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 50)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 250)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 100)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 500)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 150)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 2500)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 200)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 5000)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 250)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 25000)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 300)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 50000)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 350)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 150000)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 400)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 250000)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 450)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 500000)
            {
                if (playerStatusDataBase.kousekiSuperReaDropRitu >= 500)
                    kakutokuzumi = true;
            }
        }
        else if (epikRea)
        {
            if (slider.maxValue == 25)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 50)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 125)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 100)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 250)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 150)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 1250)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 200)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 2500)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 250)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 12500)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 300)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 25000)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 350)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 75000)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 400)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 125000)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 450)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 250000)
            {
                if (playerStatusDataBase.kousekiEpikReaDropRitu >= 500)
                    kakutokuzumi = true;
            }
        }

        else if (legendaryRea)
        {
            if (slider.maxValue == 10)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 50)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 50)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 100)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 100)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 150)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 500)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 200)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 1000)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 250)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 5000)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 300)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 10000)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 350)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 30000)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 400)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 50000)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 450)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 100000)
            {
                if (playerStatusDataBase.kousekiLegendaryReaDropRitu >= 500)
                    kakutokuzumi = true;
            }
        }
        else if (godRea)
        {
            if (slider.maxValue == 1)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 50)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 2)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 100)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 3)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 150)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 4)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 200)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 5)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 250)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 6)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 300)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 7)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 350)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 8)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 400)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 10)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 450)
                    kakutokuzumi = true;
            }
            else if (slider.maxValue == 13)
            {
                if (playerStatusDataBase.kousekiGodReaDropRitu >= 500)
                    kakutokuzumi = true;
            }
        }


        if (kakutokuzumi)
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
    public void ToroPhyKakutoku()
    {
        kakutokuzumi = true;
        kakutokuBotton.SetActive(false);
        kousekiDataBaseManager.TrophySave();
        DropRituBonasAdd();
        playerStatusDataBase.BairituSave();
        KakutokuTorophyPanel();
    }
    public void DropRituBonasAdd()
    {
        if(nomal)
        {
            playerStatusDataBase.kousekiNomalDropRitu += 50;
            kousekiDataBaseManager.whiteTorophy ++;
            reado = "ノーマル";
            torophy = "ホワイトトロフィー";
        }
        else if(rea)
        {
            playerStatusDataBase.kousekiReaDropRitu += 50;
            kousekiDataBaseManager.greenTorophy++;
            reado = "レア";
            torophy = "グリーントロフィー";
        }
        else if(superRea)
        {
            playerStatusDataBase.kousekiSuperReaDropRitu += 50;
            kousekiDataBaseManager.buleeTorophy++;
            reado = "スーパーレア";
            torophy = "ブルートロフィー";
        }
        else if(epikRea)
        {
            playerStatusDataBase.kousekiEpikReaDropRitu += 50;
            kousekiDataBaseManager.redTorophy++;
            reado = "エピックレア";
            torophy = "レッドトロフィー";
        }
        else if(legendaryRea)
        {
            playerStatusDataBase.kousekiLegendaryReaDropRitu += 50;
            kousekiDataBaseManager.purpleTorophy++;
            reado = "レジェンダリーレア";
            torophy = "パープルトロフィー";
        }
        else if(godRea)
        {
            playerStatusDataBase.kousekiGodReaDropRitu += 50;
            kousekiDataBaseManager.godTorophy++;
            reado = "ゴットレア";
            torophy = "ゴットトロフィー";
        }
    }
    public void KakutokuTorophyPanel()
    {
        torophyKakutokuPanel.SetActive(true);
        torophyKakutokuText.GetComponent<Text>().text = "「" + reado + "アイテムを" + slider.maxValue.ToString("N0") + "回取得する」\n"+torophy+"を獲得しました";
        dropBonusText.GetComponent<Text>().text = reado + "アイテムのドロップ倍率が50%上昇します";
        if (nomal) Instantiate(whiteTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (rea) Instantiate(greenTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (superRea) Instantiate(buleeTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (epikRea) Instantiate(redTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (legendaryRea) Instantiate(purpleTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (godRea) Instantiate(godTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
    }
    
}

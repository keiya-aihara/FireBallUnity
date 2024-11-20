using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReasyuToubatuSuuSlider : MonoBehaviour
{
    public GameObject countText;
    private Slider slider;
    public GameObject kousekiCopy;
    private KousekiCopy kousekiCopyScript;
    public GameObject tyekkuBotton;
    public GameObject kakutokuBotton;
    private KousekiDataBaseManager kousekiDataBaseManager;
    private PlayerStatusDataBase playerStatusDataBase;
    public bool reasyu1;
    public bool reasyu2;
    public bool reasyu3;
    public bool reasyu4;
    public bool reasyu5;
    public bool reasyu6;
    public bool reasyu7;
    public bool reasyu8;
    public bool reasyu9;
    public bool reasyu10;
    private bool kakutokuzumi;

    public GameObject torophyKakutokuPanel;
    public GameObject torophyKakutokuText;
    public GameObject giftDropBairituBoNusText;
    public GameObject kinnwakuImage;
    public GameObject torophy;
    // Start is called before the first frame update
    void Start()
    {
        kousekiDataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KousekiDataBaseManager>();
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
        slider = gameObject.GetComponent<Slider>();
        kousekiCopyScript = kousekiCopy.GetComponent<KousekiCopy>();
        slider.value = kousekiCopyScript.kousekiDataBaseManager.reaEnemyToubatuSuu;
        countText.GetComponent<CountText>().a = true;
        if(reasyu1)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 1)
                kakutokuzumi = true;
        }
        else if(reasyu2)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 2)
                kakutokuzumi = true;
        }
        else if (reasyu3)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 3)
                kakutokuzumi = true;
        }
        else if (reasyu4)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 4)
                kakutokuzumi = true;
        }
        else if (reasyu5)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 5)
                kakutokuzumi = true;
        }
        else if (reasyu6)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 6)
                kakutokuzumi = true;
        }
        else if (reasyu7)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 7)
                kakutokuzumi = true;
        }
        else if (reasyu8)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 8)
                kakutokuzumi = true;
        }
        else if (reasyu9)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 9)
                kakutokuzumi = true;
        }
        else if (reasyu10)
        {
            if (playerStatusDataBase.kousekiGiftHuyoSoubiDropritu >= 10)
                kakutokuzumi = true;
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
    public void TorophyKakutoku()
    {
        kakutokuzumi = true;
        kakutokuBotton.SetActive(false);
        kousekiDataBaseManager.TrophySave();
        GiftDoropRituBonusAdd();
        playerStatusDataBase.BairituSave();
        KakutokuTorophyPanel();
    }
    public void GiftDoropRituBonusAdd()
    {
        playerStatusDataBase.kousekiGiftHuyoSoubiDropritu += 1;
        kousekiDataBaseManager.reaTorophy += 1;
    }
    public void KakutokuTorophyPanel()
    {
        torophyKakutokuPanel.SetActive(true);
        torophyKakutokuText.GetComponent<Text>().text = "「レア種モンスター" + slider.maxValue.ToString("N0")+"体討伐する」\nレアトロフィーを獲得しました";
        giftDropBairituBoNusText.GetComponent<Text>().text = "ギフト付与装備のドロップ率が1％上昇します";
        Instantiate(torophy, transform.position, transform.rotation, kinnwakuImage.transform);
    }
}

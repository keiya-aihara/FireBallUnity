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
        GiftDoropRituBonusAdd();
        KakutokuTorophyPanel();
    }
    public void GiftDoropRituBonusAdd()
    {
        playerStatusDataBase.giftHuyoSoubiDropritu += 1;
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

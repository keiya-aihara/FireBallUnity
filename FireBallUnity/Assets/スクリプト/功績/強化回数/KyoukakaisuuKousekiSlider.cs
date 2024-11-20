using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KyoukakaisuuKousekiSlider : MonoBehaviour
{
    public GameObject countText;
    private Slider slider;
    public GameObject kousekiCopy;
    private KousekiCopy kousekiCopyScript;
    public GameObject tyekkuBotton;
    public GameObject kakutokuBotton;
    private KousekiDataBaseManager kousekiDataBaseManager;
    private PlayerStatusDataBase playerStatusDataBase;
    public bool kyouka5;
    public bool kyouka10;
    public bool kyouka15;
    public bool kyouka20;
    public bool kyouka25;
    public bool kyouka30;
    public bool kyouka35;
    public bool kyouka40;
    public bool kyouka45;
    public bool kyouka50;

    private bool kakutokuzumi;

    public GameObject torophyKakutokuPanel;
    public GameObject torophyKakutokuText;
    public GameObject kyoukaHiyouBonusText;
    public GameObject kinnwakuImage;
    public GameObject torophy;
    // Start is called before the first frame update
    void Start()
    {
        kousekiDataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KousekiDataBaseManager>();
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
        slider = gameObject.GetComponent<Slider>();
        kousekiCopyScript = kousekiCopy.GetComponent<KousekiCopy>();

        slider.value = kousekiCopyScript.kousekiDataBaseManager.kyoukakaisuu;
        countText.GetComponent<CountText>().a = true;

        if(kyouka5)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 5)
                kakutokuzumi = true;
        }
        else if(kyouka10)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 10)
                kakutokuzumi = true;
        }
        else if (kyouka15)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 15)
                kakutokuzumi = true;
        }
        else if (kyouka20)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 20)
                kakutokuzumi = true;
        }
        else if (kyouka25)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 25)
                kakutokuzumi = true;
        }
        else if (kyouka30)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 30)
                kakutokuzumi = true;
        }
        else if (kyouka35)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 35)
                kakutokuzumi = true;
        }
        else if (kyouka40)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 40)
                kakutokuzumi = true;
        }
        else if (kyouka45)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 45)
                kakutokuzumi = true;
        }
        else if (kyouka50)
        {
            if (playerStatusDataBase.kyoukataikaGennsyouritu >= 50)
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
        KyoukaTaikaBonusAdd();
        playerStatusDataBase.BairituSave();
        KakutokuTorophyPanel();
    }
    public void KyoukaTaikaBonusAdd()
    {
        playerStatusDataBase.kyoukataikaGennsyouritu += 5;
        kousekiDataBaseManager.kyoukasekiTorophy++;
    }
    public void KakutokuTorophyPanel()
    {
        torophyKakutokuPanel.SetActive(true);
        torophyKakutokuText.GetComponent<Text>().text = "「アイテム強化を"+slider.maxValue.ToString("N0")+"回行う」\n強化石トロフィーを獲得しました";
        kyoukaHiyouBonusText.GetComponent<Text>().text = "アイテム強化時の対価消費量が5%減少します";
        Instantiate(torophy, transform.position, transform.rotation, kinnwakuImage.transform);
    }
}

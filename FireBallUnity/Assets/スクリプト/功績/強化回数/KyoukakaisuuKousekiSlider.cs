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
        KyoukaTaikaBonusAdd();
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

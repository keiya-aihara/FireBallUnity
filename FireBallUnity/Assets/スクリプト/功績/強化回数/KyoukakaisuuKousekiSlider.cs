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
    private bool kakutokuzumi;

    public GameObject torophyKakutokuPanel;
    public GameObject torophyKakutokuText;
    public GameObject kyoukaHiyouBonusText;
    public GameObject kinnwakuImage;
    public GameObject torophy;
    // Start is called before the first frame update
    void Start()
    {
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
        kousekiDataBaseManager = GameObject.Find("KousekiDataBaseManager").GetComponent<KousekiDataBaseManager>();
        kakutokuzumi = true;
        kakutokuBotton.SetActive(false);
        KyoukaTaikaBonusAdd();
        KakutokuTorophyPanel();
    }
    public void KyoukaTaikaBonusAdd()
    {
        kousekiDataBaseManager.kyoukataikaGennsyouritu += 5;
        kousekiDataBaseManager.kyoukasekiTorophy++;
    }
    public void KakutokuTorophyPanel()
    {
        torophyKakutokuPanel.SetActive(true);
        torophyKakutokuText.GetComponent<Text>().text = "�u�A�C�e��������"+slider.maxValue.ToString("N0")+"��s���v\n�����΃g���t�B�[���l�����܂���";
        kyoukaHiyouBonusText.GetComponent<Text>().text = "�A�C�e���������̑Ή�����ʂ�5%�������܂�";
        Instantiate(torophy, transform.position, transform.rotation, kinnwakuImage.transform);
    }
}

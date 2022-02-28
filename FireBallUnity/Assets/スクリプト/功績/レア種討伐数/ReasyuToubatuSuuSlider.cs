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
    private bool kakutokuzumi;

    public GameObject torophyKakutokuPanel;
    public GameObject torophyKakutokuText;
    public GameObject giftDropBairituBoNusText;
    public GameObject kinnwakuImage;
    public GameObject torophy;
    // Start is called before the first frame update
    void Start()
    {
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
        kousekiDataBaseManager = GameObject.Find("KousekiDataBaseManager").GetComponent<KousekiDataBaseManager>();
        kakutokuzumi = true;
        kakutokuBotton.SetActive(false);
        GiftDoropRituBonusAdd();
        KakutokuTorophyPanel();
    }
    public void GiftDoropRituBonusAdd()
    {
        kousekiDataBaseManager.giftHuyoSoubiDropritu += 1;
        kousekiDataBaseManager.reaTorophy += 1;
    }
    public void KakutokuTorophyPanel()
    {
        torophyKakutokuPanel.SetActive(true);
        torophyKakutokuText.GetComponent<Text>().text = "�u���A�탂���X�^�[" + slider.maxValue.ToString("N0")+"�̓�������v\n���A�g���t�B�[���l�����܂���";
        giftDropBairituBoNusText.GetComponent<Text>().text = "�M�t�g�t�^�����̃h���b�v����1���㏸���܂�";
        Instantiate(torophy, transform.position, transform.rotation, kinnwakuImage.transform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ReadobetuItemSlider : MonoBehaviour
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

        if (nomal) slider.value = kousekiCopyScript.kousekiDataBaseManager.nomalGetSuu;
        else if (rea) slider.value = kousekiCopyScript.kousekiDataBaseManager.reaGetSuu;
        else if (superRea) slider.value = kousekiCopyScript.kousekiDataBaseManager.superReaGetSuu;
        else if (epikRea) slider.value = kousekiCopyScript.kousekiDataBaseManager.epikReaGetSuu;
        else if (legendaryRea) slider.value = kousekiCopyScript.kousekiDataBaseManager.legendaryReaGetSuu;
        else if (godRea) slider.value = kousekiCopyScript.kousekiDataBaseManager.godReaGetSuu;
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
    public void ToroPhyKakutoku()
    {
        kousekiDataBaseManager = GameObject.Find("KousekiDataBaseManager").GetComponent<KousekiDataBaseManager>();
        kakutokuzumi = true;
        kakutokuBotton.SetActive(false);
        DropRituBonasAdd();
        KakutokuTorophyPanel();

    }
    public void DropRituBonasAdd()
    {
        if(nomal)
        {
            kousekiDataBaseManager.nomalDropRitu += 50;
            kousekiDataBaseManager.whiteTorophy ++;
            reado = "�m�[�}��";
            torophy = "�z���C�g�g���t�B�[";
        }
        else if(rea)
        {
            kousekiDataBaseManager.reaDropRitu += 50;
            kousekiDataBaseManager.greenTorophy++;
            reado = "���A";
            torophy = "�O���[���g���t�B�[";
        }
        else if(superRea)
        {
            kousekiDataBaseManager.superReaDropRitu += 50;
            kousekiDataBaseManager.buleeTorophy++;
            reado = "�X�[�p�[���A";
            torophy = "�u���[�g���t�B�[";
        }
        else if(epikRea)
        {
            kousekiDataBaseManager.epikReaDropRitu += 50;
            kousekiDataBaseManager.redTorophy++;
            reado = "�G�s�b�N���A";
            torophy = "���b�h�g���t�B�[";
        }
        else if(legendaryRea)
        {
            kousekiDataBaseManager.legendaryReaDropRitu += 50;
            kousekiDataBaseManager.purpleTorophy++;
            reado = "���W�F���_���[���A";
            torophy = "�p�[�v���g���t�B�[";
        }
        else if(godRea)
        {
            kousekiDataBaseManager.godReaDropRitu += 50;
            kousekiDataBaseManager.godTorophy++;
            reado = "�S�b�g���A";
            torophy = "�S�b�g�g���t�B�[";
        }
    }
    public void KakutokuTorophyPanel()
    {
        torophyKakutokuPanel.SetActive(true);
        torophyKakutokuText.GetComponent<Text>().text = "�u" + reado + "�A�C�e����" + slider.maxValue.ToString("N0") + "��擾����v\n"+torophy+"���l�����܂���";
        dropBonusText.GetComponent<Text>().text = reado + "�A�C�e���̃h���b�v����50%�㏸���܂�";
        if (nomal) Instantiate(whiteTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (rea) Instantiate(greenTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (superRea) Instantiate(buleeTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (epikRea) Instantiate(redTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (legendaryRea) Instantiate(purpleTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (godRea) Instantiate(godTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
    }
}

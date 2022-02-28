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
                syuzoku = "���b";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 10;
                syuzoku = "�l��";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 10;
                syuzoku = "���l";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 10;
                syuzoku = "�s��";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 10;
                syuzoku = "����";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 10;
                syuzoku = "��";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 10;
                syuzoku = "�_";
            }
            tokkou = 10;
            torophy = "�u�����Y�g���t�B�[";
            kousekiDataBaseManager.buronzuTorophy++;
        }
        else if (tokkou15)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 15;
                syuzoku = "���b";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 15;
                syuzoku = "�l��";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 15;
                syuzoku = "���l";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 15;
                syuzoku = "�s��";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 15;
                syuzoku = "����";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 15;
                syuzoku = "��";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 15;
                syuzoku = "�_";
            }
            tokkou = 15;
            torophy = "�V���o�[�g���t�B�[";
            kousekiDataBaseManager.sirubaaTorophy++;
        }
        else if (tokkou20)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 20;
                syuzoku = "���b";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 20;
                syuzoku = "�l��";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 20;
                syuzoku = "���l";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 20;
                syuzoku = "�s��";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 20;
                syuzoku = "����";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 20;
                syuzoku = "��";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 20;
                syuzoku = "�_";
            }
            tokkou = 20;
            torophy = "�S�[���h�g���t�B�[";
            kousekiDataBaseManager.goorudoTorophy++;
        }
        else if (tokkou25)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 25;
                syuzoku = "���b";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 25;
                syuzoku = "�l��";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 25;
                syuzoku = "���l";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 25;
                syuzoku = "�s��";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 25;
                syuzoku = "����";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 25;
                syuzoku = "��";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 25;
                syuzoku = "�_";
            }
            tokkou = 25;
            torophy = "�v���`�i�g���t�B�[";
            kousekiDataBaseManager.puratinaTorophy++;
        }
        else if (tokkou30)
        {
            if (mazyuu)
            {
                kousekiDataBaseManager.mazyuuTokkou += 30;
                syuzoku = "���b";
            }
            else if (ninngenn)
            {
                kousekiDataBaseManager.ninngennTokkou += 30;
                syuzoku = "�l��";
            }
            else if (mazinn)
            {
                kousekiDataBaseManager.mazinnTokkou += 30;
                syuzoku = "���l";
            }
            else if (husi)
            {
                kousekiDataBaseManager.husiTokkou += 30;
                syuzoku = "�s��";
            }
            else if (akuma)
            {
                kousekiDataBaseManager.akumaTokkou += 30;
                syuzoku = "����";
            }
            else if (ryuu)
            {
                kousekiDataBaseManager.RyuuTokkou += 30;
                syuzoku = "��";
            }
            else if (kami)
            {
                kousekiDataBaseManager.KamiTokkou += 30;
                syuzoku = "�_";
            }
            tokkou = 30;
            torophy = "�_�C�A�����h�g���t�B�[";
            kousekiDataBaseManager.daiamonndoTorophy++;
        }
    }
    public void KakutokuTorophyPanel()
    {
        torophyKakutokuPanel.SetActive(true);
        torophyKakutokuText.GetComponent<Text>().text = "�u�푰�E" + syuzoku + "��"+slider.maxValue.ToString("N0")+"�̓�������v\n" + torophy + "���l�����܂���";
        tokkouText.GetComponent<Text>().text = syuzoku + "�ɑ΂���^�_���[�W��" + tokkou + "%�㏸���܂�";
        if (tokkou10) Instantiate(buronzuTorophy, transform.localPosition, transform.rotation, kinnwakuImage.transform);
        else if (tokkou15) Instantiate(sirubaaTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (tokkou20) Instantiate(goorudoTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (tokkou25) Instantiate(puratinaTorophy, transform.position, transform.rotation, kinnwakuImage.transform);
        else if (tokkou30) Instantiate(daiamonndoTorophy, transform.position,transform.rotation, kinnwakuImage.transform);
    }
}


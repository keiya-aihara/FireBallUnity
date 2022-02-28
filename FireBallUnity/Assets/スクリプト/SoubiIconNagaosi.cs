using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;

public class SoubiIconNagaosi : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    private bool a;
    private bool b;
    private float nagaosiTime;
    private GameObject panel;
    public GameObject statusPanel;
    public GameObject statusPanelContent;
    public GameObject statusPanel2;
    public GameObject statusPanel2Content;

    public float e=1;

    private GameObject soubi;
    private WeponDataList.WeponData soubiData;

    private int number;
    private bool kinnkyoriWepon;
    private bool ennkyoriWepon;
    private bool yoroi;
    private bool sonota;

    private TextMeshProUGUI textMeshProUGUI;
    private Text text;
    public GameObject soubiName;
    public GameObject syougouGiftHosei;

    public GameObject nomalSyougouhoseinouryoku;
    public GameObject reaSyougouhoseinouryoiku;
    public GameObject superReaSyougouhoseinouryoku;

    public GameObject gihutohoseibairitu;
    public GameObject nouryokuti;
    public GameObject hp;
    public GameObject mp;
    public GameObject fireBallCost;
    public GameObject kougekiryoku;
    public GameObject kinnkyoriKaisinnritu;
    public GameObject maryoku;
    public GameObject ennkyoriKaisinnritu;
    public GameObject bougyoryoku;
    public GameObject kaisinnTaisei;
    public GameObject meityuuritu;
    public GameObject kaihiritu;
    public GameObject syougekiryoku;
    public GameObject kougekisokudo;
    public GameObject kougekihanni;
    public GameObject sukiru;
    public GameObject sukiruName;

    private GameObject soubiBotton;
    private SoubiBotton soubiBottonScript;
    private GameObject lockBotton;
    private LockBotton lockBottonScript;
    private GameObject kyoukaBotton;

    private GameObject baikyakuBotton;

    private KinnkyoriWeponSoubiIcon kinnkyoriWeponSoubiIcon;
    private EnnkyoriWeponSoubiIcon ennkyoriWeponSoubiIcon;
    private YoroiSoubiIcon yoroiSoubiIcon;
    private SonotaSoubiIcon sonotaSoubiIcon;

    private GameObject dataBaseManager;
    private WeponDateBaseManager weponDateBaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    private YoroiDataBaseManager yoroiDataBaseManager;
    private SonotaDataBaseManager sonotaDataBaseManager;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "StatusMenu")
        {
            panel = GameObject.Find("�X�e�[�^�X�p�l�� Scroll View");
        }
        if(SceneManager.GetActiveScene().name =="Souko")
        {
            panel = GameObject.Find("UIPanel");
        }
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            nagaosiTime += Time.deltaTime;
        }
        if(nagaosiTime >= 1)
        {
            if (SceneManager.GetActiveScene().name == "StatusMenu")
            {
                if (kinnkyoriWepon)
                {
                    Instantiate(statusPanel, panel.transform.position + new Vector3(0, e, 0), transform.rotation, panel.transform);

                    weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                    soubiData = weponDateBaseManager.GetWeponData(number);

                    soubiBotton = GameObject.Find("��������{�^��");
                    lockBotton = GameObject.Find("�ی삷��{�^��");
                    soubiBottonScript = soubiBotton.GetComponent<SoubiBotton>();
                    lockBottonScript = lockBotton.GetComponent<LockBotton>();

                    soubiBottonScript.number = number;
                    lockBottonScript.number = number;

                    b = true;

                    kinnkyoriWeponSoubiIcon.a = false;
                    kinnkyoriWepon = false;
                }

                if (ennkyoriWepon)
                {
                    Instantiate(statusPanel, panel.transform.position + new Vector3(0, e, 0), transform.rotation, panel.transform);

                    ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                    soubiData = ennkyoriWeponDataBaseManager.GetWeponData(number);

                    soubiBotton = GameObject.Find("��������{�^��");
                    lockBotton = GameObject.Find("�ی삷��{�^��");
                    soubiBottonScript = soubiBotton.GetComponent<SoubiBotton>();
                    lockBottonScript = lockBotton.GetComponent<LockBotton>();

                    soubiBottonScript.number = number;
                    lockBottonScript.number = number;

                    b = true;

                    ennkyoriWeponSoubiIcon.a = false;
                    ennkyoriWepon = false;
                }
                if (yoroi)
                {
                    Instantiate(statusPanel, panel.transform.position + new Vector3(0, e, 0), transform.rotation, panel.transform);

                    yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                    soubiData = yoroiDataBaseManager.GetWeponData(number);

                    soubiBotton = GameObject.Find("��������{�^��");
                    lockBotton = GameObject.Find("�ی삷��{�^��");
                    soubiBottonScript = soubiBotton.GetComponent<SoubiBotton>();
                    lockBottonScript = lockBotton.GetComponent<LockBotton>();

                    soubiBottonScript.number = number;
                    lockBottonScript.number = number;

                    b = true;

                    yoroiSoubiIcon.a = false;
                    yoroi = false;
                }
                if (sonota)
                {
                    Instantiate(statusPanel, panel.transform.position + new Vector3(0, e, 0), transform.rotation, panel.transform);

                    sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                    soubiData = sonotaDataBaseManager.GetWeponData(number);

                    soubiBotton = GameObject.Find("��������{�^��");
                    lockBotton = GameObject.Find("�ی삷��{�^��");
                    soubiBottonScript = soubiBotton.GetComponent<SoubiBotton>();
                    lockBottonScript = lockBotton.GetComponent<LockBotton>();

                    soubiBottonScript.number = number;
                    lockBottonScript.number = number;

                    b = true;

                    sonotaSoubiIcon.a = false;
                    sonota = false;
                }

                a = false;
                nagaosiTime = 0;
            }
            
        }

        if(b)
        {
            StatusPanel();
            b = false;
        }

    }
    public void SoukoStatusPanel()
    {
        if (SceneManager.GetActiveScene().name == "Souko")
        {
            if (kinnkyoriWepon)
            {
                Instantiate(statusPanel2, panel.transform.position + new Vector3(0, e, 0), transform.rotation, panel.transform);

                weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                soubiData = weponDateBaseManager.GetWeponData(number);

                lockBotton = GameObject.Find("�ی삷��{�^��");
                lockBottonScript = lockBotton.GetComponent<LockBotton>();
                lockBottonScript.number = number;

                b = true;

                kinnkyoriWeponSoubiIcon.a = false;
                kinnkyoriWepon = false;
            }

            if (ennkyoriWepon)
            {
                Instantiate(statusPanel2, panel.transform.position + new Vector3(0, e, 0), transform.rotation, panel.transform);

                ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                soubiData = ennkyoriWeponDataBaseManager.GetWeponData(number);

                lockBotton = GameObject.Find("�ی삷��{�^��");
                lockBottonScript = lockBotton.GetComponent<LockBotton>();
                lockBottonScript.number = number;

                b = true;

                ennkyoriWeponSoubiIcon.a = false;
                ennkyoriWepon = false;
            }
            if (yoroi)
            {
                Instantiate(statusPanel2, panel.transform.position + new Vector3(0, e, 0), transform.rotation, panel.transform);

                yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                soubiData = yoroiDataBaseManager.GetWeponData(number);

                b = true;

                lockBotton = GameObject.Find("�ی삷��{�^��");
                lockBottonScript = lockBotton.GetComponent<LockBotton>();
                lockBottonScript.number = number;

                yoroiSoubiIcon.a = false;
                yoroi = false;
            }
            if (sonota)
            {
                Instantiate(statusPanel2, panel.transform.position + new Vector3(0, e, 0), transform.rotation, panel.transform);

                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                soubiData = sonotaDataBaseManager.GetWeponData(number);

                b = true;

                lockBotton = GameObject.Find("�ی삷��{�^��");
                lockBottonScript = lockBotton.GetComponent<LockBotton>();
                lockBottonScript.number = number;

                sonotaSoubiIcon.a = false;
                sonota = false;
            }

            a = false;
            nagaosiTime = 0;
        }
    }
    private void StatusPanel()
    {
        if (SceneManager.GetActiveScene().name == "StatusMenu")
        {
            statusPanelContent = GameObject.Find("Content ���� �̍��E�M�t�g�␳");

            SoubiNameUpdata();
            Instantiate(soubiName, transform.position, transform.rotation, statusPanelContent.transform);

            if (soubiData.syougouName != "" || soubiData.giftBairituName != "")
            {
                Debug.Log("A");
                text = syougouGiftHosei.GetComponent<Text>();
                text.text = "�s�̍��t�q�M�t�g�r�␳�l";
                Instantiate(syougouGiftHosei, transform.position, transform.rotation, statusPanelContent.transform);

                if (soubiData.syougouName != "")
                {


                    if (soubiData.syougouRea)
                    {
                        text = nomalSyougouhoseinouryoku.GetComponent<Text>();
                        text.text = " -" + soubiData.syougouBairitu;
                        Instantiate(nomalSyougouhoseinouryoku, transform.position, transform.rotation, statusPanelContent.transform);
                    }
                    if (soubiData.syougouSuperRea)
                    {
                        text = reaSyougouhoseinouryoiku.GetComponent<Text>();
                        text.text = " -" + soubiData.syougouBairitu;
                        Instantiate(reaSyougouhoseinouryoiku, transform.position, transform.rotation, statusPanelContent.transform);
                    }
                    if (soubiData.syougouEpikRea)
                    {
                        text = superReaSyougouhoseinouryoku.GetComponent<Text>();
                        text.text = " -" + soubiData.syougouBairitu;
                        Instantiate(superReaSyougouhoseinouryoku, transform.position, transform.rotation, statusPanelContent.transform);
                    }


                }

                if (soubiData.giftBairituName != "")
                {
                    text = gihutohoseibairitu.GetComponent<Text>();
                    text.text = " -" + soubiData.giftBairituName;
                    Instantiate(gihutohoseibairitu, transform.position, transform.rotation, statusPanelContent.transform);
                }
            }
            text = nouryokuti.GetComponent<Text>();
            text.text = "�\�͒l";
            Instantiate(nouryokuti, transform.position, transform.rotation, statusPanelContent.transform);

            if (soubiData.maxHp != 0)
            {
                text = hp.GetComponent<Text>();
                text.text = " - HP�@" + soubiData.kyoukagoMaxHp + "�s" + soubiData.syougouMaxHp + "�t";
                Instantiate(hp, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.maxMp != 0)
            {
                text = mp.GetComponent<Text>();
                text.text = " - MP�@" + soubiData.kyoukagoMaxMp + "�s" + soubiData.syougouMaxMp + "�t";
                Instantiate(mp, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.fireBallCost != 0)
            {
                text = fireBallCost.GetComponent<Text>();
                text.text = " - FB�R�X�g�@" + soubiData.fireBallCost + "�s" + soubiData.fireBallCost + "�t";
                Instantiate(fireBallCost, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kougekiryoku != 0)
            {
                text = kougekiryoku.GetComponent<Text>();
                text.text = " - �U���́@" + soubiData.kyoukagoKougekiryoku + "�s" + soubiData.syougouKougekiryoku + "�t";
                Instantiate(kougekiryoku, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.maryoku != 0)
            {
                text = maryoku.GetComponent<Text>();
                text.text = " - ���́@" + soubiData.kyoukagoMaryoku + "�s" + soubiData.syougouMamryoku + "�t";
                Instantiate(maryoku, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kinnkyoriKaisinnritu != 0)
            {
                text = kinnkyoriKaisinnritu.GetComponent<Text>();
                text.text = " - �ߋ�����S���@" + soubiData.kinnkyoriKaisinnritu + "�s" + soubiData.syougouKinnkyoriKaisinnritu + "�t";
                Instantiate(kinnkyoriKaisinnritu, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.ennkyoriKaisinnsitu != 0)
            {
                text = ennkyoriKaisinnritu.GetComponent<Text>();
                text.text = " - ��������S���@" + soubiData.ennkyoriKaisinnsitu + "�s" + soubiData.syougouEnnkyoriKaisinnritu + "�t";
                Instantiate(ennkyoriKaisinnritu, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.bougyoryoiku != 0)
            {
                text = bougyoryoku.GetComponent<Text>();
                text.text = " - �h��́@" + soubiData.kyoukagoBougyoryoku + "�s" + soubiData.syougouBougyoryoku + "�t";
                Instantiate(bougyoryoku, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kaisinnTaisei != 0)
            {
                text = kaisinnTaisei.GetComponent<Text>();
                text.text = " - ��S�ϐ��@" + soubiData.kaisinnTaisei + "�s" + soubiData.syougouKaisinnTaisei + "�t";
                Instantiate(kaisinnTaisei, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.meityuuritu != 0)
            {
                text = meityuuritu.GetComponent<Text>();
                text.text = " - �������@" + soubiData.kyoukagoMeityuuritu + "�s" + soubiData.syougouMeityuuritu + "�t";
                Instantiate(meityuuritu, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kaihiritu != 0)
            {
                text = kaihiritu.GetComponent<Text>();
                text.text = " - ��𗦁@" + soubiData.kyoukagoKaihiritu + "�s" + soubiData.syougouKaihiritu + "�t";
                Instantiate(kaihiritu, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.nokkubakku != 0)
            {
                text = syougekiryoku.GetComponent<Text>();
                text.text = " - �Ռ��́@" + soubiData.nokkubakku + "m";
                Instantiate(syougekiryoku, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kougekiHinndo != 0)
            {
                text = kougekisokudo.GetComponent<Text>();
                text.text = " - �U�����x�@" + soubiData.kougekiHinndo + "�b";
                Instantiate(kougekisokudo, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kougekiHanni != 0)
            {
                text = kougekihanni.GetComponent<Text>();
                text.text = " - �U���͈́@���a" + soubiData.kougekiHanni + "m";
                Instantiate(kougekihanni, transform.position, transform.rotation, statusPanelContent.transform);
            }
            text = sukiru.GetComponent<Text>();
            text.text = "�X�L��";
            Instantiate(sukiru, transform.position, transform.rotation, statusPanelContent.transform);
        }
        if (SceneManager.GetActiveScene().name == "Souko")
        {
            statusPanel2Content = GameObject.Find("Content ���� �̍��E�M�t�g�␳");

            SoubiNameUpdata();
            Instantiate(soubiName, transform.position, transform.rotation, statusPanel2Content.transform);
            if (soubiData.syougouName != "" || soubiData.giftBairituName != "")
            {
                text = syougouGiftHosei.GetComponent<Text>();
                text.text = "�s�̍��t�q�M�t�g�r�␳�l";
                Instantiate(syougouGiftHosei, transform.position, transform.rotation, statusPanel2Content.transform);

                if (soubiData.syougouName != "")
                {
                    if (soubiData.syougouRea)
                    {
                        text = nomalSyougouhoseinouryoku.GetComponent<Text>();
                        text.text = " -" + soubiData.syougouBairitu;
                        Instantiate(nomalSyougouhoseinouryoku, transform.position, transform.rotation, statusPanel2Content.transform);
                    }
                    if (soubiData.syougouSuperRea)
                    {
                        text = reaSyougouhoseinouryoiku.GetComponent<Text>();
                        text.text = " -" + soubiData.syougouBairitu;
                        Instantiate(reaSyougouhoseinouryoiku, transform.position, transform.rotation, statusPanel2Content.transform);
                    }
                    if (soubiData.syougouEpikRea)
                    {
                        text = superReaSyougouhoseinouryoku.GetComponent<Text>();
                        text.text = " -" + soubiData.syougouBairitu;
                        Instantiate(superReaSyougouhoseinouryoku, transform.position, transform.rotation, statusPanel2Content.transform);
                    }


                }

                if (soubiData.giftBairituName != "")
                {
                    text = gihutohoseibairitu.GetComponent<Text>();
                    text.text = " -" + soubiData.giftBairituName;
                    Instantiate(gihutohoseibairitu, transform.position, transform.rotation, statusPanel2Content.transform);
                }
            }
            text = nouryokuti.GetComponent<Text>();
            text.text = "�\�͒l";
            Instantiate(nouryokuti, transform.position, transform.rotation, statusPanel2Content.transform);

            if (soubiData.maxHp != 0)
            {
                text = hp.GetComponent<Text>();
                text.text = " - HP�@" + soubiData.kyoukagoMaxHp + "�s" + soubiData.syougouMaxHp + "�t";
                Instantiate(hp, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.maxMp != 0)
            {
                text = mp.GetComponent<Text>();
                text.text = " - MP�@" + soubiData.kyoukagoMaxMp + "�s" + soubiData.syougouMaxMp + "�t";
                Instantiate(mp, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.fireBallCost != 0)
            {
                text = fireBallCost.GetComponent<Text>();
                text.text = " - FB�R�X�g�@" + soubiData.fireBallCost + "�s" + soubiData.fireBallCost + "�t";
                Instantiate(fireBallCost, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.kougekiryoku != 0)
            {
                text = kougekiryoku.GetComponent<Text>();
                text.text = " - �U���́@" + soubiData.kyoukagoKougekiryoku + "�s" + soubiData.syougouKougekiryoku + "�t";
                Instantiate(kougekiryoku, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.maryoku != 0)
            {
                text = maryoku.GetComponent<Text>();
                text.text = " - ���́@" + soubiData.kyoukagoMaryoku + "�s" + soubiData.syougouMamryoku + "�t";
                Instantiate(maryoku, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.kinnkyoriKaisinnritu != 0)
            {
                text = kinnkyoriKaisinnritu.GetComponent<Text>();
                text.text = " - �ߋ�����S���@" + soubiData.kinnkyoriKaisinnritu + "�s" + soubiData.syougouKinnkyoriKaisinnritu + "�t";
                Instantiate(kinnkyoriKaisinnritu, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.ennkyoriKaisinnsitu != 0)
            {
                text = ennkyoriKaisinnritu.GetComponent<Text>();
                text.text = " - ��������S���@" + soubiData.ennkyoriKaisinnsitu + "�s" + soubiData.syougouEnnkyoriKaisinnritu + "�t";
                Instantiate(ennkyoriKaisinnritu, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.bougyoryoiku != 0)
            {
                text = bougyoryoku.GetComponent<Text>();
                text.text = " - �h��́@" + soubiData.kyoukagoBougyoryoku + "�s" + soubiData.syougouBougyoryoku + "�t";
                Instantiate(bougyoryoku, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.kaisinnTaisei != 0)
            {
                text = kaisinnTaisei.GetComponent<Text>();
                text.text = " - ��S�ϐ��@" + soubiData.kaisinnTaisei + "�s" + soubiData.syougouKaisinnTaisei + "�t";
                Instantiate(kaisinnTaisei, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.meityuuritu != 0)
            {
                text = meityuuritu.GetComponent<Text>();
                text.text = " - �������@" + soubiData.kyoukagoMeityuuritu + "�s" + soubiData.syougouMeityuuritu + "�t";
                Instantiate(meityuuritu, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.kaihiritu != 0)
            {
                text = kaihiritu.GetComponent<Text>();
                text.text = " - ��𗦁@" + soubiData.kyoukagoKaihiritu + "�s" + soubiData.syougouKaihiritu + "�t";
                Instantiate(kaihiritu, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.nokkubakku != 0)
            {
                text = syougekiryoku.GetComponent<Text>();
                text.text = " - �Ռ��́@" + soubiData.nokkubakku + "m";
                Instantiate(syougekiryoku, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.kougekiHinndo != 0)
            {
                text = kougekisokudo.GetComponent<Text>();
                text.text = " - �U�����x�@" + soubiData.kougekiHinndo + "�b";
                Instantiate(kougekisokudo, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.kougekiHanni != 0)
            {
                text = kougekihanni.GetComponent<Text>();
                text.text = " - �U���͈́@���a" + soubiData.kougekiHanni + "m";
                Instantiate(kougekihanni, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            text = sukiru.GetComponent<Text>();
            text.text = "�X�L��";
            Instantiate(sukiru, transform.position, transform.rotation, statusPanel2Content.transform);

        }
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        
        soubi = pointerEventData.selectedObject;
       
        if (soubi.tag == "KinnkyoriWeponSoubiReadoIcon")
        {
            if (soubi.transform.parent.name == "Content �ߋ�������@�X�e�[�^�X")
            {
                kinnkyoriWeponSoubiIcon = soubi.GetComponent<KinnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<KinnkyoriWeponSoubiIcon>().number;
                kinnkyoriWeponSoubiIcon.a = true;
                a = true;
                kinnkyoriWepon = true;
            }
            else if(soubi.transform.parent.name == "Content Select Soubi�@���������E���p")
            {
                kinnkyoriWeponSoubiIcon = soubi.GetComponent<KinnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<KinnkyoriWeponSoubiIcon>().number;
                kinnkyoriWeponSoubiIcon.a = true;
                a = true;
                kinnkyoriWepon = true;
            }
        }
        if(soubi.tag == "KinnkyoriWeponSoubiIcon")
        {
            if(soubi.transform.parent.parent.name == "Content �ߋ�������@�X�e�[�^�X")
            {
                kinnkyoriWeponSoubiIcon = soubi.transform.parent.GetComponent<KinnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<KinnkyoriWeponSoubiIcon>().number;
                kinnkyoriWeponSoubiIcon.a = true;
                a = true;
                kinnkyoriWepon = true;
            }
            else if (soubi.transform.parent.parent.name == "Content Select Soubi�@���������E���p")
            {
                kinnkyoriWeponSoubiIcon = soubi.GetComponent<KinnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<KinnkyoriWeponSoubiIcon>().number;
                kinnkyoriWeponSoubiIcon.a = true;
                a = true;
                kinnkyoriWepon = true;
            }
        }
        if (soubi.tag == "EnnkyoriWeponSoubiReadoIcon")
        {
            if (soubi.transform.parent.name == "Content ���������� �X�e�[�^�X")
            {
                ennkyoriWeponSoubiIcon = soubi.GetComponent<EnnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<EnnkyoriWeponSoubiIcon>().number;
                ennkyoriWeponSoubiIcon.a = true;
                a = true;
                ennkyoriWepon = true;
            }
            else if (soubi.transform.parent.name == "Content Select Soubi�@���������E���p")
            {
                ennkyoriWeponSoubiIcon = soubi.GetComponent<EnnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<EnnkyoriWeponSoubiIcon>().number;
                ennkyoriWeponSoubiIcon.a = true;
                a = true;
                ennkyoriWepon = true;
            }
        }
        if (soubi.tag == "EnnkyoriWeponSoubiIcon")
        {
            if (soubi.transform.parent.parent.name == "Content ���������� �X�e�[�^�X")
            {
                ennkyoriWeponSoubiIcon = soubi.transform.parent.GetComponent<EnnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<EnnkyoriWeponSoubiIcon>().number;
                ennkyoriWeponSoubiIcon.a = true;
                a = true;
                ennkyoriWepon = true;
                Debug.Log(ennkyoriWeponSoubiIcon.a);
            }
            else if (soubi.transform.parent.parent.name == "Content Select Soubi�@���������E���p")
            {
                ennkyoriWeponSoubiIcon = soubi.GetComponent<EnnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<EnnkyoriWeponSoubiIcon>().number;
                ennkyoriWeponSoubiIcon.a = true;
                a = true;
                ennkyoriWepon = true;
            }
        }
        if (soubi.tag == "YoroiSoubiReadoIcon")
        {
            if (soubi.transform.parent.name == "Content �Z���� �X�e�[�^�X")
            {
                yoroiSoubiIcon = soubi.GetComponent<YoroiSoubiIcon>();
                number = soubi.GetComponent<YoroiSoubiIcon>().number;
                yoroiSoubiIcon.a = true;
                a = true;
                yoroi = true;
                Debug.Log(yoroiSoubiIcon.a);
            }
            else if (soubi.transform.parent.name == "Content Select Soubi�@���������E���p")
            {
                yoroiSoubiIcon = soubi.GetComponent<YoroiSoubiIcon>();
                number = soubi.GetComponent<YoroiSoubiIcon>().number;
                yoroiSoubiIcon.a = true;
                a = true;
                yoroi = true;
            }
        }
        if (soubi.tag == "YoroiSoubiIcon")
        {
            if (soubi.transform.parent.parent.name == "Content �Z���� �X�e�[�^�X")
            {
                yoroiSoubiIcon = soubi.transform.parent.GetComponent<YoroiSoubiIcon>();
                number = soubi.GetComponent<YoroiSoubiIcon>().number;
                yoroiSoubiIcon.a = true;
                a = true;
                yoroi = true;
                Debug.Log(yoroiSoubiIcon.a);
            }
            else if (soubi.transform.parent.parent.name == "Content Select Soubi�@���������E���p")
            {
                yoroiSoubiIcon = soubi.GetComponent<YoroiSoubiIcon>();
                number = soubi.GetComponent<YoroiSoubiIcon>().number;
                yoroiSoubiIcon.a = true;
                a = true;
                yoroi = true;
            }
        }
        if (soubi.tag == "SonotaSoubiIcon")
        {
            if (soubi.transform.parent.parent.name == "Content ���̑����� �X�e�[�^�X 1")
            {
                sonotaSoubiIcon = soubi.transform.parent.GetComponent<SonotaSoubiIcon>();
                number = soubi.GetComponent<SonotaSoubiIcon>().number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
                Debug.Log(sonotaSoubiIcon.a);
            }
            else if (soubi.transform.parent.parent.name == "Content Select Soubi�@���������E���p")
            {
                sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
                number = soubi.GetComponent<SonotaSoubiIcon>().number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
            }
        }
        if(soubi.tag == "SonotaSoubiReadoIcon")
            {
            if (soubi.transform.parent.name == "Content ���̑����� �X�e�[�^�X 1")
            {
                sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
                number = soubi.GetComponent<SonotaSoubiIcon>().number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
                Debug.Log(sonotaSoubiIcon.a);
            }
            else if (soubi.transform.parent.name == "Content Select Soubi�@���������E���p")
            {
                Debug.Log("aaaaa");
                sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
                number = soubi.GetComponent<SonotaSoubiIcon>().number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
            }

        }
        if (soubi.tag == "SonotaSoubiIcon")
        {
            if (soubi.transform.parent.parent.name == "Content ���̑����� �X�e�[�^�X2")
            {
                sonotaSoubiIcon = soubi.transform.parent.GetComponent<SonotaSoubiIcon>();
                number = soubi.GetComponent<SonotaSoubiIcon>().number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
                Debug.Log(sonotaSoubiIcon.a);
            }
        }
        if (soubi.tag == "SonotaSoubiReadoIcon")
        {
            if (soubi.transform.parent.name == "Content ���̑����� �X�e�[�^�X2")
            {
                sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
                number = soubi.GetComponent<SonotaSoubiIcon>().number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
                Debug.Log(sonotaSoubiIcon.a);
            }

        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if(soubi.tag=="KinnkyoriWeponSoubiReadoIcon")
        {
            number = soubi.GetComponent<KinnkyoriWeponSoubiIcon>().number;
            kinnkyoriWeponSoubiIcon = soubi.GetComponent<KinnkyoriWeponSoubiIcon>();
        }
        if(soubi.tag == "KinnkyoriWeponSoubiIcon")
        {
            number = soubi.GetComponent<KinnkyoriWeponSoubiIcon>().number;
            kinnkyoriWeponSoubiIcon = soubi.GetComponent<KinnkyoriWeponSoubiIcon>();
        }
        if (soubi.tag == "EnnkyoriWeponSoubiReadoIcon")
        {
            number = soubi.GetComponent<EnnkyoriWeponSoubiIcon>().number;
            ennkyoriWeponSoubiIcon = soubi.GetComponent<EnnkyoriWeponSoubiIcon>();
        }
        if (soubi.tag == "EnnkyoriWeponSoubiIcon")
        {
            number = soubi.GetComponent<EnnkyoriWeponSoubiIcon>().number;
            ennkyoriWeponSoubiIcon = soubi.GetComponent<EnnkyoriWeponSoubiIcon>();
        }
        if (soubi.tag == "YoroiSoubiReadoIcon")
        {
            number = soubi.GetComponent<YoroiSoubiIcon>().number;
            yoroiSoubiIcon = soubi.GetComponent<YoroiSoubiIcon>();
        }
        if (soubi.tag == "YoroiSoubiIcon")
        {
            number = soubi.GetComponent<YoroiSoubiIcon>().number;
            yoroiSoubiIcon = soubi.GetComponent<YoroiSoubiIcon>();
        }
        if (soubi.tag == "SonotaSoubiReadoIcon")
        {
            number = soubi.GetComponent<SonotaSoubiIcon>().number;
            sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
        }
        if (soubi.tag == "SonotaSoubiIcon")
        {
            number = soubi.GetComponent<SonotaSoubiIcon>().number;
            sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
        }

        a = false;
        nagaosiTime = 0;
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {

    }
    private void SoubiNameUpdata()
    {
        textMeshProUGUI = soubiName.GetComponent<TextMeshProUGUI>();
        if (soubiData.kyoukaLv >= 1)
        {
            if (soubiData.syougouRea)
            {
                textMeshProUGUI.text = "<color=#3EFF4D>" + soubiData.syougouName+ "<color=#FFFFFF>" + soubiData.name + soubiData.giftName + "LV" + soubiData.kyoukaLv;
            }
            else if(soubiData.syougouSuperRea)
            {
                textMeshProUGUI.text = "<color=#3D92FF>" + soubiData.syougouName + "<color=#FFFFFF>" + soubiData.name + soubiData.giftName + "LV" + soubiData.kyoukaLv;

            }
            else if(soubiData.syougouEpikRea)
            {
                textMeshProUGUI.text = "<color=#FF3D4A>" + soubiData.syougouName + "<color=#FFFFFF>" + soubiData.name + soubiData.giftName + "LV" + soubiData.kyoukaLv;
            }
            else
            {
                textMeshProUGUI.text = "<color=#FFFFFF>" + soubiData.name + soubiData.giftName + "LV" + soubiData.kyoukaLv;
            }
        }
        else
        {
            if (soubiData.syougouRea)
            {
                textMeshProUGUI.text = "<color=#3EFF4D>" + soubiData.syougouName + "<color=#FFFFFF>" + soubiData.name + soubiData.giftName;
            }
            else if (soubiData.syougouSuperRea)
            {
                textMeshProUGUI.text = "<color=#3D92FF>" + soubiData.syougouName + "<color=#FFFFFF>" + soubiData.name + soubiData.giftName;

            }
            else if (soubiData.syougouEpikRea)
            {
                textMeshProUGUI.text = "<color=#FF3D4A>" + soubiData.syougouName + "<color=#FFFFFF>" + soubiData.name + soubiData.giftName;
            }
            else
            {
                textMeshProUGUI.text = "<color=#FFFFFF>" + soubiData.name + soubiData.giftName;
            }
        }
    }
}
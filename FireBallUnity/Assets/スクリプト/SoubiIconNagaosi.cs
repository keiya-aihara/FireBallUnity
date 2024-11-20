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
    private GameObject statusPanel2;
    private GameObject statusPanel2Content;

    private StatusPanelSetActive statusPanelSetActive;

    private SoubiSkillDatabase soubiSkillDatabase;

    public KinnkyoriWeponSoubiIcon soubiIcon;

    private SkillPanelOpen skillPanelOpen;
    public GameObject skillPanel;

    public float e=1;

    private GameObject soubi;
    private WeponDataList.WeponData soubiData;

    private int number;
    private bool kinnkyoriWepon;
    private bool ennkyoriWepon;
    private bool yoroi;
    private bool sonota;

    private TextMeshProUGUI textMeshProUGUI;

    public GameObject soubiName;
    public GameObject syougouGiftHosei;

    public Text nomalSyougouhoseinouryoku;
    public Text reaSyougouhoseinouryoiku;
    public Text superReaSyougouhoseinouryoku;

    public Text text;
    public Text statasText;
    private GameObject statusTextGameObject;

    public Text gihutohoseibairitu;
    public Text nouryokuti;
    /*
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
    public GameObject mazyuuTokkou;
    public GameObject ninngennTokkou;
    public GameObject mazinnTokkou;
    public GameObject husiTokkou;
    public GameObject akumaTokkou;
    public GameObject ryuuTokkou;
    public GameObject kamiTokkou;
    public GameObject soubiDropBairitu;
    public GameObject syougouHuyoritu;
    public GameObject giftHuyoritu;
   */
    public GameObject sukiru;
    public GameObject sukiruName;

    private GameObject soubiBotton;
    private SoubiBotton soubiBottonScript;
    private GameObject lockBotton;
    private LockBotton lockBottonScript;

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
            panel = GameObject.Find("ステータスパネル Scroll View");
        }
        if(SceneManager.GetActiveScene().name =="Souko")
        {
            panel = GameObject.Find("UIPanel");
        }
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        soubiSkillDatabase = dataBaseManager.GetComponent<SoubiSkillDatabase>();
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            nagaosiTime += Time.deltaTime;
        }
        if(nagaosiTime >= 0.4f)
        {
            if (SceneManager.GetActiveScene().name == "StatusMenu")
            {
                statusPanelSetActive = GameObject.Find("スタータスパネル専用Canvas").GetComponent<StatusPanelSetActive>();
                statusPanel =statusPanelSetActive.statusPanelStatusMenu;
                Debug.Log(statusPanel);
                if (kinnkyoriWepon)
                {
                    kinnkyoriWeponSoubiIcon.HaiSEPlay();
                    statusPanel.SetActive(true);
                    
                    weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                    soubiData = weponDateBaseManager.GetWeponData(number);

                    soubiBotton = GameObject.Find("装備するボタン");
                    lockBotton = GameObject.Find("保護するボタン");
                    soubiBottonScript = soubiBotton.GetComponent<SoubiBotton>();
                    lockBottonScript = lockBotton.GetComponent<LockBotton>();

                    soubiBottonScript.kinnkyoriWeponSoubiIcon = kinnkyoriWeponSoubiIcon;//


                    lockBottonScript.kinnkyoriWepon = true;
                    lockBottonScript.ennkyoriWepon = false;
                    lockBottonScript.yoroi = false;
                    lockBottonScript.sonota = false;

                    soubiBottonScript.number = number;
                    lockBottonScript.number = number;
                    b = true;

                    kinnkyoriWeponSoubiIcon.a = false;
                    kinnkyoriWepon = false;
                }

                else if (ennkyoriWepon)
                {
                    ennkyoriWeponSoubiIcon.HaiSEPlay();
                    statusPanel.SetActive(true);

                    ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                    soubiData = ennkyoriWeponDataBaseManager.GetWeponData(number);

                    soubiBotton = GameObject.Find("装備するボタン");
                    lockBotton = GameObject.Find("保護するボタン");
                    soubiBottonScript = soubiBotton.GetComponent<SoubiBotton>();
                    lockBottonScript = lockBotton.GetComponent<LockBotton>();

                    soubiBottonScript.ennkyoriWeponSoubiIcon = ennkyoriWeponSoubiIcon;

                    lockBottonScript.kinnkyoriWepon = false;
                    lockBottonScript.ennkyoriWepon = true;
                    lockBottonScript.yoroi = false;
                    lockBottonScript.sonota = false;

                    soubiBottonScript.number = number;
                    lockBottonScript.number = number;
                    b = true;

                    ennkyoriWeponSoubiIcon.a = false;
                    ennkyoriWepon = false;
                }
                else if (yoroi)
                {
                    yoroiSoubiIcon.HaiSEPlay();
                    statusPanel.SetActive(true);

                    yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                    soubiData = yoroiDataBaseManager.GetWeponData(number);

                    soubiBotton = GameObject.Find("装備するボタン");
                    lockBotton = GameObject.Find("保護するボタン");
                    soubiBottonScript = soubiBotton.GetComponent<SoubiBotton>();
                    lockBottonScript = lockBotton.GetComponent<LockBotton>();

                    soubiBottonScript.yoroiSoubiIcon = yoroiSoubiIcon;

                    lockBottonScript.kinnkyoriWepon = false;
                    lockBottonScript.ennkyoriWepon = false;
                    lockBottonScript.yoroi = true;
                    lockBottonScript.sonota = false;

                    soubiBottonScript.number = number;
                    lockBottonScript.number = number;
                    b = true;

                    yoroiSoubiIcon.a = false;
                    yoroi = false;
                }
                if (sonota)
                {
                    sonotaSoubiIcon.HaiSEPlay();
                    statusPanel.SetActive(true);

                    sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                    soubiData = sonotaDataBaseManager.GetWeponData(number);

                    soubiBotton = GameObject.Find("装備するボタン");
                    lockBotton = GameObject.Find("保護するボタン");
                    soubiBottonScript = soubiBotton.GetComponent<SoubiBotton>();
                    lockBottonScript = lockBotton.GetComponent<LockBotton>();

                    soubiBottonScript.sonotaSoubiIcon = sonotaSoubiIcon;

                    lockBottonScript.kinnkyoriWepon = false;
                    lockBottonScript.ennkyoriWepon = false;
                    lockBottonScript.yoroi = false;
                    lockBottonScript.sonota = true;

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
            statusPanelSetActive = GameObject.Find("ステータスパネル専用Canvas").GetComponent<StatusPanelSetActive>();
            statusPanel2 = statusPanelSetActive.GetComponent<StatusPanelSetActive>().statusPanelSouko;
            if (kinnkyoriWepon)
            {
                statusPanel2.SetActive(true);

                weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                soubiData = weponDateBaseManager.GetWeponData(number);

                lockBotton = GameObject.Find("保護するボタン");
                lockBottonScript = lockBotton.GetComponent<LockBotton>();
                lockBottonScript.number = number;

                b = true;

                kinnkyoriWeponSoubiIcon.a = false;
                kinnkyoriWepon = false;
            }

            else if (ennkyoriWepon)
            {
                statusPanel2.SetActive(true);

                ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                soubiData = ennkyoriWeponDataBaseManager.GetWeponData(number);

                lockBotton = GameObject.Find("保護するボタン");
                lockBottonScript = lockBotton.GetComponent<LockBotton>();
                lockBottonScript.number = number;

                b = true;

                ennkyoriWeponSoubiIcon.a = false;
                ennkyoriWepon = false;
            }
            else if (yoroi)
            {
                statusPanel2.SetActive(true);

                yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                soubiData = yoroiDataBaseManager.GetWeponData(number);

                b = true;

                lockBotton = GameObject.Find("保護するボタン");
                lockBottonScript = lockBotton.GetComponent<LockBotton>();
                lockBottonScript.number = number;

                yoroiSoubiIcon.a = false;
                yoroi = false;
            }
            else if (sonota)
            {
                statusPanel2.SetActive(true);

                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                soubiData = sonotaDataBaseManager.GetWeponData(number);

                b = true;

                lockBotton = GameObject.Find("保護するボタン");
                lockBottonScript = lockBotton.GetComponent<LockBotton>();
                lockBottonScript.number = number;

                sonotaSoubiIcon.a = false;
                sonota = false;
            }

            a = false;
            nagaosiTime = 0;
        }
    }
    public void StatusPanel()
    {
        if (SceneManager.GetActiveScene().name == "StatusMenu")
        {
            statusPanelContent = GameObject.Find("Content 装備 称号・ギフト補正");

            SoubiNameUpdata();
            Instantiate(soubiName, transform.position, transform.rotation, statusPanelContent.transform);

            if (soubiData.syougouName != "" || soubiData.giftBairituName != "")
            {
                text = syougouGiftHosei.GetComponent<Text>();
                text.text = "《称号》〈ギフト〉補正値";
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
            text.text = "能力値";
            Instantiate(nouryokuti, transform.position, transform.rotation, statusPanelContent.transform);

            if (soubiData.maxHp != 0)
            {
                statasText.text = " - HP　" + soubiData.kyoukagoMaxHp + "《" + soubiData.syougouMaxHp + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.maxMp != 0)
            {
                statasText.text = " - MP　" + soubiData.kyoukagoMaxMp + "《" + soubiData.syougouMaxMp + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.fireBallCost != 0)
            {
                statasText.text = " - FBコスト　" + soubiData.fireBallCost + "《" + soubiData.fireBallCost + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kougekiryoku != 0)
            {
                statasText.text = " - 攻撃力　" + soubiData.kyoukagoKougekiryoku + "《" + soubiData.syougouKougekiryoku + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.maryoku != 0)
            {
                statasText.text = " - 魔力　" + soubiData.kyoukagoMaryoku + "《" + soubiData.syougouMamryoku + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kinnkyoriKaisinnritu != 0)
            {
                statasText.text = " - 近距離会心率　" + soubiData.kinnkyoriKaisinnritu + "《" + soubiData.syougouKinnkyoriKaisinnritu + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.ennkyoriKaisinnsitu != 0)
            {
                statasText.text = " - 遠距離会心率　" + soubiData.ennkyoriKaisinnsitu + "《" + soubiData.syougouEnnkyoriKaisinnritu + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.bougyoryoiku != 0)
            {
                statasText.text = " - 防御力　" + soubiData.kyoukagoBougyoryoku + "《" + soubiData.syougouBougyoryoku + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kaisinnTaisei != 0)
            {
                statasText.text = " - 会心耐性　" + soubiData.kaisinnTaisei + "《" + soubiData.syougouKaisinnTaisei + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.meityuuritu != 0)
            {
                statasText.text = " - 命中率　" + soubiData.kyoukagoMeityuuritu + "《" + soubiData.syougouMeityuuritu + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kaihiritu != 0)
            {
                statasText.text = " - 回避率　" + soubiData.kyoukagoKaihiritu + "《" + soubiData.syougouKaihiritu + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.nokkubakku != 0)
            {
                statasText.text = " - 衝撃力　" + soubiData.nokkubakku + "《" + soubiData.syougouSyougekiryoku + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.kougekiHinndo != 0)
            {
                if (soubiData.zyukurenndoKougekiHinndo != 0)
                {
                    statasText.text = " - 攻撃速度　" + soubiData.zyukurenndoKougekiHinndo + "秒"+ "《" + soubiData.syougouSrushHinndo + "》";
                    Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
                }
                else
                {
                    statasText.text = " - 攻撃速度　" + soubiData.kougekiHinndo + "秒"+ "《" + soubiData.syougouSrushHinndo + "》";
                    Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
                }
            }
            if (soubiData.kougekiHanni != 0)
            {
                statasText.text = " - 攻撃範囲　半径" + soubiData.kougekiHanni + "《" + soubiData.syougouKougekiHanni + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiMazyuuTokkou!=0)
            {
                statasText.text = " - 魔獣特攻" + soubiData.soubiMazyuuTokkou + "%"+"《" + soubiData.syougouMazyuuTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiNinngennTokkou != 0)
            {
                statasText.text = " - 人間特攻" + soubiData.soubiNinngennTokkou + "%"+"《" + soubiData.syougouNinngennTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiMazinnTokkou != 0)
            {
                statasText.text = " - 魔人特攻" + soubiData.soubiMazinnTokkou + "%"+"《" + soubiData.syougouMazinnTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiHusiTokkou != 0)
            {
                statasText.text = " - 不死特攻" + soubiData.soubiHusiTokkou + "%"+ "《" + soubiData.syougouHusiTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiAkumaTokkou != 0)
            {
                statasText.text = " - 悪魔特攻" + soubiData.soubiAkumaTokkou + "%"+ "《" + soubiData.syougouAkumaTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiRyuuTokkou != 0)
            {
                statasText.text = " - 竜特攻" + soubiData.soubiRyuuTokkou + "%"+ "《" + soubiData.syougouRyuuTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiKamiTokkou != 0)
            {
                statasText.text = " - 神特攻" + soubiData.soubiKamiTokkou + "%"+ "《" + soubiData.syougouKamiTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiDropBairitu != 0)
            {
                statasText.text = " - ドロップ倍率" + soubiData.soubiDropBairitu + "%"+ "《" + soubiData.syougouSoubiDropBairitu + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.syougouDropRitu != 0)
            {
                statasText.text = " - 称号付与率" + soubiData.syougouDropRitu + "%"+ "《" + soubiData.syougouSyougouDropRitu + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }
            if (soubiData.soubiGifthuyosoubiDropritu != 0)
            {
                statasText.text = " - ギフト付与率" + soubiData.soubiGifthuyosoubiDropritu + "%"+"《" + soubiData.syougouSoubiGifthuyosoubiDropritu + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanelContent.transform);
            }

            if (soubiData.skill)
            {
                Instantiate(sukiru, transform.position, transform.rotation, statusPanelContent.transform);
                sukiruName.GetComponent<Text>().text = soubiSkillDatabase.GetSoubiSkillData(soubiData.skillNo).skillName;
                skillPanelOpen = Instantiate(sukiruName, transform.position, transform.rotation, statusPanelContent.transform).GetComponent<SkillPanelOpen>();
                skillPanelOpen.statusPanelSetActive = statusPanelSetActive;
                skillPanelOpen.skillNo = soubiData.skillNo;
                skillPanelOpen.soubiSkillDatabase = soubiSkillDatabase;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Souko")
        {
            statusPanel2Content = GameObject.Find("Content 装備 称号・ギフト補正");

            SoubiNameUpdata();
            Instantiate(soubiName, transform.position, transform.rotation, statusPanel2Content.transform);
            if (soubiData.syougouName != "" || soubiData.giftBairituName != "")
            {
                text = syougouGiftHosei.GetComponent<Text>();
                text.text = "《称号》〈ギフト〉補正値";
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
            text.text = "能力値";
            Instantiate(nouryokuti, transform.position, transform.rotation, statusPanel2Content.transform);

            if (soubiData.maxHp != 0)
            {
                statasText.text = " - HP　" + soubiData.kyoukagoMaxHp + "《" + soubiData.syougouMaxHp + "》";
                statusTextGameObject = Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
                statusTextGameObject.name = "HP(Clone)";
            }
            if (soubiData.maxMp != 0)
            {
                statasText.text = " - MP　" + soubiData.kyoukagoMaxMp + "《" + soubiData.syougouMaxMp + "》";
                statusTextGameObject = Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
                statusTextGameObject.name = "MP(Clone)";
            }
            if (soubiData.fireBallCost != 0)
            {
                statasText.text = " - FBコスト　" + soubiData.fireBallCost + "《" + soubiData.fireBallCost + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.kougekiryoku != 0)
            {
                statasText.text = " - 攻撃力　" + soubiData.kyoukagoKougekiryoku + "《" + soubiData.syougouKougekiryoku + "》";
                statusTextGameObject = Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
                statusTextGameObject.name = "攻撃力(Clone)";
            }
            if (soubiData.maryoku != 0)
            {
                statasText.text = " - 魔力　" + soubiData.kyoukagoMaryoku + "《" + soubiData.syougouMamryoku + "》";
                statusTextGameObject = Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
                statusTextGameObject.name = "魔力(Clone)";
            }
            if (soubiData.kinnkyoriKaisinnritu != 0)
            {
                statasText.text = " - 近距離会心率　" + soubiData.kinnkyoriKaisinnritu + "《" + soubiData.syougouKinnkyoriKaisinnritu + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.ennkyoriKaisinnsitu != 0)
            {
                statasText.text = " - 遠距離会心率　" + soubiData.ennkyoriKaisinnsitu + "《" + soubiData.syougouEnnkyoriKaisinnritu + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.bougyoryoiku != 0)
            {
                statasText.text = " - 防御力　" + soubiData.kyoukagoBougyoryoku + "《" + soubiData.syougouBougyoryoku + "》";
                statusTextGameObject = Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
                statusTextGameObject.name = "防御力(Clone)";
            }
            if (soubiData.kaisinnTaisei != 0)
            {
                statasText.text = " - 会心耐性　" + soubiData.kaisinnTaisei + "《" + soubiData.syougouKaisinnTaisei + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.meityuuritu != 0)
            {
                statasText.text = " - 命中率　" + soubiData.kyoukagoMeityuuritu + "《" + soubiData.syougouMeityuuritu + "》";
                statusTextGameObject = Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
                statusTextGameObject.name = "命中率(Clone)";
            }
            if (soubiData.kaihiritu != 0)
            {
                statasText.text = " - 回避率　" + soubiData.kyoukagoKaihiritu + "《" + soubiData.syougouKaihiritu + "》";
                statusTextGameObject = Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
                statusTextGameObject.name = "回避率(Clone)";
            }
            if (soubiData.nokkubakku != 0)
            {
                statasText.text = " - 衝撃力　" + soubiData.nokkubakku + "《" + soubiData.syougouSyougekiryoku + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.kougekiHinndo != 0)
            {
                if (soubiData.zyukurenndoKougekiHinndo != 0)
                {
                    statasText.text = " - 攻撃速度　" + soubiData.zyukurenndoKougekiHinndo + "秒"+ "《" + soubiData.syougouSrushHinndo + "》";
                    Instantiate(statasText, transform.position, transform.rotation, statusPanel2Content.transform);
                }
                else
                {
                    statasText.text = " - 攻撃速度　" + "秒"+"《" + soubiData.syougouSrushHinndo + "》" + soubiData.kougekiHinndo;
                    Instantiate(statasText, transform.position, transform.rotation, statusPanel2Content.transform);
                }
            }
            if (soubiData.kougekiHanni != 0)
            {
                statasText.text = " - 攻撃範囲　半径" + soubiData.kougekiHanni + "m"+ "《" + soubiData.syougouKougekiHanni + "》";
                Instantiate(statasText, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiMazyuuTokkou != 0)
            {
                statasText.text = " - 魔獣特攻" + soubiData.soubiMazyuuTokkou + "%"+ "《" + soubiData.syougouMazyuuTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiNinngennTokkou != 0)
            {
                statasText.text = " - 人間特攻" + soubiData.soubiNinngennTokkou + "%"+"《" + soubiData.syougouNinngennTokkou+"》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiMazinnTokkou != 0)
            {
                statasText.text = " - 魔人特攻" + soubiData.soubiMazinnTokkou + "%"+ "《" + soubiData.syougouMazinnTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiHusiTokkou != 0)
            {
                statasText.text = " - 不死特攻" + soubiData.soubiHusiTokkou + "%"+"《" + soubiData.syougouHusiTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiAkumaTokkou != 0)
            {
                statasText.text = " - 悪魔特攻" + soubiData.soubiAkumaTokkou + "%"+ "《" + soubiData.syougouAkumaTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiRyuuTokkou != 0)
            {
                statasText.text = " - 竜特攻" + soubiData.soubiRyuuTokkou + "%"+ "《" + soubiData.syougouRyuuTokkou + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiKamiTokkou != 0)
            {
                statasText.text = " - 神特攻" + soubiData.soubiKamiTokkou + "%"+ "《" + soubiData.syougouKamiTokkou+ "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiDropBairitu != 0)
            {
                statasText.text = " - ドロップ倍率" + soubiData.soubiDropBairitu + "%"+ "《" + soubiData.syougouSoubiDropBairitu + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.syougouDropRitu != 0)
            {
                statasText.text = " - 称号付与率" + soubiData.syougouDropRitu + "%"+ "《" + soubiData.syougouSyougouDropRitu + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }
            if (soubiData.soubiGifthuyosoubiDropritu != 0)
            {
                statasText.text = " - ギフト付与率" + soubiData.soubiGifthuyosoubiDropritu + "%"+ "《" + soubiData.syougouSoubiGifthuyosoubiDropritu + "》";
                Instantiate(statasText.gameObject, transform.position, transform.rotation, statusPanel2Content.transform);
            }

            if (soubiData.skill)
            {
                Instantiate(sukiru, transform.position, transform.rotation, statusPanel2Content.transform);

                sukiruName.GetComponent<Text>().text = soubiSkillDatabase.GetSoubiSkillData(soubiData.skillNo).skillName;
                skillPanelOpen = Instantiate(sukiruName, transform.position, transform.rotation, statusPanel2Content.transform).GetComponent<SkillPanelOpen>();
                skillPanelOpen.statusPanelSetActive = statusPanelSetActive;
                skillPanelOpen.skillNo = soubiData.skillNo;
                skillPanelOpen.soubiSkillDatabase = soubiSkillDatabase;
            }

        }
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        
        soubi = pointerEventData.selectedObject;
        if (soubi.tag == "KinnkyoriWeponSoubiReadoIcon")
        {
            if (soubi.transform.parent.name == "Content 近距離武器　ステータス"|| soubi.transform.parent.name == "Content Select Soubi　ステータス")
            {
                kinnkyoriWeponSoubiIcon = soubi.GetComponent<KinnkyoriWeponSoubiIcon>();
                number = kinnkyoriWeponSoubiIcon.number;
                kinnkyoriWeponSoubiIcon.a = true;
                a = true;
                kinnkyoriWepon = true;
            }
            else if(soubi.transform.parent.name == "Content Select Soubi　装備強化・売却")
            {
                kinnkyoriWeponSoubiIcon = soubi.GetComponent<KinnkyoriWeponSoubiIcon>();
                number = soubi.GetComponent<KinnkyoriWeponSoubiIcon>().number;
                kinnkyoriWeponSoubiIcon.a = true;
                a = true;
                kinnkyoriWepon = true;
            }
            Debug.Log(soubi);
        }
        else if(soubi.tag == "KinnkyoriWeponSoubiIcon")
        {
            if(soubi.transform.parent.parent.name == "Content 近距離武器　ステータス"|| soubi.transform.parent.parent.name == "Content Select Soubi　ステータス")
            {
                kinnkyoriWeponSoubiIcon = soubi.transform.parent.GetComponent<KinnkyoriWeponSoubiIcon>();
                number = kinnkyoriWeponSoubiIcon.number;
                kinnkyoriWeponSoubiIcon.a = true;
                a = true;
                kinnkyoriWepon = true;
            }
            else if (soubi.transform.parent.parent.name == "Content Select Soubi　装備強化・売却")
            {
                kinnkyoriWeponSoubiIcon = soubi.GetComponent<KinnkyoriWeponSoubiIcon>();
                number = kinnkyoriWeponSoubiIcon.number;
                kinnkyoriWeponSoubiIcon.a = true;
                a = true;
                kinnkyoriWepon = true;
            }
            Debug.Log(soubi);
        }
        else if (soubi.tag == "EnnkyoriWeponSoubiReadoIcon")
        {
            if (soubi.transform.parent.name == "Content 遠距離武器 ステータス" || soubi.transform.parent.name == "Content Select Soubi　ステータス")
            {
                ennkyoriWeponSoubiIcon = soubi.GetComponent<EnnkyoriWeponSoubiIcon>();
                number = ennkyoriWeponSoubiIcon.number;
                ennkyoriWeponSoubiIcon.a = true;
                a = true;
                ennkyoriWepon = true;
            }
            else if (soubi.transform.parent.name == "Content Select Soubi　装備強化・売却")
            {
                ennkyoriWeponSoubiIcon = soubi.GetComponent<EnnkyoriWeponSoubiIcon>();
                number = ennkyoriWeponSoubiIcon.number;
                ennkyoriWeponSoubiIcon.a = true;
                a = true;
                ennkyoriWepon = true;
            }
        }
        else if (soubi.tag == "EnnkyoriWeponSoubiIcon")
        {
            if (soubi.transform.parent.parent.name == "Content 遠距離武器 ステータス" || soubi.transform.parent.parent.name == "Content Select Soubi　ステータス")
            {
                ennkyoriWeponSoubiIcon = soubi.transform.parent.GetComponent<EnnkyoriWeponSoubiIcon>();
                number = ennkyoriWeponSoubiIcon.number;
                ennkyoriWeponSoubiIcon.a = true;
                a = true;
                ennkyoriWepon = true;
                Debug.Log(ennkyoriWeponSoubiIcon.a);
            }
            else if (soubi.transform.parent.parent.name == "Content Select Soubi　装備強化・売却")
            {
                ennkyoriWeponSoubiIcon = soubi.GetComponent<EnnkyoriWeponSoubiIcon>();
                number = ennkyoriWeponSoubiIcon.number;
                ennkyoriWeponSoubiIcon.a = true;
                a = true;
                ennkyoriWepon = true;
            }
        }
        else if (soubi.tag == "YoroiSoubiReadoIcon")
        {
            if (soubi.transform.parent.name == "Content 鎧装備 ステータス" || soubi.transform.parent.name == "Content Select Soubi　ステータス")
            {
                yoroiSoubiIcon = soubi.GetComponent<YoroiSoubiIcon>();
                number = yoroiSoubiIcon.number;
                yoroiSoubiIcon.a = true;
                a = true;
                yoroi = true;
            }
            else if (soubi.transform.parent.name == "Content Select Soubi　装備強化・売却")
            {
                yoroiSoubiIcon = soubi.GetComponent<YoroiSoubiIcon>();
                number = yoroiSoubiIcon.number;
                yoroiSoubiIcon.a = true;
                a = true;
                yoroi = true;
            }
        }
        else if (soubi.tag == "YoroiSoubiIcon")
        {
            if (soubi.transform.parent.parent.name == "Content 鎧装備 ステータス" || soubi.transform.parent.parent.name == "Content Select Soubi　ステータス")
            {
                yoroiSoubiIcon = soubi.transform.parent.GetComponent<YoroiSoubiIcon>();
                number = yoroiSoubiIcon.number;
                yoroiSoubiIcon.a = true;
                a = true;
                yoroi = true;
                Debug.Log(yoroiSoubiIcon.a);
            }
            else if (soubi.transform.parent.parent.name == "Content Select Soubi　装備強化・売却")
            {
                yoroiSoubiIcon = soubi.GetComponent<YoroiSoubiIcon>();
                number = yoroiSoubiIcon.number;
                yoroiSoubiIcon.a = true;
                a = true;
                yoroi = true;
            }
        }
        else if (soubi.tag == "SonotaSoubiIcon")
        {
            if (soubi.transform.parent.parent.name == "Content その他装備 ステータス 1" || soubi.transform.parent.parent.name == "Content Select Soubi　ステータス")
            {
                sonotaSoubiIcon = soubi.transform.parent.GetComponent<SonotaSoubiIcon>();
                number = sonotaSoubiIcon.number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
                Debug.Log(sonotaSoubiIcon.a);
            }
            else if (soubi.transform.parent.parent.name == "Content Select Soubi　装備強化・売却")
            {
                sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
                number = sonotaSoubiIcon.number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
            }
        }
        else if(soubi.tag == "SonotaSoubiReadoIcon")
            {
            if (soubi.transform.parent.name == "Content その他装備 ステータス 1" || soubi.transform.parent.name == "Content Select Soubi　ステータス")
            {
                sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
                number = sonotaSoubiIcon.number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
            }
            else if (soubi.transform.parent.name == "Content Select Soubi　装備強化・売却")
            {
                sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
                number = sonotaSoubiIcon.number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
            }

        }
        if (soubi.tag == "SonotaSoubiIcon")
        {
            if (soubi.transform.parent.parent.name == "Content その他装備 ステータス2" || soubi.transform.parent.parent.name == "Content Select Soubi　ステータス")
            {
                sonotaSoubiIcon = soubi.transform.parent.GetComponent<SonotaSoubiIcon>();
                number = sonotaSoubiIcon.number;
                sonotaSoubiIcon.a = true;
                a = true;
                sonota = true;
                Debug.Log(sonotaSoubiIcon.a);
            }
        }
        if (soubi.tag == "SonotaSoubiReadoIcon")
        {
            if (soubi.transform.parent.name == "Content その他装備 ステータス2" || soubi.transform.parent.name == "Content Select Soubi　ステータス")
            {
                sonotaSoubiIcon = soubi.GetComponent<SonotaSoubiIcon>();
                number = sonotaSoubiIcon.number;
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

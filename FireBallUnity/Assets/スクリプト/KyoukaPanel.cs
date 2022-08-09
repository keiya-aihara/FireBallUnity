using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class KyoukaPanel : MonoBehaviour
{
    public Text syoziMoney;
    public TextMeshProUGUI syoziKyoukaseki;
    public TextMeshProUGUI kyoukakakuninnText;
    public Text kinngakukakuninnText;
    public TextMeshProUGUI kyoukasekiTextMeshPro;
    public GameObject taikagatarimasennPanel;
    public GameObject lv100OkBotton;
    public Text kyoukamaeText;
    public Text migiYazirusiText;
    public Text kyoukagoText;

    private int kyoukagoNouryokuti;
    private GameObject moneyManager;
    private MoneyManager moneyManagerScript;
    private KyoukasekiManager kyoukasekiManager;
    public GameObject yesBotton;
    public GameObject noBotton;

    public int number;

    private GameObject dataBaseManager;
    private WeponDateBaseManager weponDateBaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    private YoroiDataBaseManager yoroiDataBaseManager;
    private SonotaDataBaseManager sonotaDataBaseManager;
    private WeponDataList.WeponData soubi;
    private PlayerStatusDataBase playerStatusDataBase;
    public bool kinnkyoriWepon;
    public bool ennkyoriWepon;
    public bool yoroi;
    public bool sonota;
    private int kyoukaKinngaku;
    private int kyoukasekiSyou;
    private int kyoukasekiTyuu;
    private int kyoukasekiDai;
    private int reado;

    private KousekiDataBaseManager kousekiDataBaseManager;

    private GameObject statusText;
    private Text statusTextText;

    private List<int> sonotasoubiKyoukaStatus = new List<int>();
    private int sonotaSoubiKyoukaStatusInt;
    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActiveSelfGameObject()
    {
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        playerStatusDataBase = dataBaseManager.GetComponent<PlayerStatusDataBase>();

        moneyManagerScript = dataBaseManager.GetComponent<MoneyManager>();
        kyoukasekiManager = dataBaseManager.GetComponent<KyoukasekiManager>();
        kousekiDataBaseManager = dataBaseManager.GetComponent<KousekiDataBaseManager>();
        syoziMoney.text = "所持品 " + moneyManagerScript.money.ToString("N0") + "コイン";
        syoziKyoukaseki.text = "  <sprite=0>×" + kyoukasekiManager.kyoukasekiSyou + "  <sprite=2>×" + kyoukasekiManager.kyoukasekiTyuu + "  <sprite=1>×" + kyoukasekiManager.kyoukasekiDai;
        getSoubi();
        if (moneyManagerScript.money < kyoukaKinngaku || kyoukasekiManager.kyoukasekiSyou < kyoukasekiSyou || kyoukasekiManager.kyoukasekiTyuu < kyoukasekiTyuu || kyoukasekiManager.kyoukasekiDai < kyoukasekiDai)
        {
            taikagatarimasennPanel.SetActive(true);
        }
        Saidaikyouka();
        KyoukazenngoNouryokutiGet();

    }
    private void getSoubi()
    {
        if (kinnkyoriWepon)
        {
            weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
            soubi = weponDateBaseManager.GetWeponData(number);

            if (soubi.kyoukaLv >= 1)
            {
                if (soubi.syougouRea)
                {
                    kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else if (soubi.syougouSuperRea)
                {
                    kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else if (soubi.syougouEpikRea)
                {
                    kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else
                {
                    kyoukakakuninnText.text = soubi.name + soubi.giftName + "Lv" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
            }
            else
            {
                if (soubi.syougouRea)
                {
                    kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else if (soubi.syougouSuperRea)
                {
                    kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else if (soubi.syougouEpikRea)
                {
                    kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else
                {
                    kyoukakakuninnText.text = soubi.name + soubi.giftName + "\nを強化しますか？";
                }
            }

            if (soubi.nomal)
            {
                reado = 1;
            }
            else if (soubi.rea)
            {
                reado = 2;
            }
            else if (soubi.superRea)
            {
                reado = 3;
            }
            else if (soubi.epik)
            {
                reado = 4;
            }
            else if (soubi.legendary)
            {
                reado = 5;
            }
            else if (soubi.god)
            {
                reado = 6;
            }
        
            kyoukaHiyou(soubi.kyoukaLv, reado);
        }
    
        if (ennkyoriWepon)
        {
            ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
            soubi = ennkyoriWeponDataBaseManager.GetWeponData(number);
            if (soubi.kyoukaLv >= 1)
            {
                if (soubi.syougouRea)
                {
                    kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else if (soubi.syougouSuperRea)
                {
                    kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else if (soubi.syougouEpikRea)
                {
                    kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else
                {
                    kyoukakakuninnText.text = soubi.name + soubi.giftName + "Lv" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
            }
            else
            {
                if (soubi.syougouRea)
                {
                    kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else if (soubi.syougouSuperRea)
                {
                    kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else if (soubi.syougouEpikRea)
                {
                    kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else
                {
                    kyoukakakuninnText.text = soubi.name + soubi.giftName + "\nを強化しますか？";
                }
            }
            if (soubi.nomal)
            {
                reado = 1;
            }
            else if (soubi.rea)
            {
                reado = 2;
            }
            else if (soubi.superRea)
            {
                reado = 3;
            }
            else if (soubi.epik)
            {
                reado = 4;
            }
            else if (soubi.legendary)
            {
                reado = 5;
            }
            else if (soubi.god)
            {
                reado = 6;
            }
            kyoukaHiyou(soubi.kyoukaLv, reado);
        }
        if (yoroi)
        {
            yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
            soubi = yoroiDataBaseManager.GetWeponData(number);
            if (soubi.kyoukaLv >= 1)
            {
                if (soubi.syougouRea)
                {
                    kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else if (soubi.syougouSuperRea)
                {
                    kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else if (soubi.syougouEpikRea)
                {
                    kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else
                {
                    kyoukakakuninnText.text = soubi.name + soubi.giftName + "Lv" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
            }
            else
            {
                if (soubi.syougouRea)
                {
                    kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else if (soubi.syougouSuperRea)
                {
                    kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else if (soubi.syougouEpikRea)
                {
                    kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else
                {
                    kyoukakakuninnText.text = soubi.name + soubi.giftName + "\nを強化しますか？";
                }
            }
            if (soubi.nomal)
            {
                reado = 1;
            }
            else if (soubi.rea)
            {
                reado = 2;
            }
            else if (soubi.superRea)
            {
                reado = 3;
            }
            else if (soubi.epik)
            {
                reado = 4;
            }
            else if (soubi.legendary)
            {
                reado = 5;
            }
            else if (soubi.god)
            {
                reado = 6;
            }
            kyoukaHiyou(soubi.kyoukaLv, reado);
        }
        if (sonota)
        {
            sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
            soubi = sonotaDataBaseManager.GetWeponData(number);
            if (soubi.kyoukaLv >= 1)
            {
                if (soubi.syougouRea)
                {
                    kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else if (soubi.syougouSuperRea)
                {
                    kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else if (soubi.syougouEpikRea)
                {
                    kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
                else
                {
                    kyoukakakuninnText.text = soubi.name + soubi.giftName + "Lv" + soubi.kyoukaLvName + "\nを強化しますか？";
                }
            }
            else
            {
                if (soubi.syougouRea)
                {
                    kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else if (soubi.syougouSuperRea)
                {
                    kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else if (soubi.syougouEpikRea)
                {
                    kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "\nを強化しますか？";
                }
                else
                {
                    kyoukakakuninnText.text = soubi.name + soubi.giftName + "\nを強化しますか？";
                }
            }
            if (soubi.nomal)
            {
                reado = 1;
            }
            else if (soubi.rea)
            {
                reado = 2;
            }
            else if (soubi.superRea)
            {
                reado = 3;
            }
            else if (soubi.epik)
            {
                reado = 4;
            }
            else if (soubi.legendary)
            {
                reado = 5;
            }
            else if (soubi.god)
            {
                reado = 6;
            }
            kyoukaHiyou(soubi.kyoukaLv, reado);
        }
            
    }
    private void kyoukaHiyou(int lv,int reado)//readoは１ならnormal２ならレア。。。６ならゴットレア
    {
        if(reado==1)
        {
            kyoukaKinngaku = 500 * (lv + 1);
            kyoukasekiSyou = lv + 1;
            kyoukasekiSyou = Mathf.CeilToInt((kyoukasekiSyou * (100 - (playerStatusDataBase.kyoukataikaGennsyouritu))) / 100);
            if (lv>=30)
            {
                kyoukasekiTyuu = lv + 1 - 30;
                kyoukasekiTyuu = Mathf.CeilToInt((kyoukasekiTyuu * (100 - (playerStatusDataBase.kyoukataikaGennsyouritu))) / 100);
                //Debug.Log(kyoukasekiTyuu);
            }
            else
            {
                kyoukasekiTyuu = 0;
            }
            if(lv>=60)
            {
                kyoukasekiDai = lv + 1 - 60;
                kyoukasekiDai = Mathf.CeilToInt((kyoukasekiDai * (100 - (playerStatusDataBase.kyoukataikaGennsyouritu))) / 100);
            }
            else
            {
                kyoukasekiDai = 0;
            }
        }
        if (moneyManagerScript.money < kyoukaKinngaku || kyoukasekiManager.kyoukasekiSyou < kyoukasekiSyou || kyoukasekiManager.kyoukasekiTyuu < kyoukasekiTyuu || kyoukasekiManager.kyoukasekiDai < kyoukasekiDai)
        {
            taikagatarimasennPanel.SetActive(true);
        }
        kinngakukakuninnText.text = "強化対価 " + kyoukaKinngaku.ToString("N0") + " コイン";
        kyoukasekiTextMeshPro.text = "<sprite=0>×" + kyoukasekiSyou + "  <sprite=2>×" + kyoukasekiTyuu + "  <sprite=1>× " + kyoukasekiDai;
        Saidaikyouka();
    }
    public void TaikagatarimasennIieBottonDown()
    {
        if (soubi.kyoukaLv >= 1)
        {
            if (soubi.syougouRea)
            {
                GameObject.Find("装備名(Clone)").GetComponent<TextMeshProUGUI>().text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName;
            }
            else if(soubi.syougouSuperRea)
            {
                GameObject.Find("装備名(Clone)").GetComponent<TextMeshProUGUI>().text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName;
            }
            else if(soubi.syougouEpikRea)
            {
                GameObject.Find("装備名(Clone)").GetComponent<TextMeshProUGUI>().text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName;
            }
            else
            {
                GameObject.Find("装備名(Clone)").GetComponent<TextMeshProUGUI>().text = soubi.name + soubi.giftBairituName + "Lv" + soubi.kyoukaLvName;
            }
        }
        kinngakukakuninnText.gameObject.SetActive(true);
        kyoukasekiTextMeshPro.gameObject.SetActive(true);
        yesBotton.SetActive(true);
        noBotton.SetActive(true);
        taikagatarimasennPanel.SetActive(true);
        migiYazirusiText.gameObject.SetActive(true);
        kyoukagoText.gameObject.SetActive(true);
        lv100OkBotton.SetActive(false);
        taikagatarimasennPanel.SetActive(false);
        if(kinnkyoriWepon)
        {
            statusText = GameObject.Find("攻撃力(Clone)");
            statusText.GetComponent<Text>().text = " - 攻撃力　" + soubi.kyoukagoKougekiryoku + "《" + soubi.syougouKougekiryoku + "》";
        }
        else if(ennkyoriWepon)
        {
            statusText=GameObject.Find("魔力(Clone)");
            statusText.GetComponent<Text>().text = " - 魔力　" + soubi.kyoukagoMaryoku + "《" + soubi.syougouMamryoku + "》";
        }
        else if(yoroi)
        {
            statusText = GameObject.Find("防御力(Clone)");
            statusText.GetComponent<Text>().text= " - 防御力　" + soubi.kyoukagoBougyoryoku + "《" + soubi.syougouBougyoryoku + "》";
        }
        gameObject.SetActive(false);
    }
    public void HaiBottonDown()
    {
        moneyManagerScript.money -= kyoukaKinngaku;
        kyoukasekiManager.kyoukasekiSyou -= kyoukasekiSyou;
        kyoukasekiManager.kyoukasekiTyuu -= kyoukasekiTyuu;
        kyoukasekiManager.kyoukasekiDai -= kyoukasekiDai;
        syoziMoney.text = "所持品 " + moneyManagerScript.money.ToString("N0") + "コイン";
        syoziKyoukaseki.text = "  <sprite=0>×" + kyoukasekiManager.kyoukasekiSyou + "  <sprite=2>×" + kyoukasekiManager.kyoukasekiTyuu + "  <sprite=1>×" + kyoukasekiManager.kyoukasekiDai;

        if (soubi.kyoukaLv<10)
        {
            soubi.kyoukaBairitu += 1;
        }
        else if (soubi.kyoukaLv < 20)
        {
            soubi.kyoukaBairitu += 2;
        }
        else if (soubi.kyoukaLv < 30)
        {
            soubi.kyoukaBairitu += 3;
        }
        else if (soubi.kyoukaLv < 40)
        {
            soubi.kyoukaBairitu += 4;
        }
        else if(soubi.kyoukaLv < 100)
        {
            soubi.kyoukaBairitu += 5;
        }
        soubi.kyoukaLv++;
        soubi.kyoukaLvName = soubi.kyoukaLv.ToString();
        if (soubi.syougouRea)
        {
            kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
        }
        else if (soubi.syougouSuperRea)
        {
            kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
        }
        else if (soubi.syougouEpikRea)
        {
            kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nを強化しますか？";
        }
        else
        {
            kyoukakakuninnText.text = soubi.name + soubi.giftName + "Lv" + soubi.kyoukaLvName + "\nを強化しますか？";
        }

        NouryokutiUpdata();
        kyoukaHiyou(soubi.kyoukaLv,reado);
        KyoukazenngoNouryokutiGet();
        kousekiDataBaseManager.kyoukakaisuu++;
    }
    public void NouryokutiUpdata()
    {
        if (kinnkyoriWepon)
        {
            soubi.kyoukagoKougekiryoku = Mathf.FloorToInt(soubi.kougekiryoku * (1 + soubi.kyoukaBairitu / 100));
        }
        else if (ennkyoriWepon)
        {
            soubi.kyoukagoMaryoku = Mathf.FloorToInt(soubi.maryoku * (1 + soubi.kyoukaBairitu / 100));
        }
        else if (yoroi)
        {
            soubi.kyoukagoBougyoryoku = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + soubi.kyoukaBairitu / 100));
        }
        else if (sonota)
        {
            if (soubi.sonotaKyoukaStatus == 1)
            {
                soubi.kyoukagoMaxHp = Mathf.FloorToInt(soubi.maxHp * (1 + soubi.kyoukaBairitu / 100));
            }

            else if (soubi.sonotaKyoukaStatus == 2)
            {
                soubi.kyoukagoMaxMp = Mathf.FloorToInt(soubi.maxMp * (1 + soubi.kyoukaBairitu / 100));
            }

            else if (soubi.sonotaKyoukaStatus == 3)
            {
                soubi.kyoukagoKougekiryoku = Mathf.FloorToInt(soubi.kougekiryoku * (1 + soubi.kyoukaBairitu / 100));
            }

            else if (soubi.sonotaKyoukaStatus == 4)
            {
                soubi.kyoukagoMaryoku = Mathf.FloorToInt(soubi.maryoku * (1 + soubi.kyoukaBairitu / 100));
            }

            else if (soubi.sonotaKyoukaStatus == 5)
            {
                soubi.kyoukagoBougyoryoku = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + soubi.kyoukaBairitu / 100));
            }
        }
    }
    private void KyoukazenngoNouryokutiGet()
    {
        if (kinnkyoriWepon)
        {
            kyoukamaeText.text = "攻撃力\n" + soubi.kyoukagoKougekiryoku;
            if (soubi.kyoukaLv < 10)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 1) / 100));
            }
            else if (soubi.kyoukaLv < 20)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 2) / 100));
            }
            else if (soubi.kyoukaLv < 30)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 3) / 100));
            }
            else if (soubi.kyoukaLv < 40)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 4) / 100));
            }
            else
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 5) / 100));
            }
            kyoukagoText.text = "攻撃力\n" + kyoukagoNouryokuti;
        }
        else if (ennkyoriWepon)
        {
            kyoukamaeText.text = "魔力\n" + soubi.kyoukagoMaryoku;
            if (soubi.kyoukaLv < 10)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 1) / 100));
            }
            else if (soubi.kyoukaLv < 20)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 2) / 100));
            }
            else if (soubi.kyoukaLv < 30)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 3) / 100));
            }
            else if (soubi.kyoukaLv < 40)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 4) / 100));
            }
            else
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 5) / 100));
            }
            kyoukagoText.text = "魔力\n" + kyoukagoNouryokuti;
        }
        else if (yoroi)
        {
            kyoukamaeText.text = "防御力\n" + soubi.kyoukagoBougyoryoku;
            if (soubi.kyoukaLv < 10)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 1) / 100));
            }
            else if (soubi.kyoukaLv < 20)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 2) / 100));
            }
            else if (soubi.kyoukaLv < 30)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 3) / 100));
            }
            else if (soubi.kyoukaLv < 40)
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 4) / 100));
            }
            else
            {
                kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 5) / 100));
            }
            kyoukagoText.text = "防御力\n" + kyoukagoNouryokuti;
        }
        else if (sonota)
        {
            if (soubi.sonotaKyoukaStatus == 1)
            {
                kyoukamaeText.text = "HP\n" + soubi.kyoukagoMaxHp;
                if (soubi.kyoukaLv < 10)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxHp * (1 + (soubi.kyoukaBairitu + 1) / 100));
                }
                else if (soubi.kyoukaLv < 20)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxHp * (1 + (soubi.kyoukaBairitu + 2) / 100));
                }
                else if (soubi.kyoukaLv < 30)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxHp * (1 + (soubi.kyoukaBairitu + 3) / 100));
                }
                else if (soubi.kyoukaLv < 40)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxHp * (1 + (soubi.kyoukaBairitu + 4) / 100));
                }
                else
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxHp * (1 + (soubi.kyoukaBairitu + 5) / 100));
                }
                kyoukagoText.text = "HP\n" + kyoukagoNouryokuti;
            }
            else if (soubi.sonotaKyoukaStatus == 2)
            {
                kyoukamaeText.text = "MP\n" + soubi.kyoukagoMaxMp;
                if (soubi.kyoukaLv < 10)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxMp * (1 + (soubi.kyoukaBairitu + 1) / 100));
                }
                else if (soubi.kyoukaLv < 20)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxMp * (1 + (soubi.kyoukaBairitu + 2) / 100));
                }
                else if (soubi.kyoukaLv < 30)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxMp * (1 + (soubi.kyoukaBairitu + 3) / 100));
                }
                else if (soubi.kyoukaLv < 40)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxMp * (1 + (soubi.kyoukaBairitu + 4) / 100));
                }
                else
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maxMp * (1 + (soubi.kyoukaBairitu + 5) / 100));
                }
                kyoukagoText.text = "MP\n" + kyoukagoNouryokuti;
            }
            else if (soubi.sonotaKyoukaStatus == 3)
            {
                kyoukamaeText.text = "攻撃力\n" + soubi.kyoukagoKougekiryoku;
                if (soubi.kyoukaLv < 10)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 1) / 100));
                }
                else if (soubi.kyoukaLv < 20)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 2) / 100));
                }
                else if (soubi.kyoukaLv < 30)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 3) / 100));
                }
                else if (soubi.kyoukaLv < 40)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 4) / 100));
                }
                else
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.kougekiryoku * (1 + (soubi.kyoukaBairitu + 5) / 100));
                }
                kyoukagoText.text = "攻撃力\n" + kyoukagoNouryokuti;
            }
            else if (soubi.sonotaKyoukaStatus == 4)
            {
                kyoukamaeText.text = "魔力\n" + soubi.kyoukagoMaryoku;
                if (soubi.kyoukaLv < 10)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 1) / 100));
                }
                else if (soubi.kyoukaLv < 20)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 2) / 100));
                }
                else if (soubi.kyoukaLv < 30)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 3) / 100));
                }
                else if (soubi.kyoukaLv < 40)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 4) / 100));
                }
                else
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.maryoku * (1 + (soubi.kyoukaBairitu + 5) / 100));
                }
                kyoukagoText.text = "魔力\n" + kyoukagoNouryokuti;
            }
            else if (soubi.sonotaKyoukaStatus == 5)
            {
                kyoukamaeText.text = "防御力\n" + soubi.kyoukagoBougyoryoku;
                if (soubi.kyoukaLv < 10)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 1) / 100));
                }
                else if (soubi.kyoukaLv < 20)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 2) / 100));
                }
                else if (soubi.kyoukaLv < 30)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 3) / 100));
                }
                else if (soubi.kyoukaLv < 40)
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 4) / 100));
                }
                else
                {
                    kyoukagoNouryokuti = Mathf.FloorToInt(soubi.bougyoryoiku * (1 + (soubi.kyoukaBairitu + 5) / 100));
                }
                kyoukagoText.text = "防御力\n" + kyoukagoNouryokuti;
            }
        }
    }
    private void Saidaikyouka()
    {
        if (soubi.kyoukaLv >= 100)
        {
            if (soubi.syougouRea)
            {
                kyoukakakuninnText.text = "<color=#3EFF4D>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nは最大強化済みです";
            }
            else if (soubi.syougouSuperRea)
            {
                kyoukakakuninnText.text = "<color=#3D92FF>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nは最大強化済みです";
            }
            else if (soubi.syougouEpikRea)
            {
                kyoukakakuninnText.text = "<color=#FF3D4A>" + soubi.syougouName + "<color=#FFFFFF>" + soubi.name + soubi.giftName +"LV"+soubi.kyoukaLvName+ "\nは最大強化済みです";
            }
            else
            {
                kyoukakakuninnText.text = soubi.name + soubi.giftName + "LV" + soubi.kyoukaLvName + "\nは最大強化済みです";
            }
            kinngakukakuninnText.gameObject.SetActive(false);
            kyoukasekiTextMeshPro.gameObject.SetActive(false);
            yesBotton.SetActive(false);
            noBotton.SetActive(false);
            taikagatarimasennPanel.SetActive(false);
            migiYazirusiText.gameObject.SetActive(false);
            kyoukagoText.gameObject.SetActive(false);
            lv100OkBotton.SetActive(true);
        }
    }
}

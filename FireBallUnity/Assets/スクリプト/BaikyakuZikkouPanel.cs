using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaikyakuZikkouPanel : MonoBehaviour
{
    private GameObject[] tyekku;
    private int tyekkuLangth;
    public int baikyakuKinngaku;
    private GameObject dataBaseManager;
    public GameObject statusPanel;
    public StatusPanelVector statusPanelVector;
    private WeponDateBaseManager weponDateBaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    private YoroiDataBaseManager yoroiDataBaseManager;
    private SonotaDataBaseManager sonotaDataBaseManager;

    public GameObject kinnkyoriWeponScrollView;
    public GameObject ennkyoriWeponScrollView;
    public GameObject yoroiScrollView;
    public GameObject sonotaScrollView;

    public KinnkyoriWeponContentController kinnkyoriWeponContentController;
    public EnnkyoriWeponContentContoroller ennkyoriWeponContentContoroller;
    public YoroiContentContoroller yoroiContentContoroller;
    public SonotaSoubiContentController sonotaSoubiContentController;

    public Text kosuukakuninn;
    public Text baikyakukinngakukakuninn;
    public BaikyakuPanelBaikyakugoKoinn baikyakuPanelBaikyakugoKoinn;
    public BaikyakuPanelSyozikoinnText baikyakuPanelSyozikoinnText;

    private PlayerStatusDataBase playerStatusDataBase;
    public GameObject soubiTyuuPanel;

    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoubityuuKakuninnPanel()
    {
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        playerStatusDataBase = dataBaseManager.GetComponent<PlayerStatusDataBase>();
        soubiTyuuPanel.SetActive(false);
        if (kinnkyoriWeponScrollView.activeSelf)
        {
            if (statusPanelVector.number == playerStatusDataBase.kinnkyoriWeponNo)
                soubiTyuuPanel.SetActive(true);
        }
        else if (ennkyoriWeponScrollView.activeSelf)
        {
            if (statusPanelVector.number == playerStatusDataBase.ennkyoriWeponNo)
                soubiTyuuPanel.SetActive(true);
        }
        else if (yoroiScrollView.activeSelf)
        {
            if (statusPanelVector.number == playerStatusDataBase.yoroiNo)
                soubiTyuuPanel.SetActive(true);
        }
        else if (sonotaScrollView.activeSelf)
        {
            if (statusPanelVector.number == playerStatusDataBase.sonota1No || statusPanelVector.number == playerStatusDataBase.sonota2No)
                soubiTyuuPanel.SetActive(true);
        }
    }
    public void IieBotonDown()
    {
        a = false;
        gameObject.SetActive(false) ;
    }
    public void HaiBottonDown()
    {
        if (a)
        {
            if (kinnkyoriWeponScrollView.activeSelf)
            {
                
                weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    weponDateBaseManager.weponDataList.weponDatas.Remove(weponDateBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number));
                    kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                }
            }
            else if (ennkyoriWeponScrollView.activeSelf)
            {
                ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    ennkyoriWeponDataBaseManager.weponDataList.weponDatas.Remove(ennkyoriWeponDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number));
                    ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                }
            }
            else if (yoroiScrollView.activeSelf)
            {
                yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    yoroiDataBaseManager.weponDataList.weponDatas.Remove(yoroiDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number));
                    yoroiContentContoroller.YoroiContentUpdata();
                }
            }
            else if (sonotaScrollView.activeSelf)
            {
                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    sonotaDataBaseManager.weponDataList.weponDatas.Remove(sonotaDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number));
                    sonotaSoubiContentController.SonotaContentUpdata();
                }
            }
        }
        else
        {
            if (statusPanelVector.kinnkyoriWepon)
            {
                if (dataBaseManager.GetComponent<PlayerStatusDataBase>().kinnkyoriWeponNo == statusPanelVector.number)
                {

                }
                else
                {
                    weponDateBaseManager.weponDataList.weponDatas.Remove(weponDateBaseManager.GetWeponData(statusPanelVector.number));
                    GameObject.FindGameObjectWithTag("SoukoKinnkyoriWeponContent").GetComponent<KinnkyoriWeponContentController>().kinnkyoriWeponContentUpdata();
                    statusPanel.SetActive(false);
                }
            }
            else if(statusPanelVector.ennkyoriWepon)
            {
                ennkyoriWeponDataBaseManager.weponDataList.weponDatas.Remove(ennkyoriWeponDataBaseManager.GetWeponData(statusPanelVector.number));
                GameObject.FindGameObjectWithTag("SoukoEnnkyoriWeponContent").GetComponent<EnnkyoriWeponContentContoroller>().EnnkyoriWeponContentUpdata();
                statusPanel.SetActive(false);
            }
            else if(statusPanelVector.yoroi)
            {
                yoroiDataBaseManager.weponDataList.weponDatas.Remove(yoroiDataBaseManager.GetWeponData(statusPanelVector.number));
                GameObject.FindGameObjectWithTag("SoukoYoroiContent").GetComponent<YoroiContentContoroller>().YoroiContentUpdata();
                statusPanel.SetActive(false);
            }
            else if(statusPanelVector.sonota)
            {
                sonotaDataBaseManager.weponDataList.weponDatas.Remove(sonotaDataBaseManager.GetWeponData(statusPanelVector.number));
                GameObject.FindGameObjectWithTag("SoukoSonotaContent").GetComponent<SonotaSoubiContentController>().SonotaContentUpdata();
                statusPanel.SetActive(false);
            }
            a = false;
        }
        dataBaseManager.GetComponent<MoneyManager>().money += baikyakuKinngaku;
        dataBaseManager.GetComponent<MoneyManager>().MoneySave();
        dataBaseManager.GetComponent<PlayerStatusDataBase>().SoubiScritableSave();
        gameObject.SetActive(false);

    }
    public void SetActiveTrue()
    {
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        baikyakuKinngaku = 0;
        if (a)
        {
            tyekku = GameObject.FindGameObjectsWithTag("Tyekku");
            tyekkuLangth = tyekku.Length;
 
            if (kinnkyoriWeponScrollView.activeSelf)
            {
                weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    baikyakuKinngaku += weponDateBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number).baikyakuKinngaku;
                }
                Debug.Log(baikyakuKinngaku);
            }
            else if (ennkyoriWeponScrollView.activeSelf)
            {
                ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    baikyakuKinngaku += ennkyoriWeponDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number).baikyakuKinngaku;
                }
                Debug.Log(baikyakuKinngaku);
            }
            else if (yoroiScrollView.activeSelf)
            {
                yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    baikyakuKinngaku += yoroiDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number).baikyakuKinngaku;
                }
                Debug.Log(baikyakuKinngaku);
            }
            else if (sonotaScrollView.activeSelf)
            {
                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    baikyakuKinngaku += sonotaDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number).baikyakuKinngaku;
                }
                Debug.Log(baikyakuKinngaku);
            }
            kosuukakuninn.text = tyekkuLangth + "個のアイテムを選択中\n売却しますか？";
            baikyakukinngakukakuninn.text = "売却金額　" + baikyakuKinngaku.ToString("N0") + "　コイン";
        }
        else
        {
            if (statusPanelVector.kinnkyoriWepon)
            {
                weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                baikyakuKinngaku += weponDateBaseManager.GetWeponData(statusPanelVector.number).baikyakuKinngaku;
            }
            else if (statusPanelVector.ennkyoriWepon)
            {
                ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                baikyakuKinngaku += ennkyoriWeponDataBaseManager.GetWeponData(statusPanelVector.number).baikyakuKinngaku;
            }
            else if (statusPanelVector.yoroi)
            {
                yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                baikyakuKinngaku += yoroiDataBaseManager.GetWeponData(statusPanelVector.number).baikyakuKinngaku;
            }
            else if (statusPanelVector.sonota)
            {
                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                baikyakuKinngaku += sonotaDataBaseManager.GetWeponData(statusPanelVector.number).baikyakuKinngaku;
            }
            kosuukakuninn.text = "1個のアイテムを選択中\n売却しますか？";
            baikyakukinngakukakuninn.text = "売却金額　" + baikyakuKinngaku.ToString("N0") + "　コイン";
        }
        baikyakuPanelSyozikoinnText.BaikyakumaeSyoziCoinText();
        baikyakuPanelBaikyakugoKoinn.BaikyakuZenngoKinngakuText();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SortBotton : MonoBehaviour
{
    public bool hp;
    public bool mp;
    public bool fbCost;
    public bool kougekiryoku;
    public bool maryoku;
    public bool kinnkyoriKaisinnritu;
    public bool ennkyoriKaisinnritu;
    public bool bougyoryoku;
    public bool kaisinnTaisei;
    public bool meityuuritu;
    public bool kaihiritu;
    public bool syougekiryoku;
    public bool kougekiHinndo;
    public bool kougekiHanni;
    public bool nyuusyuzyunn;

    private GameObject dataBaseManager;
    private WeponDateBaseManager weponDateBaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    private YoroiDataBaseManager yoroiDataBaseManager;
    private SonotaDataBaseManager sonotaDataBaseManager;

    public GameObject contentKinnkyoriWepon;
    public GameObject contentEnnkyoriWepon;
    public GameObject contentYoroi;
    public GameObject contentSonota1;
    public GameObject contentSonota2;

    private KinnkyoriWeponContentController kinnkyoriWeponContentController;
    private EnnkyoriWeponContentContoroller ennkyoriWeponContentContoroller;
    private YoroiContentContoroller yoroiContentContoroller;
    private SonotaSoubiContentController sonotaSoubiContentController;

    public GameObject scrollViewKinnkyoriWepon;
    public GameObject scrollViewEnnkyoriWepon;
    public GameObject scrollViewYoroi;
    public GameObject scrollViewSonota1;
    public GameObject scrollViewSonota2;

    public GameObject sortPanel;
    void Start()
    {
        dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SortBottnDawn()
    {
        if (scrollViewKinnkyoriWepon.activeSelf)
        {
            weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
            kinnkyoriWeponContentController = contentKinnkyoriWepon.GetComponent<KinnkyoriWeponContentController>();
            if (hp)
            {
                weponDateBaseManager.weponDataList.Hpzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (mp)
            {
                weponDateBaseManager.weponDataList.Mpzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (fbCost)
            {
                weponDateBaseManager.weponDataList.FbCostzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kougekiryoku)
            {
                Debug.Log("a");
                weponDateBaseManager.weponDataList.Kougekiryokuzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (maryoku)
            {
                weponDateBaseManager.weponDataList.Maryokuzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kinnkyoriKaisinnritu)
            {
                weponDateBaseManager.weponDataList.Kinnkyorikaisinnrituzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (ennkyoriKaisinnritu)
            {
                weponDateBaseManager.weponDataList.EnnkyoriKaisinnrituzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (bougyoryoku)
            {
                weponDateBaseManager.weponDataList.Bougyoryokuzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kaisinnTaisei)
            {
                weponDateBaseManager.weponDataList.Kaisinntaiseizyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (meityuuritu)
            {
                weponDateBaseManager.weponDataList.Meityuurituzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kaihiritu)
            {
                weponDateBaseManager.weponDataList.Kaihirituzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (syougekiryoku)
            {
                weponDateBaseManager.weponDataList.Syougekiryokuzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kougekiHinndo)
            {
                weponDateBaseManager.weponDataList.Kougekihinndozyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kougekiHanni)
            {
                weponDateBaseManager.weponDataList.Kougekihannizyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (nyuusyuzyunn)
            {
                weponDateBaseManager.weponDataList.Nyuusyuzyunn();
                kinnkyoriWeponContentController.kinnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
        }
        else if (scrollViewEnnkyoriWepon.activeSelf)
        {
            ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
            ennkyoriWeponContentContoroller = contentEnnkyoriWepon.GetComponent<EnnkyoriWeponContentContoroller>();
            if (hp)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Hpzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);

            }
            else if (mp)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Mpzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (fbCost)
            {
                ennkyoriWeponDataBaseManager.weponDataList.FbCostzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kougekiryoku)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Kougekiryokuzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (maryoku)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Maryokuzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kinnkyoriKaisinnritu)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Kinnkyorikaisinnrituzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (ennkyoriKaisinnritu)
            {
                ennkyoriWeponDataBaseManager.weponDataList.EnnkyoriKaisinnrituzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (bougyoryoku)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Bougyoryokuzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kaisinnTaisei)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Kaisinntaiseizyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (meityuuritu)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Meityuurituzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kaihiritu)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Kaihirituzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (syougekiryoku)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Syougekiryokuzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kougekiHinndo)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Kougekihinndozyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (kougekiHanni)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Kougekihannizyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
            else if (nyuusyuzyunn)
            {
                ennkyoriWeponDataBaseManager.weponDataList.Nyuusyuzyunn();
                ennkyoriWeponContentContoroller.EnnkyoriWeponContentUpdata();
                sortPanel.SetActive(false);
            }
        }
        else if (scrollViewYoroi.activeSelf)
        {
            yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
            yoroiContentContoroller = contentYoroi.GetComponent<YoroiContentContoroller>();
            if (hp)
            {
                yoroiDataBaseManager.weponDataList.Hpzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (mp)
            {
                yoroiDataBaseManager.weponDataList.Mpzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (fbCost)
            {
                yoroiDataBaseManager.weponDataList.FbCostzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kougekiryoku)
            {
                yoroiDataBaseManager.weponDataList.Kougekiryokuzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (maryoku)
            {
                yoroiDataBaseManager.weponDataList.Maryokuzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kinnkyoriKaisinnritu)
            {
                yoroiDataBaseManager.weponDataList.Kinnkyorikaisinnrituzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (ennkyoriKaisinnritu)
            {
                yoroiDataBaseManager.weponDataList.EnnkyoriKaisinnrituzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (bougyoryoku)
            {
                yoroiDataBaseManager.weponDataList.Bougyoryokuzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kaisinnTaisei)
            {
                yoroiDataBaseManager.weponDataList.Kaisinntaiseizyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (meityuuritu)
            {
                yoroiDataBaseManager.weponDataList.Meityuurituzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kaihiritu)
            {
                yoroiDataBaseManager.weponDataList.Kaihirituzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (syougekiryoku)
            {
                yoroiDataBaseManager.weponDataList.Syougekiryokuzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kougekiHinndo)
            {
                yoroiDataBaseManager.weponDataList.Kougekihinndozyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kougekiHanni)
            {
                yoroiDataBaseManager.weponDataList.Kougekihannizyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
            if (nyuusyuzyunn)
            {
                yoroiDataBaseManager.weponDataList.Nyuusyuzyunn();
                yoroiContentContoroller.YoroiContentUpdata();
                sortPanel.SetActive(false);
            }
        }
        if (scrollViewSonota1.activeSelf)
        {
            sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
            sonotaSoubiContentController = contentSonota1.GetComponent<SonotaSoubiContentController>();
            if (hp)
            {
                sonotaDataBaseManager.weponDataList.Hpzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (mp)
            {
                sonotaDataBaseManager.weponDataList.Mpzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (fbCost)
            {
                sonotaDataBaseManager.weponDataList.FbCostzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kougekiryoku)
            {
                sonotaDataBaseManager.weponDataList.Kougekiryokuzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (maryoku)
            {
                sonotaDataBaseManager.weponDataList.Maryokuzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kinnkyoriKaisinnritu)
            {
                sonotaDataBaseManager.weponDataList.Kinnkyorikaisinnrituzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (ennkyoriKaisinnritu)
            {
                sonotaDataBaseManager.weponDataList.EnnkyoriKaisinnrituzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (bougyoryoku)
            {
                sonotaDataBaseManager.weponDataList.Bougyoryokuzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kaisinnTaisei)
            {
                sonotaDataBaseManager.weponDataList.Kaisinntaiseizyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (meityuuritu)
            {
                sonotaDataBaseManager.weponDataList.Meityuurituzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kaihiritu)
            {
                sonotaDataBaseManager.weponDataList.Kaihirituzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (syougekiryoku)
            {
                sonotaDataBaseManager.weponDataList.Syougekiryokuzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kougekiHinndo)
            {
                sonotaDataBaseManager.weponDataList.Kougekihinndozyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (kougekiHanni)
            {
                sonotaDataBaseManager.weponDataList.Kougekihannizyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
            if (nyuusyuzyunn)
            {
                sonotaDataBaseManager.weponDataList.Nyuusyuzyunn();
                sonotaSoubiContentController.SonotaContentUpdata();
                sortPanel.SetActive(false);
            }
        }
        if(SceneManager.GetActiveScene().name=="StatusMenu" )
        {
            if (scrollViewSonota2.activeSelf)
            {
                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                sonotaSoubiContentController = contentSonota2.GetComponent<SonotaSoubiContentController>();
                if (hp)
                {
                    sonotaDataBaseManager.weponDataList.Hpzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (mp)
                {
                    sonotaDataBaseManager.weponDataList.Mpzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (fbCost)
                {
                    sonotaDataBaseManager.weponDataList.FbCostzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (kougekiryoku)
                {
                    sonotaDataBaseManager.weponDataList.Kougekiryokuzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (maryoku)
                {
                    sonotaDataBaseManager.weponDataList.Maryokuzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (kinnkyoriKaisinnritu)
                {
                    sonotaDataBaseManager.weponDataList.Kinnkyorikaisinnrituzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (ennkyoriKaisinnritu)
                {
                    sonotaDataBaseManager.weponDataList.EnnkyoriKaisinnrituzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (bougyoryoku)
                {
                    sonotaDataBaseManager.weponDataList.Bougyoryokuzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (kaisinnTaisei)
                {
                    sonotaDataBaseManager.weponDataList.Kaisinntaiseizyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (meityuuritu)
                {
                    sonotaDataBaseManager.weponDataList.Meityuurituzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (kaihiritu)
                {
                    sonotaDataBaseManager.weponDataList.Kaihirituzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (syougekiryoku)
                {
                    sonotaDataBaseManager.weponDataList.Syougekiryokuzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (kougekiHinndo)
                {
                    sonotaDataBaseManager.weponDataList.Kougekihinndozyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (kougekiHanni)
                {
                    sonotaDataBaseManager.weponDataList.Kougekihannizyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
                if (nyuusyuzyunn)
                {
                    sonotaDataBaseManager.weponDataList.Nyuusyuzyunn();
                    sonotaSoubiContentController.SonotaContentUpdata();
                    sortPanel.SetActive(false);
                }
            }
        }

    }
}

       
    


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
    private StatusPanelVector statusPanel;
    private WeponDateBaseManager weponDateBaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    private YoroiDataBaseManager yoroiDataBaseManager;
    private SonotaDataBaseManager sonotaDataBaseManager;

    public GameObject kosuukakuninn;
    public GameObject baikyakukinngakukakuninn;

    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        dataBaseManager = GameObject.Find("DataBaseManager");
        tyekku = GameObject.FindGameObjectsWithTag("Tyekku");
        tyekkuLangth = tyekku.Length;
        transform.localPosition = new Vector2(0, 486.9f);
        baikyakuKinngaku = 0;
        if (a)
        {
            if (GameObject.Find("Scroll View �ߋ������� �q��"))
            {
                weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    baikyakuKinngaku += weponDateBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number).baikyakuKinngaku;
                }
                Debug.Log(baikyakuKinngaku);
            }
            if (GameObject.Find("Scroll View ���������� �q��"))
            {
                ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    baikyakuKinngaku += ennkyoriWeponDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number).baikyakuKinngaku;
                }
                Debug.Log(baikyakuKinngaku);
            }
            if (GameObject.Find("Scroll View �Z���� �q��"))
            {
                yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    baikyakuKinngaku += yoroiDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number).baikyakuKinngaku;
                }
                Debug.Log(baikyakuKinngaku);
            }
            if (GameObject.Find("Scroll View ���̑����� �q��"))
            {
                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    baikyakuKinngaku += sonotaDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number).baikyakuKinngaku;
                }
                Debug.Log(baikyakuKinngaku);
            }
            kosuukakuninn.GetComponent<Text>().text = tyekkuLangth + "�̃A�C�e����I��\n���p���܂����H";
            baikyakukinngakukakuninn.GetComponent<Text>().text = "���p���z�@" + baikyakuKinngaku.ToString("N0") + "�@�R�C��";
        }
        else
        {
            statusPanel = GameObject.Find("Scroll View �����X�e�[�^�X �X�e�[�^�X2(Clone)").GetComponent<StatusPanelVector>();
            if (statusPanel.kinnkyoriWepon)
            {
                weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                baikyakuKinngaku += weponDateBaseManager.GetWeponData(statusPanel.number).baikyakuKinngaku;
            }
            else if(statusPanel.ennkyoriWepon)
            {
                ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                baikyakuKinngaku += ennkyoriWeponDataBaseManager.GetWeponData(statusPanel.number).baikyakuKinngaku;
            }
            else if(statusPanel.yoroi)
            {
                yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                baikyakuKinngaku += yoroiDataBaseManager.GetWeponData(statusPanel.number).baikyakuKinngaku;
            }
            else if(statusPanel.sonota)
            {
                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                baikyakuKinngaku += sonotaDataBaseManager.GetWeponData(statusPanel.number).baikyakuKinngaku;
            }
            kosuukakuninn.GetComponent<Text>().text = tyekkuLangth + "1�̃A�C�e����I��\n���p���܂����H";
            baikyakukinngakukakuninn.GetComponent<Text>().text = "���p���z�@" + baikyakuKinngaku.ToString("N0") + "�@�R�C��";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IieBotonDown()
    {
        a = false;
        Destroy(gameObject);
    }
    public void HaiBottonDown()
    {
        if (a)
        {
            if (GameObject.Find("Scroll View �ߋ������� �q��"))
            {
                weponDateBaseManager = dataBaseManager.GetComponent<WeponDateBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    weponDateBaseManager.weponDataList.weponDatas.Remove(weponDateBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number));
                    GameObject.FindGameObjectWithTag("SoukoKinnkyoriWeponContent").GetComponent<KinnkyoriWeponContentController>().kinnkyoriWeponContentUpdata();
                }
            }
            if (GameObject.Find("Scroll View ���������� �q��"))
            {
                ennkyoriWeponDataBaseManager = dataBaseManager.GetComponent<EnnkyoriWeponDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    ennkyoriWeponDataBaseManager.weponDataList.weponDatas.Remove(ennkyoriWeponDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number));
                    GameObject.FindGameObjectWithTag("SoukoEnnkyoriWeponContent").GetComponent<EnnkyoriWeponContentContoroller>().EnnkyoriWeponContentUpdata();
                }
            }
            if (GameObject.Find("Scroll View �Z���� �q��"))
            {
                yoroiDataBaseManager = dataBaseManager.GetComponent<YoroiDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    yoroiDataBaseManager.weponDataList.weponDatas.Remove(yoroiDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number));
                    GameObject.FindGameObjectWithTag("SoukoYoroiContent").GetComponent<YoroiContentContoroller>().YoroiContentUpdata();
                }
            }
            if (GameObject.Find("Scroll View ���̑����� �q��"))
            {
                sonotaDataBaseManager = dataBaseManager.GetComponent<SonotaDataBaseManager>();
                for (int a = 0; a < tyekkuLangth; a++)
                {
                    sonotaDataBaseManager.weponDataList.weponDatas.Remove(sonotaDataBaseManager.GetWeponData(tyekku[a].GetComponent<Tyekku>().number));
                    GameObject.FindGameObjectWithTag("SoukoSonotaContent").GetComponent<SonotaSoubiContentController>().SonotaContentUpdata();
                }
            }
        }
        else
        {
            if (statusPanel.kinnkyoriWepon)
            {
                weponDateBaseManager.weponDataList.weponDatas.Remove(weponDateBaseManager.GetWeponData(statusPanel.number));
                GameObject.FindGameObjectWithTag("SoukoKinnkyoriWeponContent").GetComponent<KinnkyoriWeponContentController>().kinnkyoriWeponContentUpdata();
                Destroy(GameObject.Find("Scroll View �����X�e�[�^�X �X�e�[�^�X2(Clone)"));
            }
            else if(statusPanel.ennkyoriWepon)
            {
                ennkyoriWeponDataBaseManager.weponDataList.weponDatas.Remove(ennkyoriWeponDataBaseManager.GetWeponData(statusPanel.number));
                GameObject.FindGameObjectWithTag("SoukoEnnkyoriWeponContent").GetComponent<EnnkyoriWeponContentContoroller>().EnnkyoriWeponContentUpdata();
                Destroy(GameObject.Find("Scroll View �����X�e�[�^�X �X�e�[�^�X2(Clone)"));
            }
            else if(statusPanel.yoroi)
            {
                yoroiDataBaseManager.weponDataList.weponDatas.Remove(yoroiDataBaseManager.GetWeponData(statusPanel.number));
                GameObject.FindGameObjectWithTag("SoukoYoroiContent").GetComponent<YoroiContentContoroller>().YoroiContentUpdata();
                Destroy(GameObject.Find("Scroll View �����X�e�[�^�X �X�e�[�^�X2(Clone)"));
            }
            else if(statusPanel.sonota)
            {
                sonotaDataBaseManager.weponDataList.weponDatas.Remove(sonotaDataBaseManager.GetWeponData(statusPanel.number));
                GameObject.FindGameObjectWithTag("SoukoSonotaContent").GetComponent<SonotaSoubiContentController>().SonotaContentUpdata();
                Destroy(GameObject.Find("Scroll View �����X�e�[�^�X �X�e�[�^�X2(Clone)"));
            }
            a = false;
        }
        dataBaseManager.GetComponent<MoneyManager>().money += baikyakuKinngaku;
        Destroy(gameObject);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBotton : MonoBehaviour
{
    public int number;
    private GameObject dataBasaManager;

    private WeponDateBaseManager weponDateBaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    private YoroiDataBaseManager yoroiDataBaseManager;
    private SonotaDataBaseManager sonotaDataBaseManager;
    // Start is called before the first frame update
    void Start()
    {
        dataBasaManager = GameObject.Find("DataBaseManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void KeyLock()
    {
        if (GameObject.Find("Scroll View �ߋ������� �X�e�[�^�X") || GameObject.Find("Scroll View �ߋ������� �q��"))
        {
            weponDateBaseManager = dataBasaManager.GetComponent<WeponDateBaseManager>();
            if (weponDateBaseManager.GetWeponData(number).keyLock == false)
            {
                weponDateBaseManager.GetWeponData(number).keyLock = true;
            }
            else
            {
                weponDateBaseManager.GetWeponData(number).keyLock = false;
            }
        }
        if (GameObject.Find("Scroll View ���������� �X�e�[�^�X")||GameObject.Find("Scroll View ���������� �q��"))
        {
            ennkyoriWeponDataBaseManager = dataBasaManager.GetComponent<EnnkyoriWeponDataBaseManager>();
            if (ennkyoriWeponDataBaseManager.GetWeponData(number).keyLock == false)
            {
                ennkyoriWeponDataBaseManager.GetWeponData(number).keyLock = true;
            }
            else
            {
                ennkyoriWeponDataBaseManager.GetWeponData(number).keyLock = false;
            }
        }
        if (GameObject.Find("Scroll View �Z���� �X�e�[�^�X") || GameObject.Find("Scroll View �Z���� �q��"))
        {
            yoroiDataBaseManager = dataBasaManager.GetComponent<YoroiDataBaseManager>();
            if (yoroiDataBaseManager.GetWeponData(number).keyLock == false)
            {
                yoroiDataBaseManager.GetWeponData(number).keyLock = true;
            }
            else
            {
               yoroiDataBaseManager.GetWeponData(number).keyLock = false;
            }
        }
        if (GameObject.Find("Scroll View ���̑����� �X�e�[�^�X1")||GameObject.Find("Scroll View ���̑����� �q��"))
        {
            sonotaDataBaseManager = dataBasaManager.GetComponent<SonotaDataBaseManager>();
            if (sonotaDataBaseManager.GetWeponData(number).keyLock == false)
            {
                sonotaDataBaseManager.GetWeponData(number).keyLock = true;
            }
            else
            {
                sonotaDataBaseManager.GetWeponData(number).keyLock = false;
            }
        }
        if (GameObject.Find("Scroll View ���̑����� �X�e�[�^�X2"))
        {
            sonotaDataBaseManager = dataBasaManager.GetComponent<SonotaDataBaseManager>();
            if (sonotaDataBaseManager.GetWeponData(number).keyLock == false)
            {
                sonotaDataBaseManager.GetWeponData(number).keyLock = true;
            }
            else
            {
                sonotaDataBaseManager.GetWeponData(number).keyLock = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoubiBotton : MonoBehaviour
{
    public int number;
    private GameObject dataBasaManager;

    private PlayerStatusDataBase playerStatusDataBase;
    private WeponDateBaseManager weponDateBaseManager;
    private EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
    private YoroiDataBaseManager yoroiDataBaseManager;
    private SonotaDataBaseManager sonotaDataBaseManager;

    private SoubityuuIcon contentSelectSoubiStatus;
    // Start is called before the first frame update
    void Start()
    {
        dataBasaManager = GameObject.Find("DataBaseManager");
        playerStatusDataBase = dataBasaManager.GetComponent<PlayerStatusDataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoubiHennkou()
    {
        if(GameObject.Find("Scroll View �ߋ������� �X�e�[�^�X"))
        {
            playerStatusDataBase.kinnkyoriWeponNo = number;
            playerStatusDataBase.StatusUpdate();
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi�@�X�e�[�^�X").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
        }
        if (GameObject.Find("Scroll View ���������� �X�e�[�^�X"))
        {
            playerStatusDataBase.ennkyoriWeponNo = number;
            playerStatusDataBase.StatusUpdate();
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi�@�X�e�[�^�X").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
        }
        if (GameObject.Find("Scroll View �Z���� �X�e�[�^�X"))
        {
            playerStatusDataBase.yoroiNo = number;
            playerStatusDataBase.StatusUpdate();
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi�@�X�e�[�^�X").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
        }
        if (GameObject.Find("Scroll View ���̑����� �X�e�[�^�X1"))
        {
            playerStatusDataBase.sonota1No = number;
            playerStatusDataBase.StatusUpdate();
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi�@�X�e�[�^�X").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
        }
        if (GameObject.Find("Scroll View ���̑����� �X�e�[�^�X2"))
        {
            playerStatusDataBase.sonota2No = number;
            playerStatusDataBase.StatusUpdate();
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi�@�X�e�[�^�X").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
        }
    }
}

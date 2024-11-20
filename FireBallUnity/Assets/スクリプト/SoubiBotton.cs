using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoubiBotton : MonoBehaviour
{
    public int number;
    private GameObject dataBasaManager;

    private PlayerStatusDataBase playerStatusDataBase;
    public StatusPanelVector statusPanelVector;

    public KinnkyoriWeponSoubiIcon kinnkyoriWeponSoubiIcon;
    public EnnkyoriWeponSoubiIcon ennkyoriWeponSoubiIcon;
    public YoroiSoubiIcon yoroiSoubiIcon;
    public SonotaSoubiIcon sonotaSoubiIcon;

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
        if(GameObject.Find("Scroll View 近距離武器 ステータス"))
        {
            playerStatusDataBase.kinnkyoriWeponNo = number;
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi　ステータス").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
            contentSelectSoubiStatus.StatusTextUpdata();//
            kinnkyoriWeponSoubiIcon.soubiTyuu();
        }
        else if (GameObject.Find("Scroll View 遠距離武器 ステータス"))
        {
            playerStatusDataBase.ennkyoriWeponNo = number;
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi　ステータス").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
            contentSelectSoubiStatus.StatusTextUpdata();
            ennkyoriWeponSoubiIcon.soubiTyuu();
        }
        else if (GameObject.Find("Scroll View 鎧装備 ステータス"))
        {
            playerStatusDataBase.yoroiNo = number;
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi　ステータス").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
            contentSelectSoubiStatus.StatusTextUpdata();
            yoroiSoubiIcon.soubiTyuu();
        }
        else if (GameObject.Find("Scroll View その他装備 ステータス1"))
        {
            playerStatusDataBase.sonota1No = number;
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi　ステータス").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
            contentSelectSoubiStatus.StatusTextUpdata();
            sonotaSoubiIcon.SoubiTyuu1();
        }
       else if (GameObject.Find("Scroll View その他装備 ステータス2"))
        {
            playerStatusDataBase.sonota2No = number;
            contentSelectSoubiStatus = GameObject.Find("Content Select Soubi　ステータス").GetComponent<SoubityuuIcon>();
            contentSelectSoubiStatus.SoubiHennkou();
            contentSelectSoubiStatus.StatusTextUpdata();
            sonotaSoubiIcon.SoubiTyuu2();
        }
    }
}

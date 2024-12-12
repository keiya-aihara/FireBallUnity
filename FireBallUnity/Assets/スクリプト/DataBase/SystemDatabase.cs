using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class SystemDatabase : MonoBehaviour
{
    public bool zidouSyuukai;
    public string zennkainoStageName;


    private ZidouBaikyakuSyuunou zidouBaikyakuSyuunou;

    public bool nomalSinaiBool;
    public bool nomalSubeteBool;
    public bool nomalMuinnBool;

    public bool reaSinaiBool;
    public bool reaSubeteBool;
    public bool reaMuinnBool;

    public bool superReaSinaiBool;
    public bool superReaSubeteBool;
    public bool superReaMuinnBool;


    public GameObject nomalSinaiTyekku;
    public GameObject nomalSubeteTyekku;
    public GameObject nomalMuinnTyekku;

    public GameObject reaSinaiTyekku;
    public GameObject reaSubeteTyekku;
    public GameObject reaMuinnTyekku;

    public GameObject superReaSinaiTyekku;
    public GameObject superReaSubeteTyekku;
    public GameObject superReaMuinnTyekku;


    public Image nomalSinai;
    public Image nomalSubete;
    public Image nomalMuinn;

    public Image reaSinai;
    public Image reaSubete;
    public Image reaMuinn;

    public Image superReaSinai;
    public Image superReaSubete;
    public Image superReaMuinn;

    public SystemSaveData systemSaveData;
    public void StartSub()
    {
        zidouBaikyakuSyuunou = GameObject.Find("自動売却GameObject収納").GetComponent<ZidouBaikyakuSyuunou>();

        nomalSinai = zidouBaikyakuSyuunou.nomalSinai;
        nomalSubete = zidouBaikyakuSyuunou.nomalSubete;
        nomalMuinn = zidouBaikyakuSyuunou.nomalMuinn;

        reaSinai = zidouBaikyakuSyuunou.reaSinai;
        reaSubete = zidouBaikyakuSyuunou.reaSubete;
        reaMuinn = zidouBaikyakuSyuunou.reaMuinn;

        superReaSinai = zidouBaikyakuSyuunou.superReaSinai;
        superReaSubete = zidouBaikyakuSyuunou.superReaSubete;
        superReaMuinn = zidouBaikyakuSyuunou.superReaMuinn;

        nomalSinaiTyekku = zidouBaikyakuSyuunou.nomalSinaiTyekku;
        nomalSubeteTyekku = zidouBaikyakuSyuunou.nomalSubeteTyekku;
        nomalMuinnTyekku = zidouBaikyakuSyuunou.nomalMuinnTyekku;

        reaSinaiTyekku = zidouBaikyakuSyuunou.reaSinaiTyekku;
        reaSubeteTyekku = zidouBaikyakuSyuunou.reaSubeteTyekku;
        reaMuinnTyekku = zidouBaikyakuSyuunou.reaMuinnTyekku;

        superReaSinaiTyekku = zidouBaikyakuSyuunou.superReaSinaiTyekku;
        superReaSubeteTyekku = zidouBaikyakuSyuunou.superReaSubeteTyekku;
        superReaMuinnTyekku = zidouBaikyakuSyuunou.superReaMuinnTyekku;
        SystemLoad();
    }
    public void ZidouBaikyakuPanelOpen()
    {
        if (nomalSinaiBool)
        {
            nomalSinai.color=new Color(255,0,0,255);
            nomalSubete.color = new Color(255, 255, 255, 255);
            nomalMuinn.color = new Color(255, 255, 255, 255);

            nomalSinaiTyekku.SetActive(true);
            nomalSubeteTyekku.SetActive(false);
            nomalMuinnTyekku.SetActive(false);
        }
        else if(nomalSubeteBool)
        {
            nomalSinai.color = new Color(255, 255, 255, 255);
            nomalSubete.color = new Color(255, 0, 0, 255);
            nomalMuinn.color = new Color(255, 255, 255, 255);

            nomalSinaiTyekku.SetActive(false);
            nomalSubeteTyekku.SetActive(true);
            nomalMuinnTyekku.SetActive(false);
        }
        else if (nomalMuinnBool)
        {
            nomalSinai.color = new Color(255, 255, 255, 255);
            nomalSubete.color = new Color(255, 255, 255, 255);
            nomalMuinn.color = new Color(255, 0, 0, 255);

            nomalSinaiTyekku.SetActive(false);
            nomalSubeteTyekku.SetActive(false);
            nomalMuinnTyekku.SetActive(true);
        }

        if (reaSinaiBool)
        {
            reaSinai.color = new Color(255, 0, 0, 255);
            reaSubete.color = new Color(141, 255, 141, 255);
            reaMuinn.color = new Color(141, 255, 141, 255);

            reaSinaiTyekku.SetActive(true);
            reaSubeteTyekku.SetActive(false);
            reaMuinnTyekku.SetActive(false);
        }
        else if (reaSubeteBool)
        {
            reaSinai.color = new Color(141, 255, 141, 255);
            reaSubete.color = new Color(255, 0, 0, 255);
            reaMuinn.color = new Color(141, 255, 141, 255);

            reaSinaiTyekku.SetActive(false);
            reaSubeteTyekku.SetActive(true);
            reaMuinnTyekku.SetActive(false);
        }
        else if (reaMuinnBool)
        {
            reaSinai.color = new Color(141, 255, 141, 255);
            reaSubete.color = new Color(141, 255, 141, 255);
            reaMuinn.color = new Color(255, 0, 0, 255);

            reaSinaiTyekku.SetActive(false);
            reaSubeteTyekku.SetActive(false);
            reaMuinnTyekku.SetActive(true);
        }

        if (superReaSinaiBool)
        {
            superReaSinai.color = new Color(255, 0, 0, 255);
            superReaSubete.color = new Color(114, 147, 255, 255);
            superReaMuinn.color = new Color(114, 147, 255, 255);

            superReaSinaiTyekku.SetActive(true);
            superReaSubeteTyekku.SetActive(false);
            superReaMuinnTyekku.SetActive(false);
        }
        else if (superReaSubeteBool)
        {
            superReaSinai.color = new Color(114, 147, 255, 255);
            superReaSubete.color = new Color(255, 0, 0, 255);
            superReaMuinn.color = new Color(114, 147, 255, 255);

            superReaSinaiTyekku.SetActive(false);
            superReaSubeteTyekku.SetActive(true);
            superReaMuinnTyekku.SetActive(false);
        }
        else if (superReaMuinnBool)
        {
            superReaSinai.color = new Color(114, 147, 255, 255);
            superReaSubete.color = new Color(114, 147, 255, 255);
            superReaMuinn.color = new Color(255, 0, 0, 255);

            superReaSinaiTyekku.SetActive(false);
            superReaSubeteTyekku.SetActive(false);
            superReaMuinnTyekku.SetActive(true);
        }

    
}
    public void NomalSinaiTrue()
    {
        nomalSinaiBool = true;
        nomalSubeteBool = false;
        nomalMuinnBool = false;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void NomalSubeteTrue()
    {
        nomalSinaiBool = false;
        nomalSubeteBool = true;
        nomalMuinnBool = false;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void NomalMuinnTrue()
    {
        nomalSinaiBool = false;
        nomalSubeteBool = false;
        nomalMuinnBool = true;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void ReaSinaiTrue()
    {
        reaSinaiBool = true;
        reaSubeteBool = false;
        reaMuinnBool = false;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void ReaSubeteTrue()
    {
        reaSinaiBool = false;
        reaSubeteBool = true;
        reaMuinnBool = false;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void ReaMuinnTrue()
    {
        reaSinaiBool = false;
        reaSubeteBool = false;
        reaMuinnBool = true;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void SuperReaSinaiTrue()
    {
        superReaSinaiBool = true;
        superReaSubeteBool = false;
        superReaMuinnBool = false;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void SuperReaSubeteTrue()
    {
        superReaSinaiBool = false;
        superReaSubeteBool = true;
        superReaMuinnBool = false;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void SuperReaMuinnTrue()
    {
        superReaSinaiBool = false;
        superReaSubeteBool = false;
        superReaMuinnBool = true;
        SystemSave();
        ZidouBaikyakuPanelOpen();
    }
    public void SystemSave()//システムセーブ
    {
        systemSaveData = new SystemSaveData();

        systemSaveData.nomalSinaiBool = nomalSinaiBool;
        systemSaveData.nomalSubeteBool = nomalSubeteBool;
        systemSaveData.nomalMuinnBool = nomalMuinnBool;
        systemSaveData.reaSinaiBool = reaSinaiBool;
        systemSaveData.reaSubeteBool = reaSubeteBool;
        systemSaveData.reaMuinnBool = reaMuinnBool;
        systemSaveData.superReaSinaiBool = superReaSinaiBool;
        systemSaveData.superReaSubeteBool = superReaSubeteBool;
        systemSaveData.superReaMuinnBool = superReaMuinnBool;
        Debug.Log("システムをセーブした。");

        string json = JsonUtility.ToJson(systemSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.System.json", json);
    }
    public void StageNameSave()
    {
        systemSaveData = new SystemSaveData();

        systemSaveData.zennkainoStageName = zennkainoStageName;

        string json = JsonUtility.ToJson(systemSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.StageName.json", json);
        //Debug.Log("ステージ名をセーブした。");
    }
    public void SystemLoad()//システムロード
    {
        string path = Application.persistentDataPath + "/savefile.System.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            SystemSaveData loadData = JsonUtility.FromJson<SystemSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            nomalSinaiBool = loadData.nomalSinaiBool;
            nomalSubeteBool = loadData.nomalSubeteBool;
            nomalMuinnBool = loadData.nomalMuinnBool;
            reaSinaiBool = loadData.reaSinaiBool;
            reaSubeteBool = loadData.reaSubeteBool;
            reaMuinnBool = loadData.reaMuinnBool;
            superReaSinaiBool = loadData.superReaSinaiBool;
            superReaSubeteBool = loadData.superReaSubeteBool;
            superReaMuinnBool = loadData.superReaMuinnBool;
        }
    }
    public void StageNameLoad()
    {
        string path = Application.persistentDataPath + "/savefile.StageName.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log("ステージ名をロードした。");
            SystemSaveData loadData = JsonUtility.FromJson<SystemSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            zennkainoStageName = loadData.zennkainoStageName;
        }
    }
    public void BaikyakuStageNameSyokika()
    {
        nomalSinaiBool = true;
        reaSinaiBool = true;
        superReaSinaiBool = true;
        zennkainoStageName = "";
        SystemSave();
        StageNameSave();
    }
}

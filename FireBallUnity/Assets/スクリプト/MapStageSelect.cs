using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapStageSelect : MonoBehaviour
{
    public StageZissekiDatabase stageZissekiDatabase;
    public GameObject stageSyousaiPanel;
    public Text titleStageName;
    public Text stageName1;
    public Text stageName2;
    public Text stageName3;
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;

    public GameObject sirennnoDoukutu;
    public GameObject umibenoHaikyo;
    public GameObject bladFangHeigenn;
    public GameObject bladHeibun;
    public GameObject warumuKouya;
    public GameObject mamarion;
    public GameObject nazonoKikaiSisetu;
    public GameObject gooremuSeizousyo;
    public GameObject meikounoIe;
    public GameObject kuguturo;
    public GameObject kotounoNusi;
    public GameObject makaikai;
    public GameObject hitogatamazyuuNoSyuuraku;
    public GameObject maborosinoDoukutu;
    private void Start()
    {
        stageZissekiDatabase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<StageZissekiDatabase>();
        if (stageZissekiDatabase.stageNo[2]>=1)
        {
            sirennnoDoukutu.SetActive(true);
            if(stageZissekiDatabase.stageNo[5]>=1)
            {
                umibenoHaikyo.SetActive(true);
            }
            if(stageZissekiDatabase.stageNo[8]>=1)
            {
                bladFangHeigenn.SetActive(true);
            }
            if (stageZissekiDatabase.stageNo[11] >= 1)
            {
                bladHeibun.SetActive(true);
            }
            if (stageZissekiDatabase.stageNo[14] >= 1)
            {
                warumuKouya.SetActive(true);
            }
            if (stageZissekiDatabase.stageNo[17] >= 1)
            {
                mamarion.SetActive(true);
                Debug.Log(stageZissekiDatabase.stageNo[20]);
            }
            if (stageZissekiDatabase.stageNo[20] >= 1)
            {
                nazonoKikaiSisetu.SetActive(true);
            }
            if (stageZissekiDatabase.stageNo[23] >= 1)
            {
                gooremuSeizousyo.SetActive(true);
            }
            if(stageZissekiDatabase.stageNo[26]>=1)
            {
                meikounoIe.SetActive(true);
            }
            if (stageZissekiDatabase.stageNo[29]>=1)
            {
                kuguturo.SetActive(true);
            }
            if (stageZissekiDatabase.stageNo[32] >= 1)
            {
                kotounoNusi.SetActive(true);
            }
            if (stageZissekiDatabase.stageNo[35] >= 1)
            {
                makaikai.SetActive(true);
            }
            if (stageZissekiDatabase.stageNo[38] >= 1)
            {
                hitogatamazyuuNoSyuuraku.SetActive(true);
            }
            if(stageZissekiDatabase.stageNo[41]>=1)
            {
                maborosinoDoukutu.SetActive(true);
            }
        }
    }
    public void FaiasiaSougennSelect()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ファイアジア平原";
        stageName1.text = "01";

        if(stageZissekiDatabase.stageNo[0]>=1)
        {
            stage2.SetActive(true);
            stageName2.text = "02";
        }
        if(stageZissekiDatabase.stageNo[1]>=1)
        {
            stage3.SetActive(true);
            stageName3.text = "03";
        }
    }
    public void SyuurennnoDoukutuSelect()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "修練の洞窟";
        stageName1.text = "04";

        if (stageZissekiDatabase.stageNo[3] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "05";
        }
        if (stageZissekiDatabase.stageNo[4] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "06";
        }
    }
    public void UmibenoHaikyoSelect()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "海辺の廃墟";
        stageName1.text = "07";

        if (stageZissekiDatabase.stageNo[6] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "08";
        }
        if (stageZissekiDatabase.stageNo[7] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "09";
        }
    }
    public void BladFangHeigenSelect()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ブラッドファング平原";
        stageName1.text = "10";

        if (stageZissekiDatabase.stageNo[9] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "11";
        }
        if (stageZissekiDatabase.stageNo[10] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "12";
        }
    }
    public void BladHeibun()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ブラッドヘイブン";
        stageName1.text = "13";

        if (stageZissekiDatabase.stageNo[12] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "14";
        }
        if (stageZissekiDatabase.stageNo[13] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "15";
        }
    }
    public void WarumuKouya()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ワルム荒野";
        stageName1.text = "16";

        if (stageZissekiDatabase.stageNo[15] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "17";
        }
        if (stageZissekiDatabase.stageNo[16] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "18";
        }
    }
    public void Mamarion()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "マーマリオン";
        stageName1.text = "19";

        if (stageZissekiDatabase.stageNo[18] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "20";
        }
        if (stageZissekiDatabase.stageNo[19] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "21";
        }
    }
    public void NazonoKikaiSisetu()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "謎の機械施設";
        stageName1.text = "22";

        if (stageZissekiDatabase.stageNo[21] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "23";
        }
        if (stageZissekiDatabase.stageNo[22] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "24";
        }
    }
    public void GooremuSeizousyo()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ゴーレム製造所";
        stageName1.text = "25";

        if (stageZissekiDatabase.stageNo[24] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "26";
        }
        if (stageZissekiDatabase.stageNo[25] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "27";
        }
    }
    public void MeikounoIe()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "名工の家";
        stageName1.text = "28";

        if (stageZissekiDatabase.stageNo[27] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "29";
        }
        if (stageZissekiDatabase.stageNo[28] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "30";
        }
    }
    public void Kuguturo()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "傀儡炉";
        stageName1.text = "31";

        if (stageZissekiDatabase.stageNo[30] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "32";
        }
        if (stageZissekiDatabase.stageNo[31] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "33";
        }
    }
    public void KotounoNusi()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "孤島のヌシ";
        stageName1.text = "34";

        if (stageZissekiDatabase.stageNo[33] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "35";
        }
        if (stageZissekiDatabase.stageNo[34] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "36";
        }
    }
    public void Makaikai()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "魔渦海";
        stageName1.text = "37";

        if (stageZissekiDatabase.stageNo[36] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "38";
        }
        if (stageZissekiDatabase.stageNo[37] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "39";
        }
    }
    public void HitogatamazyuuNoSyuuraku()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "人型魔獣の集落";
        stageName1.text = "40";

        if (stageZissekiDatabase.stageNo[39] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "41";
        }
        if (stageZissekiDatabase.stageNo[40] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "42";
        }
    }
    public void MaborosinoDoukutu()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "幻の洞窟";
        stageName1.text = "43";

        if (stageZissekiDatabase.stageNo[42] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "44";
        }
        if (stageZissekiDatabase.stageNo[43] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "45";
        }
    }
}

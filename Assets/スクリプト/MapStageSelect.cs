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

    public GameObject stage1SyosinnsyanoMiti;
    public GameObject stage1BoukennsyanoSirenn;
    public GameObject stage1EiyuunoMiti;
    public GameObject stage1Yuusyanosirenn;
    public GameObject stage1DennsetunoMiti;
    public GameObject stage1KamigaminoRyouiki;

    public GameObject stage2SyosinnsyanoMiti;
    public GameObject stage2BoukennsyanoSirenn;
    public GameObject stage2EiyuunoMiti;
    public GameObject stage2Yuusyanosirenn;
    public GameObject stage2DennsetunoMiti;
    public GameObject stage2KamigaminoRyouiki;

    public GameObject stage3SyosinnsyanoMiti;
    public GameObject stage3BoukennsyanoSirenn;
    public GameObject stage3EiyuunoMiti;
    public GameObject stage3Yuusyanosirenn;
    public GameObject stage3DennsetunoMiti;
    public GameObject stage3KamigaminoRyouiki;

    public GameObject[] stageNannidoHanntei;
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
        Stage1NannidoHanntei();

        if(stageZissekiDatabase.stageNo[0]>=1)
        {
            stage2.SetActive(true);
            stageName2.text = "02";
            Stage2NannidoHanntei();
        }
        if(stageZissekiDatabase.stageNo[1]>=1)
        {
            stage3.SetActive(true);
            stageName3.text = "03";
            Stage3NannidoHanntei();
        }
    }
    public void SyuurennnoDoukutuSelect()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "修練の洞窟";
        stageName1.text = "04";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[3] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "05";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[4] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "06";
            Stage3NannidoHanntei();
        }
    }
    public void UmibenoHaikyoSelect()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "海辺の廃墟";
        stageName1.text = "07";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[6] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "08";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[7] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "09";
            Stage3NannidoHanntei();
        }
    }
    public void BladFangHeigenSelect()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ブラッドファング平原";
        stageName1.text = "10";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[9] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "11";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[10] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "12";
            Stage3NannidoHanntei();
        }
    }
    public void BladHeibun()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ブラッドヘイブン";
        stageName1.text = "13";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[12] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "14";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[13] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "15";
            Stage3NannidoHanntei();
        }
    }
    public void WarumuKouya()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ワルム荒野";
        stageName1.text = "16";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[15] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "17";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[16] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "18";
            Stage3NannidoHanntei();
        }
    }
    public void Mamarion()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "マーマリオン";
        stageName1.text = "19";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[18] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "20";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[19] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "21";
            Stage3NannidoHanntei();
        }
    }
    public void NazonoKikaiSisetu()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "謎の機械施設";
        stageName1.text = "22";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[21] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "23";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[22] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "24";
            Stage3NannidoHanntei();
        }
    }
    public void GooremuSeizousyo()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "ゴーレム製造所";
        stageName1.text = "25";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[24] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "26";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[25] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "27";
            Stage3NannidoHanntei();
        }
    }
    public void MeikounoIe()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "名工の家";
        stageName1.text = "28";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[27] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "29";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[28] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "30";
            Stage3NannidoHanntei();
        }
    }
    public void Kuguturo()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "傀儡炉";
        stageName1.text = "31";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[30] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "32";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[31] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "33";
            Stage3NannidoHanntei();
        }
    }
    public void KotounoNusi()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "孤島のヌシ";
        stageName1.text = "34";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[33] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "35";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[34] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "36";
            Stage3NannidoHanntei();
        }
    }
    public void Makaikai()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "魔渦海";
        stageName1.text = "37";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[36] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "38";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[37] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "39";
            Stage3NannidoHanntei();
        }
    }
    public void HitogatamazyuuNoSyuuraku()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "人型魔獣の集落";
        stageName1.text = "40";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[39] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "41";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[40] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "42";
            Stage3NannidoHanntei();
        }
    }
    public void MaborosinoDoukutu()
    {
        stageSyousaiPanel.SetActive(true);
        titleStageName.text = "幻の洞窟";
        stageName1.text = "43";
        Stage1NannidoHanntei();


        if (stageZissekiDatabase.stageNo[42] >= 1)
        {
            stage2.SetActive(true);
            stageName2.text = "44";
            Stage2NannidoHanntei();

        }
        if (stageZissekiDatabase.stageNo[43] >= 1)
        {
            stage3.SetActive(true);
            stageName3.text = "45";
            Stage3NannidoHanntei();
        }
    }
    public void StageNannidoHannteiSetActiveFalse()
    {
        for (int a = 0; a < stageNannidoHanntei.Length; a++)
        {
            stageNannidoHanntei[a].SetActive(false);
        }
    }
    public void StageNannidoHannteiSetActiveTrue()
    {
        for (int a = 0; a < stageNannidoHanntei.Length; a++)
        {
            stageNannidoHanntei[a].SetActive(true);
        }
    }
    public void Stage1NannidoHanntei()
    {
        if(stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName1.text)-1].syosinnsyanoMiti>=1)
        {
            stage1SyosinnsyanoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName1.text)-1].boukennsyanoSirenn >= 1)
        {
            stage1BoukennsyanoSirenn.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName1.text)-1].eiyuunoMiti >= 1)
        {
            stage1EiyuunoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName1.text)-1].yuusyanoTyousenn >= 1)
        {
            stage1Yuusyanosirenn.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName1.text)-1].dennsetunoSirenn >= 1)
        {
            stage1DennsetunoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName1.text)-1].kamigaminoRyouiki >= 1)
        {
            stage1KamigaminoRyouiki.SetActive(true);
        }
    }
    public void Stage2NannidoHanntei()
    {
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName2.text) - 1].syosinnsyanoMiti >= 1)
        {
            stage2SyosinnsyanoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName2.text) - 1].boukennsyanoSirenn >= 1)
        {
            stage2BoukennsyanoSirenn.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName2.text) - 1].eiyuunoMiti >= 1)
        {
            stage2EiyuunoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName2.text) - 1].yuusyanoTyousenn >= 1)
        {
            stage2Yuusyanosirenn.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName2.text) - 1].dennsetunoSirenn >= 1)
        {
            stage2DennsetunoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName2.text) - 1].kamigaminoRyouiki >= 1)
        {
            stage2KamigaminoRyouiki.SetActive(true);
        }
    }
    public void Stage3NannidoHanntei()
    {
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName3.text) - 1].syosinnsyanoMiti >= 1)
        {
            stage3SyosinnsyanoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName3.text) - 1].boukennsyanoSirenn >= 1)
        {
            stage3BoukennsyanoSirenn.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName3.text) - 1].eiyuunoMiti >= 1)
        {
            stage3EiyuunoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName3.text) - 1].yuusyanoTyousenn >= 1)
        {
            stage3Yuusyanosirenn.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName3.text) - 1].dennsetunoSirenn >= 1)
        {
            stage3DennsetunoMiti.SetActive(true);
        }
        if (stageZissekiDatabase.stageNannidoZissekis[int.Parse(stageName3.text) - 1].kamigaminoRyouiki >= 1)
        {
            stage3KamigaminoRyouiki.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVLoader : MonoBehaviour
{
    // フルパスを直接指定する
    public string filePath = @"C:\Users\KEIYA\Documents\GitHub\FireBallUnity\FireBallUnity\Assets\DataBase\FireBall開発メモ.csv";
    public EnemyDataList enemyDataList;
    public SyougouScritableObject syougouScritableObject;
    [ContextMenu("モンスター実装")]
    void LoadCSV()
    {
        //Debug.Log("CSV file path: " + filePath);  // ファイルパスを確認
        
        if (File.Exists(filePath))
        {
            string[] csvData = File.ReadAllLines(filePath);
            foreach (string line in csvData)
            {
                string[] row = line.Split(',');
                // CSVデータの処理
                enemyDataList.enemyDatas[int.Parse(row[0])].no = int.Parse(row[0]);
                enemyDataList.enemyDatas[int.Parse(row[0])].enemyName = row[1];

                if(row[2]=="〇")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].rea = true;
                }
                else enemyDataList.enemyDatas[int.Parse(row[0])].rea = false;

                if(row[3]=="魔獣")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].mazyuu = true;
                }
                else if (row[3] == "人間")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].ninngenn = true;
                }
                else if (row[3] == "魔人")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].mazinn = true;
                }
                else if (row[3] == "不死")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].husi = true;
                }
                else if (row[3] == "悪魔")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].akuma = true;
                }
                else if (row[3] == "竜")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].ryuu = true;
                }
                else if (row[3] == "神")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].kami = true;
                }

                enemyDataList.enemyDatas[int.Parse(row[0])].maxHp = int.Parse(row[4]);
                enemyDataList.enemyDatas[int.Parse(row[0])].kougekiryoku = int.Parse(row[5]);
                enemyDataList.enemyDatas[int.Parse(row[0])].kaisinnritu = float.Parse(row[6]);
                enemyDataList.enemyDatas[int.Parse(row[0])].bougyoryoku = int.Parse(row[7]);
                enemyDataList.enemyDatas[int.Parse(row[0])].kaisinnTaisei = float.Parse(row[8]);
                enemyDataList.enemyDatas[int.Parse(row[0])].mahouBougyoryoku = int.Parse(row[9]);
                enemyDataList.enemyDatas[int.Parse(row[0])].meityuuritu = float.Parse(row[11]);
                enemyDataList.enemyDatas[int.Parse(row[0])].kaihiritu = float.Parse(row[12]);
                enemyDataList.enemyDatas[int.Parse(row[0])].kougekiHinndo = float.Parse(row[13]);
                enemyDataList.enemyDatas[int.Parse(row[0])].speed = int.Parse(row[14]);
                enemyDataList.enemyDatas[int.Parse(row[0])].nokkubakkuBougyo = float.Parse(row[15]);
                enemyDataList.enemyDatas[int.Parse(row[0])].exp = int.Parse(row[16]);
                enemyDataList.enemyDatas[int.Parse(row[0])].gold = int.Parse(row[17]);
                enemyDataList.enemyDatas[int.Parse(row[0])].dropItemSuu = int.Parse(row[18]);

                if (row[19] == "")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].nomalDropRitu = 8;
                    enemyDataList.enemyDatas[int.Parse(row[0])].reaDropRitu = 20;
                    enemyDataList.enemyDatas[int.Parse(row[0])].superReaDropRitu = 10;
                    enemyDataList.enemyDatas[int.Parse(row[0])].epikDropRitu = 5;
                    enemyDataList.enemyDatas[int.Parse(row[0])].legendaryDropRitu = 2.5f;
                    enemyDataList.enemyDatas[int.Parse(row[0])].godDropRitu = 0.01f;
                }
                else if (row[19] == "●")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].nomalDropRitu = 25;
                    enemyDataList.enemyDatas[int.Parse(row[0])].reaDropRitu = 10;
                    enemyDataList.enemyDatas[int.Parse(row[0])].superReaDropRitu = 5;
                    enemyDataList.enemyDatas[int.Parse(row[0])].epikDropRitu = 2.5f;
                    enemyDataList.enemyDatas[int.Parse(row[0])].legendaryDropRitu = 1.25f;
                    enemyDataList.enemyDatas[int.Parse(row[0])].godDropRitu = 0.01f;
                }
                else if (row[19] == "★")
                {
                    enemyDataList.enemyDatas[int.Parse(row[0])].nomalDropRitu = 100;
                    enemyDataList.enemyDatas[int.Parse(row[0])].reaDropRitu = 100;
                    enemyDataList.enemyDatas[int.Parse(row[0])].superReaDropRitu = 75;
                    enemyDataList.enemyDatas[int.Parse(row[0])].epikDropRitu = 50;
                    enemyDataList.enemyDatas[int.Parse(row[0])].legendaryDropRitu = 25;
                    enemyDataList.enemyDatas[int.Parse(row[0])].godDropRitu = 0.01f;
                }
            }
        }
        else
        {
            Debug.LogError("CSV file not found!");
        }
    }
    [ContextMenu("称号実装")]
    void LoadSyougouCSV()
    {
        //Debug.Log("CSV file path: " + filePath);  // ファイルパスを確認

        if (File.Exists(filePath))
        {
            string[] csvData = File.ReadAllLines(filePath);
            foreach (string line in csvData)
            {
                string[] row = line.Split(',');
                // CSVデータの処理
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.no = int.Parse(row[44]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.syougouName = "《"+row[45]+"》";

                if (row[46] == "R")
                {
                    syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.syougouBairitu = "《ステータス + 25％》";
                    syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.rea = true;
                }
                else if (row[46] == "S")
                {
                    syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.syougouBairitu = "《ステータス + 50％》";
                    syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.superRea = true;
                }
                else if (row[46] == "E")
                {
                    syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.syougouBairitu = "《ステータス + 100％》";
                    syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.epikRea = true;
                }

                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.maxHpPlus = int.Parse(row[47]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.maxMpPlus = int.Parse(row[48]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.fireBallCostPlus = -int.Parse(row[49]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.kougekiryokuPlus = int.Parse(row[50]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.maryokuPlus = int.Parse(row[51]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.kinnkyoriKaisinnrituPlus = float.Parse(row[52]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.ennkyoriKaisinnrituPlus = float.Parse(row[53]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.bouggyoryokuPlus = int.Parse(row[54]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.kaisinnTaisei = float.Parse(row[55]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.meityuurituPlus = float.Parse(row[56]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.kaihirituPlus = float.Parse(row[57]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.syougekiryoku = float.Parse(row[58]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.srushHinndo = float.Parse(row[59]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.kougekiHanni = float.Parse(row[60]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.soubiDropBairitu = int.Parse(row[61]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.syougouDropRitu = int.Parse(row[62]);
                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.GetComponent<SyougouBase>().syougouStatus.soubiGifthuyosoubiDropritu = int.Parse(row[63]);

                syougouScritableObject.syougouDatas[int.Parse(row[44])].gameObject.name = row[44] + "《" + row[45] + "》";
            }
        }
        else
        {
            Debug.LogError("CSV file not found!");
        }
    }
}



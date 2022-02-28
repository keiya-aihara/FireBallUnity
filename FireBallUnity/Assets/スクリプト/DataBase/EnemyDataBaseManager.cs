using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyDataBaseManager : MonoBehaviour
{
    public static EnemyDataBaseManager instance;   

    public EnemyDataList enemyDataList;       

    public GameObject[] dropItemPrefabs;
    public GameObject[] dropSyougouPrefabs;
    public EnemyDataList.EnemyData GetEnemyData(int enemyNo)
    {
        EnemyDataList.EnemyData enemyData = new EnemyDataList.EnemyData();

        enemyData = enemyDataList.enemyDatas.Find((x) => x.no == enemyNo);

        return enemyData;
    }

    public GameObject GetDropItemPrefabDate(int itemNo)
    {
        return dropItemPrefabs[itemNo];
    }
    public GameObject GetDropSyougouPrefabDate(int syougouNo)
    {
        return dropSyougouPrefabs[syougouNo];
    }
}

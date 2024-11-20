using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponDateBaseManager : MonoBehaviour
{
    public static WeponDateBaseManager instance;    

    [Header("所持装備一覧")]
    public WeponDataList weponDataList;        
    public WeponDataList.WeponData GetWeponData(int weponNo)
    {
        WeponDataList.WeponData weponData = new WeponDataList.WeponData();

        weponData = weponDataList.weponDatas.Find((x) => x.no == weponNo);

        return weponData;
    }
}

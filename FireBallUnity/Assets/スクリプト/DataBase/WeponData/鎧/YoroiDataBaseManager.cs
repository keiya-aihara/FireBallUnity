using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoroiDataBaseManager : MonoBehaviour
{
    public static YoroiDataBaseManager instance;

    public WeponDataList weponDataList;

    public WeponDataList.WeponData GetWeponData(int weponNo)
    {
        WeponDataList.WeponData weponData = new WeponDataList.WeponData();

        weponData = weponDataList.weponDatas.Find((x) => x.no == weponNo);

        return weponData;
    }
}

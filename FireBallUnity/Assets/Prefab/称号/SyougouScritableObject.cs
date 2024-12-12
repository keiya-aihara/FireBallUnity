using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "MyScriptable/Create SyougouData", fileName = "SyougouDataList")]
public class SyougouScritableObject : ScriptableObject
{
    public List<GameObject> syougouDatas;
}

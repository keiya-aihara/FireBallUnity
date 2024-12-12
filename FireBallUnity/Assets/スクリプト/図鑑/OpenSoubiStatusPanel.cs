using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSoubiStatusPanel : MonoBehaviour
{
    public WeponDataList.WeponData weponData;
    public void OpenStatusPanel()
    {
        SEPlay();
        if (GameObject.Find("#ドロップ装備ステータスPanel")) return;
        GameObject.Find("装備図鑑ActiveButton").GetComponent<OpenSoubiZukan2>().OpenSoubiStatusPanelMesod(weponData,gameObject);
    }
    public void SEPlay()
    {
        GameObject.Find("SE").GetComponent<HaiIieButtonSE>().HaiButtonSE();
    }
}

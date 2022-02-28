using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaikyakuPanelBaikyakugoKoinn : MonoBehaviour
{
    public GameObject baikyakuZikkouPanel;
    void Start()
    {
        gameObject.GetComponent<Text>().text = "îÑãpå„ÉRÉCÉì\n" + (GameObject.Find("DataBaseManager").GetComponent<MoneyManager>().money + baikyakuZikkouPanel.GetComponent<BaikyakuZikkouPanel>().baikyakuKinngaku).ToString("N0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

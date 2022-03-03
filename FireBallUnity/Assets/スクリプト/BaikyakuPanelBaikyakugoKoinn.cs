using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaikyakuPanelBaikyakugoKoinn : MonoBehaviour
{
    public BaikyakuZikkouPanel baikyakuZikkouPanel;
    public Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void BaikyakuZenngoKinngakuText()
    {
        text.text = "売却後コイン\n" + (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().money + baikyakuZikkouPanel.baikyakuKinngaku).ToString("N0");
    }
}

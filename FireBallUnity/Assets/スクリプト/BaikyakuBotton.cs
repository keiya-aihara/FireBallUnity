using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaikyakuBotton : MonoBehaviour
{
    private GameObject uiPanel;
    public GameObject baikyakuPanel;
    public BaikyakuZikkouPanel baikyakuZikkouPanelScript;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BaikyakuBottonDown()
    {
        baikyakuPanel.SetActive(true);
        baikyakuZikkouPanelScript.SoubityuuKakuninnPanel();
        baikyakuZikkouPanelScript.a = false;
        baikyakuZikkouPanelScript.SetActiveTrue();
    }
}

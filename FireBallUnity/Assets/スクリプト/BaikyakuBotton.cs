using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaikyakuBotton : MonoBehaviour
{
    private GameObject uiPanel;
    public GameObject baikyakuPanel;
    void Start()
    {
        uiPanel = GameObject.Find("UIPanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BaikyakuBottonDown()
    {
        baikyakuPanel.GetComponent<BaikyakuZikkouPanel>().a = false;
        Instantiate(baikyakuPanel, transform.position, transform.rotation, uiPanel.transform) ;
    }
}

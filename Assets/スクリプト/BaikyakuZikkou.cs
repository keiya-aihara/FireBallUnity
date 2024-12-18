using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaikyakuZikkou : MonoBehaviour
{
    public GameObject baikyakuKakuninnMenu;
    public BaikyakuZikkouPanel baikyakuZikkouPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BaikyakuZikkouBottonDown()
    {
        baikyakuKakuninnMenu.SetActive(true);
        baikyakuZikkouPanel.a = true;
        baikyakuZikkouPanel.SetActiveTrue();
    }
}

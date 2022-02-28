using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPSlider : MonoBehaviour
{
    private GameObject expManager;
    private EXPManager expManagerScript;
    private Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
        expManager = GameObject.Find("DataBaseManager");
        expManagerScript = expManager.GetComponent<EXPManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(expManagerScript.exp_stokku==0)
        {
            slider.value = 0;
        }
        slider.maxValue = expManagerScript.lv * 100;
        slider.value = slider.maxValue - expManagerScript.needExp;
    }
}

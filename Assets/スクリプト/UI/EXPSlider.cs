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
        expManagerScript = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<EXPManager>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = expManagerScript.lvUpExp;
        slider.value = slider.maxValue - expManagerScript.needExp;
    }
}

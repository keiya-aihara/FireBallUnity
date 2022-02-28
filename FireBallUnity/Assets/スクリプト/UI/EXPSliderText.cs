using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPSliderText : MonoBehaviour
{
    private GameObject expManager;
    private EXPManager expManagerScript;
    private Text text;
    void Start()
    {
        expManager = GameObject.Find("DataBaseManager");
        expManagerScript = expManager.GetComponent<EXPManager>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "LV" + expManagerScript.lv;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPCounterMainManu : MonoBehaviour
{
    private GameObject expManager;
    private EXPManager expManagerScript;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        expManager = GameObject.Find("EXPManager");
        expManagerScript = expManager.GetComponent<EXPManager>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text ="LV "+ expManagerScript.lv.ToString();
    }
}

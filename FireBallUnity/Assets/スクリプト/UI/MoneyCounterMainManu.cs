using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounterMainManu : MonoBehaviour
{
    private GameObject moneyManager;
    private MoneyManager moneyManagerScript;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        moneyManager = GameObject.Find("MoneyManager");
        moneyManagerScript = moneyManager.GetComponent<MoneyManager>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = moneyManagerScript.money.ToString("N0");
    }
}

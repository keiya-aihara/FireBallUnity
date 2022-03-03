using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaikyakuPanelSyozikoinnText : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BaikyakumaeSyoziCoinText()
    {
        text.text = "所持コイン\n" + DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().money.ToString("N0");
    }
}

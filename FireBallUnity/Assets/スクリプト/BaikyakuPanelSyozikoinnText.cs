using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaikyakuPanelSyozikoinnText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       gameObject.GetComponent<Text>().text = "èäéùÉRÉCÉì\n" + GameObject.Find("DataBaseManager").GetComponent<MoneyManager>().money.ToString("N0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HaiIieButtonDownSE : MonoBehaviour
{
    
    public void HaiButtonDown()
    {
        GameObject.Find("SE").GetComponent<HaiIieButtonSE>().HaiButtonSE();

    }
    public void IieButtonDown()
    {
        GameObject.Find("SE").GetComponent<HaiIieButtonSE>().IieButtonSE();
    }
}

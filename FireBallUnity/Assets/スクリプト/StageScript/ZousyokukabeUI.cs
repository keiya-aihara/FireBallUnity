using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZousyokukabeUI : MonoBehaviour
{
    public GameObject zousyokukabe;
    public ZousyokukabeStatus zousyokukabeStatus;
    public Text bairitu;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        zousyokukabeStatus = zousyokukabe.GetComponent<ZousyokukabeStatus>();
        bairitu.GetComponentInChildren<Text>().text = "Å{" + (zousyokukabeStatus.bairitu).ToString("N0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

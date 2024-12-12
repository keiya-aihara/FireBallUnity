using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAPModoruButton : MonoBehaviour
{
    public GameObject[] pin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Modoru()
    {
        for(int a=0;a<pin.Length;a++)
        {
            pin[a].SetActive(false);
        }
    }
}

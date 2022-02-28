using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkkatuBaikyakuBotton : MonoBehaviour
{
    public GameObject kyannseruBotton;
    public GameObject baikyakusuruBotton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void IkkatuBaikyakuBottonDown()
    {
        kyannseruBotton.SetActive(true);
        baikyakusuruBotton.SetActive(true);
    }
}

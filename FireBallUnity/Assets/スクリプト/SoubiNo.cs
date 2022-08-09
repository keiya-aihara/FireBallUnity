using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoubiNo : MonoBehaviour
{
    public int number;
    void Start()
    {
        if(transform.parent.gameObject.tag=="KinnkyoriWeponSoubiReadoIcon")
        {
            number = transform.parent.gameObject.GetComponent<KinnkyoriWeponSoubiIcon>().number;
        }
        else if (transform.parent.gameObject.tag == "EnnkyoriWeponSoubiReadoIcon")
        {
            number = transform.parent.gameObject.GetComponent<EnnkyoriWeponSoubiIcon>().number;
        }
        else if (transform.parent.gameObject.tag == "YoroiSoubiReadoIcon")
        {
            number = transform.parent.gameObject.GetComponent<YoroiSoubiIcon>().number;
        }
        else if (transform.parent.gameObject.tag == "SonotaSoubiReadoIcon")
        {
            number = transform.parent.gameObject.GetComponent<SonotaSoubiIcon>().number;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

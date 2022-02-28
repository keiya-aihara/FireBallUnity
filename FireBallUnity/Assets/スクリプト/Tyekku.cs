using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyekku : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Scroll View 近距離武器 倉庫"))
        {
            number = gameObject.transform.parent.GetComponent<KinnkyoriWeponSoubiIcon>().number;
        }
        if(GameObject.Find("Scroll View 遠距離武器 倉庫"))
        {
            number = gameObject.transform.parent.GetComponent<EnnkyoriWeponSoubiIcon>().number;
        }
        if(GameObject.Find("Scroll View 鎧装備 倉庫"))
        {
            number = gameObject.transform.parent.GetComponent<YoroiSoubiIcon>().number;
        }
        if(GameObject.Find("Scroll View その他装備 倉庫"))
        {
            number = gameObject.transform.parent.GetComponent<SonotaSoubiIcon>().number;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyekku : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Scroll View �ߋ������� �q��"))
        {
            number = gameObject.transform.parent.GetComponent<KinnkyoriWeponSoubiIcon>().number;
        }
        if(GameObject.Find("Scroll View ���������� �q��"))
        {
            number = gameObject.transform.parent.GetComponent<EnnkyoriWeponSoubiIcon>().number;
        }
        if(GameObject.Find("Scroll View �Z���� �q��"))
        {
            number = gameObject.transform.parent.GetComponent<YoroiSoubiIcon>().number;
        }
        if(GameObject.Find("Scroll View ���̑����� �q��"))
        {
            number = gameObject.transform.parent.GetComponent<SonotaSoubiIcon>().number;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

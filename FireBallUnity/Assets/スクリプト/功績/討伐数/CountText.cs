using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour
{
    public bool a;
    // Start is called before the first frame update
    private void Awake()
    {
        a = false;
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            gameObject.GetComponent<Text>().text = transform.parent.GetComponent<Slider>().value.ToString("N0") + "/" + transform.parent.GetComponent<Slider>().maxValue.ToString("N0");
            a = false;
        }
    }
}

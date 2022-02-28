using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrolTop : MonoBehaviour
{
    public GameObject scrollBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScrollTop()
    {
        scrollBar.GetComponent<Scrollbar>().value = 1;
    }
}

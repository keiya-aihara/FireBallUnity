using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortPanelSctiveScrollView : MonoBehaviour
{
    public GameObject sortPanel;

    public bool a;
    void Start()
    {
        a = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            if (sortPanel.activeSelf == false)
            {
                sortPanel.SetActive(true);
            }
            
        }
    }
}

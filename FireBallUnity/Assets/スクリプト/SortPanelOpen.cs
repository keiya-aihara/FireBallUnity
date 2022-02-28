using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortPanelOpen : MonoBehaviour
{
    public GameObject sortPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SortPanelOpenBoton()
    {
        if (sortPanel.activeSelf)
        {
            sortPanel.SetActive(false);
        }
        else
        {
            sortPanel.SetActive(true);
        }
    }
}

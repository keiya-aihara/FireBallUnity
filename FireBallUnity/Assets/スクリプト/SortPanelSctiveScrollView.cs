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
            if (Input.GetMouseButtonDown(0))
            {
                if(Input.mousePosition.y <= 750)
                {
                    if (GameObject.Find("Scroll View 装備ステータス ステータス1(Clone)") ==null)
                    {
                        sortPanel.SetActive(false);
                        gameObject.SetActive(false);
                    }
                }

            }
            
        }
    }
}

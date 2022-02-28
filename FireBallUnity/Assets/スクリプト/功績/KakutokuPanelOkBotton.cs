using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakutokuPanelOkBotton : MonoBehaviour
{
    public GameObject kakutokuPanel;
    public GameObject kinnwaku;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OkBottonDown()
    {
        foreach (Transform child in kinnwaku.transform)
        {
            Destroy(child.gameObject);
        }
        kakutokuPanel.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStatusPanel : MonoBehaviour
{
    public GameObject statusPanel;
    public GameObject content;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeleteStatusPanel()
    {
        foreach (Transform n in content.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
        statusPanel.SetActive(false);
    }
}

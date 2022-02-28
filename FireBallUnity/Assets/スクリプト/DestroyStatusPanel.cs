using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStatusPanel : MonoBehaviour
{
    public GameObject statusPanel;
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
        Destroy(statusPanel);
    }
}

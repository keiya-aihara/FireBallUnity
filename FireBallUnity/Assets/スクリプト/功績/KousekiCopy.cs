using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KousekiCopy : MonoBehaviour
{
    public KousekiDataBaseManager kousekiDataBaseManager;
    public bool a;
    // Start is called before the first frame update
    private void Awake()
    {
        kousekiDataBaseManager = GameObject.Find("DataBaseManager").GetComponent<KousekiDataBaseManager>();

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

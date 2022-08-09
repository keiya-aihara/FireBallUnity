using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KousekiCopy : MonoBehaviour
{
    public KousekiDataBaseManager kousekiDataBaseManager;
    public PlayerStatusDataBase playerStatusDataBase;
    public bool a;
    // Start is called before the first frame update
    private void Awake()
    {
        kousekiDataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KousekiDataBaseManager>();
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

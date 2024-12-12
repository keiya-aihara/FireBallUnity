using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetStageName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SystemDatabase>().StageNameLoad();
        gameObject.GetComponent<Text>().text = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SystemDatabase>().zennkainoStageName;
    }
}

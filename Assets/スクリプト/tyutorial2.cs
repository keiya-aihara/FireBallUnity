using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tyutorial2 : MonoBehaviour
{
    public GameObject tyutorialPanel;
    void Start()
    {
        if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<StageZissekiDatabase>().stageNo[0] == 1&& DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<StageZissekiDatabase>().stageNo[1]==0)
        {
            tyutorialPanel.SetActive(true);
        }
    }
}

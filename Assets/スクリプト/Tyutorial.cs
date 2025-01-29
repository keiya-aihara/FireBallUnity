using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyutorial : MonoBehaviour

{
    public GameObject tyutorialPanel;
    void Start()
    {
            if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<StageZissekiDatabase>().stageNo[0] == 0)
            {
                tyutorialPanel.SetActive(true);
            }
    }
}

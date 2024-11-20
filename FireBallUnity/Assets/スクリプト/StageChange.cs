using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageChange : MonoBehaviour
{
    private SystemDatabase systemDatabase;
    public Text stageName;

    private void Start()
    {
        systemDatabase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SystemDatabase>();
    }
    public void Boukennsuru()
    {
        systemDatabase.zennkainoStageName = stageName.text;
        systemDatabase.StageNameSave();
        SceneManager.LoadScene(stageName.text);
    }
    public void Zidousyuukai()
    {
        systemDatabase.zennkainoStageName = stageName.text;
        systemDatabase.StageNameSave();
        systemDatabase.zidouSyuukai = true;
        SceneManager.LoadScene(stageName.text);
    }
}

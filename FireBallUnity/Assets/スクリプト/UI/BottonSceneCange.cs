using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BottonSceneCange : MonoBehaviour
{
    public ResultSceneManager resultSceneManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TestStage()
    {
        // ?uButtonScene?v????????????????????scene??????????
        SceneManager.LoadScene("テスト用ステージ");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().LoseBGMStart();
    }
    public void Map()
    {
        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SystemDatabase>().zidouSyuukai = false;
        SceneManager.LoadScene("MAP");
        //DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().MapBGMStart();
        Destroy(GameObject.Find("ResultManager"));


    }
    public void SaidoBoukennsuru()
    {
        resultSceneManager = GameObject.Find("ResultManager").GetComponent<ResultSceneManager>();
        SceneManager.LoadScene(resultSceneManager.stageName);
        Destroy(GameObject.Find("ResultManager"));

    }
    public void mainMenu()
    {
        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>().StatusUpdate();
        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SystemDatabase>().zidouSyuukai = false;
        SceneManager.LoadScene("MainMenu");
        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().MenuBGMStart();
        Destroy(GameObject.Find("ResultManager"));
    }
    public void statusMenu()
    {
        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>().StatusUpdate();
        SceneManager.LoadScene("StatusMenu");
    }
    
    public void soukoMenu()
    {
        SceneManager.LoadScene("Souko");
    }
    public void Kouseki()
    {
        SceneManager.LoadScene("Kouseki");
    }
    public void SkillMenu()
    {
        SceneManager.LoadScene("SkillMenu");

    }
    public void BoukennnoSyo()
    {
        SceneManager.LoadScene("BoukennnoSyo");
    }
}

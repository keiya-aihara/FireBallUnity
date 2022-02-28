using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BottonSceneCange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start1()
    {
        // ?uButtonScene?v????????????????????scene??????????
        SceneManager.LoadScene("1-1GamaStage");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(GameObject.Find("ResultManager"));
    }
    public void statusMenu()
    {
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
}

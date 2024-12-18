using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkillPanelOpen : MonoBehaviour
{
    public int skillNo;
    public SoubiSkillDatabase soubiSkillDatabase;
    public SoubiSkillDataList.SoubiSkillData soubiSkillData;

    public StatusPanelSetActive statusPanelSetActive;

    public GameObject skillPanel;

    public GameObject skillName;
    public GameObject skillSyousai;
    public GameObject skillIryoku;

    private GameObject contentSelectSoubi;
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "StatusMenu")contentSelectSoubi = GameObject.Find("Content Select Soubi　ステータス");
        else contentSelectSoubi= GameObject.Find("Content Select Soubi　装備強化・売却");
    }
    public void OpenSkillPanel()
    {
        HaiSEPlay();
        statusPanelSetActive.SkillPanelOpen();

        skillName = GameObject.Find("スキル名Text");
        skillSyousai = GameObject.Find("スキル説明Text");
        skillIryoku = GameObject.Find("威力Text");

        soubiSkillData = soubiSkillDatabase.GetSoubiSkillData(skillNo);

        skillName.GetComponent<Text>().text = soubiSkillData.skillName;
        skillSyousai.GetComponent<Text>().text = soubiSkillData.skillSetumei;
        if (soubiSkillData.iryoku != 0) skillIryoku.GetComponent<Text>().text = "威力:" + soubiSkillData.iryoku.ToString();
        else skillIryoku.GetComponent<Text>().text = "";
    }
    public void HaiSEPlay()
    {
        GameObject.Find("SE").GetComponent<AudioSource>().Play();
    }
}

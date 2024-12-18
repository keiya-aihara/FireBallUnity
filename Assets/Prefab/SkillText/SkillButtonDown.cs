using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillButtonDown : MonoBehaviour
{
    public int skillNumber;
    public int soubiSkillNumber;
    private GameObject contentSelectSoubi;
    void Start()
    {
        contentSelectSoubi = GameObject.Find("Content Select Soubi　ステータス");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SkillBottunDown()
    {
        gameObject.GetComponentInParent<StatuMenuSkill>().SkillSetumei(skillNumber);
        HaiSEPlay();
    }
    public void SoubiSkillButtonDown()
    {
        gameObject.GetComponentInParent<StatuMenuSkill>().SoubiSkillSetumei(soubiSkillNumber);
        HaiSEPlay();
    }
    public void HaiSEPlay()
    {
            GameObject.Find("SE").GetComponent<HaiIieButtonSE>().HaiButtonSE();
    }
}

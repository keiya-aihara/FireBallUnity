using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillButtonDown : MonoBehaviour
{
    public int skillNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SkillBottunDown()
    {
        gameObject.GetComponentInParent<StatuMenuSkill>().SkillSetumei(skillNumber);
    }
}

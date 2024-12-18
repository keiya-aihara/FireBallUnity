using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusButtonColor : MonoBehaviour
{
    public Image statusButton;
    public Image bairituButton;
    public Image skillButton;
    public Color yes;
    public Color no;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StatusButton()
    {
        statusButton.color = yes;
        bairituButton.color = no;
        skillButton.color = no;
    }
    public void BairituButtou()
    {
        statusButton.color = no;
        bairituButton.color = yes;
        skillButton.color = no;
    }
    public void SkillButton()
    {
        statusButton.color = no;
        bairituButton.color = no;
        skillButton.color = yes;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButtonColor : MonoBehaviour
{
    public bool skillButtonColorBool;

    public Image image;

    public Color trueColor;
    public Color falseColor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SkillButtonColorUpdate()
    {
        if (skillButtonColorBool)
        {
            image.color = trueColor;
        }
        else
        {
            image.color = falseColor;
        }
    }
}

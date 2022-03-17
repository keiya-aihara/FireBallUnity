using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillButtonColorHanntei : MonoBehaviour
{
    public Color kiiro;
    public Color haiiro;
    public Image image;
    public SkillBottonColor skillBottonColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SkillAdd(int number)
    {
        if(image.color==kiiro)
        {

        }
        else if(image.color==haiiro)
        {

        }
        else
        {
            skillBottonColor.SkillButtonDown(number);
        }
    }
}

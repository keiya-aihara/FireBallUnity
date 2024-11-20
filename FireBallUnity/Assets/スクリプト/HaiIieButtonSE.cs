using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaiIieButtonSE : MonoBehaviour
{
    public AudioSource haiButton;
    public AudioSource iieButton;
    public void HaiButtonSE()
    {
        haiButton.Play();
    }
    public void IieButtonSE()
    {
        iieButton.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaiIieButtonSE : MonoBehaviour
{
    public AudioSource haiButton;
    public AudioSource iieButton;

    public BGMSEVolume bGMSEVolume;
    public void HaiButtonSE()
    {
        haiButton.volume = bGMSEVolume.seVolume;
        haiButton.Play();
    }
    public void IieButtonSE()
    {
        iieButton.volume = bGMSEVolume.seVolume;
        iieButton.Play();
    }
}

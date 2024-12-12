using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBGMScript : MonoBehaviour
{
    public AudioClip menuBGM;
    public AudioClip mapBGM;

    public AudioClip ennkyoriBGM1;
    public AudioClip ennkyoriBGM2;
    public AudioClip ennkyoriBGM3;
    public AudioClip ennkyoriBGM4;

    public AudioClip kinnkyoriBGM1;
    public AudioClip kinnkyoriBGM2;
    public AudioClip kinnkyoriBGM3;
    public AudioClip kinnkyoriBGM4;

    private int bgmRandomNumber;

    public AudioClip winBGM;
    public AudioClip winSE;
    public AudioClip loseBGM;

    public AudioSource audioSource;

    public BGMSEVolume bGMSEVolume;

    private void Start()
    {
        MenuBGMStart();
    }
    public void MenuBGMStart()
    {
        audioSource.clip = menuBGM;
        audioSource.volume = bGMSEVolume.bgmVolume;
        audioSource.Play();
    }
    public void MapBGMStart()
    {
        audioSource.clip = mapBGM;
        audioSource.volume = bGMSEVolume.bgmVolume;
        audioSource.Play();
    }
    public void EnnkyoriBGMStart()
    {
        bgmRandomNumber = Random.Range(0, 4);

        if (bgmRandomNumber == 0) audioSource.clip = ennkyoriBGM1;
        else if (bgmRandomNumber == 1) audioSource.clip = ennkyoriBGM2;
        else if (bgmRandomNumber == 2) audioSource.clip = ennkyoriBGM3;
        else if(bgmRandomNumber == 3) audioSource.clip = ennkyoriBGM4;
        audioSource.volume = bGMSEVolume.bgmVolume;
        audioSource.Play();
    }
    public void KinnkyoriBGMStart()
    {
        bgmRandomNumber = Random.Range(0, 4);

        if (bgmRandomNumber == 0) audioSource.clip = kinnkyoriBGM1;
        else if (bgmRandomNumber == 1) audioSource.clip = kinnkyoriBGM2;
        else if (bgmRandomNumber == 2) audioSource.clip = kinnkyoriBGM3;
        else if (bgmRandomNumber == 3) audioSource.clip = kinnkyoriBGM4;
        audioSource.volume = bGMSEVolume.bgmVolume;
        audioSource.Play();
    }
    public void WinBGMStart()
    {
        audioSource.clip = winBGM;
        audioSource.volume = bGMSEVolume.bgmVolume;
        audioSource.Play();
    }
    public void WinSEStart()
    {
        audioSource.clip = winSE;
        audioSource.volume = bGMSEVolume.bgmVolume;
        audioSource.Play();
    }
    public void LoseBGMStart()
    {
        audioSource.clip = loseBGM;
        audioSource.volume = bGMSEVolume.bgmVolume;
        audioSource.Play();
    }
}


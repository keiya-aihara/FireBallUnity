using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenntouBGMManager : MonoBehaviour
{
    public AudioSource FireBallSE;
    public AudioSource playerAtackSE;
    public AudioSource missSE;
    public AudioSource kaisinnSE;

    public BGMSEVolume bGMSEVolume;

    public void FireBallSEPlay()
    {
        FireBallSE.volume = bGMSEVolume.seVolume;
        FireBallSE.Play();
    }
    public void PlayerAtackSEPlay()
    {
        playerAtackSE.volume = bGMSEVolume.seVolume;
        playerAtackSE.Play();
    }
    public void MissSEPlay()
    {
        missSE.volume = bGMSEVolume.seVolume;
        missSE.Play();
    }
    public void KaisinnSE()
    {
        kaisinnSE.volume = bGMSEVolume.seVolume;
        kaisinnSE.Play();
    }
}
